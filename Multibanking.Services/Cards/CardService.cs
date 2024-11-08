using System.Text;
using AutoMapper;
using Multibanking.CardEmissionClient.Model;
using Multibanking.CardInformationClient.Model;
using Multibanking.CardOperationClient.Model;
using Multibanking.Contracts.Card;
using Multibanking.Data.OpenAPIBankClients.CardClient;
using Multibanking.Data.Repositories.Card;
using Multibanking.Entities.Cards;
using Multibanking.Services.Account;
using Multibanking.Services.User;

namespace Multibanking.Services.Cards;

public class CardService(
    ICardRepository cardRepository,
    ICardEmissionClient cardEmissionClient,
    ICardOperationClient cardOperationClient,
    IUserContextService userContextService,
    IAccountService accountService,
    IMapper mapper,
    ICardInformationClient cardInformationClient) : ICardService
{
    public void ValidateUserCard(Guid cardGuid)
    {
        if (!UserHasCard(cardGuid))
            throw new Exception("Взаимодействие с данной картой невозможно (заблокирована или относится к другому пользователю");
    }

    public string GetDecryptedPan(Guid cardGuid)
    {
        return Encoding.UTF8.GetString(Convert.FromBase64String(GetCardDetail(cardGuid).EncryptedPan));
    }

    public void CreateCard(CardCreateDto cardCreateDto)
    {
        if (!accountService.IsAccountExist(cardCreateDto.AccountId))
            throw new ArgumentException("Счет, к которому пытаются прикрепить банковскую карту не существует");

        var cardInfoResponse = cardEmissionClient.UpdateCreateCard(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
            new CardOpenRequest(Guid.NewGuid().ToString()));

        var user = userContextService.GetUserDtoFromHttpContext();
        var card = mapper.Map<Card>(cardCreateDto);
        card.Pan = cardInfoResponse.MaskedPan;
        card.UserId = user.Id;
        card.PublicId = cardInfoResponse.PublicId;
        card.Status = CardStatus.Active;
        cardRepository.Create(card);
        cardRepository.SaveChanges();
    }

    public CredentialsResponse GetCardDetail(Guid cardId)
    {
        var card = GetCardEntityAndValidate(cardId);
        var credentialsResponse = cardInformationClient.GetCredentials(card.PublicId, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString());

        return credentialsResponse;
    }


    public CvvResponse GetCardCvv(Guid cardId)
    {
        var card = GetCardEntityAndValidate(cardId);

        var cvvResponse = cardInformationClient.GetCvv(card.PublicId, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
        return cvvResponse;
    }

    public List<CardReadDto> GetCards()
    {
        var user = userContextService.GetUserDtoFromHttpContext();
        var cards = cardRepository.Read().Where(card => card.UserId == user.Id).ToList();
        return mapper.Map<List<CardReadDto>>(cards);
    }

    public CardReadDto GetCard(Guid cardId)
    {
        ValidateUserCard(cardId);
        return mapper.Map<CardReadDto>(cardRepository.Read().Single(card => card.Id == cardId));
    }

    public void DeleteCard(Guid cardId)
    {
        var card = GetCardEntityAndValidate(cardId);
        cardOperationClient.UpdateCloseCard(card.PublicId, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

        cardRepository.Delete(card);
        cardRepository.SaveChanges();
    }

    public void UpdateCard(CardUpdateDto cardUpdateDto)
    {
        var card = GetCardEntityAndValidate(cardUpdateDto.Id);

        if (card.Status == CardStatus.PermanentBlock)
            throw new ArgumentException("Карта перманентно заблокирована, обновление невозможно");

        if (cardUpdateDto is { PublicKey: not null, EncodedPinCode: null } or { PublicKey: null, EncodedPinCode: not null })
            throw new ArgumentException("При указании публичного ключа / зашифрованного пин-кода необходимо указывать зашифрованный пи-код / публичный ключ");

        if (cardUpdateDto.Status != null && cardUpdateDto.Status != card.Status)
        {
            cardOperationClient.UpdateCardOption(card.PublicId, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
                new CardStatusRequest((CardStatusRequest.NewStatusEnum)(int)cardUpdateDto.Status));
            card.Status = cardUpdateDto.Status.Value;
            cardRepository.SaveChanges();
        }

        if (cardUpdateDto is { EncodedPinCode: not null, PublicKey: not null })
            cardOperationClient.UpdateCardPin(card.PublicId, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
                new PinCardRequest(cardUpdateDto.EncodedPinCode, cardUpdateDto.PublicKey));
    }

    private bool UserHasCard(Guid cardId)
    {
        var userDto = userContextService.GetUserDtoFromHttpContext();
        return cardRepository.Read().SingleOrDefault(card => card.UserId == userDto.Id && card.Id == cardId && card.Status != CardStatus.PermanentBlock) != null;
    }

    private Card GetCardEntityAndValidate(Guid cardId)
    {
        var card = cardRepository.Read().SingleOrDefault(card => card.Id == cardId);
        ValidateCard(card);
        return card!;
    }

    private void ValidateCard(Card? card)
    {
        if (card is null)
            throw new ArgumentException("Данной карты не существует");

        if (card.UserId != userContextService.GetUserDtoFromHttpContext().Id)
            throw new ArgumentException("Нельзя взаимодействовать с чужой картой");
    }
}
using Multibanking.CardInformationClient.Model;
using Multibanking.Contracts.Card;

namespace Multibanking.Services.Cards;

public interface ICardService
{
    void CreateCard(CardCreateDto cardCreateDto);

    CredentialsResponse GetCardDetail(Guid cardId);

    CvvResponse GetCardCvv(Guid cardId);

    List<CardReadDto> GetCards();

    void DeleteCard(Guid cardId);

    void UpdateCard(CardUpdateDto cardUpdateDto);

    bool UserHasCard(Guid cardId);
}
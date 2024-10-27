using Multibanking.Contracts.UniversalPayment;
using Multibanking.Data.OpenAPIBankClients.UniversalPaymentClient;
using Multibanking.Services.Cards;
using Multibanking.UniversalPaymentClient.Model;

namespace Multibanking.Services.UniversalPayments;

public class UniversalPaymentService(IUniversalPaymentClient universalPaymentClient, ICardService cardService) : IUniversalPaymentService
{
    public void CreatePaymentRequest(CreateUniversalPaymentDto createUniversalPaymentDto)
    {
        cardService.ValidateUserCard(createUniversalPaymentDto.CardId);
        var card = cardService.GetCard(createUniversalPaymentDto.CardId);
        
        universalPaymentClient.Request(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), [], Guid.NewGuid().ToString(),
            new RequestPaymentDtoRq(
                new ProviderServiceDtoRq(createUniversalPaymentDto.ServiceId), [], new MoneyDto(createUniversalPaymentDto.Amount, new CurrencyDto(createUniversalPaymentDto.Currency)),
                new ClientProductDtoRq(card.PublicId, ClientProductDtoRq.ProductTypeEnum.CARD))
        );
    }
}
using AutoMapper;
using Multibanking.Contracts.UnidentifiedPayment;
using Multibanking.Data.OpenAPIBankClients.UnidentifiedPaymentClient;
using Multibanking.Services.Cards;
using Multibanking.Services.UnidentifiedPayments.Models;
using Multibanking.UnidentifiedPaymentClient.Model;

namespace Multibanking.Services.UnidentifiedPayments;

public class UnidentifiedPaymentService(IUnidentifiedPaymentClient unidentifiedPaymentClient, IMapper mapper, ICardService cardService) : IUnidentifiedPaymentService
{
    private const int QuantityLongPullingAttempts = 10;
    private const int LongPullingPeriod = 1000;

    public async Task CreatePayment(CreateUnidentifiedPaymentDto createUnidentifiedPaymentDto)
    {
        cardService.ValidateUserCard(createUnidentifiedPaymentDto.CardGuid);
        var createUnidentifiedPaymentModel = mapper.Map<CreateUnidentifiedPaymentModel>(createUnidentifiedPaymentDto);
        createUnidentifiedPaymentModel.DebtorPan = cardService.GetDecryptedPan(createUnidentifiedPaymentDto.CardGuid);

        await CreatePaymentWithValidation(createUnidentifiedPaymentModel);
    }

    private ConsentResponseComplexType CreateConsentPaymentInit(CreateUnidentifiedPaymentModel createUnidentifiedPaymentModel)
    {
        var consentResponseComplexType = unidentifiedPaymentClient.CreatePaymentConsent(Guid.NewGuid().ToString(),
            new ConsentRequestComplexType(
                new ConsentRequestComplexTypeData(new DataConsentRequestComplexTypeInitiation(
                    Guid.NewGuid().ToString(),
                    Guid.NewGuid().ToString(),
                    ExternalLocalInstrument1Code.TmpVal1,
                    new InitiationComplexTypeInstructedAmount(createUnidentifiedPaymentModel.Amount, createUnidentifiedPaymentModel.Currency),
                    new InitiationComplexTypeDebtorAccount(PaymentAccountIdentificationDynamicType.PAN, createUnidentifiedPaymentModel.DebtorPan),
                    null,
                    null,
                    new InitiationComplexTypeCreditorAccount(createUnidentifiedPaymentModel.CreditPaymentAccountIdentificationDynamicType,
                        createUnidentifiedPaymentModel.CreditAccountIdentification)
                )),
                new ConsentRequestComplexTypeRisk()
            ), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

        if (consentResponseComplexType == null)
            throw new Exception("Со стороны банкинга не пришло ответа");

        return consentResponseComplexType;
    }

    private async Task<ConsentResponseComplexType> CreateConsentPaymentWithValidation(CreateUnidentifiedPaymentModel createUnidentifiedPaymentModel)
    {
        var consentResponseComplexType = CreateConsentPaymentInit(createUnidentifiedPaymentModel);

        var longPullingAttempt = 0;
        while (consentResponseComplexType.Data.Status is not (ConsentStatusStaticType.Consumed or ConsentStatusStaticType.Rejected))
        {
            if (longPullingAttempt == QuantityLongPullingAttempts)
                throw new Exception($"Банкинг не дал ответа по транзакции в течении {QuantityLongPullingAttempts} попыток. Вы можете отследить транзакцию в меню транзакций");

            await Task.Delay(LongPullingPeriod);
            consentResponseComplexType = unidentifiedPaymentClient.GetPaymentConsent(consentResponseComplexType.Data.ConsentId, Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString());
            longPullingAttempt++;
        }

        if (consentResponseComplexType.Data.Status == ConsentStatusStaticType.Rejected)
            throw new Exception("Ошибка на стороне банкинга. Не получилось создать согласие на неидентифицированный перевод.");

        return consentResponseComplexType;
    }

    private async Task<PaymentResponseComplexType> CreatePaymentInit(CreateUnidentifiedPaymentModel createUnidentifiedPaymentModel)
    {
        var consentResponseComplexType = await CreateConsentPaymentWithValidation(createUnidentifiedPaymentModel);


        var paymentResponseComplexType = unidentifiedPaymentClient.CreatePayment(Guid.NewGuid().ToString(), new PaymentRequestComplexType(
                new PaymentRequestComplexTypeData(
                    consentResponseComplexType.Data.ConsentId,
                    new DataConsentRequestComplexTypeInitiation(
                        Guid.NewGuid().ToString(),
                        Guid.NewGuid().ToString(),
                        ExternalLocalInstrument1Code.TmpVal1,
                        new InitiationComplexTypeInstructedAmount(createUnidentifiedPaymentModel.Amount, createUnidentifiedPaymentModel.Currency),
                        new InitiationComplexTypeDebtorAccount(PaymentAccountIdentificationDynamicType.PAN, createUnidentifiedPaymentModel.DebtorPan),
                        creditorAccount: new InitiationComplexTypeCreditorAccount(createUnidentifiedPaymentModel.CreditPaymentAccountIdentificationDynamicType,
                            createUnidentifiedPaymentModel.CreditAccountIdentification)
                    )),
                new ConsentRequestComplexTypeRisk()
            ), Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString(),
            Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

        if (paymentResponseComplexType == null)
            throw new Exception("Со стороны банкинга не пришло ответа");

        return paymentResponseComplexType;
    }

    private async Task CreatePaymentWithValidation(CreateUnidentifiedPaymentModel createUnidentifiedPaymentModel)
    {
        var paymentResponseComplexType = await CreatePaymentInit(createUnidentifiedPaymentModel);

        var longPullingAttempt = 0;
        while (paymentResponseComplexType.Data.Status is not (TransactionStatusStaticType.AcceptedCreditSettlementCompleted
               or TransactionStatusStaticType.AcceptedSettlementCompleted or TransactionStatusStaticType.Rejected))
        {
            if (longPullingAttempt == QuantityLongPullingAttempts)
                throw new Exception($"Банкинг не дал ответа по транзакции в течении {QuantityLongPullingAttempts} попыток. Вы можете отследить транзакцию в меню транзакций");

            await Task.Delay(LongPullingPeriod);
            paymentResponseComplexType = unidentifiedPaymentClient.GetPayment(paymentResponseComplexType.Data.PaymentId, Guid.NewGuid().ToString(), Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString(),
                Guid.NewGuid().ToString());

            longPullingAttempt++;
        }

        if (paymentResponseComplexType.Data.Status == TransactionStatusStaticType.Rejected)
            throw new Exception("Банкинг отклонил транзакцию");
    }
}
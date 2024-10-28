using Multibanking.Contracts.PeriodPaymentConsent;
using Multibanking.Data.OpenAPIBankClients.PeriodPaymentClient;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Services.PeriodPayments.Implementations;

public class PeriodPaymentService(IPeriodPaymentClient periodPaymentClient, IPeriodPaymentConsentService periodPaymentConsentService) : IPeriodPaymentService
{
    private const int QuantityLongPullingAttempts = 10;
    private const int LongPullingPeriod = 1000;
    
    public async Task CreatePeriodPayment(Guid periodPaymentConsentId, string amount, string currency)
    {
        var periodPaymentConsent = periodPaymentConsentService.GetPeriodPaymentConsent(periodPaymentConsentId);
        var fundsConfirmationResponse = CreateFundsConfirmation(amount, currency, periodPaymentConsent);
        var periodPaymentResponse = InitPeriodPayment(amount, currency, fundsConfirmationResponse, periodPaymentConsent);
        await ValidatePaymentCreation(periodPaymentResponse);
        
    }

    private async Task ValidatePaymentCreation(VRPResponse periodPaymentResponse)
    {
        var longPullingAttempt = 0;
        while (periodPaymentResponse.Data.Status is not (TransactionStatusCode.AcceptedSettlementCompleted or TransactionStatusCode.AcceptedCreditSettlementCompleted or TransactionStatusCode.Rejected))
        {
            if (longPullingAttempt == QuantityLongPullingAttempts)
                throw new Exception($"Банкинг не дал ответа по транзакции в течении {QuantityLongPullingAttempts} попыток. Вы можете отследить транзакцию в меню транзакций");

            await Task.Delay(LongPullingPeriod);
            
            periodPaymentResponse = periodPaymentClient.GetVRPVRPId(periodPaymentResponse.Data.VRPId);
            
            longPullingAttempt++;
        }
        
        if (periodPaymentResponse.Data.Status == TransactionStatusCode.Rejected)
            throw new Exception("Ошибка на стороне банкинга. Не получилось создать платеж.");
    }

    private VRPResponse InitPeriodPayment(string amount, string currency, VRPFundsConfirmationResponse fundsConfirmationResponse, ReadPeriodPaymentConsentDto periodPaymentConsent)
    {
        var periodPaymentResponse =  periodPaymentClient.CreateVRP(new VRPRequest(new VRPRequestData(fundsConfirmationResponse.Data.ConsentId, Guid.NewGuid().ToString(),
            periodPaymentConsent.ConsentBanking.Data.Initiation,
            new VRPRequestDataInstruction(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), instructedAmount: new VRPInstructionInstructedAmount(amount, currency))
        ), new VRPConsentRequestRisk()));
        return periodPaymentResponse;
        
    }

    private VRPFundsConfirmationResponse CreateFundsConfirmation(string amount, string currency, ReadPeriodPaymentConsentDto periodPaymentConsent)
    {
        var fundsConfirmationResponse = periodPaymentClient.CreateVRPConsentConsentIdFundsConfirmations(periodPaymentConsent.ConsentBanking.Data.ConsentId,
            new VRPFundsConfirmationRequest(
                new VRPFundsConfirmationRequestData(
                    periodPaymentConsent.ConsentBanking.Data.ConsentId,
                    Guid.NewGuid().ToString(),
                    new VRPFundsConfirmationRequestDataInstructedAmount(amount, currency)
                )
            ), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), Guid.NewGuid().ToString());

        if (fundsConfirmationResponse == null)
            throw new Exception("Не пришел ответ от банкинга");

        if (fundsConfirmationResponse.Data.FundsAvailableResult.FundsAvailable == VRPFundsConfirmationResponseDataFundsAvailableResult.FundsAvailableEnum.NotAvailable)
            throw new Exception("Недостаточно средств на счете");
        return fundsConfirmationResponse;
    }
}
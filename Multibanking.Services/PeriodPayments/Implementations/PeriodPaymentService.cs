using Multibanking.Data.OpenAPIBankClients.PeriodPaymentClient;

namespace Multibanking.Services.PeriodPayments.Implementations;

public class PeriodPaymentService(IPeriodPaymentClient periodPaymentClient) : IPeriodPaymentService
{
    public void Sad()
    {
        //periodPaymentClient.CreateVRP(new VRPRequest(new VRPRequestData()))
    }
}
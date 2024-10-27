using Moq;
using Multibanking.Data.OpenAPIBankClients.UniversalPaymentClient;

namespace Multibanking.Infrustructure.Mocks;

public static class UniversalPaymentClientMock
{
    public static Mock<IUniversalPaymentClient> MockUnidentifiedPaymentClient()
    {
        var mock = new Mock<IUniversalPaymentClient>();

        return mock;
    }
}
using Moq;
using Multibanking.AccountClient.Model;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Infrustructure.Mocks;

public static class AccountClientMock
{
    public static Mock<IAccountConsentsClient> MockAccountConsentsClient()
    {
        var mock = new Mock<IAccountConsentsClient>();
        mock.Setup(accountConsentsClient => accountConsentsClient.CreateAccountAccessConsents(It.IsAny<Consent>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
            .Returns(() =>
            {
                var id = Guid.NewGuid().ToString();
                return new ConsentResponse(new DataConsentResponseType(id, DateTime.Now,
                    ConsentStatusType.Authorised, DateTime.Now, []), new object(), new LinksType(id), new MetaType());
            });

        return mock;
    }

    public static Mock<IAccountsClient> MockAccountsClient()
    {
        var mock = new Mock<IAccountsClient>();
        return mock;
    }

    public static Mock<IBalancesClient> MockBalancesClient()
    {
        var mock = new Mock<IBalancesClient>();
        return mock;
    }


    public static Mock<ITransactionsClient> MockTransactionsClient()
    {
        var mock = new Mock<ITransactionsClient>();
        return mock;
    }

    public static Mock<IStatementsClient> MockStatementsClient()
    {
        var mock = new Mock<IStatementsClient>();
        return mock;
    }
}
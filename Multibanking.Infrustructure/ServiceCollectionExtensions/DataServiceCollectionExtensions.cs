using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Multibanking.Data.OpenAPIBankClients.AccountClient;
using Multibanking.Data.OpenAPIBankClients.AccountClient.Implementations;
using Multibanking.Data.OpenAPIBankClients.BonusPointClient;
using Multibanking.Data.OpenAPIBankClients.CardClient;
using Multibanking.Data.OpenAPIBankClients.PeriodPaymentClient;
using Multibanking.Data.OpenAPIBankClients.ServiceClient;
using Multibanking.Data.OpenAPIBankClients.UnidentifiedPaymentClient;
using Multibanking.Data.OpenAPIBankClients.UniversalPaymentClient;
using Multibanking.Data.Repositories.Account;
using Multibanking.Data.Repositories.Card;
using Multibanking.Data.Repositories.PeriodPayments;
using Multibanking.Data.Repositories.Users;
using Multibanking.Infrustructure.Mocks;
using Multibanking.Infrustructure.Models;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class DataServiceCollectionExtensions
{
    public static IServiceCollection AddData(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        return serviceCollection
            .AddRepositories()
            .AddOpenApiBankClients(configuration);
    }

    private static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddScoped<IUserRepository, UserRepository>()
            .AddScoped<IAccountConsentRepository, AccountConsentRepository>()
            .AddScoped<ICardRepository, CardRepository>()
            .AddScoped<IPeriodPaymentConsentRepository, PeriodPaymentConsentRepository>();
    }

    private static IServiceCollection AddOpenApiBankClients(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        var mockClients = configuration.GetRequiredSection(nameof(MockOpenApiBankClientsSettings))
            .Get<MockOpenApiBankClientsSettings>()!;

        if (mockClients.IsAccountClientMock)
            serviceCollection
                .AddScoped<IAccountConsentsClient>(_ => AccountClientMock.MockAccountConsentsClient().Object)
                .AddScoped<IAccountsClient>(_ => AccountClientMock.MockAccountsClient().Object)
                .AddScoped<IBalancesClient>(_ => AccountClientMock.MockBalancesClient().Object)
                .AddScoped<IStatementsClient>(_ => AccountClientMock.MockStatementsClient().Object)
                .AddScoped<ITransactionsClient>(_ => AccountClientMock.MockTransactionsClient().Object);
        else
            serviceCollection
                .AddScoped<IAccountConsentsClient, AccountConsentsClient>()
                .AddScoped<IAccountsClient, AccountsClient>()
                .AddScoped<IBalancesClient, BalancesClient>()
                .AddScoped<IStatementsClient, StatementsClient>()
                .AddScoped<ITransactionsClient, TransactionsClient>();

        if (mockClients.IsUnidentifiedPaymentClientMock)
            serviceCollection.AddScoped<IUnidentifiedPaymentClient>(_ => UnidentifiedPaymentClientMock.MockUnidentifiedPaymentClient().Object);
        else
            serviceCollection.AddScoped<IUnidentifiedPaymentClient, Data.OpenAPIBankClients.UnidentifiedPaymentClient.UnidentifiedPaymentClient>();

        if (mockClients.IsCardClientMock)
            serviceCollection
                .AddScoped<ICardEmissionClient>(_ => CardClientMock.MockCardEmissionClient().Object)
                .AddScoped<ICardInformationClient>(_ => CardClientMock.MockCardInformationClient().Object)
                .AddScoped<ICardOperationClient>(_ => CardClientMock.MockCardOperationClient().Object);
        else
            serviceCollection
                .AddScoped<ICardEmissionClient, Data.OpenAPIBankClients.CardClient.Implementations.CardEmissionClient>()
                .AddScoped<ICardInformationClient, Data.OpenAPIBankClients.CardClient.Implementations.CardInformationClient>()
                .AddScoped<ICardOperationClient, Data.OpenAPIBankClients.CardClient.Implementations.CardOperationClient>();

        if (mockClients.IsServiceClientMock)
            serviceCollection.AddScoped<IServiceClient>(_ => ServiceClientMock.MockServiceClient().Object);
        else
            serviceCollection.AddScoped<IServiceClient, Data.OpenAPIBankClients.ServiceClient.ServiceClient>();

        if (mockClients.IsUniversalPaymentClientMock)
            serviceCollection.AddScoped<IUniversalPaymentClient>(_ => UniversalPaymentClientMock.MockUnidentifiedPaymentClient().Object);
        else
            serviceCollection.AddScoped<IUniversalPaymentClient, Data.OpenAPIBankClients.UniversalPaymentClient.UniversalPaymentClient>();

        if (mockClients.IsPeriodPaymentClientMock)
        {
            serviceCollection.AddScoped<IPeriodPaymentConsentClient>(_ => PeriodPaymentClientMock.MockPeriodPaymentConsentClient().Object);
            serviceCollection.AddScoped<IPeriodPaymentClient>(_ => PeriodPaymentClientMock.MockPeriodPaymentClient().Object);
        }
        else
        {
            serviceCollection.AddScoped<IPeriodPaymentConsentClient, Data.OpenAPIBankClients.PeriodPaymentClient.Implementations.PeriodPaymentConsentClient>();
            serviceCollection.AddScoped<IPeriodPaymentClient, Data.OpenAPIBankClients.PeriodPaymentClient.Implementations.PeriodPaymentClient>();
        }

        if (mockClients.IsBonusPointClientMock)
            serviceCollection.AddScoped<IBonusPointClient>(_ => BonusPointClientMock.MockBonusPointClient().Object);
        else
            serviceCollection.AddScoped<IBonusPointClient, Data.OpenAPIBankClients.BonusPointClient.BonusPointClient>();
        
        return serviceCollection;
    }
}
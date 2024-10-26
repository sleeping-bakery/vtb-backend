using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Multibanking.Data.OpenAPIBankClients.AccountClient;
using Multibanking.Data.OpenAPIBankClients.AccountClient.Implementations;
using Multibanking.Data.OpenAPIBankClients.CardClient;
using Multibanking.Data.OpenAPIBankClients.UnidentifiedPaymentClient;
using Multibanking.Data.Repositories.Account;
using Multibanking.Data.Repositories.Card;
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
            .AddScoped<ICardRepository, CardRepository>();
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

        return serviceCollection;
    }
}
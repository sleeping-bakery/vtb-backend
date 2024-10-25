using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Multibanking.Data.OpenAPIBankClients.AccountClient;
using Multibanking.Data.OpenAPIBankClients.AccountClient.Implementations;
using Multibanking.Data.Repositories.Account;
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
            .AddScoped<IAccountConsentRepository, AccountConsentRepository>();
    }

    private static IServiceCollection AddOpenApiBankClients(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        var mockClients = configuration.GetRequiredSection(nameof(MockOpenApiBankClientsSettings))
            .Get<MockOpenApiBankClientsSettings>()!;

        if (mockClients.IsAccountClientMock)
        {
            serviceCollection
                .AddScoped<IAccountConsentsClient>(_ => AccountClientMock.MockAccountConsentsClient().Object)
                .AddScoped<IAccountsClient>(_ => AccountClientMock.MockAccountsClient().Object)
                .AddScoped<IBalancesClient>(_ => AccountClientMock.MockBalancesClient().Object)
                .AddScoped<IStatementsClient>(_ => AccountClientMock.MockStatementsClient().Object)
                .AddScoped<ITransactionsClient>(_ => AccountClientMock.MockTransactionsClient().Object);
        }
        else
        {
            serviceCollection
                .AddScoped<IAccountConsentsClient, AccountConsentsClient>()
                .AddScoped<IAccountsClient, AccountsClient>()
                .AddScoped<IBalancesClient, BalancesClient>()
                .AddScoped<IStatementsClient, StatementsClient>()
                .AddScoped<ITransactionsClient, TransactionsClient>();
        }

        return serviceCollection;
    }
}
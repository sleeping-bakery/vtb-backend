using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Multibanking.Data.OpenAPIBankClients.AccountClient;
using Multibanking.Data.OpenAPIBankClients.AccountClient.Implementations;
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
        return serviceCollection.AddScoped<IUserRepository, UserRepository>();
    }

    private static IServiceCollection AddOpenApiBankClients(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        var mockClients = configuration.GetRequiredSection(nameof(MockOpenApiBankClientsSettings))
            .Get<MockOpenApiBankClientsSettings>()!;

        if (mockClients.IsAccountClientMock)
        {
            serviceCollection.AddScoped<IAccountConsentsClient>(_ =>
                AccountClientMock.MockAccountConsentsClient().Object);
            serviceCollection.AddScoped<IAccountsClient>(_ => AccountClientMock.MockAccountsClient().Object);
            serviceCollection.AddScoped<IBalancesClient>(_ => AccountClientMock.MockBalancesClient().Object);
            serviceCollection.AddScoped<IStatementsClient>(_ => AccountClientMock.MockStatementsClient().Object);
            serviceCollection.AddScoped<ITransactionsClient>(_ => AccountClientMock.MockTransactionsClient().Object);
        }
        else
        {
            serviceCollection.AddScoped<IAccountConsentsClient, AccountConsentsClient>();
            serviceCollection.AddScoped<IAccountsClient, AccountsClient>();
            serviceCollection.AddScoped<IBalancesClient, BalancesClient>();
            serviceCollection.AddScoped<IStatementsClient, StatementsClient>();
            serviceCollection.AddScoped<ITransactionsClient, TransactionsClient>();
        }

        return serviceCollection;
    }
}
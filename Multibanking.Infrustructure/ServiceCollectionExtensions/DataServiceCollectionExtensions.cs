using Microsoft.Extensions.DependencyInjection;
using Multibanking.Data.Repositories.Users;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class DataServiceCollectionExtensions
{
    public static IServiceCollection AddData(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddScoped<IUserRepository, UserRepository>();
    }
}
using Microsoft.Extensions.DependencyInjection;
using Multibanking.Repositories.Users;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class RepositoriesServiceCollectionExtensions
{
    public static IServiceCollection AddRepositories(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddScoped<IUserRepository, UserRepository>();
    }
}
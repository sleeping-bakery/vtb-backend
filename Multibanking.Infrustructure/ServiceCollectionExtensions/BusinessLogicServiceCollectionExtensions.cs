using Microsoft.Extensions.DependencyInjection;
using Multibanking.Services.Account;
using Multibanking.Services.Account.Implementations;
using Multibanking.Services.User;
using Multibanking.Services.User.Implementations;
using Multibanking.Services.User.MappingProfiles;
using Multibanking.Services.User.Middlewares;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class BusinessLogicServiceCollectionExtensions
{
    public static IServiceCollection AddBusinessLogic(this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddMapping()
            .AddServices()
            .AddMiddlewares();
    }

    private static IServiceCollection AddMapping(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddAutoMapper([typeof(UserMapperProfile)]);
    }

    private static IServiceCollection AddServices(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddScoped<IUserService, UserService>()
            .AddScoped<IAccountConsentsService, AccountConsentsService>();
    }

    private static IServiceCollection AddMiddlewares(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddTransient<CreateUserMiddleware>();
    }
}
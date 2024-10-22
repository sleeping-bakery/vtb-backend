using Microsoft.Extensions.DependencyInjection;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAllServices(this IServiceCollection serviceCollection)
    {
        return serviceCollection
            .AddInfrastructure()
            .AddRepositories()
            .AddBusinessLogic();
    }
}
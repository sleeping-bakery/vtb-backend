using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAllServices(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        return serviceCollection
            .AddInfrastructure(configuration)
            .AddData(configuration)
            .AddBusinessLogic();
    }
}
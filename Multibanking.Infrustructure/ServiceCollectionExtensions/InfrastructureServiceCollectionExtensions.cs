using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Multibanking.Entities.Database;
namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection)
    {
        // TODO: Add connection string param
        return serviceCollection.AddDbContext<MultibankingDbContext>(options => options.UseNpgsql("Server=127.0.0.1;Port=5432;Database=postgres;User Id=postgres;Password=postgres;"));
    }
}
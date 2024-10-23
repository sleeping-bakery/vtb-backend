using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Multibanking.Entities.Database;
namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        configuration.SubstituteEnvironmentVariables();
        return serviceCollection.AddDbContext<MultibankingDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
    }
    
    private  static void SubstituteEnvironmentVariables(this IConfiguration configuration)
    {
        var keys = configuration.AsEnumerable().Select(section => section.Key).ToList();

        foreach (var key in keys)
        {
            var value = configuration[key];
            if (value == null) continue;
            var substitutedValue = SubstituteEnvironmentVariables(value);
            if (configuration is IConfigurationRoot configRoot)
            {
                configRoot[key] = substitutedValue;
            }
        }
    }
    private static string SubstituteEnvironmentVariables(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        // Используем регулярное выражение для поиска всех ${VARIABLE_NAME}
        var regex = new System.Text.RegularExpressions.Regex(@"\${(.*?)}");
        return regex.Replace(str, match =>
        {
            var envVariable = match.Groups[1].Value; // Получаем имя переменной
            return Environment.GetEnvironmentVariable(envVariable) ?? match.Value; // Подставляем значение или оставляем как есть
        });
    }
}
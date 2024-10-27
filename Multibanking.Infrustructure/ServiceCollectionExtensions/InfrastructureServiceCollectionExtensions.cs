using System.Text.RegularExpressions;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Multibanking.Entities.Database;
using Multibanking.Infrustructure.Models;

namespace Multibanking.Infrustructure.ServiceCollectionExtensions;

public static class InfrastructureServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructure(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        configuration.SubstituteEnvironmentVariables();

        return serviceCollection
            .AddKeycloak(configuration)
            .AddDbContext<MultibankingDbContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")))
            .AddSwagger();
    }

    private static IServiceCollection AddSwagger(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddSwaggerGen(swaggerGenOptions =>
        {
            var xmlPath = Path.Combine(AppContext.BaseDirectory, "Multibanking.API.xml");
            swaggerGenOptions.IncludeXmlComments(xmlPath);

            // Настройка авторизации через Bearer token
            swaggerGenOptions.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Введите 'Bearer' [пробел] и ваш токен в формате: 'Bearer 12345abcdef'",
                Name = "Authorization",
                Type = SecuritySchemeType.ApiKey
            });

            swaggerGenOptions.AddSecurityRequirement(new OpenApiSecurityRequirement
            {
                {
                    new OpenApiSecurityScheme
                    {
                        Reference = new OpenApiReference
                        {
                            Type = ReferenceType.SecurityScheme,
                            Id = "Bearer"
                        }
                    },
                    new string[] { }
                }
            });
        });
    }

    private static IServiceCollection AddKeycloak(this IServiceCollection serviceCollection,
        IConfiguration configuration)
    {
        var keycloakSettings = configuration.GetRequiredSection(nameof(KeycloakSettings)).Get<KeycloakSettings>()!;

        return serviceCollection.AddKeycloakSettings(keycloakSettings)
            .AddAuthentication(keycloakSettings)
            .AddAuthorization();
    }

    private static IServiceCollection AddKeycloakSettings(this IServiceCollection serviceCollection,
        KeycloakSettings keycloakSettings)
    {
        // ReSharper disable once RedundantAssignment
        return serviceCollection.Configure<KeycloakSettings>(options =>
        {
            // ReSharper disable once RedundantAssignment
            options = keycloakSettings;
        });
    }

    private static IServiceCollection AddAuthentication(this IServiceCollection serviceCollection,
        KeycloakSettings keycloakSettings)
    {
        serviceCollection.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            .AddJwtBearer(options => ConfigureJwtBearerOptions(options, keycloakSettings));
        return serviceCollection;
    }

    private static ICollection<JsonWebKey> GetSigningKeys(KeycloakSettings keycloakSettings)
    {
        var jsonWebKeySetJson = new HttpClient().GetStringAsync(keycloakSettings.CertificateUrl).Result;
        var jsonWebKeySet = new JsonWebKeySet(jsonWebKeySetJson);
        return jsonWebKeySet.Keys;
    }

    private static IServiceCollection AddAuthorization(this IServiceCollection serviceCollection)
    {
        return serviceCollection.AddAuthorization(options =>
            options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build());
    }

    private static void SubstituteEnvironmentVariables(this IConfiguration configuration)
    {
        var keys = configuration.AsEnumerable().Select(section => section.Key).ToList();

        foreach (var key in keys)
        {
            var value = configuration[key];
            if (value == null) continue;
            var substitutedValue = SubstituteEnvironmentVariables(value);
            if (configuration is IConfigurationRoot configRoot) configRoot[key] = substitutedValue;
        }
    }

    private static void ConfigureJwtBearerOptions(JwtBearerOptions options, KeycloakSettings keycloakSettings)
    {
        options.Authority = keycloakSettings.Authority;

        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateActor = true,
            ValidateAudience = true,
            ValidAudience = keycloakSettings.ValidAudience,
            ValidateIssuer = true,
            ValidIssuer = keycloakSettings.ValidIssuer,
            ValidateLifetime = true,
            ValidateSignatureLast = true,
            ValidateTokenReplay = true,
            ValidateWithLKG = true,
            ValidateIssuerSigningKey = true,
            IssuerSigningKeyResolver = (_, _, _, _) => GetSigningKeys(keycloakSettings),
            LogValidationExceptions = true
        };

        options.Events = new JwtBearerEvents
        {
            OnAuthenticationFailed = context =>
            {
                Console.WriteLine($"Authentication failed: {context.Exception.Message}");
                return Task.CompletedTask;
            },
            OnForbidden = _ =>
            {
                Console.WriteLine("Forbidden request.");
                return Task.CompletedTask;
            }
        };

        // Убрать когда захостимся, оставить только для дебага
        options.RequireHttpsMetadata = false;
    }


    private static string SubstituteEnvironmentVariables(string str)
    {
        if (string.IsNullOrEmpty(str))
            return str;

        // Используем регулярное выражение для поиска всех ${VARIABLE_NAME}
        var regex = new Regex(@"\${(.*?)}");
        return regex.Replace(str, match =>
        {
            var envVariable = match.Groups[1].Value; // Получаем имя переменной
            return Environment.GetEnvironmentVariable(envVariable) ??
                   match.Value; // Подставляем значение или оставляем как есть
        });
    }
}
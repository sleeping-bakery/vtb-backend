using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Multibanking.Entities.Database;
using Multibanking.Infrustructure.ServiceCollectionExtensions;
using Multibanking.Services.User;

namespace Multibanking.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        Console.WriteLine($"EnvironmentName: {builder.Environment.EnvironmentName}");
        // Add services to the container.
        builder.Configuration
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();
        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();
        builder.Services.AddHttpContextAccessor();
        

        // TODO: Унести в 
        builder.Services.AddAuthentication(d =>
            {
                d.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                d.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer("Bearer", options =>
            {
                // TODO: Прокидывать через конфиги
                options.Authority = "http://localhost:8080";
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateActor = true,

                    ValidateAudience = true,
                    // TODO: Прокидывать через конфиги
                    ValidAudience = "account",

                    ValidateIssuer = true,
                    // TODO: Прокидывать через конфиги
                    ValidIssuer = "http://localhost:8080/realms/master",
                    // TODO: Поменять на true, когда будем хоститься
                    ValidateLifetime = true,

                    ValidateSignatureLast = true,
                    ValidateTokenReplay = true,
                    ValidateWithLKG = true,

                    ValidateIssuerSigningKey = true,
                    // TODO: получить напрямую с КК
                    IssuerSigningKeyResolver = (_, _, _, _) =>
                    {
                        // TODO: прокинуть через конфиги
                        var jsonWebKeySet = new JsonWebKeySet(new HttpClient().GetStringAsync("http://localhost:8080/realms/master/protocol/openid-connect/certs").Result);
                        return jsonWebKeySet.Keys;
                    },
                    LogValidationExceptions = true,
                    
                };
                options.Events = new JwtBearerEvents()
                {
                    OnAuthenticationFailed = c =>
                    {
                        Console.WriteLine(c.Exception.Message);
                        return Task.CompletedTask; 
                    }
                };
                // TODO: Убрать когда захостимся, оставить только для дебага
                options.RequireHttpsMetadata = false;
            });
        builder.Services.AddAuthorization(options =>
            options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build());

        builder.Services.AddAllServices(builder.Configuration);

        var app = builder.Build();

// TODO: Решить, оставлять ли swagger (по логике да)
        // if (app.Environment.IsDevelopment())
        // {
        app.UseSwagger();
        app.UseSwaggerUI();
        // }

        Console.WriteLine($"IsDevelopment {app.Environment.IsDevelopment()}");

        // TODO: убрать в конфиг
        // if (app.Environment.IsDevelopment())
        // {
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<MultibankingDbContext>();
        db.Database.Migrate();
        // }


        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers();

        // TODO: убрать в конфиг
        app.UseMiddleware<CreateUserMiddleware>();

        app.Run();
    }
}
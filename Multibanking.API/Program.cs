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

        // Add services to the container.

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
                    
                    ValidateLifetime = true,
                    
                    ValidateSignatureLast = true,
                    ValidateTokenReplay = true,
                    ValidateWithLKG = true,
                    
                    ValidateIssuerSigningKey = true,
                    // TODO: получить напрямую с КК
                    IssuerSigningKey = new JsonWebKey(@"{""keys"":[{""kid"":""x8iUtT5g62gjlSfsOP1ETapFlwO7-VnQXbxh3zWkGyw"",""kty"":""RSA"",""alg"":""RS256"",""use"":""sig"",""n"":""twG0FyOlpnGN_Ch7lHCJYPFPBkHQlHFTX29Li2uXzKaWRFFxHdkbIRbkux--J9HPkrefv0kXOJBVqEDTX3xuDhhFifU8blyn1o53BILbTG25cEUkUWb9jZqo9NDmgatiu44AmDVS-IrFZyqLT_7OyOFpzuhDb702Cd5qkfu4buIwPf1P26ifFFGo1VnpRIxdRhbiQ34_fWwR2thxng_HCwBxg2eLE_OlWtoBo3PWKJu3j1uOYCEUMWwuwkVCJhOaqC-j-27_3utF6ryj9TVdqP3mJurJNlBoA1aNE2iQV0QqlkYxBbpFtjPaDDTS5T88HL8ZwU5w-lX6rIB3A0AklQ"",""e"":""AQAB"",""x5c"":[""MIICmzCCAYMCBgGStgfs5DANBgkqhkiG9w0BAQsFADARMQ8wDQYDVQQDDAZtYXN0ZXIwHhcNMjQxMDIyMjA1ODQ1WhcNMzQxMDIyMjEwMDI1WjARMQ8wDQYDVQQDDAZtYXN0ZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQC3AbQXI6WmcY38KHuUcIlg8U8GQdCUcVNfb0uLa5fMppZEUXEd2RshFuS7H74n0c+St5+/SRc4kFWoQNNffG4OGEWJ9TxuXKfWjncEgttMbblwRSRRZv2Nmqj00OaBq2K7jgCYNVL4isVnKotP/s7I4WnO6ENvvTYJ3mqR+7hu4jA9/U/bqJ8UUajVWelEjF1GFuJDfj99bBHa2HGeD8cLAHGDZ4sT86Va2gGjc9Yom7ePW45gIRQxbC7CRUImE5qoL6P7bv/e60XqvKP1NV2o/eYm6sk2UGgDVo0TaJBXRCqWRjEFukW2M9oMNNLlPzwcvxnBTnD6VfqsgHcDQCSVAgMBAAEwDQYJKoZIhvcNAQELBQADggEBAFVk6vsj0nw070hVFjaZ25hUDpC8bOSM3p3Q7o6H8iYa7nz5qPM3N0xe6LzG4AaL4DJM+70VEAF2sgkM6OS0IVW+T0dVscQTLKowEebm7okqvoy3t/z4vYwFgOGXh+KTa9tbog0hlOZDsZo4mJbt2i7QynKMyNwPGfbjk1yAw/g27xlKADEPyNCXkC6xMx8hMzMAcKnlwkdT8q+inesGzgCrUvfBtc9YnhoiMpZr7kqtb8b3LsW/h+RrhaGD+gFuX+6XrfswLkStaTfHLMJl5HxRSYE92mfG+f3e2R2g2yzMz7/vrPtTTs/76CcoYDXI/24KMsTD+5FIFC6Bc7weJs8=""],""x5t"":""66AgaXV_goAJfXLwpqLz4EDB9Yc"",""x5t#S256"":""EBWp5-QvtvhhnEZ0k4ypcYfod8kxz1yUMe0duopSnfM""},{""kid"":""d_9NCTcCaWnvtjo9zQNBz4NC1drKcGR0EjXrMPI1dE0"",""kty"":""RSA"",""alg"":""RSA-OAEP"",""use"":""enc"",""n"":""11xfjH8ASepFt7aiTO8yGPg-jbiDwUtXVpHBvXVIECIU7-pXQdKqItQvtvkVfacNcguDn-jgTRpYdLv3QWCIua8MgahaNIlGffn4b1jFMDIKOGQ-enD7marJpDFcUTesXvVWfdl5zUQVZVQRW4JsPeUxYMAI83Us3f0f5T5JKuzVUTUOcU5m1behJk3tn4knMuPuqW84GhpAf1I8r-XkgT1TmJQ8Mg-GSClgvV0kmYmNvHpNR5LGYYfQdVdjkjOFoJYwjRpL40KaXe5AGqmIOcxRE_aPi_KwT0t6o7mycndQ1Q8HGXGkQ5M-xx96wyHO23jgJotSHDs_qDfMPIRnuw"",""e"":""AQAB"",""x5c"":[""MIICmzCCAYMCBgGStgftdzANBgkqhkiG9w0BAQsFADARMQ8wDQYDVQQDDAZtYXN0ZXIwHhcNMjQxMDIyMjA1ODQ1WhcNMzQxMDIyMjEwMDI1WjARMQ8wDQYDVQQDDAZtYXN0ZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDXXF+MfwBJ6kW3tqJM7zIY+D6NuIPBS1dWkcG9dUgQIhTv6ldB0qoi1C+2+RV9pw1yC4Of6OBNGlh0u/dBYIi5rwyBqFo0iUZ9+fhvWMUwMgo4ZD56cPuZqsmkMVxRN6xe9VZ92XnNRBVlVBFbgmw95TFgwAjzdSzd/R/lPkkq7NVRNQ5xTmbVt6EmTe2fiScy4+6pbzgaGkB/Ujyv5eSBPVOYlDwyD4ZIKWC9XSSZiY28ek1HksZhh9B1V2OSM4WgljCNGkvjQppd7kAaqYg5zFET9o+L8rBPS3qjubJyd1DVDwcZcaRDkz7HH3rDIc7beOAmi1IcOz+oN8w8hGe7AgMBAAEwDQYJKoZIhvcNAQELBQADggEBAAmvzQoausEpzykFkZDFsj+SXVRrhTyW5e32RDN6Tkc+xik/LKfxw5vOT4YwduP8XiF00610bvSF1OlB8OM4A8b/Ya8pFCspkc1yKQtTb9a2IrWOwDgT8LV7IAs0WmNhys+UQrpM/41pv0MyipqcBDUDpbkKlFrRaQhxbKu0k3pjx73rjbRFHOf7TvWbUv//AxDCLHfwccHzfY7ZgoA7gOAwaSWcw6RpI6qpa7puCNqQl735GxMwKz2sqxmbaPCRKOvdcgZOQG0yCuvEAQzVCYsyTWyj/9WRpOOoiTqxxgv/G8QK2O+zkeZboLsV27kxK8Gc6TA5Ssq5mJBnbnhTi7A=""],""x5t"":""JlrdftAx9bP0KGpbnlK8kHL2lxw"",""x5t#S256"":""iI9-iEiozD5ZGYLCZP7c3p3bAW_kP97L2A-JBL38ujM""}]}"),
                    LogValidationExceptions = true,
                };
#if DEBUG
                options.RequireHttpsMetadata = false;
#endif
                options.Events = new JwtBearerEvents()
                {
                    OnAuthenticationFailed = c => throw c.Exception
                };
            });
        builder.Services.AddAuthorization(options =>
            options.FallbackPolicy = new AuthorizationPolicyBuilder()
                .RequireAuthenticatedUser()
                .Build());

        builder.Services.AddAllServices();

        var app = builder.Build();


        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        // TODO: убрать в конфиг
        if (app.Environment.IsDevelopment())
        {
            using var scope = app.Services.CreateScope();
            var db = scope.ServiceProvider.GetRequiredService<MultibankingDbContext>();
            db.Database.Migrate();
        }


        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers();

        // TODO: убрать в конфиг
        app.UseMiddleware<CreateUserMiddleware>();

        app.Run();
    }
}
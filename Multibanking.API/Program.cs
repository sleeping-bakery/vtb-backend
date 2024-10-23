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
                    // TODO: Поменять на true, когда будем хоститься
                    ValidateLifetime = true,

                    ValidateSignatureLast = true,
                    ValidateTokenReplay = true,
                    ValidateWithLKG = true,

                    ValidateIssuerSigningKey = true,
                    // TODO: получить напрямую с КК
                    IssuerSigningKey = new JsonWebKey(
                        @"{
    ""keys"": [
        {
            ""kid"": ""FINVMCN_8UMTQmhMLkYmtkfKgH3cerITmlgqQs9RECI"",
            ""kty"": ""RSA"",
            ""alg"": ""RS256"",
            ""use"": ""sig"",
            ""n"": ""sgOG-qAtqIol3BXzDdS6WUBh4_g4s5Ua70epvIgswwqMR2NUVcvo4pWdlrBh600mfdmKDHxYv5257WT5DLvhCSu4HNdk9JlhsiLV3sGVAXoNvULpz2uvaukyD3k_31RyKDo4hgMXmwB6vpMKI9a2ftUOV1wFgfBRKrrnzwuDRN_Pp0L_KpLePhHYluDQhmkRGrUjocU1BY70k8PIGOI1IfRwzqMqnXz7CFYR_i0HVAfw0mget94t300FJMYffXbMfIvbu4Axr5AMbEYsjPdIKQduanAj4HH5NKKVpO4QtKycYnNAMqMlQMrS5_8fHvhhm66PWyF5DyyZvA1VWCxhVQ"",
            ""e"": ""AQAB"",
            ""x5c"": [
                ""MIICmzCCAYMCBgGSuZTR1TANBgkqhkiG9w0BAQsFADARMQ8wDQYDVQQDDAZtYXN0ZXIwHhcNMjQxMDIzMTMzMTMxWhcNMzQxMDIzMTMzMzExWjARMQ8wDQYDVQQDDAZtYXN0ZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQCyA4b6oC2oiiXcFfMN1LpZQGHj+DizlRrvR6m8iCzDCoxHY1RVy+jilZ2WsGHrTSZ92YoMfFi/nbntZPkMu+EJK7gc12T0mWGyItXewZUBeg29QunPa69q6TIPeT/fVHIoOjiGAxebAHq+kwoj1rZ+1Q5XXAWB8FEquufPC4NE38+nQv8qkt4+EdiW4NCGaREatSOhxTUFjvSTw8gY4jUh9HDOoyqdfPsIVhH+LQdUB/DSaB633i3fTQUkxh99dsx8i9u7gDGvkAxsRiyM90gpB25qcCPgcfk0opWk7hC0rJxic0AyoyVAytLn/x8e+GGbro9bIXkPLJm8DVVYLGFVAgMBAAEwDQYJKoZIhvcNAQELBQADggEBAIKjQe/wVUR6bt54GuqvtA6ywlmmhsCzIFiZB0nemZt3Bw29ebj42RBdy87rnLcsfI4AT3yCaKhVrGJ0kC3LJ1B3XHMfWr7OVTW8HINlfkmO6iOWKILhl5GufPM+mjvJ52I/MKE579wnep+84EO3tpziBQR7fKY3tMGVHG04KRh1NLgC5GsNadyQIhy+814S+EwDBHCrTUD2i4HV8nub1fsGHTKjgYF28O5TPU3jHRjNdVV6YY3tA+8HmjlPUmb4558jz03x7FbH1AEDUUwd4lRzXwsfqoNzpFGKwYcYtuQTmMK31YIdWV6iTbnsQSFd674/zaONnynyAjEoCdcugL0=""
            ],
            ""x5t"": ""zo0ZBEslNfF4kHRO9bWv2J1CbuU"",
            ""x5t#S256"": ""Iq9l2mStZo6KRQLIBPCm-BLOCv6Rx8t11mooR61lNeY""
        },
        {
            ""kid"": ""ENZbly2pYWZbqNaAPTKQSuhgcAxD5sY3Su2HrUQ590k"",
            ""kty"": ""RSA"",
            ""alg"": ""RSA-OAEP"",
            ""use"": ""enc"",
            ""n"": ""39_qhlMwwNoNpMDIwdo3UeXPqAUpuMJrWzSOwfKLjDEb2Ti2nmLcgu-EhNqS_2lAf8sPjSwTOF8QRCFSrGnfVpfQZFFMd2FopB9oIJcrYEMMuCNzC87LNdX1E7LnsZLwH9b8XZJRKxRqFcDWZgww3bSA_DYJawM7Dob9e1y9sGK5htDwPBWlONEpmPW89Z2o9-GMzh7K1wY4aLNGt7Idj9NVoZQwQ6F30wMGoWIhk5EzQkYcqZ6x0RKgO5bJ-RJQCuk_FcYoIE-_6iYBFDBYtw25RHoZcg_4amu5S9XZLKtI82T4f-Wkdaj5xENxcN8Jr_TBcWL6W5LG_R2RFyLlGw"",
            ""e"": ""AQAB"",
            ""x5c"": [
                ""MIICmzCCAYMCBgGSuZTShTANBgkqhkiG9w0BAQsFADARMQ8wDQYDVQQDDAZtYXN0ZXIwHhcNMjQxMDIzMTMzMTMxWhcNMzQxMDIzMTMzMzExWjARMQ8wDQYDVQQDDAZtYXN0ZXIwggEiMA0GCSqGSIb3DQEBAQUAA4IBDwAwggEKAoIBAQDf3+qGUzDA2g2kwMjB2jdR5c+oBSm4wmtbNI7B8ouMMRvZOLaeYtyC74SE2pL/aUB/yw+NLBM4XxBEIVKsad9Wl9BkUUx3YWikH2gglytgQwy4I3MLzss11fUTsuexkvAf1vxdklErFGoVwNZmDDDdtID8NglrAzsOhv17XL2wYrmG0PA8FaU40SmY9bz1naj34YzOHsrXBjhos0a3sh2P01WhlDBDoXfTAwahYiGTkTNCRhypnrHREqA7lsn5ElAK6T8VxiggT7/qJgEUMFi3DblEehlyD/hqa7lL1dksq0jzZPh/5aR1qPnEQ3Fw3wmv9MFxYvpbksb9HZEXIuUbAgMBAAEwDQYJKoZIhvcNAQELBQADggEBANI/A6WszvtWaq5ZZkw5UtNiiw9+9nJW72HqF1QPJFFJLncT3o36cq7X1qQCnGUy1aerC2K3L4+zQfLVB7G0ZSt/iLhhsGEbndZ7L737j3tssNOtfuwoLlZuF1T/DBV97VnIZ1rFmjR9Ch6iQ/0KXDPX89L4WCCJmqO1BC4il6ltH0sX4lq8MrdUTK92yD4NGqVt5f/E4sVkCICO/KibOQVsIOYFov3Q2RxDTqOKyTdx7AfB8gGHVjwfSH7YFed9PvgFvn3l07bZf5fJ/n0Yy4V2tIiya7A1J9ScaaHYjMOg0073+G+CbQElijEezKnknqYHYze/64aNWhGVgvxzQF4=""
            ],
            ""x5t"": ""6SF2zgV3Iprf0YJBmqlMFxdGYPU"",
            ""x5t#S256"": ""vgWKMilRDDO31PO2VWD6X5FsA_zV58sMxYQPpO3T2fA""
        }
    ]
}"),
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

        builder.Services.AddAllServices();

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
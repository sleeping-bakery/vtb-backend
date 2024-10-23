using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using Multibanking.Entities.Database;
using Multibanking.Infrustructure.ServiceCollectionExtensions;
using Multibanking.Services.User;

namespace Multibanking.API;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        
        builder.Configuration
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
            .AddJsonFile($"appsettings.{builder.Environment.EnvironmentName}.json", optional: true, reloadOnChange: true)
            .AddEnvironmentVariables();
        
        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddHttpContextAccessor();
        

        

        builder.Services.AddAllServices(builder.Configuration);

        var app = builder.Build();

        //TODO: Перенос app'а
        app.UseSwagger();
        app.UseSwaggerUI();

        Console.WriteLine($"IsDevelopment {app.Environment.IsDevelopment()}");

 
        using var scope = app.Services.CreateScope();
        var db = scope.ServiceProvider.GetRequiredService<MultibankingDbContext>();
        db.Database.Migrate();


        app.UseHttpsRedirection();

        app.UseAuthentication();
        app.UseAuthorization();


        app.MapControllers();

        app.UseMiddleware<CreateUserMiddleware>();

        app.Run();
    }
}
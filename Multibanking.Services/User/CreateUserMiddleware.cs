using Microsoft.AspNetCore.Http;

namespace Multibanking.Services.User;

public class CreateUserMiddleware(IUserService userService) : IMiddleware
{
    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        userService.CrateUserIfNotExist();
        await next(context);
    }
}
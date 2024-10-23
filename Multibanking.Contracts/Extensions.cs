using Microsoft.AspNetCore.Http;

namespace Multibanking.Contracts;

public static class Extensions
{
    public static string GetLogin(this IHttpContextAccessor httpContextAccessor)
    {
        return httpContextAccessor.HttpContext.User.Claims.Single(claim => claim.Type == "preferred_username").Value;
    }
}
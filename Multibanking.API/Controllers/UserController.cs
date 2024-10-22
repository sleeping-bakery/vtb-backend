using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.User;
using Multibanking.Services.User;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService) : ControllerBase
{
    [HttpGet]
    public ActionResult<UserDto> Get()
    {
        return userService.GetUserFromHttpContext();
    }
}
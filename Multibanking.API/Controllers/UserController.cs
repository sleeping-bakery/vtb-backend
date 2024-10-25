using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.User;
using Multibanking.Services.User;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService, IUserContextService userContextService) : ControllerBase
{
    [HttpGet]
    public ActionResult<UserDto> Get()
    {
        return userContextService.GetUserDtoFromHttpContext();
    }

    [HttpPut]
    public ActionResult Put(UserUpdateDto userDto)
    {
        userService.UpdateUser(userDto);
        return Ok();
    }
}
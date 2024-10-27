using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.User;
using Multibanking.Services.User;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UserController(IUserService userService, IUserContextService userContextService) : ControllerBase
{
    /// <summary>
    ///     Получить информацию о текущем пользователе
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<UserDto> Get()
    {
        return userContextService.GetUserDtoFromHttpContext();
    }

    /// <summary>
    ///     Обновить текущего пользователя. Влияет на согласие на стороне банкинга
    /// </summary>
    /// <param name="userDto"></param>
    /// <returns></returns>
    [HttpPut]
    public ActionResult Put(UserUpdateDto userDto)
    {
        userService.UpdateUser(userDto);
        return Ok();
    }
}
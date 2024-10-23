using Multibanking.Contracts.User;

namespace Multibanking.Services.User;

public interface IUserService
{
    UserDto GetUserDtoFromHttpContext();
    void CrateUserIfNotExist();
    void UpdateUser(UserDto userDto);
}
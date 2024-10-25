using Multibanking.Contracts.User;

namespace Multibanking.Services.User;

public interface IUserService
{
    void CrateUserIfNotExist();
    void UpdateUser(UserUpdateDto userDto);
}
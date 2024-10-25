using Multibanking.Contracts.User;

namespace Multibanking.Services.User;

public interface IUserContextService
{
    UserDto GetUserDtoFromHttpContext();
}
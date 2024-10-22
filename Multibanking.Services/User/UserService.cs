using AutoMapper;
using Microsoft.AspNetCore.Http;
using Multibanking.Contracts;
using Multibanking.Contracts.User;
using Multibanking.Repositories.Users;

namespace Multibanking.Services.User;

public interface IUserService
{
    UserDto GetUserFromHttpContext();
    void CrateUserIfNotExist();
}

public class UserService(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
    : IUserService
{
    public UserDto GetUserFromHttpContext()
    {
        var user = userRepository.Read()
                       .SingleOrDefault(user => httpContextAccessor.GetLogin().ToLower() == user.Login.ToLower()) ??
                   throw new ArgumentException("Пользователя с данным логином не существует");
        return mapper.Map<UserDto>(user);
    }

    public void CrateUserIfNotExist()
    {
        if (userRepository.Exist(user => user.Login.ToLower() == httpContextAccessor.GetLogin().ToLower()))
            return;
        CreateUserFromHttpContext();
    }

    private void CreateUserFromHttpContext()
    {
        userRepository.Create(new Entities.Users.User
        {
            AccountConsents = [],
            Login = httpContextAccessor.GetLogin()
        });
        userRepository.SaveChanges();
    }
}
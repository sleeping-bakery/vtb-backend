using AutoMapper;
using Microsoft.AspNetCore.Http;
using Multibanking.Contracts;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Contracts.User;
using Multibanking.Repositories.Users;

namespace Multibanking.Services.User;

public interface IUserService
{
    UserDto GetUserDtoFromHttpContext();
    void CrateUserIfNotExist();
    void UpdateUser(UserDto userDto);
}

public class UserService(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor)
    : IUserService
{
    public UserDto GetUserDtoFromHttpContext()
    {
        return mapper.Map<UserDto>(GetUserFromHttpContext());
    }

    private Entities.Users.User GetUserFromHttpContext()
    {
        var user = userRepository.Read()
                       .SingleOrDefault(user => httpContextAccessor.GetLogin().ToLower() == user.Login.ToLower()) ??
                   throw new ArgumentException("Пользователя с данным логином не существует");
        return user;
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

    public void UpdateUser(UserDto userDto)
    {
        var user = GetUserFromHttpContext();
        if (user.Id != userDto.Id)
            throw new ArgumentException("Нельзя обновлять другого пользователя");
        if (!string.Equals(user.Login, userDto.Login, StringComparison.CurrentCultureIgnoreCase))
            throw new ArgumentException("Нельзя обновлять логин");
        var existingAccountConsents = Enum.GetValues<AccountConsent>();
        userDto.AccountConsents.ForEach(userConsent =>
        {
            if (!existingAccountConsents.Contains(userConsent))
                throw new ArgumentException($"Данный вид согласия на счет не существует: {userConsent}");
        });


        mapper.Map(userDto, user);
        // TODO: Начать кидать запросы на согласия по OPENAPI
        userRepository.Update(user);
        userRepository.SaveChanges();
    }
}
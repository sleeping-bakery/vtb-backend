using Microsoft.AspNetCore.Http;
using Multibanking.Contracts;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Contracts.User;
using Multibanking.Data.Repositories.Users;
using Multibanking.Services.Account;

namespace Multibanking.Services.User.Implementations;

public class UserService(
    IUserRepository userRepository,
    IAccountConsentsService accountConsentsService,
    IHttpContextAccessor httpContextAccessor,
    IUserContextService userContextService)
    : IUserService
{
    public void CrateUserIfNotExist()
    {
        if (userRepository.Exist(user => user.Login.ToLower() == httpContextAccessor.GetLogin().ToLower()))
            return;
        CreateUserFromHttpContext();
    }

    public void UpdateUser(UserUpdateDto userDto)
    {
        var user = userContextService.GetUserDtoFromHttpContext();
        if (user.Id != userDto.Id)
            throw new ArgumentException("Нельзя обновлять другого пользователя");
        if (!string.Equals(user.Login, userDto.Login, StringComparison.CurrentCultureIgnoreCase))
            throw new ArgumentException("Нельзя обновлять логин");
        if (userDto.AccountConsents.Distinct().Count() != userDto.AccountConsents.Count)
            throw new ArgumentException("Нельзя проставлять несколько одинаковых согласий");
        var existingAccountConsents = Enum.GetValues<AccountConsent>();
        userDto.AccountConsents.ForEach(userConsent =>
        {
            if (!existingAccountConsents.Contains(userConsent))
                throw new ArgumentException($"Данный вид согласия на счет не существует: {userConsent}");
        });

        accountConsentsService.CreateAccountAccessConsents(userDto.AccountConsents);

        var userEntity = userRepository.Read().Single(u => u.Id == userDto.Id);

        userEntity.AccountConsents = userDto.AccountConsents;

        userRepository.Update(userEntity);
        userRepository.SaveChanges();
    }

    private void CreateUserFromHttpContext()
    {
        userRepository.Create(new Entities.Users.User
        {
            AccountConsents = [],
            Login = httpContextAccessor.GetLogin(),
            Cards = []
        });
        userRepository.SaveChanges();
    }
}
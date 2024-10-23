﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Multibanking.Contracts;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Contracts.User;
using Multibanking.Data.Repositories.Users;
using Multibanking.Services.Account;

namespace Multibanking.Services.User.Implementations;

public class UserService(IUserRepository userRepository, IMapper mapper, IHttpContextAccessor httpContextAccessor, IAccountConsentsService accountConsentsService)
    : IUserService
{
    public UserDto GetUserDtoFromHttpContext()
    {
        return mapper.Map<UserDto>(GetUserFromHttpContext());
    }

    public void CrateUserIfNotExist()
    {
        if (userRepository.Exist(user => user.Login.ToLower() == httpContextAccessor.GetLogin().ToLower()))
            return;
        CreateUserFromHttpContext();
    }

    public void UpdateUser(UserDto userDto)
    {
        var user = GetUserFromHttpContext();
        if (user.Id != userDto.Id)
            throw new ArgumentException("Нельзя обновлять другого пользователя");
        if (!string.Equals(user.Login, userDto.Login, StringComparison.CurrentCultureIgnoreCase))
            throw new ArgumentException("Нельзя обновлять логин");
        if (user.AccountConsents.Distinct().Count() != userDto.AccountConsents.Count)
            throw new ArgumentException("Нельзя проставлять несколько одинаковых согласий");
        var existingAccountConsents = Enum.GetValues<AccountConsent>();
        userDto.AccountConsents.ForEach(userConsent =>
        {
            if (!existingAccountConsents.Contains(userConsent))
                throw new ArgumentException($"Данный вид согласия на счет не существует: {userConsent}");
        });

        accountConsentsService.CreateAccountAccessConsents(userDto.AccountConsents);

        mapper.Map(userDto, user);
        userRepository.Update(user);
        userRepository.SaveChanges();
    }

    private Entities.Users.User GetUserFromHttpContext()
    {
        var user = userRepository.Read()
                       .SingleOrDefault(user => httpContextAccessor.GetLogin().ToLower() == user.Login.ToLower()) ??
                   throw new ArgumentException("Пользователя с данным логином не существует");
        return user;
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
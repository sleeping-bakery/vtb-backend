using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Multibanking.Contracts;
using Multibanking.Contracts.User;
using Multibanking.Data.Repositories.Users;

namespace Multibanking.Services.User.Implementations;



public class UserContextService(IMapper mapper, IUserRepository userRepository, IHttpContextAccessor httpContextAccessor) : IUserContextService
{
    public UserDto GetUserDtoFromHttpContext()
    {
        return mapper.Map<UserDto>(GetUserFromHttpContext());
    }

    private Entities.Users.User GetUserFromHttpContext()
    {
        var user = userRepository.Read()
                       .Include(user => user.UserAccountConsent)
                       .SingleOrDefault(user => httpContextAccessor.GetLogin().ToLower() == user.Login.ToLower()) ??
                   throw new ArgumentException("Пользователя с данным логином не существует");
        return user;
    }
}
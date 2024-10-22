using AutoMapper;
using Multibanking.Contracts.User;

namespace Multibanking.Services.User;

public class UserMapperProfile : Profile
{
    public UserMapperProfile()
    {
        CreateMap<Entities.Users.User, UserDto>();
        CreateMap<UserDto, Entities.Users.User>();
    }
}
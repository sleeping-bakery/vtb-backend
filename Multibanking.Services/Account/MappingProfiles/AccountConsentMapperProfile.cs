using AutoMapper;
using Multibanking.Contracts.Consent;
using Multibanking.Entities.Accounts;

namespace Multibanking.Services.Account.MappingProfiles;

public class AccountConsentMapperProfile : Profile
{
    public AccountConsentMapperProfile()
    {
        CreateMap<UserAccountConsent, UserAccountConsentDto>();
        CreateMap<UserAccountConsentDto, UserAccountConsent>();
    }
}
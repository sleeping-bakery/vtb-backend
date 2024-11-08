using AutoMapper;
using Multibanking.Contracts.PeriodPaymentConsent;
using Multibanking.Entities.PeriodPayments;
using Multibanking.Services.PeriodPayments.Models;

namespace Multibanking.Services.PeriodPayments.MappingProfiles;

public class PeriodPaymentMapperProfile : Profile
{
    public PeriodPaymentMapperProfile()
    {
        CreateMap<CreatePeriodPaymentConsentDto, CreatePeriodPaymentConsentModel>();
        CreateMap<PeriodPaymentConsent, ReadPeriodPaymentConsentDto>();
    }
}
using AutoMapper;
using Multibanking.Contracts.UnidentifiedPayment;
using Multibanking.Services.UnidentifiedPayments.Models;

namespace Multibanking.Services.UnidentifiedPayments.MappingProfiles;

public class UnidentifiedPaymentMapperProfile : Profile
{
    public UnidentifiedPaymentMapperProfile()
    {
        CreateMap<CreateUnidentifiedPaymentDto, CreateUnidentifiedPaymentModel>();
    }
}
using AutoMapper;
using Multibanking.Contracts.Guarantee;
using Multibanking.Entities.GuaranteeOrders;

namespace Multibanking.Services.Guarantees.MappingProfiles;

public class GuaranteeMapperProfile : Profile
{
    public GuaranteeMapperProfile()
    {
        CreateMap<GuaranteeOrder, ReadGuaranteeOrderDto>();
    }
}
using AutoMapper;
using Multibanking.Contracts.Guarantee;
using Multibanking.Data.Repositories.Guarantee;
using Multibanking.Entities.GuaranteeOrders;
using Multibanking.GuaranteeClient.Model;
using Multibanking.Services.User;

namespace Multibanking.Services.Guarantees.Implementations;

public class GuaranteeService(IGuaranteeOrderRepository guaranteeOrderRepository, IUserContextService userContextService, IMapper mapper) : IGuaranteeService
{
    public void CreateOrder(OrderResponse orderResponse)
    {
        guaranteeOrderRepository.Create(new GuaranteeOrder
        {
            ResponseInit = orderResponse,
            UserId = userContextService.GetUserDtoFromHttpContext().Id
        });
        guaranteeOrderRepository.SaveChanges();
    }

    public void DeleteOrder(string orderId)
    {
        var guaranteeOrder = guaranteeOrderRepository.Read().Single(guaranteeOrder => guaranteeOrder.ResponseInit.OrderId == orderId);
        if (guaranteeOrder.UserId != userContextService.GetUserDtoFromHttpContext().Id)
            throw new Exception("Нельзя взаимодействовать с чужими заявками");
        guaranteeOrderRepository.Delete(guaranteeOrder);
        guaranteeOrderRepository.SaveChanges();
    }

    public List<ReadGuaranteeOrderDto> GetOrdersForUser()
    {
        var userDto = userContextService.GetUserDtoFromHttpContext();
        return mapper.Map<List<ReadGuaranteeOrderDto>>(guaranteeOrderRepository.Read().Where(guaranteeOrder => userDto.Id == guaranteeOrder.UserId).ToList());
    }
}
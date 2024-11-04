using Multibanking.Contracts.Guarantee;
using Multibanking.Entities.GuaranteeOrders;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Services.Guarantees;

public interface IGuaranteeService
{
    void CreateOrder(OrderResponse orderResponse);
    void DeleteOrder(string orderId);

    List<ReadGuaranteeOrderDto>  GetOrdersForUser();

}
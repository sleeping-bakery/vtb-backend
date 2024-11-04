using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Services.Guarantees;

public interface IGuaranteeOrderService
{
    void PostGuaranteeOrder(Order order);

    void DeleteOrder(string orderId, DeclineOrderDto declineOrderDto);

    OrderStatus GetOrder(string orderId);
}
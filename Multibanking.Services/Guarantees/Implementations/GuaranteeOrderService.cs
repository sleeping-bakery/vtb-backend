using Multibanking.Data.OpenAPIBankClients.GuaranteeClient;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Services.Guarantees.Implementations;

public class GuaranteeOrderService(IGuaranteeOrderClient guaranteeOrderClient, IGuaranteeService guaranteeService) : IGuaranteeOrderService
{
    public void PostGuaranteeOrder(Order order)
    {
        var orderResponse = guaranteeOrderClient.CreateOrder(Guid.NewGuid().ToString(), order);
        if (orderResponse == null)
            throw new Exception("Заявка не была создана; не поступило ответа от банкинга");

        guaranteeService.CreateOrder(orderResponse);
    }

    public void DeleteOrder(string orderId, DeclineOrderDto declineOrderDto)
    {
        guaranteeOrderClient.DeclineByClient(orderId, Guid.NewGuid().ToString(), declineOrderDto);
        guaranteeService.DeleteOrder(orderId);
    }

    public OrderStatus GetOrder(string orderId)
    {
        return guaranteeOrderClient.GetOrder(orderId, Guid.NewGuid().ToString());
    }
}
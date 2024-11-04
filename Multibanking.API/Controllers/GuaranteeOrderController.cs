using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.Guarantee;
using Multibanking.GuaranteeClient.Model;
using Multibanking.Services.Guarantees;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GuaranteeOrderController(IGuaranteeOrderService guaranteeOrderService, IGuaranteeService guaranteeService) : ControllerBase
{
    [HttpPost]
    public ActionResult Post([FromBody] Order order)
    {
        guaranteeOrderService.PostGuaranteeOrder(order);
        return Ok();
    }

    /// <summary>
    ///     Удалить заявку. orderId - брать из ResponseInit 
    /// </summary>
    /// <param name="declineOrderDto"></param>
    /// <param name="orderId"></param>
    /// <exception cref="Exception"></exception>
    [HttpDelete]
    public ActionResult Delete([FromBody] DeclineOrderDto declineOrderDto, [FromQuery] string orderId)
    {
        guaranteeOrderService.DeleteOrder(orderId, declineOrderDto);
        return Ok();
    }

    /// <summary>
    ///     Получить статус заявки. orderId - брать из ResponseInit
    /// </summary>
    /// <param name="orderId"></param>
    /// <returns></returns>
    [HttpGet("OrderId")]
    public ActionResult<OrderStatus> Get(string orderId) => guaranteeOrderService.GetOrder(orderId);

    [HttpGet]
    public List<ReadGuaranteeOrderDto> Get() => guaranteeService.GetOrdersForUser();
}
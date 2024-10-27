using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.UnidentifiedPayment;
using Multibanking.Services.UnidentifiedPayments;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UnidentifiedPaymentController(IUnidentifiedPaymentService unidentifiedPaymentService) : ControllerBase
{
    /// <summary>
    ///     Позволяет сделать неидентифицированный платеж
    /// </summary>
    /// <param name="createUnidentifiedPaymentDto"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<IActionResult> Post(CreateUnidentifiedPaymentDto createUnidentifiedPaymentDto)
    {
        await unidentifiedPaymentService.CreatePayment(createUnidentifiedPaymentDto);

        return Ok();
    }
}
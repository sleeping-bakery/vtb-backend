using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.PeriodPaymentConsent;
using Multibanking.Services.PeriodPayments;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PeriodPaymentController(IPeriodPaymentService periodPaymentService) : ControllerBase
{
    /// <summary>
    ///     Создать периодический платеж
    /// </summary>
    /// <param name="periodPaymentDto"></param>
    /// <returns></returns>
    [HttpPost]
    public async Task<ActionResult> Post([FromBody] CreatePeriodPaymentDto periodPaymentDto)
    {
        await periodPaymentService.CreatePeriodPayment(periodPaymentDto.PeriodPaymentConsentId, periodPaymentDto.Amount, periodPaymentDto.Currency);
        return Ok();
    }
}
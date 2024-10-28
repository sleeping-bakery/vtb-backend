using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.PeriodPaymentConsent;
using Multibanking.Services.PeriodPayments;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class PeriodPaymentConsentController(IPeriodPaymentConsentService periodPaymentConsentService) : ControllerBase
{
    /// <summary>
    /// Создать согласие на периодические платежи
    /// </summary>
    /// <param name="createPeriodPaymentConsentDto"></param>
    /// <returns></returns>
    [HttpPost]
    public ActionResult Post([FromBody] CreatePeriodPaymentConsentDto createPeriodPaymentConsentDto)
    {
        periodPaymentConsentService.CreatePeriodPaymentConsent(createPeriodPaymentConsentDto);
        return Ok();
    }

    /// <summary>
    /// Получить все согласия на периодические платежи, принадлежащие пользователю
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<List<ReadPeriodPaymentConsentDto>> Get()
    {
        return periodPaymentConsentService.GetPeriodPaymentConsents();
    }

    [HttpDelete]
    public ActionResult Delete([FromQuery] Guid periodPaymentConsentId)
    {
        periodPaymentConsentService.DeletePeriodPaymentConsent(periodPaymentConsentId);
        return Ok();
    }
    
}
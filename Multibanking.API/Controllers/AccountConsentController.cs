using Microsoft.AspNetCore.Mvc;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]

public class AccountConsentController(IAccountConsentsService accountConsentsService) : ControllerBase
{
    
    /// <summary>
    /// Отозвать согласие со стороны банкинга
    /// </summary>
    /// <returns></returns>
    [HttpDelete]
    public ActionResult Delete()
    {
        accountConsentsService.RevokeAccountAccessConsent();
        return Ok();
    }
}
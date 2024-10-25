using Microsoft.AspNetCore.Mvc;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountConsentController(IAccountConsentsService accountConsentsService) : ControllerBase
{
    [HttpDelete]
    public ActionResult Delete()
    {
        accountConsentsService.RevokeAccountAccessConsent();
        return Ok();
    }
}
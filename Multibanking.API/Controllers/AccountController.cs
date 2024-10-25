using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class AccountController(IAccountService accountService) : ControllerBase
{
    [HttpGet]
    public ActionResult<AccountResponse> Get()
    {
        return accountService.GetAccounts();
    }
    
    [HttpGet("{accountId}")]
    public ActionResult<AccountResponse> Get([Required] string accountId)
    {
        return accountService.GetAccountDetail(accountId);
    }
}
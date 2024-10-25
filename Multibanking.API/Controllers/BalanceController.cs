using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BalanceController(IBalanceService balanceService) : ControllerBase
{
    [HttpGet]
    public ActionResult<BalanceResponse> Get()
    {
        return balanceService.GetBalance();
    }
    
    [HttpGet("{accountId}")]
    public ActionResult<BalanceResponse> Get([Required] string accountId)
    {
        return balanceService.GetBalance(accountId);
    }
    
}
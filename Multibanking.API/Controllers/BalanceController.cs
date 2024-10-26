using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class BalanceController(IBalanceService balanceService) : ControllerBase
{
    /// <summary>
    /// Все балансы по всем счетам
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<BalanceResponse> Get()
    {
        return balanceService.GetBalance();
    }
    
    /// <summary>
    /// Баланс по счету (массив с одним балансом)
    /// </summary>
    /// <param name="accountId"></param>
    /// <returns></returns>
    [HttpGet("{accountId}")]
    public ActionResult<BalanceResponse> Get([Required] string accountId)
    {
        return balanceService.GetBalance(accountId);
    }
    
}
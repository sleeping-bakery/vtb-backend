using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

/// <summary>
/// Контроллер счетов
/// </summary>
/// <param name="accountService"></param>
[ApiController]
[Route("[controller]")]
public class AccountController(IAccountService accountService) : ControllerBase
{
    /// <summary>
    /// Получить все счета пользователя
    /// </summary>
    /// <returns> </returns>
    [HttpGet]
    public ActionResult<AccountResponse> Get()
    {
        return accountService.GetAccounts();
    }
    
    /// <summary>
    /// Получить счет пользователя. Вернется Массив счетов с одним счетом пользователя
    /// </summary>
    /// <param name="accountId">Id счета</param>
    /// <returns></returns>
    [HttpGet("{accountId}")]
    public ActionResult<AccountResponse> Get([Required] string accountId)
    {
        return accountService.GetAccountDetail(accountId);
    }
}
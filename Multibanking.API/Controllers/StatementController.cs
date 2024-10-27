using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StatementController(IStatementService statementService) : ControllerBase
{
    /// <summary>
    ///     Получить выписку по счету
    /// </summary>
    /// <param name="accountId"></param>
    /// <returns></returns>
    [HttpGet("{accountId}")]
    public ActionResult<StatementResponse> Get([Required] string accountId)
    {
        return statementService.GetAccountStatement(accountId);
    }

    /// <summary>
    ///     Получить выписки по всем счетам
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<StatementResponse> Get()
    {
        return statementService.GetAccountStatement();
    }
}
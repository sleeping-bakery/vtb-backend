using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class StatementController(IStatementService statementService) : ControllerBase
{
    [HttpGet("{accountId}")]
    public ActionResult<StatementResponse> Get([Required] string accountId)
    {
        return statementService.GetAccountStatement(accountId);
    }
    
    [HttpGet]
    public ActionResult<StatementResponse> Get()
    {
        return statementService.GetAccountStatement();
    }
    
}
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController(ITransactionService transactionService) : ControllerBase
{
    [HttpGet]
    public ActionResult<TransactionResponse> Get()
    {
        return transactionService.GetTransactions();
    }
    
    [HttpGet("{accountId}")]
    public ActionResult<TransactionResponse> Get([Required] string accountId)
    {
        return transactionService.GetTransactions(accountId);
    }
}
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Multibanking.AccountClient.Model;
using Multibanking.Services.Account;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class TransactionController(ITransactionService transactionService) : ControllerBase
{
    /// <summary>
    ///     Получить операции (транзакции) по всем счетам
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<TransactionResponse> Get()
    {
        return transactionService.GetTransactions();
    }

    /// <summary>
    ///     Получить операции (транзакции) по счету
    /// </summary>
    /// <param name="accountId"></param>
    /// <returns></returns>
    [HttpGet("{accountId}")]
    public ActionResult<TransactionResponse> Get([Required] string accountId)
    {
        return transactionService.GetTransactions(accountId);
    }
}
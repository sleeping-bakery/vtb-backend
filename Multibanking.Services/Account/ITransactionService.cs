using Multibanking.AccountClient.Model;

namespace Multibanking.Services.Account;

public interface ITransactionService
{
    TransactionResponse GetTransactions();

    TransactionResponse GetTransactions(string accountId);
}
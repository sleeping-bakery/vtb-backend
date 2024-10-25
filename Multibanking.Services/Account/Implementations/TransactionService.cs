using Multibanking.AccountClient.Model;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class TransactionService(ITransactionsClient transactionsClient) : ITransactionService
{
    public TransactionResponse GetTransactions()
    {
        return transactionsClient.GetTransactions();
    }
    
    public TransactionResponse GetTransactions(string accountId)
    {
        return transactionsClient.GetAccountsaccountIdTransactions(accountId);
    }
}
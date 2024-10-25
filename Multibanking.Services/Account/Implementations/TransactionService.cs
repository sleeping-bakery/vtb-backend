using Multibanking.AccountClient.Model;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class TransactionService(ITransactionsClient transactionsClient, IAccountConsentsService accountConsentsService) : ITransactionService
{
    public TransactionResponse GetTransactions()
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadTransactionsBasic);        
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadTransactionsCredits);

        return transactionsClient.GetTransactions();
    }
    
    public TransactionResponse GetTransactions(string accountId)
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadTransactionsBasic);        
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadTransactionsCredits);
        return transactionsClient.GetAccountsaccountIdTransactions(accountId);
    }
}
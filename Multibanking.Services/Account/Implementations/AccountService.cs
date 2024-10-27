using Multibanking.AccountClient.Model;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class AccountService(IAccountsClient accountsClient, IAccountConsentsService accountConsentsService) : IAccountService
{
    public AccountResponse GetAccounts()
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadAccountsBasic);
        return accountsClient.GetAccounts();
    }

    public AccountResponse GetAccountDetail(string accountId)
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadTransactionsDetail);
        return accountsClient.GetAccountsaccountId(accountId);
    }

    public bool IsAccountExist(string accountId)
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadAccountsBasic);
        var accountResponse = GetAccountDetail(accountId);
        return accountResponse.Data.Account.Count > 0;
    }
}
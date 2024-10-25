using Multibanking.AccountClient.Model;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class AccountService(IAccountsClient accountsClient) : IAccountService
{
    public AccountResponse GetAccounts()
    {
        var res =  accountsClient.GetAccounts();
        return res;
    }

    public AccountResponse GetAccountDetail(string accountId)
    {
        return accountsClient.GetAccountsaccountId(accountId);
    }
}


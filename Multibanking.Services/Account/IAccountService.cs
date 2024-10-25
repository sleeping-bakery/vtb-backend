using Multibanking.AccountClient.Model;

namespace Multibanking.Services.Account;

public interface IAccountService
{
    AccountResponse GetAccounts();

    AccountResponse GetAccountDetail(string accountId);
}
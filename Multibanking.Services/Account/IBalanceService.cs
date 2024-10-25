using Multibanking.AccountClient.Model;

namespace Multibanking.Services.Account;

public interface IBalanceService
{
    BalanceResponse GetBalance(string accountId);
    BalanceResponse GetBalance();
}
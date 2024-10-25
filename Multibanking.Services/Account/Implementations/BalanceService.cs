using Multibanking.AccountClient.Model;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class BalanceService(IBalancesClient balancesClient) : IBalanceService
{
    public BalanceResponse GetBalance(string accountId)
    {
        return balancesClient.GetAccountsaccountIdBalances(accountId);
    }

    public BalanceResponse GetBalance()
    {
        return balancesClient.GetBalances();
    }
}
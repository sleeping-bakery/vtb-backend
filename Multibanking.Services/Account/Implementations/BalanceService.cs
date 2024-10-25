using Multibanking.AccountClient.Model;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class BalanceService(IBalancesClient balancesClient, IAccountConsentsService accountConsentsService) : IBalanceService
{
    public BalanceResponse GetBalance(string accountId)
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadBalances);
        return balancesClient.GetAccountsaccountIdBalances(accountId);
    }

    public BalanceResponse GetBalance()
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadBalances);
        return balancesClient.GetBalances();
    }
}
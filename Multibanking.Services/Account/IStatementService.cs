using Multibanking.AccountClient.Model;

namespace Multibanking.Services.Account;

public interface IStatementService
{
    StatementResponse GetAccountStatement(string accountId);
    StatementResponse GetAccountStatement();
}
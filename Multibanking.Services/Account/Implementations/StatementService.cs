using Multibanking.AccountClient.Model;
using Multibanking.Contracts.Consent.Enums;
using Multibanking.Data.OpenAPIBankClients.AccountClient;

namespace Multibanking.Services.Account.Implementations;

public class StatementService(IStatementsClient statementsClient, IAccountConsentsService accountConsentsService) : IStatementService
{
    public StatementResponse GetAccountStatement()
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadAccountsBasic);
        return statementsClient.GetStatements();
    }

    public StatementResponse GetAccountStatement(string accountId)
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadAccountsBasic);

        var statementId = GetAccountStatementId(accountId);
        return statementsClient.GetAccountsaccountIdStatementsStatementId(accountId, statementId);
    }

    private string GetAccountStatementId(string accountId)
    {
        accountConsentsService.ValidateUserConsent(AccountConsent.ReadAccountsBasic);
        var statementInitResponse = statementsClient.GetStatementsaccountId(accountId, Guid.NewGuid().ToString(),
            new StatementInitRequest(new DataStatementInitRequestComplexType(new StatementInitReqComplexType(accountId)), new object()));
        return statementInitResponse.Data.Statement.StatementId;
    }
}
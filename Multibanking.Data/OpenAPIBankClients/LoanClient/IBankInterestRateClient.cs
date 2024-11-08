using Multibanking.Contracts.Loan;

namespace Multibanking.Data.OpenAPIBankClients.LoanClient;

public interface IBankInterestRateClient
{
    List<BankInterestRate> GetAvailableInterestRates();
}
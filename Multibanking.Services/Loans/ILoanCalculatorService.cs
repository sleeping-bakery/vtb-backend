using Multibanking.Contracts.Loan;

namespace Multibanking.Services.Loans;

public interface ILoanCalculatorService
{
    LoanCalculationResult CalculateLoan(decimal amount, decimal annualInterestRate, int termInYears);

    List<BankInterestRate> GetBankInterestRate();
}
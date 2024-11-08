using Multibanking.Contracts.Loan;
using Multibanking.Data.OpenAPIBankClients.LoanClient;

namespace Multibanking.Services.Loans;

public class LoanCalculatorService(IBankInterestRateClient bankInterestRateClient) : ILoanCalculatorService
{
    public LoanCalculationResult CalculateLoan(decimal amount, decimal annualInterestRate, int termInYears)
    {
        var monthlyInterestRate = annualInterestRate / 12 / 100;
        var numberOfPayments = termInYears * 12;

        var monthlyPayment = amount * monthlyInterestRate / (decimal)(1 - Math.Pow((double)(1 + monthlyInterestRate), -numberOfPayments));
        var totalPayment = monthlyPayment * numberOfPayments;
        var totalInterest = totalPayment - amount;

        return new LoanCalculationResult
        {
            MonthlyPayment = monthlyPayment,
            TotalPayment = totalPayment,
            TotalInterest = totalInterest
        };
    }

    public List<BankInterestRate> GetBankInterestRate()
    {
        return bankInterestRateClient.GetAvailableInterestRates();
    }
}
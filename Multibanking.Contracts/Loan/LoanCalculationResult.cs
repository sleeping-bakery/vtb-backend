namespace Multibanking.Contracts.Loan;

public class LoanCalculationResult
{
    public decimal MonthlyPayment { get; set; }
    public decimal TotalPayment { get; set; }
    public decimal TotalInterest { get; set; }
}
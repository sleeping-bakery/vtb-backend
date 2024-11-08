namespace Multibanking.Contracts.Loan;

public class LoanCalculationRequest
{
    public decimal LoanAmount { get; set; }
    public int LoanTermInYears { get; set; }
    public decimal SelectedInterestRate { get; set; }
}
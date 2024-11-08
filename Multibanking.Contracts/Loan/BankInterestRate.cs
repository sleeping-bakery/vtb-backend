namespace Multibanking.Contracts.Loan;

public class BankInterestRate
{
    public required string BankName { get; set; }
    public decimal InterestRate { get; set; }
    public required string ApplicationUrl { get; set; }
}
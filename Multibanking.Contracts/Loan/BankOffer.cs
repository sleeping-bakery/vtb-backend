namespace Multibanking.Contracts.Loan;

public class BankOffer
{
    public Guid Id { get; set; }
    public required string BankName { get; set; }
    public uint QuantityMonths { get; set; }
}
namespace Multibanking.Contracts.Loan;

public class InstallmentPlan
{
    public InstallmentPlan() {}

    public InstallmentPlan(uint quantityMonths, uint remainingMonths, Guid bankOfferId, Guid transactionId)
    {
        Id = Guid.NewGuid();
        QuantityMonths = quantityMonths;
        RemainingMonths = remainingMonths;
        BankOfferId = bankOfferId;
        TransactionId = transactionId;
        
    }
    public Guid Id { get; set; }

    public uint QuantityMonths { get; set; }

    public uint RemainingMonths { get; set; }
    
    public Guid BankOfferId { get; set; }
    
    public Guid TransactionId { get; set; }
}
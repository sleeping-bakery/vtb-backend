namespace Multibanking.Contracts.UniversalPayment;

public class CreateUniversalPaymentDto
{
    public required string ServiceId { get; set; } 
    public required decimal Amount { get; set; }
    public required string Currency { get; set; }
    public required Guid CardId { get; set; }
}
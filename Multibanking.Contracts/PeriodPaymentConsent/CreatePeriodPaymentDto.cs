namespace Multibanking.Contracts.PeriodPaymentConsent;

public class CreatePeriodPaymentDto
{
    public Guid PeriodPaymentConsentId { get; set; }
    public required string Amount { get; set; }
    public required string Currency { get; set; }
}
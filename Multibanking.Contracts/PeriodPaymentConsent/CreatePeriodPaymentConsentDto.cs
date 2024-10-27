using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Contracts.PeriodPaymentConsent;

public class CreatePeriodPaymentConsentDto
{
    public required string Amount { get; set; }
    public required string Currency { get; set; }
    public required List<PeriodicLimitsInner> PeriodAmount { get; set; }
    public required string CreditorName { get; set; }
    public required Guid CardGuid { get; set; }
    public required PartyIdentificationIdentificationInner CreditorIdentification { get; set; }
}
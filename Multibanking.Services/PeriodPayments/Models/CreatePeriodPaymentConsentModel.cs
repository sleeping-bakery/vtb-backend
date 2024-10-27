using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Services.PeriodPayments.Models;

public class CreatePeriodPaymentConsentModel
{
    public required string Amount { get; set; }
    public required string Currency { get; set; }
    public required List<PeriodicLimitsInner> PeriodAmount { get; set; }
    public required string DebtorPan { get; set; }
    public required PartyIdentificationIdentificationInner CreditorIdentification { get; set; }
    public required string CreditorName { get; set; }
}
namespace Multibanking.Services.PeriodPayments;

public interface IPeriodPaymentService
{
    Task CreatePeriodPayment(Guid periodPaymentConsentId, string amount, string currency);
}
using Multibanking.Contracts.PeriodPaymentConsent;

namespace Multibanking.Services.PeriodPayments;

public interface IPeriodPaymentConsentService
{
    Task CreatePeriodPaymentConsent(CreatePeriodPaymentConsentDto periodPaymentConsentDto);
    List<ReadPeriodPaymentConsentDto> GetPeriodPaymentConsents();
    void DeletePeriodPaymentConsent(Guid periodPaymentConsentId);
    ReadPeriodPaymentConsentDto GetPeriodPaymentConsent(Guid periodPaymentConsentId);
}
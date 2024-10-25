using Multibanking.Contracts.Consent.Enums;

namespace Multibanking.Services.Account;

public interface IAccountConsentsService
{
    public void CreateAccountAccessConsents(ICollection<AccountConsent> consentStatusTypes);

    public void RevokeAccountAccessConsent();
}
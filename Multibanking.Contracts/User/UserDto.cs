using Multibanking.Contracts.Consent;
using Multibanking.Contracts.Consent.Enums;

namespace Multibanking.Contracts.User;

public class UserDto
{
    public required Guid Id { get; init; }

    public required List<AccountConsent> AccountConsents { get; init; }

    public required string Login { get; init; }

    public UserAccountConsentDto? UserAccountConsent { get; init; }
}
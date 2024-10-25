using Multibanking.Contracts.Consent.Enums;

namespace Multibanking.Contracts.User;

public class UserUpdateDto
{
    public required Guid Id { get; init; }
    public required List<AccountConsent> AccountConsents { get; init; }
    public required string Login { get; init; }
}
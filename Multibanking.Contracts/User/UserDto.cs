using Multibanking.Contracts.Consent.Enums;

namespace Multibanking.Contracts.User;

public record UserDto(Guid Id, List<AccountConsent> AccountConsents, string Login);

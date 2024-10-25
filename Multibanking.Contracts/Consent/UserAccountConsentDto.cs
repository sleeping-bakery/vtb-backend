using Multibanking.Contracts.User;

namespace Multibanking.Contracts.Consent;

public class UserAccountConsentDto
{
    public Guid Id { get; init; }
    public Guid UserId { get; init; }
    public required UserDto User { get; init; }
    public required string AccountConsentId { get; init; }
    
}
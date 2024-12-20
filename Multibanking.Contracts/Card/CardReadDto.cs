namespace Multibanking.Contracts.Card;

public class CardReadDto
{
    public Guid Id { get; set; }

    public required string AccountId { get; set; }

    public required Guid UserId { get; set; }

    public required string Pan { get; set; }

    public required CardStatus Status { get; set; }

    public required string PublicId { get; set; }
}
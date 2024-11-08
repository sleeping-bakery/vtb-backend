namespace Multibanking.Contracts.BonusPoint;

public class PostBonusPointDto
{
    public required string AccountId { get; set; }
    public required string CatalogId { get; set; }
    public decimal TransactionId { get; set; }
    public decimal Amount { get; set; }
}
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Contracts.Guarantee;

public class ReadGuaranteeOrderDto
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public required OrderResponse ResponseInit { get; set; }
}
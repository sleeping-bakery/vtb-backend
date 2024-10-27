using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Contracts.PeriodPaymentConsent;

public class ReadPeriodPaymentConsentDto
{
    public required Guid CardId { get; set; }   
    
    public required VRPConsentResponse ConsentBanking { get; set; }
    
    public required Guid UserId { get; set; }
    
    public required Guid Id { get; set; }
}
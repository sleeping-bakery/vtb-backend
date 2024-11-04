using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Services.Guarantees;

public interface IGuaranteeCommissionService
{
    CommissionResponseDto AdvancedCalculationCommission(CommissionRequest commissionRequest);
}
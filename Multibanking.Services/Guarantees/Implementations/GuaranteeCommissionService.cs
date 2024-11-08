using Multibanking.Data.OpenAPIBankClients.GuaranteeClient;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Services.Guarantees.Implementations;

public class GuaranteeCommissionService(IGuaranteeCommissionClient guaranteeCommissionClient) : IGuaranteeCommissionService
{
    public CommissionResponseDto AdvancedCalculationCommission(CommissionRequest commissionRequest)
    {
        var precalculateResult = guaranteeCommissionClient.PrecalculateCommission(Guid.NewGuid().ToString(), commissionRequest);
        if (precalculateResult == null)
            throw new Exception("Со стороны банкинга не пришло ответа");

        return precalculateResult;
    }
}
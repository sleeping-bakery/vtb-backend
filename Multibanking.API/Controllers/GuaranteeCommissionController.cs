using Microsoft.AspNetCore.Mvc;
using Multibanking.GuaranteeClient.Model;
using Multibanking.Services.Guarantees;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class GuaranteeCommissionController(IGuaranteeCommissionService guaranteeCommissionService) : ControllerBase
{
    [HttpPost]
    public ActionResult<CommissionResponseDto> Post([FromBody] CommissionRequest commissionRequest)
    {
        return guaranteeCommissionService.AdvancedCalculationCommission(commissionRequest);
    }
}
using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.UniversalPayment;
using Multibanking.Services.UniversalPayments;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UniversalPaymentController(IUniversalPaymentService paymentService): ControllerBase
{
    [HttpPost]
    public void Post(CreateUniversalPaymentDto createUniversalPaymentDto)
    {
        paymentService.CreatePaymentRequest(createUniversalPaymentDto);
    }
}
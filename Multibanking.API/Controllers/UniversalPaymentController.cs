using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.UniversalPayment;
using Multibanking.Services.UniversalPayments;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class UniversalPaymentController(IUniversalPaymentService paymentService): ControllerBase
{
    /// <summary>
    /// Создать универсальный платеж по услуге
    /// </summary>
    /// <param name="createUniversalPaymentDto"></param>
    [HttpPost]
    public void Post(CreateUniversalPaymentDto createUniversalPaymentDto)
    {
        paymentService.CreatePaymentRequest(createUniversalPaymentDto);
    }
}
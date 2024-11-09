using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.Loan;
using Multibanking.Services.Loans;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class InstallmentPlanController(IInstallmentPlanService installmentPlanService) : ControllerBase
{
    /// <summary>
    /// Получить предложения по рассрочке от банка
    /// </summary>
    /// <param name="loanSize"></param>
    /// <param name="currency"></param>
    /// <returns></returns>
    [HttpGet("BankOffer")]
    public ActionResult<List<BankOffer>> Get([FromQuery] decimal loanSize, [FromQuery] string currency) => installmentPlanService.GetBankOffers(loanSize, currency);

    /// <summary>
    /// Сделать платеж по рассрочке
    /// </summary>
    /// <param name="installmentPlanId"></param>
    [HttpPost("Payment")]
    public void Post([FromQuery] Guid installmentPlanId) => installmentPlanService.CreateInstallmentPayment(installmentPlanId);

    /// <summary>
    /// Создать рассрочку
    /// </summary>
    /// <param name="bankOfferId"></param>
    /// <param name="transactionId"></param>
    [HttpPost]
    public void Post([FromQuery] Guid bankOfferId, [FromQuery] Guid transactionId) => installmentPlanService.CreateInstallmentPlan(bankOfferId, transactionId);

    /// <summary>
    /// Получить все активные рассрочки
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    public ActionResult<List<InstallmentPlan>> Get() => installmentPlanService.GetInstallmentPlans();
}
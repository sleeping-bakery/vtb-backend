using Microsoft.AspNetCore.Mvc;
using Multibanking.Contracts.Loan;
using Multibanking.Services.Loans;

namespace Multibanking.API.Controllers;

[ApiController]
[Route("[controller]")]
public class LoanCalculatorController(ILoanCalculatorService loanCalculatorService) : ControllerBase
{
    [HttpPost]
    public ActionResult<LoanCalculationResult> Post([FromBody] LoanCalculationRequest request)
    {
        var result = loanCalculatorService.CalculateLoan(request.LoanAmount, request.SelectedInterestRate, request.LoanTermInYears);
        return Ok(result);
    }

    [HttpGet("BankInterestRate")]
    public ActionResult<List<BankInterestRate>> Get()
    {
        return loanCalculatorService.GetBankInterestRate();
    }
}
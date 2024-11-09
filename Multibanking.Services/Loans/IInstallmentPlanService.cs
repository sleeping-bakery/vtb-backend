using Multibanking.Contracts.Loan;

namespace Multibanking.Services.Loans;

public interface IInstallmentPlanService
{
    List<BankOffer> GetBankOffers(decimal loanSize, string currency);

    void CreateInstallmentPlan(Guid bankOfferId, Guid transactionId);

    void CreateInstallmentPayment(Guid installmentPlanId);

    List<InstallmentPlan> GetInstallmentPlans();
}
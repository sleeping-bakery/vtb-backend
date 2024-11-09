using Multibanking.Contracts.Loan;

namespace Multibanking.Data.OpenAPIBankClients.LoanClient;

public interface IInstallmentPlanClient
{
    List<BankOffer> GetBankOffers(decimal loanSize, string currency);
    BankOffer GetBankOffer(Guid bankOfferId);
    void CreateInstallmentPlan(InstallmentPlan installmentPlan);
    void CreateInstallmentPayment(Guid installmentPlanId);
    List<InstallmentPlan> GetInstallmentPlans();
}
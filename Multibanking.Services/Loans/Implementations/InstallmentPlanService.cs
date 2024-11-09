using Multibanking.Contracts.Loan;
using Multibanking.Data.OpenAPIBankClients.LoanClient;

namespace Multibanking.Services.Loans.Implementations;

public class InstallmentPlanService(IInstallmentPlanClient installmentPlanClient) : IInstallmentPlanService
{
    public List<BankOffer> GetBankOffers(decimal loanSize, string currency)
    {
        return installmentPlanClient.GetBankOffers(loanSize, currency);
    }
    private BankOffer GetBankOffer(Guid bankOfferId)
    {
        return installmentPlanClient.GetBankOffer(bankOfferId);
    }

    public void CreateInstallmentPlan(Guid bankOfferId, Guid transactionId)
    {
        var bankOffer = GetBankOffer(bankOfferId);
        installmentPlanClient.CreateInstallmentPlan(new InstallmentPlan(bankOffer.QuantityMonths, bankOffer.QuantityMonths, bankOfferId, transactionId));
    }

    public void CreateInstallmentPayment(Guid installmentPlanId)
    {
        installmentPlanClient.CreateInstallmentPayment(installmentPlanId);
    }

    public List<InstallmentPlan> GetInstallmentPlans()
    {
        return installmentPlanClient.GetInstallmentPlans();
    }
}
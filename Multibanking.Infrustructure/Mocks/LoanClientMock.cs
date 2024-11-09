using Moq;
using Multibanking.Contracts.Loan;
using Multibanking.Data.OpenAPIBankClients.LoanClient;

namespace Multibanking.Infrustructure.Mocks;

public class LoanClientMock
{
    

    private static readonly List<InstallmentPlan> InstallmentPlans = [];

    public static Mock<IBankInterestRateClient> MockedBankInterestRateClient()
    {
        var mock = new Mock<IBankInterestRateClient>();

        mock.Setup(bankInterestRateClient => bankInterestRateClient.GetAvailableInterestRates())
            .Returns(() =>
            [
                new BankInterestRate { BankName = "Банк Освоение", InterestRate = 20, ApplicationUrl = "https://banka.com/apply" },
                new BankInterestRate { BankName = "ВТБ", InterestRate = 19, ApplicationUrl = "https://www.vtb.ru/personal/kredit/" },
                new BankInterestRate { BankName = "Кредит банк", InterestRate = 25, ApplicationUrl = "https://bankc.com/apply" }
            ]);

        return mock;
    }

    public static Mock<IInstallmentPlanClient> MockedInstallmentPlanClient()
    {
        var mock = new Mock<IInstallmentPlanClient>();

        mock.Setup(installmentPlanClient => installmentPlanClient.GetBankOffers(It.IsAny<decimal>(), It.IsAny<string>()))
            .Returns(() => Generator.BankOffers);

        mock.Setup(installmentPlanClient => installmentPlanClient.GetBankOffer(It.IsAny<Guid>()))
            .Returns((Guid id) => Generator.BankOffers.Single(bankOffer => bankOffer.Id == id));

        mock.Setup(installmentPlanClient => installmentPlanClient.CreateInstallmentPlan(It.IsAny<InstallmentPlan>()))
            .Callback((InstallmentPlan installmentPlan) => InstallmentPlans.Add(installmentPlan));

        mock.Setup(installmentPlanClient => installmentPlanClient.GetInstallmentPlans())
            .Returns(() => InstallmentPlans);

        mock.Setup(installmentPlanClient => installmentPlanClient.CreateInstallmentPayment(It.IsAny<Guid>()))
            .Callback((Guid installmentPlanId) =>
            {
                var installmentPlan = InstallmentPlans.Single(installmentPlan => installmentPlan.Id == installmentPlanId);

                installmentPlan.RemainingMonths -= 1;
                if (installmentPlan.RemainingMonths == 0)
                    InstallmentPlans.Remove(installmentPlan);
            });

        return mock;
    }
}
using Moq;
using Multibanking.Contracts.Loan;
using Multibanking.Data.OpenAPIBankClients.LoanClient;

namespace Multibanking.Infrustructure.Mocks;

public class LoanClientMock
{
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
}
using Moq;
using Multibanking.BonusPointClient.Model;
using Multibanking.Data.OpenAPIBankClients.BonusPointClient;

namespace Multibanking.Infrustructure.Mocks;

public static class BonusPointClientMock
{
    public static Mock<IBonusPointClient> MockBonusPointClient()
    {
        var mock = new Mock<IBonusPointClient>();
        mock.Setup(bonusPointClient => bonusPointClient.GetRewardsBalance(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
            .Returns(() => new RewardBalanceDataV2(new RewardBalanceV2(true, new RewardSummaryV2(164, "CASH", "RUB"), new ProgramDetailV2(Guid.NewGuid().ToString(), "Очень важная программа", [new CatalogV2(Guid.NewGuid().ToString(), "ACH", 1, "Акции и скидки", 5, 1000)]))));
        return mock;
    }
}
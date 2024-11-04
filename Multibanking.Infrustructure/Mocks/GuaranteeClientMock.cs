using Moq;
using Multibanking.Data.OpenAPIBankClients.GuaranteeClient;
using Multibanking.GuaranteeClient.Model;

namespace Multibanking.Infrustructure.Mocks;

public static class GuaranteeClientMock
{
    public static Mock<IGuaranteeCommissionClient> MockedGuaranteeCommissionClient()
    {
        var mock = new Mock<IGuaranteeCommissionClient>();

        mock.Setup(guaranteeCommissionClient => guaranteeCommissionClient.PrecalculateCommission(It.IsAny<string>(), It.IsAny<CommissionRequest>(), It.IsAny<int>()))
            .Returns(() => new CommissionResponseDto(Generator.GenerateRandomCommission()));

        return mock;
    }

    public static Mock<IGuaranteeOrderClient> MockedGuaranteeOrderClient()
    {
        var mock = new Mock<IGuaranteeOrderClient>();

        mock.Setup(guaranteeOrderClient => guaranteeOrderClient.CreateOrder(It.IsAny<string>(), It.IsAny<Order>(), It.IsAny<int>()))
            .Returns(() =>
            {
                var orderGuid = Guid.NewGuid().ToString();
                return new OrderResponse(
                    orderGuid,
                    $"Заявка {DateTime.Now:yyyyMMddHHmmss}-{orderGuid[..8].ToUpper()}"
                );
            });

        mock.Setup(guaranteeOrderClient => guaranteeOrderClient.GetOrder(It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
            .Returns(Generator.GenerateRandomOrderStatus);


        return mock;
    }

    public static Mock<IGuaranteePaglClient> MockedGuaranteePaglClient()
    {
        var mock = new Mock<IGuaranteePaglClient>();

        return mock;
    }
}
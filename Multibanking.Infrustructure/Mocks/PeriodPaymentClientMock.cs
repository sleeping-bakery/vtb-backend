using Moq;
using Multibanking.Data.OpenAPIBankClients.PeriodPaymentClient;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Infrustructure.Mocks;

public static class PeriodPaymentClientMock
{
    public static Mock<IPeriodPaymentClient> MockPeriodPaymentClient()
    {
        var mock = new Mock<IPeriodPaymentClient>();

        return mock;
    }

    public static Mock<IPeriodPaymentConsentClient> MockPeriodPaymentConsentClient()
    {
        var mock = new Mock<IPeriodPaymentConsentClient>();
        mock.Setup(periodPaymentClient =>
                periodPaymentClient.CreateVRPConsent(It.IsAny<VRPConsentRequest>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>()))
            .Returns((VRPConsentRequest vrpConsentRequest, string _, string _, string _, string _, string _, string _, int _) =>
                new VRPConsentResponse(
                    new VRPConsentResponseData(
                        Guid.NewGuid().ToString(),
                        VRPConsentResponseData.ReadRefundAccountEnum.Yes,
                        DateTime.Now,
                        ConsentStatus.Authorised,
                        DateTime.Now,
                        vrpConsentRequest.Data.ControlParameters,
                        new VRPConsentResponseDataInitiation(
                            vrpConsentRequest.Data.Initiation.DebtorAccount,
                            vrpConsentRequest.Data.Initiation.CreditorAgent,
                            vrpConsentRequest.Data.Initiation.CreditorAccount,
                            vrpConsentRequest.Data.Initiation.CreditorAgentAccount,
                            vrpConsentRequest.Data.Initiation.Creditor,
                            vrpConsentRequest.Data.Initiation.RemittanceInformation
                        ),
                        new VRPConsentResponseDataDebtorAccount(vrpConsentRequest.Data.Initiation.DebtorAccount.Name, vrpConsentRequest.Data.Initiation.DebtorAccount.SchemeName, vrpConsentRequest.Data.Initiation.DebtorAccount.Identification)
                    ),
                    new VRPConsentRequestRisk(),
                    new VRPConsentResponseLinks(""),
                    new VRPConsentResponseMeta()
                )
            );
        return mock;
    }
}
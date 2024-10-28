using Moq;
using Multibanking.Data.OpenAPIBankClients.PeriodPaymentClient;
using Multibanking.PeriodPaymentClient.Model;

namespace Multibanking.Infrustructure.Mocks;

public static class PeriodPaymentClientMock
{
    public static Mock<IPeriodPaymentClient> MockPeriodPaymentClient()
    {
        var mock = new Mock<IPeriodPaymentClient>();

        mock.Setup(periodPaymentClient => periodPaymentClient.CreateVRPConsentConsentIdFundsConfirmations(It.IsAny<string>(), It.IsAny<VRPFundsConfirmationRequest>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(() => new VRPFundsConfirmationResponse(new VRPFundsConfirmationResponseData(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), DateTime.Now,
                Guid.NewGuid().ToString(),
                new VRPFundsConfirmationResponseDataFundsAvailableResult(DateTime.Now, VRPFundsConfirmationResponseDataFundsAvailableResult.FundsAvailableEnum.Available),
                new VRPFundsConfirmationResponseDataInstructedAmount("123", "RUB"))));

        mock.Setup(periodPaymentClient => periodPaymentClient.CreateVRP(It.IsAny<VRPRequest>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(),
                It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(() => new VRPResponse(
                new VRPResponseData(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), DateTime.Now, TransactionStatusCode.AcceptedSettlementCompleted, DateTime.Now,
                    DateTime.Now, DateTime.Now, [], new VRPResponseDataRefund(Guid.NewGuid().ToString(), AccountIdentificationCode.PAN, Guid.NewGuid().ToString()),
                    new VRPRequestDataInstruction(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), instructedAmount: new VRPInstructionInstructedAmount("123", "RUB")),
                    new VRPConsentResponseDataInitiation(), new VRPInstructionDebtorAccount(Guid.NewGuid().ToString(), AccountIdentificationCode.PAN, Guid.NewGuid().ToString())),
                new VRPConsentRequestRisk(), new VRPConsentResponseLinks(""), new VRPConsentResponseMeta()));

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
                        new VRPConsentResponseDataDebtorAccount(vrpConsentRequest.Data.Initiation.DebtorAccount.Name, vrpConsentRequest.Data.Initiation.DebtorAccount.SchemeName,
                            vrpConsentRequest.Data.Initiation.DebtorAccount.Identification)
                    ),
                    new VRPConsentRequestRisk(),
                    new VRPConsentResponseLinks(""),
                    new VRPConsentResponseMeta()
                )
            );
        return mock;
    }
}
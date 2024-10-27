using Moq;
using Multibanking.Data.OpenAPIBankClients.UnidentifiedPaymentClient;
using Multibanking.UnidentifiedPaymentClient.Model;

namespace Multibanking.Infrustructure.Mocks;

public static class UnidentifiedPaymentClientMock
{
    public static Mock<IUnidentifiedPaymentClient> MockUnidentifiedPaymentClient()
    {
        var mock = new Mock<IUnidentifiedPaymentClient>();
        mock.Setup(
                unidentifiedPaymentClient => unidentifiedPaymentClient.CreatePaymentConsent(It.IsAny<string>(), It.IsAny<ConsentRequestComplexType>(), It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(() => new ConsentResponseComplexType(
                new ConsentResponseComplexTypeData(
                    Guid.NewGuid().ToString(), DateTime.Now, ConsentStatusStaticType.Consumed, DateTime.Now, DateTime.Now, DateTime.Now, DateTime.Now, [],
                    new DataConsentRequestComplexTypeInitiation(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ExternalLocalInstrument1Code.TmpVal1,
                        new InitiationComplexTypeInstructedAmount("", ""),
                        creditorAccount: new InitiationComplexTypeCreditorAccount(PaymentAccountIdentificationDynamicType.PAN, "79995554433")
                    ),
                    new DataConsentRequestComplexTypeAuthorisation(AuthorisationStaticType.Any, DateTime.Now),
                    new DataConsentRequestComplexTypeSCASupportData(SCAExemptionTypeStaticType.EcommerceGoods, AppliedAuthenticationApproachStaticType.CA, "")
                ),
                new ConsentRequestComplexTypeRisk(), new LinksType(""), new MetaType())
            );

        mock.Setup(
                unidentifiedPaymentClient => unidentifiedPaymentClient.CreatePayment(It.IsAny<string>(), It.IsAny<PaymentRequestComplexType>(), It.IsAny<string>(),
                    It.IsAny<string>(),
                    It.IsAny<string>(), It.IsAny<string>(), It.IsAny<int>())
            )
            .Returns(() => new PaymentResponseComplexType(
                new PaymentResponseComplexTypeData(
                    Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), DateTime.Now, TransactionStatusStaticType.AcceptedSettlementCompleted, DateTime.Now, DateTime.Now,
                    DateTime.Now, [],
                    new DataConsentRequestComplexTypeInitiation(Guid.NewGuid().ToString(), Guid.NewGuid().ToString(), ExternalLocalInstrument1Code.TmpVal1,
                        new InitiationComplexTypeInstructedAmount("", ""),
                        creditorAccount: new InitiationComplexTypeCreditorAccount(PaymentAccountIdentificationDynamicType.PAN, "79995554433")
                    ),
                    new DataPaymentResponseComplexTypeMultiAuthorisation(MultiAuthorisationStatusStaticType.Authorised, 1, 1, DateTime.Now, DateTime.Now)
                ),
                new ConsentRequestComplexTypeRisk(), new LinksType(""), new MetaType()));
        return mock;
    }
}
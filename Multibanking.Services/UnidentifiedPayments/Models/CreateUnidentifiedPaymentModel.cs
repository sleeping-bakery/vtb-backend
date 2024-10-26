using Multibanking.UnidentifiedPaymentClient.Model;

namespace Multibanking.Services.UnidentifiedPayments.Models;

public class CreateUnidentifiedPaymentModel
{
    public required string Amount { get; set; }
    public required string Currency { get; set; }
    public required string DebtorPan { get; set; }
    public required PaymentAccountIdentificationDynamicType CreditPaymentAccountIdentificationDynamicType { get; set; }
    public required string CreditAccountIdentification { get; set; }
}
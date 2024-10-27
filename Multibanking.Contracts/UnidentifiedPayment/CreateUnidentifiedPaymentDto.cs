using Multibanking.UnidentifiedPaymentClient.Model;

namespace Multibanking.Contracts.UnidentifiedPayment;

public class CreateUnidentifiedPaymentDto
{
    /// <summary>
    ///     Сумма для перевода
    /// </summary>
    public required string Amount { get; set; }

    /// <summary>
    ///     Валюта (ISO 4217)
    /// </summary>
    public required string Currency { get; set; }

    /// <summary>
    ///     Идентификатор карты
    /// </summary>
    public Guid CardGuid { get; set; }

    /// <summary>
    ///     Тип счета, на который будет совершен перевод
    /// </summary>
    public PaymentAccountIdentificationDynamicType CreditPaymentAccountIdentificationDynamicType { get; set; }

    /// <summary>
    ///     Счет (номер телефона, номер карты, номер счета)
    /// </summary>
    public required string CreditAccountIdentification { get; set; }
}
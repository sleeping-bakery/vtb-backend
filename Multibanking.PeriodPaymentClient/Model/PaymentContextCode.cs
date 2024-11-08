/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Контекст проведения платежа
/// </summary>
/// <value>Контекст проведения платежа</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum PaymentContextCode
{
    /// <summary>
    ///     Enum BillPayment for value: BillPayment
    /// </summary>
    [EnumMember(Value = "BillPayment")] BillPayment = 1,

    /// <summary>
    ///     Enum EcommerceGoods for value: EcommerceGoods
    /// </summary>
    [EnumMember(Value = "EcommerceGoods")] EcommerceGoods = 2,

    /// <summary>
    ///     Enum EcommerceServices for value: EcommerceServices
    /// </summary>
    [EnumMember(Value = "EcommerceServices")]
    EcommerceServices = 3,

    /// <summary>
    ///     Enum Other for value: Other
    /// </summary>
    [EnumMember(Value = "Other")] Other = 4
}
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
///     Код причины статуса платежа
/// </summary>
/// <value>Код причины статуса платежа</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum StatusReasonCode
{
    /// <summary>
    ///     Enum Cancelled for value: Cancelled
    /// </summary>
    [EnumMember(Value = "Cancelled")] Cancelled = 1,

    /// <summary>
    ///     Enum PendingFailingSettlement for value: PendingFailingSettlement
    /// </summary>
    [EnumMember(Value = "PendingFailingSettlement")]
    PendingFailingSettlement = 2,

    /// <summary>
    ///     Enum PendingSettlement for value: PendingSettlement
    /// </summary>
    [EnumMember(Value = "PendingSettlement")]
    PendingSettlement = 3,

    /// <summary>
    ///     Enum Proprietary for value: Proprietary
    /// </summary>
    [EnumMember(Value = "Proprietary")] Proprietary = 4,

    /// <summary>
    ///     Enum ProprietaryRejection for value: ProprietaryRejection
    /// </summary>
    [EnumMember(Value = "ProprietaryRejection")]
    ProprietaryRejection = 5,

    /// <summary>
    ///     Enum Suspended for value: Suspended
    /// </summary>
    [EnumMember(Value = "Suspended")] Suspended = 6,

    /// <summary>
    ///     Enum Unmatched for value: Unmatched
    /// </summary>
    [EnumMember(Value = "Unmatched")] Unmatched = 7
}
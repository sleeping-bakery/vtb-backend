/*
 * Инициирование перевода денежных средств клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по переводам.
 *
 * The version of the OpenAPI document: 1.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Multibanking.UnidentifiedPaymentClient.Model;

/// <summary>
///     Тип комиссии за проведение платежа.
/// </summary>
/// <value>Тип комиссии за проведение платежа.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum ExternalChargeType1Code
{
    /// <summary>
    ///     Enum BRKF for value: BRKF
    /// </summary>
    [EnumMember(Value = "BRKF")] BRKF = 1,

    /// <summary>
    ///     Enum BTCH for value: BTCH
    /// </summary>
    [EnumMember(Value = "BTCH")] BTCH = 2,

    /// <summary>
    ///     Enum COMM for value: COMM
    /// </summary>
    [EnumMember(Value = "COMM")] COMM = 3,

    /// <summary>
    ///     Enum SUMM for value: SUMM
    /// </summary>
    [EnumMember(Value = "SUMM")] SUMM = 4
}
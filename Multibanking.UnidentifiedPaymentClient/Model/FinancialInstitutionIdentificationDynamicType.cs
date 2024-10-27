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
///     Идентификатор финансового учреждения
/// </summary>
/// <value>Идентификатор финансового учреждения</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum FinancialInstitutionIdentificationDynamicType
{
    /// <summary>
    ///     Enum BICFI for value: RU.CBR.BICFI
    /// </summary>
    [EnumMember(Value = "RU.CBR.BICFI")] BICFI = 1,

    /// <summary>
    ///     Enum BIK for value: RU.CBR.BIK
    /// </summary>
    [EnumMember(Value = "RU.CBR.BIK")] BIK = 2
}
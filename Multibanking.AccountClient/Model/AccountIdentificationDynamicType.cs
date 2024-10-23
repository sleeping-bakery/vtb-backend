/*
 * Получение информации о счете клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по счетам и транзакциям.
 *
 * The version of the OpenAPI document: 1.2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Multibanking.AccountClient.Model;

/// <summary>
///     Идентификатор счета
/// </summary>
/// <value>Идентификатор счета</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum AccountIdentificationDynamicType
{
    /// <summary>
    ///     Enum PAN for value: RU.CBR.PAN
    /// </summary>
    [EnumMember(Value = "RU.CBR.PAN")] PAN = 1,

    /// <summary>
    ///     Enum CellphoneNumber for value: RU.CBR.CellphoneNumber
    /// </summary>
    [EnumMember(Value = "RU.CBR.CellphoneNumber")]
    CellphoneNumber = 2,

    /// <summary>
    ///     Enum BBAN for value: RU.CBR.BBAN
    /// </summary>
    [EnumMember(Value = "RU.CBR.BBAN")] BBAN = 3
}
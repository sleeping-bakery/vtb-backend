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
///     НЕ ОПРЕДЕЛЕН
/// </summary>
/// <value>НЕ ОПРЕДЕЛЕН</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum BaseOneRate
{
    /// <summary>
    ///     Enum TmpVal2 for value: tmpVal2
    /// </summary>
    [EnumMember(Value = "tmpVal2")] TmpVal2 = 1
}
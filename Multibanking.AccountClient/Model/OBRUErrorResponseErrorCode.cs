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
///     Низкоуровневое текстовое описание ошибки
/// </summary>
/// <value>Низкоуровневое текстовое описание ошибки</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum OBRUErrorResponseErrorCode
{
    /// <summary>
    ///     Enum RUSBRFFieldMissing for value: RU.SBRF.Field.Missing
    /// </summary>
    [EnumMember(Value = "RU.SBRF.Field.Missing")]
    RUSBRFFieldMissing = 1
}
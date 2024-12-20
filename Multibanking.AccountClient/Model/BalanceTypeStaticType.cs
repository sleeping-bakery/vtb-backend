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
///     Тип баланса
/// </summary>
/// <value>Тип баланса</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum BalanceTypeStaticType
{
    /// <summary>
    ///     Enum ClosingAvailable for value: ClosingAvailable
    /// </summary>
    [EnumMember(Value = "ClosingAvailable")]
    ClosingAvailable = 1,

    /// <summary>
    ///     Enum ClosingBooked for value: ClosingBooked
    /// </summary>
    [EnumMember(Value = "ClosingBooked")] ClosingBooked = 2,

    /// <summary>
    ///     Enum ClosingCleared for value: ClosingCleared
    /// </summary>
    [EnumMember(Value = "ClosingCleared")] ClosingCleared = 3,

    /// <summary>
    ///     Enum Expected for value: Expected
    /// </summary>
    [EnumMember(Value = "Expected")] Expected = 4,

    /// <summary>
    ///     Enum OpeningAvailable for value: OpeningAvailable
    /// </summary>
    [EnumMember(Value = "OpeningAvailable")]
    OpeningAvailable = 5,

    /// <summary>
    ///     Enum OpeningBooked for value: OpeningBooked
    /// </summary>
    [EnumMember(Value = "OpeningBooked")] OpeningBooked = 6,

    /// <summary>
    ///     Enum OpeningCleared for value: OpeningCleared
    /// </summary>
    [EnumMember(Value = "OpeningCleared")] OpeningCleared = 7,

    /// <summary>
    ///     Enum PreviouslyClosedBooked for value: PreviouslyClosedBooked
    /// </summary>
    [EnumMember(Value = "PreviouslyClosedBooked")]
    PreviouslyClosedBooked = 8
}
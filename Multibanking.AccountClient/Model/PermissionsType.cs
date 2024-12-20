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
///     Типы разрешений на доступ к счету
/// </summary>
/// <value>Типы разрешений на доступ к счету</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum PermissionsType
{
    /// <summary>
    ///     Enum ReadAccountsBasic for value: ReadAccountsBasic
    /// </summary>
    [EnumMember(Value = "ReadAccountsBasic")]
    ReadAccountsBasic = 1,

    /// <summary>
    ///     Enum ReadAccountsDetail for value: ReadAccountsDetail
    /// </summary>
    [EnumMember(Value = "ReadAccountsDetail")]
    ReadAccountsDetail = 2,

    /// <summary>
    ///     Enum ReadBalances for value: ReadBalances
    /// </summary>
    [EnumMember(Value = "ReadBalances")] ReadBalances = 3,

    /// <summary>
    ///     Enum ReadTransactionsBasic for value: ReadTransactionsBasic
    /// </summary>
    [EnumMember(Value = "ReadTransactionsBasic")]
    ReadTransactionsBasic = 4,

    /// <summary>
    ///     Enum ReadTransactionsCredits for value: ReadTransactionsCredits
    /// </summary>
    [EnumMember(Value = "ReadTransactionsCredits")]
    ReadTransactionsCredits = 5,

    /// <summary>
    ///     Enum ReadTransactionsDebits for value: ReadTransactionsDebits
    /// </summary>
    [EnumMember(Value = "ReadTransactionsDebits")]
    ReadTransactionsDebits = 6,

    /// <summary>
    ///     Enum ReadTransactionsDetail for value: ReadTransactionsDetail
    /// </summary>
    [EnumMember(Value = "ReadTransactionsDetail")]
    ReadTransactionsDetail = 7
}
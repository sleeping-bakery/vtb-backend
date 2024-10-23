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
///     Статус ресурса account-consent
/// </summary>
/// <value>Статус ресурса account-consent</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConsentStatusType
{
    /// <summary>
    ///     Enum AwaitingAuthorisation for value: AwaitingAuthorisation
    /// </summary>
    [EnumMember(Value = "AwaitingAuthorisation")]
    AwaitingAuthorisation = 1,

    /// <summary>
    ///     Enum Rejected for value: Rejected
    /// </summary>
    [EnumMember(Value = "Rejected")] Rejected = 2,

    /// <summary>
    ///     Enum Authorised for value: Authorised
    /// </summary>
    [EnumMember(Value = "Authorised")] Authorised = 3,

    /// <summary>
    ///     Enum Revoked for value: Revoked
    /// </summary>
    [EnumMember(Value = "Revoked")] Revoked = 4
}
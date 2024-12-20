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
///     Defines ConsentStatusStaticType
/// </summary>
[JsonConverter(typeof(StringEnumConverter))]
public enum ConsentStatusStaticType
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
    ///     Enum Consumed for value: Consumed
    /// </summary>
    [EnumMember(Value = "Consumed")] Consumed = 4
}
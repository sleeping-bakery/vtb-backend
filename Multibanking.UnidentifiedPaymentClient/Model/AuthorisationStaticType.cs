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
///     Тип запрашиваемого потока авторизации.
/// </summary>
/// <value>Тип запрашиваемого потока авторизации.</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum AuthorisationStaticType
{
    /// <summary>
    ///     Enum Any for value: Any
    /// </summary>
    [EnumMember(Value = "Any")] Any = 1,

    /// <summary>
    ///     Enum Single for value: Single
    /// </summary>
    [EnumMember(Value = "Single")] Single = 2,

    /// <summary>
    ///     Enum Multile for value: Multile
    /// </summary>
    [EnumMember(Value = "Multile")] Multile = 3
}
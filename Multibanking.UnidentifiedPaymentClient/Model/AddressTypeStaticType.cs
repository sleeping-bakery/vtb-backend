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
///     Тип адреса
/// </summary>
/// <value>Тип адреса</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum AddressTypeStaticType
{
    /// <summary>
    ///     Enum Business for value: Business
    /// </summary>
    [EnumMember(Value = "Business")] Business = 1,

    /// <summary>
    ///     Enum Correspondence for value: Correspondence
    /// </summary>
    [EnumMember(Value = "Correspondence")] Correspondence = 2,

    /// <summary>
    ///     Enum DeliveryTo for value: DeliveryTo
    /// </summary>
    [EnumMember(Value = "DeliveryTo")] DeliveryTo = 3,

    /// <summary>
    ///     Enum MailTo for value: MailTo
    /// </summary>
    [EnumMember(Value = "MailTo")] MailTo = 4,

    /// <summary>
    ///     Enum POBox for value: POBox
    /// </summary>
    [EnumMember(Value = "POBox")] POBox = 5,

    /// <summary>
    ///     Enum Postal for value: Postal
    /// </summary>
    [EnumMember(Value = "Postal")] Postal = 6,

    /// <summary>
    ///     Enum Residential for value: Residential
    /// </summary>
    [EnumMember(Value = "Residential")] Residential = 7,

    /// <summary>
    ///     Enum Statement for value: Statement
    /// </summary>
    [EnumMember(Value = "Statement")] Statement = 8
}
/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Тип адреса
/// </summary>
/// <value>Тип адреса</value>
[JsonConverter(typeof(StringEnumConverter))]
public enum AddressTypeCode
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
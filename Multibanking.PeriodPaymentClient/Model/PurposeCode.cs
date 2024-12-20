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
///     Указывается код вида дохода цифрой лицами, выплачивающими гражданину заработную плату и (или) иные доходы: «1» – при переводе денежных средств, являющихся заработной платой и
///     (или) иными доходами; «2» – при переводе денежных средств, являющихся доходами, на которые не может быть обращено взыскание; «3» – при переводе денежных средств, являющихся
///     доходами, к которым ограничения по обращению взыскания не применяются.
/// </summary>
/// <value>
///     Указывается код вида дохода цифрой лицами, выплачивающими гражданину заработную плату и (или) иные доходы: «1» – при переводе денежных средств, являющихся заработной платой
///     и (или) иными доходами; «2» – при переводе денежных средств, являющихся доходами, на которые не может быть обращено взыскание; «3» – при переводе денежных средств, являющихся
///     доходами, к которым ограничения по обращению взыскания не применяются.
/// </value>
[JsonConverter(typeof(StringEnumConverter))]
public enum PurposeCode
{
    /// <summary>
    ///     Enum _1 for value: 1
    /// </summary>
    [EnumMember(Value = "1")] _1 = 1,

    /// <summary>
    ///     Enum _2 for value: 2
    /// </summary>
    [EnumMember(Value = "2")] _2 = 2,

    /// <summary>
    ///     Enum _3 for value: 3
    /// </summary>
    [EnumMember(Value = "3")] _3 = 3
}
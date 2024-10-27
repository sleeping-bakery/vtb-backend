/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Multibanking.PeriodPaymentClient.Client.OpenAPIDateConverter;

namespace Multibanking.PeriodPaymentClient.Model
{
    /// <summary>
    /// Статус ресурса account-consent
    /// </summary>
    /// <value>Статус ресурса account-consent</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ConsentStatus
    {
        /// <summary>
        /// Enum AwaitingAuthorisation for value: AwaitingAuthorisation
        /// </summary>
        [EnumMember(Value = "AwaitingAuthorisation")]
        AwaitingAuthorisation = 1,

        /// <summary>
        /// Enum Rejected for value: Rejected
        /// </summary>
        [EnumMember(Value = "Rejected")]
        Rejected = 2,

        /// <summary>
        /// Enum Authorised for value: Authorised
        /// </summary>
        [EnumMember(Value = "Authorised")]
        Authorised = 3,

        /// <summary>
        /// Enum Revoked for value: Revoked
        /// </summary>
        [EnumMember(Value = "Revoked")]
        Revoked = 4

    }

}

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
    /// Схема идентификации юридического или физического лица
    /// </summary>
    /// <value>Схема идентификации юридического или физического лица</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PeriodPaymentPartyIdentificationCode
    {
        /// <summary>
        /// Enum TXID for value: RU.CBR.TXID
        /// </summary>
        [EnumMember(Value = "RU.CBR.TXID")]
        TXID = 1,

        /// <summary>
        /// Enum LEI for value: RU.CBR.LEI
        /// </summary>
        [EnumMember(Value = "RU.CBR.LEI")]
        LEI = 2,

        /// <summary>
        /// Enum PASP for value: RU.CBR.PASP
        /// </summary>
        [EnumMember(Value = "RU.CBR.PASP")]
        PASP = 3,

        /// <summary>
        /// Enum CLID for value: RU.CBR.CLID
        /// </summary>
        [EnumMember(Value = "RU.CBR.CLID")]
        CLID = 4,

        /// <summary>
        /// Enum QRST for value: RU.CBR.QRST
        /// </summary>
        [EnumMember(Value = "RU.CBR.QRST")]
        QRST = 5,

        /// <summary>
        /// Enum TAXT for value: RU.CBR.TAXT
        /// </summary>
        [EnumMember(Value = "RU.CBR.TAXT")]
        TAXT = 6,

        /// <summary>
        /// Enum OGRN for value: RU.CBR.OGRN
        /// </summary>
        [EnumMember(Value = "RU.CBR.OGRN")]
        OGRN = 7

    }

}
/*
 * Инициирование перевода денежных средств клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по переводам.
 *
 * The version of the OpenAPI document: 1.1.0
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
using OpenAPIDateConverter = Multibanking.UnidentifiedPaymentClient.Client.OpenAPIDateConverter;

namespace Multibanking.UnidentifiedPaymentClient.Model
{
    /// <summary>
    /// Контекст проведения платежа.
    /// </summary>
    /// <value>Контекст проведения платежа.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PaymentContextStaticType
    {
        /// <summary>
        /// Enum BillPayment for value: BillPayment
        /// </summary>
        [EnumMember(Value = "BillPayment")]
        BillPayment = 1,

        /// <summary>
        /// Enum EcommerceGoods for value: EcommerceGoods
        /// </summary>
        [EnumMember(Value = "EcommerceGoods")]
        EcommerceGoods = 2,

        /// <summary>
        /// Enum EcommerceServices for value: EcommerceServices
        /// </summary>
        [EnumMember(Value = "EcommerceServices")]
        EcommerceServices = 3,

        /// <summary>
        /// Enum Other for value: Other
        /// </summary>
        [EnumMember(Value = "Other")]
        Other = 4,

        /// <summary>
        /// Enum PartyToParty for value: PartyToParty
        /// </summary>
        [EnumMember(Value = "PartyToParty")]
        PartyToParty = 5

    }

}

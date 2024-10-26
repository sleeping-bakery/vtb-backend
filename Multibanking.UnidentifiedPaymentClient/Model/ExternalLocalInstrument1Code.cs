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
    /// НЕ ОПРЕДЕЛЕН
    /// </summary>
    /// <value>НЕ ОПРЕДЕЛЕН</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ExternalLocalInstrument1Code
    {
        /// <summary>
        /// Enum TmpVal1 for value: tmpVal1
        /// </summary>
        [EnumMember(Value = "tmpVal1")]
        TmpVal1 = 1

    }

}

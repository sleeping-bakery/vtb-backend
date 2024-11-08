/*
 * Поисковые сервисы каталога поставщиков услуг
 *
 * Поисковые сервисы каталога поставщиков услуг
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Multibanking.ServiceClient.Model;

/// <summary>
///     Действие над услугой ПУ
/// </summary>
[DataContract(Name = "OperationActionDtoRs")]
public class OperationActionDtoRs : IEquatable<OperationActionDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Действие, которое можно произвести над услугой
    /// </summary>
    /// <value>Действие, которое можно произвести над услугой</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum KeyEnum
    {
        /// <summary>
        ///     Enum PAYMENT for value: PAYMENT
        /// </summary>
        [EnumMember(Value = "PAYMENT")] PAYMENT = 1,

        /// <summary>
        ///     Enum TEMPLATE for value: TEMPLATE
        /// </summary>
        [EnumMember(Value = "TEMPLATE")] TEMPLATE = 2,

        /// <summary>
        ///     Enum AUTOPAYMENTBYDATE for value: AUTO_PAYMENT_BY_DATE
        /// </summary>
        [EnumMember(Value = "AUTO_PAYMENT_BY_DATE")]
        AUTOPAYMENTBYDATE = 3,

        /// <summary>
        ///     Enum AUTOPAYMENTBYBALANCE for value: AUTO_PAYMENT_BY_BALANCE
        /// </summary>
        [EnumMember(Value = "AUTO_PAYMENT_BY_BALANCE")]
        AUTOPAYMENTBYBALANCE = 4,

        /// <summary>
        ///     Enum INVOICE for value: INVOICE
        /// </summary>
        [EnumMember(Value = "INVOICE")] INVOICE = 5,

        /// <summary>
        ///     Enum REPEAT for value: REPEAT
        /// </summary>
        [EnumMember(Value = "REPEAT")] REPEAT = 6,

        /// <summary>
        ///     Enum REMIND for value: REMIND
        /// </summary>
        [EnumMember(Value = "REMIND")] REMIND = 7,

        /// <summary>
        ///     Enum SUBSCRIPTION for value: SUBSCRIPTION
        /// </summary>
        [EnumMember(Value = "SUBSCRIPTION")] SUBSCRIPTION = 8
    }

    /// <summary>
    ///     Имя системы, которая будет проводить операцию, если не задано считается что операцию выполняет MS
    /// </summary>
    /// <value>Имя системы, которая будет проводить операцию, если не задано считается что операцию выполняет MS</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SystemIdEnum
    {
        /// <summary>
        ///     Enum MINERVA for value: MINERVA
        /// </summary>
        [EnumMember(Value = "MINERVA")] MINERVA = 1,

        /// <summary>
        ///     Enum MS for value: MS
        /// </summary>
        [EnumMember(Value = "MS")] MS = 2
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="OperationActionDtoRs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected OperationActionDtoRs()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="OperationActionDtoRs" /> class.
    /// </summary>
    /// <param name="key">Действие, которое можно произвести над услугой (required).</param>
    /// <param name="systemId">Имя системы, которая будет проводить операцию, если не задано считается что операцию выполняет MS.</param>
    public OperationActionDtoRs(KeyEnum key = default, SystemIdEnum? systemId = default)
    {
        Key = key;
        SystemId = systemId;
    }


    /// <summary>
    ///     Действие, которое можно произвести над услугой
    /// </summary>
    /// <value>Действие, которое можно произвести над услугой</value>
    [DataMember(Name = "key", IsRequired = true, EmitDefaultValue = true)]
    public KeyEnum Key { get; set; }


    /// <summary>
    ///     Имя системы, которая будет проводить операцию, если не задано считается что операцию выполняет MS
    /// </summary>
    /// <value>Имя системы, которая будет проводить операцию, если не задано считается что операцию выполняет MS</value>
    [DataMember(Name = "systemId", EmitDefaultValue = false)]
    public SystemIdEnum? SystemId { get; set; }

    /// <summary>
    ///     Returns true if OperationActionDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of OperationActionDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(OperationActionDtoRs input)
    {
        if (input == null) return false;
        return
            (
                Key == input.Key ||
                Key.Equals(input.Key)
            ) &&
            (
                SystemId == input.SystemId ||
                SystemId.Equals(input.SystemId)
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class OperationActionDtoRs {\n");
        sb.Append("  Key: ").Append(Key).Append("\n");
        sb.Append("  SystemId: ").Append(SystemId).Append("\n");
        sb.Append("}\n");
        return sb.ToString();
    }

    /// <summary>
    ///     Returns the JSON string presentation of the object
    /// </summary>
    /// <returns>JSON string presentation of the object</returns>
    public virtual string ToJson()
    {
        return JsonConvert.SerializeObject(this, Formatting.Indented);
    }

    /// <summary>
    ///     Returns true if objects are equal
    /// </summary>
    /// <param name="input">Object to be compared</param>
    /// <returns>Boolean</returns>
    public override bool Equals(object input)
    {
        return Equals(input as OperationActionDtoRs);
    }

    /// <summary>
    ///     Gets the hash code
    /// </summary>
    /// <returns>Hash code</returns>
    public override int GetHashCode()
    {
        unchecked // Overflow is fine, just wrap
        {
            var hashCode = 41;
            hashCode = hashCode * 59 + Key.GetHashCode();
            hashCode = hashCode * 59 + SystemId.GetHashCode();
            return hashCode;
        }
    }
}
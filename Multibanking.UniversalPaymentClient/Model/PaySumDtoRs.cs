/*
 * Cервис платежа с базовым сценарием оплаты
 *
 * сервис платежа с базовым сценарием оплаты
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.UniversalPaymentClient.Model;

/// <summary>
///     Информация по сумме платежа ответ
/// </summary>
[DataContract(Name = "PaySumDtoRs")]
public class PaySumDtoRs : IEquatable<PaySumDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PaySumDtoRs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PaySumDtoRs()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="PaySumDtoRs" /> class.
    /// </summary>
    /// <param name="payLimit">payLimit (required).</param>
    /// <param name="recommendedSums">Список рекомендованных сумм платежа.</param>
    public PaySumDtoRs(PayLimitDtoRs payLimit = default, List<MoneyDto> recommendedSums = default)
    {
        // to ensure "payLimit" is required (not null)
        if (payLimit == null) throw new ArgumentNullException("payLimit is a required property for PaySumDtoRs and cannot be null");
        PayLimit = payLimit;
        RecommendedSums = recommendedSums;
    }

    /// <summary>
    ///     Gets or Sets PayLimit
    /// </summary>
    [DataMember(Name = "payLimit", IsRequired = true, EmitDefaultValue = true)]
    public PayLimitDtoRs PayLimit { get; set; }

    /// <summary>
    ///     Список рекомендованных сумм платежа
    /// </summary>
    /// <value>Список рекомендованных сумм платежа</value>
    [DataMember(Name = "recommendedSums", EmitDefaultValue = false)]
    public List<MoneyDto> RecommendedSums { get; set; }

    /// <summary>
    ///     Returns true if PaySumDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of PaySumDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PaySumDtoRs input)
    {
        if (input == null) return false;
        return
            (
                PayLimit == input.PayLimit ||
                (PayLimit != null &&
                 PayLimit.Equals(input.PayLimit))
            ) &&
            (
                RecommendedSums == input.RecommendedSums ||
                (RecommendedSums != null &&
                 input.RecommendedSums != null &&
                 RecommendedSums.SequenceEqual(input.RecommendedSums))
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
        sb.Append("class PaySumDtoRs {\n");
        sb.Append("  PayLimit: ").Append(PayLimit).Append("\n");
        sb.Append("  RecommendedSums: ").Append(RecommendedSums).Append("\n");
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
        return Equals(input as PaySumDtoRs);
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
            if (PayLimit != null) hashCode = hashCode * 59 + PayLimit.GetHashCode();
            if (RecommendedSums != null) hashCode = hashCode * 59 + RecommendedSums.GetHashCode();
            return hashCode;
        }
    }
}
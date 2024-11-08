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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.UniversalPaymentClient.Model;

/// <summary>
///     Информация о коде подтверждения
/// </summary>
[DataContract(Name = "ConfirmCodeDtoRs")]
public class ConfirmCodeDtoRs : IEquatable<ConfirmCodeDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ConfirmCodeDtoRs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConfirmCodeDtoRs()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ConfirmCodeDtoRs" /> class.
    /// </summary>
    /// <param name="lifeTime">Время жизни кода подтверждения в секундах (required).</param>
    public ConfirmCodeDtoRs(long lifeTime = default)
    {
        LifeTime = lifeTime;
    }

    /// <summary>
    ///     Время жизни кода подтверждения в секундах
    /// </summary>
    /// <value>Время жизни кода подтверждения в секундах</value>
    [DataMember(Name = "lifeTime", IsRequired = true, EmitDefaultValue = true)]
    public long LifeTime { get; set; }

    /// <summary>
    ///     Returns true if ConfirmCodeDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of ConfirmCodeDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConfirmCodeDtoRs input)
    {
        if (input == null) return false;
        return
            LifeTime == input.LifeTime ||
            LifeTime.Equals(input.LifeTime);
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // LifeTime (long) maximum
        if (LifeTime > 180) yield return new ValidationResult("Invalid value for LifeTime, must be a value less than or equal to 180.", new[] { "LifeTime" });

        // LifeTime (long) minimum
        if (LifeTime < 30) yield return new ValidationResult("Invalid value for LifeTime, must be a value greater than or equal to 30.", new[] { "LifeTime" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConfirmCodeDtoRs {\n");
        sb.Append("  LifeTime: ").Append(LifeTime).Append("\n");
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
        return Equals(input as ConfirmCodeDtoRs);
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
            hashCode = hashCode * 59 + LifeTime.GetHashCode();
            return hashCode;
        }
    }
}
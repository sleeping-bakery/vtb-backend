/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Информация о причине статуса
/// </summary>
[DataContract(Name = "StatusReasonInformation")]
public class StatusReasonInformation : IEquatable<StatusReasonInformation>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StatusReasonInformation" /> class.
    /// </summary>
    /// <param name="reason">Код причины статуса платежа.</param>
    /// <param name="additionalInformation">Текстовое описание причины присвоения статуса.</param>
    public StatusReasonInformation(StatusReasonCode? reason = default, string additionalInformation = default)
    {
        Reason = reason;
        AdditionalInformation = additionalInformation;
    }

    /// <summary>
    ///     Код причины статуса платежа
    /// </summary>
    /// <value>Код причины статуса платежа</value>
    [DataMember(Name = "reason", EmitDefaultValue = false)]
    public StatusReasonCode? Reason { get; set; }

    /// <summary>
    ///     Текстовое описание причины присвоения статуса
    /// </summary>
    /// <value>Текстовое описание причины присвоения статуса</value>
    [DataMember(Name = "additionalInformation", EmitDefaultValue = false)]
    public string AdditionalInformation { get; set; }

    /// <summary>
    ///     Returns true if StatusReasonInformation instances are equal
    /// </summary>
    /// <param name="input">Instance of StatusReasonInformation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StatusReasonInformation input)
    {
        if (input == null) return false;
        return
            (
                Reason == input.Reason ||
                Reason.Equals(input.Reason)
            ) &&
            (
                AdditionalInformation == input.AdditionalInformation ||
                (AdditionalInformation != null &&
                 AdditionalInformation.Equals(input.AdditionalInformation))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // AdditionalInformation (string) maxLength
        if (AdditionalInformation != null && AdditionalInformation.Length > 256)
            yield return new ValidationResult("Invalid value for AdditionalInformation, length must be less than 256.", new[] { "AdditionalInformation" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class StatusReasonInformation {\n");
        sb.Append("  Reason: ").Append(Reason).Append("\n");
        sb.Append("  AdditionalInformation: ").Append(AdditionalInformation).Append("\n");
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
        return Equals(input as StatusReasonInformation);
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
            hashCode = hashCode * 59 + Reason.GetHashCode();
            if (AdditionalInformation != null) hashCode = hashCode * 59 + AdditionalInformation.GetHashCode();
            return hashCode;
        }
    }
}
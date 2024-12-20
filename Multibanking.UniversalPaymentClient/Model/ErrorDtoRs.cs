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
///     Ответ с информацией об ошибке
/// </summary>
[DataContract(Name = "ErrorDtoRs")]
public class ErrorDtoRs : IEquatable<ErrorDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ErrorDtoRs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ErrorDtoRs()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ErrorDtoRs" /> class.
    /// </summary>
    /// <param name="status">status (required).</param>
    /// <param name="errors">Список полей с ошибками.</param>
    public ErrorDtoRs(StatusDtoRs status = default, List<ErrorFieldDtoRs> errors = default)
    {
        // to ensure "status" is required (not null)
        if (status == null) throw new ArgumentNullException("status is a required property for ErrorDtoRs and cannot be null");
        Status = status;
        Errors = errors;
    }

    /// <summary>
    ///     Gets or Sets Status
    /// </summary>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public StatusDtoRs Status { get; set; }

    /// <summary>
    ///     Список полей с ошибками
    /// </summary>
    /// <value>Список полей с ошибками</value>
    [DataMember(Name = "errors", EmitDefaultValue = false)]
    public List<ErrorFieldDtoRs> Errors { get; set; }

    /// <summary>
    ///     Returns true if ErrorDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of ErrorDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ErrorDtoRs input)
    {
        if (input == null) return false;
        return
            (
                Status == input.Status ||
                (Status != null &&
                 Status.Equals(input.Status))
            ) &&
            (
                Errors == input.Errors ||
                (Errors != null &&
                 input.Errors != null &&
                 Errors.SequenceEqual(input.Errors))
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
        sb.Append("class ErrorDtoRs {\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  Errors: ").Append(Errors).Append("\n");
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
        return Equals(input as ErrorDtoRs);
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
            if (Status != null) hashCode = hashCode * 59 + Status.GetHashCode();
            if (Errors != null) hashCode = hashCode * 59 + Errors.GetHashCode();
            return hashCode;
        }
    }
}
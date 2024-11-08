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
///     Код подтверждения операции
/// </summary>
[DataContract(Name = "ClientConfirmCodeDtoRq")]
public class ClientConfirmCodeDtoRq : IEquatable<ClientConfirmCodeDtoRq>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ClientConfirmCodeDtoRq" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ClientConfirmCodeDtoRq()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ClientConfirmCodeDtoRq" /> class.
    /// </summary>
    /// <param name="code">Значение кода подтверждения (required).</param>
    public ClientConfirmCodeDtoRq(string code = default)
    {
        // to ensure "code" is required (not null)
        if (code == null) throw new ArgumentNullException("code is a required property for ClientConfirmCodeDtoRq and cannot be null");
        Code = code;
    }

    /// <summary>
    ///     Значение кода подтверждения
    /// </summary>
    /// <value>Значение кода подтверждения</value>
    [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
    public string Code { get; set; }

    /// <summary>
    ///     Returns true if ClientConfirmCodeDtoRq instances are equal
    /// </summary>
    /// <param name="input">Instance of ClientConfirmCodeDtoRq to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ClientConfirmCodeDtoRq input)
    {
        if (input == null) return false;
        return
            Code == input.Code ||
            (Code != null &&
             Code.Equals(input.Code));
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Code (string) maxLength
        if (Code != null && Code.Length > 36) yield return new ValidationResult("Invalid value for Code, length must be less than 36.", new[] { "Code" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ClientConfirmCodeDtoRq {\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
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
        return Equals(input as ClientConfirmCodeDtoRq);
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
            if (Code != null) hashCode = hashCode * 59 + Code.GetHashCode();
            return hashCode;
        }
    }
}
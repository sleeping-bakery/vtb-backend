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
///     Описание ошибки
/// </summary>
[DataContract(Name = "ErrorFieldDtoRs")]
public class ErrorFieldDtoRs : IEquatable<ErrorFieldDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ErrorFieldDtoRs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ErrorFieldDtoRs()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ErrorFieldDtoRs" /> class.
    /// </summary>
    /// <param name="name">Ключ/название ошибочного поля (required).</param>
    /// <param name="code">Код ошибки (required).</param>
    /// <param name="message">Текст ошибки (required).</param>
    public ErrorFieldDtoRs(string name = default, string code = default, string message = default)
    {
        // to ensure "name" is required (not null)
        if (name == null) throw new ArgumentNullException("name is a required property for ErrorFieldDtoRs and cannot be null");
        Name = name;
        // to ensure "code" is required (not null)
        if (code == null) throw new ArgumentNullException("code is a required property for ErrorFieldDtoRs and cannot be null");
        Code = code;
        // to ensure "message" is required (not null)
        if (message == null) throw new ArgumentNullException("message is a required property for ErrorFieldDtoRs and cannot be null");
        Message = message;
    }

    /// <summary>
    ///     Ключ/название ошибочного поля
    /// </summary>
    /// <value>Ключ/название ошибочного поля</value>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Код ошибки
    /// </summary>
    /// <value>Код ошибки</value>
    [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
    public string Code { get; set; }

    /// <summary>
    ///     Текст ошибки
    /// </summary>
    /// <value>Текст ошибки</value>
    [DataMember(Name = "message", IsRequired = true, EmitDefaultValue = true)]
    public string Message { get; set; }

    /// <summary>
    ///     Returns true if ErrorFieldDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of ErrorFieldDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ErrorFieldDtoRs input)
    {
        if (input == null) return false;
        return
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
            ) &&
            (
                Code == input.Code ||
                (Code != null &&
                 Code.Equals(input.Code))
            ) &&
            (
                Message == input.Message ||
                (Message != null &&
                 Message.Equals(input.Message))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Name (string) maxLength
        if (Name != null && Name.Length > 255) yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new[] { "Name" });

        // Code (string) maxLength
        if (Code != null && Code.Length > 255) yield return new ValidationResult("Invalid value for Code, length must be less than 255.", new[] { "Code" });

        // Message (string) maxLength
        if (Message != null && Message.Length > 255) yield return new ValidationResult("Invalid value for Message, length must be less than 255.", new[] { "Message" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ErrorFieldDtoRs {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Message: ").Append(Message).Append("\n");
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
        return Equals(input as ErrorFieldDtoRs);
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
            if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
            if (Code != null) hashCode = hashCode * 59 + Code.GetHashCode();
            if (Message != null) hashCode = hashCode * 59 + Message.GetHashCode();
            return hashCode;
        }
    }
}
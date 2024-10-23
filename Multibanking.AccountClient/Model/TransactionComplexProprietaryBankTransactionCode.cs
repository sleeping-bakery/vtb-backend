/*
 * Получение информации о счете клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по счетам и транзакциям.
 *
 * The version of the OpenAPI document: 1.2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.AccountClient.Model;

/// <summary>
///     Подробная информация для полной идентификации собственного банковского кода транзакции
/// </summary>
[DataContract(Name = "TransactionComplex_ProprietaryBankTransactionCode")]
public class
    TransactionComplexProprietaryBankTransactionCode : IEquatable<TransactionComplexProprietaryBankTransactionCode>,
    IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionComplexProprietaryBankTransactionCode" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TransactionComplexProprietaryBankTransactionCode()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionComplexProprietaryBankTransactionCode" /> class.
    /// </summary>
    /// <param name="code">Собственный банковский код транзакции (required).</param>
    /// <param name="issuer">Идентификация эмитента собственного банковского кода транзакции.</param>
    public TransactionComplexProprietaryBankTransactionCode(string code = default, string issuer = default)
    {
        // to ensure "code" is required (not null)
        if (code == null)
            throw new ArgumentNullException(
                "code is a required property for TransactionComplexProprietaryBankTransactionCode and cannot be null");
        Code = code;
        Issuer = issuer;
    }

    /// <summary>
    ///     Собственный банковский код транзакции
    /// </summary>
    /// <value>Собственный банковский код транзакции</value>
    [DataMember(Name = "code", IsRequired = true, EmitDefaultValue = true)]
    public string Code { get; set; }

    /// <summary>
    ///     Идентификация эмитента собственного банковского кода транзакции
    /// </summary>
    /// <value>Идентификация эмитента собственного банковского кода транзакции</value>
    [DataMember(Name = "issuer", EmitDefaultValue = false)]
    public string Issuer { get; set; }

    /// <summary>
    ///     Returns true if TransactionComplexProprietaryBankTransactionCode instances are equal
    /// </summary>
    /// <param name="input">Instance of TransactionComplexProprietaryBankTransactionCode to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TransactionComplexProprietaryBankTransactionCode input)
    {
        if (input == null) return false;
        return
            (
                Code == input.Code ||
                (Code != null &&
                 Code.Equals(input.Code))
            ) &&
            (
                Issuer == input.Issuer ||
                (Issuer != null &&
                 Issuer.Equals(input.Issuer))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Code (string) maxLength
        if (Code != null && Code.Length > 35)
            yield return new ValidationResult("Invalid value for Code, length must be less than 35.", new[] { "Code" });

        // Issuer (string) maxLength
        if (Issuer != null && Issuer.Length > 35)
            yield return new ValidationResult("Invalid value for Issuer, length must be less than 35.",
                new[] { "Issuer" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TransactionComplexProprietaryBankTransactionCode {\n");
        sb.Append("  Code: ").Append(Code).Append("\n");
        sb.Append("  Issuer: ").Append(Issuer).Append("\n");
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
        return Equals(input as TransactionComplexProprietaryBankTransactionCode);
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
            if (Issuer != null) hashCode = hashCode * 59 + Issuer.GetHashCode();
            return hashCode;
        }
    }
}
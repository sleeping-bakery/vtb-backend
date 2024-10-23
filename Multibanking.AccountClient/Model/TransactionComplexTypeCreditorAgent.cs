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
///     Финансовое организация, обслуживающая счет получателя средств
/// </summary>
[DataContract(Name = "TransactionComplexType_CreditorAgent")]
public class TransactionComplexTypeCreditorAgent : IEquatable<TransactionComplexTypeCreditorAgent>,
    IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionComplexTypeCreditorAgent" /> class.
    /// </summary>
    /// <param name="schemeName">Название схемы.</param>
    /// <param name="identification">Идентификатор.</param>
    /// <param name="name">Название.</param>
    /// <param name="address">address.</param>
    public TransactionComplexTypeCreditorAgent(FinancialInstitutionIdentificationDynamicType? schemeName = default,
        string identification = default, string name = default,
        BranchAndFinancialInstitutionIdentificationComplexTypeAddress address = default)
    {
        SchemeName = schemeName;
        Identification = identification;
        Name = name;
        Address = address;
    }

    /// <summary>
    ///     Название схемы
    /// </summary>
    /// <value>Название схемы</value>
    [DataMember(Name = "schemeName", EmitDefaultValue = false)]
    public FinancialInstitutionIdentificationDynamicType? SchemeName { get; set; }

    /// <summary>
    ///     Идентификатор
    /// </summary>
    /// <value>Идентификатор</value>
    [DataMember(Name = "identification", EmitDefaultValue = false)]
    public string Identification { get; set; }

    /// <summary>
    ///     Название
    /// </summary>
    /// <value>Название</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets Address
    /// </summary>
    [DataMember(Name = "Address", EmitDefaultValue = false)]
    public BranchAndFinancialInstitutionIdentificationComplexTypeAddress Address { get; set; }

    /// <summary>
    ///     Returns true if TransactionComplexTypeCreditorAgent instances are equal
    /// </summary>
    /// <param name="input">Instance of TransactionComplexTypeCreditorAgent to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TransactionComplexTypeCreditorAgent input)
    {
        if (input == null) return false;
        return
            (
                SchemeName == input.SchemeName ||
                SchemeName.Equals(input.SchemeName)
            ) &&
            (
                Identification == input.Identification ||
                (Identification != null &&
                 Identification.Equals(input.Identification))
            ) &&
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
            ) &&
            (
                Address == input.Address ||
                (Address != null &&
                 Address.Equals(input.Address))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Identification (string) maxLength
        if (Identification != null && Identification.Length > 35)
            yield return new ValidationResult("Invalid value for Identification, length must be less than 35.",
                new[] { "Identification" });

        // Name (string) maxLength
        if (Name != null && Name.Length > 140)
            yield return new ValidationResult("Invalid value for Name, length must be less than 140.",
                new[] { "Name" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TransactionComplexTypeCreditorAgent {\n");
        sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
        sb.Append("  Identification: ").Append(Identification).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  Address: ").Append(Address).Append("\n");
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
        return Equals(input as TransactionComplexTypeCreditorAgent);
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
            hashCode = hashCode * 59 + SchemeName.GetHashCode();
            if (Identification != null) hashCode = hashCode * 59 + Identification.GetHashCode();
            if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
            if (Address != null) hashCode = hashCode * 59 + Address.GetHashCode();
            return hashCode;
        }
    }
}
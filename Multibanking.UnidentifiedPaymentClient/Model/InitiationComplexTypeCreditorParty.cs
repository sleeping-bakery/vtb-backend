/*
 * Инициирование перевода денежных средств клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по переводам.
 *
 * The version of the OpenAPI document: 1.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.UnidentifiedPaymentClient.Model;

/// <summary>
///     Информация о контрагенте.
/// </summary>
[DataContract(Name = "InitiationComplexType_CreditorParty")]
public class InitiationComplexTypeCreditorParty : IEquatable<InitiationComplexTypeCreditorParty>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="InitiationComplexTypeCreditorParty" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected InitiationComplexTypeCreditorParty()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="InitiationComplexTypeCreditorParty" /> class.
    /// </summary>
    /// <param name="name">Наименование контрагента. (required).</param>
    /// <param name="postalAddress">postalAddress.</param>
    public InitiationComplexTypeCreditorParty(string name = default, PartyIdentificationCompexTypePostalAddress postalAddress = default)
    {
        // to ensure "name" is required (not null)
        if (name == null) throw new ArgumentNullException("name is a required property for InitiationComplexTypeCreditorParty and cannot be null");
        Name = name;
        PostalAddress = postalAddress;
    }

    /// <summary>
    ///     Наименование контрагента.
    /// </summary>
    /// <value>Наименование контрагента.</value>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Gets or Sets PostalAddress
    /// </summary>
    [DataMember(Name = "PostalAddress", EmitDefaultValue = false)]
    public PartyIdentificationCompexTypePostalAddress PostalAddress { get; set; }

    /// <summary>
    ///     Returns true if InitiationComplexTypeCreditorParty instances are equal
    /// </summary>
    /// <param name="input">Instance of InitiationComplexTypeCreditorParty to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InitiationComplexTypeCreditorParty input)
    {
        if (input == null) return false;
        return
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
            ) &&
            (
                PostalAddress == input.PostalAddress ||
                (PostalAddress != null &&
                 PostalAddress.Equals(input.PostalAddress))
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
        if (Name != null && Name.Length > 160) yield return new ValidationResult("Invalid value for Name, length must be less than 160.", new[] { "Name" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InitiationComplexTypeCreditorParty {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
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
        return Equals(input as InitiationComplexTypeCreditorParty);
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
            if (PostalAddress != null) hashCode = hashCode * 59 + PostalAddress.GetHashCode();
            return hashCode;
        }
    }
}
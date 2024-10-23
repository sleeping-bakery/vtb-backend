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
///     Идентификация юридического или физического лица
/// </summary>
[DataContract(Name = "PartyIdentification")]
public class PartyIdentification : IEquatable<PartyIdentification>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PartyIdentification" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PartyIdentification()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="PartyIdentification" /> class.
    /// </summary>
    /// <param name="schemeName">schemeName (required).</param>
    /// <param name="identification">Уникальный и однозначный идентификатор участника, присвоенный идентифицирующей организацией. (required).</param>
    public PartyIdentification(PartyIdentificationCode schemeName = default, string identification = default)
    {
        SchemeName = schemeName;
        // to ensure "identification" is required (not null)
        if (identification == null) throw new ArgumentNullException("identification is a required property for PartyIdentification and cannot be null");
        Identification = identification;
    }

    /// <summary>
    ///     Gets or Sets SchemeName
    /// </summary>
    [DataMember(Name = "schemeName", IsRequired = true, EmitDefaultValue = true)]
    public PartyIdentificationCode SchemeName { get; set; }

    /// <summary>
    ///     Уникальный и однозначный идентификатор участника, присвоенный идентифицирующей организацией.
    /// </summary>
    /// <value>Уникальный и однозначный идентификатор участника, присвоенный идентифицирующей организацией.</value>
    [DataMember(Name = "identification", IsRequired = true, EmitDefaultValue = true)]
    public string Identification { get; set; }

    /// <summary>
    ///     Returns true if PartyIdentification instances are equal
    /// </summary>
    /// <param name="input">Instance of PartyIdentification to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PartyIdentification input)
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
            yield return new ValidationResult("Invalid value for Identification, length must be less than 35.", new[] { "Identification" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PartyIdentification {\n");
        sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
        sb.Append("  Identification: ").Append(Identification).Append("\n");
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
        return Equals(input as PartyIdentification);
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
            return hashCode;
        }
    }
}
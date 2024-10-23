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
///     Идентификация счета плательщика в случае кредитной операции
/// </summary>
[DataContract(Name = "CashAccountCompexType")]
public class CashAccountCompexType : IEquatable<CashAccountCompexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CashAccountCompexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CashAccountCompexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="CashAccountCompexType" /> class.
    /// </summary>
    /// <param name="schemeName">Название схемы (required).</param>
    /// <param name="identification">Идентификатор счета (required).</param>
    public CashAccountCompexType(AccountIdentificationDynamicType schemeName = default, string identification = default)
    {
        SchemeName = schemeName;
        // to ensure "identification" is required (not null)
        if (identification == null) throw new ArgumentNullException("identification is a required property for CashAccountCompexType and cannot be null");
        Identification = identification;
    }

    /// <summary>
    ///     Название схемы
    /// </summary>
    /// <value>Название схемы</value>
    [DataMember(Name = "schemeName", IsRequired = true, EmitDefaultValue = true)]
    public AccountIdentificationDynamicType SchemeName { get; set; }

    /// <summary>
    ///     Идентификатор счета
    /// </summary>
    /// <value>Идентификатор счета</value>
    [DataMember(Name = "identification", IsRequired = true, EmitDefaultValue = true)]
    public string Identification { get; set; }

    /// <summary>
    ///     Returns true if CashAccountCompexType instances are equal
    /// </summary>
    /// <param name="input">Instance of CashAccountCompexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CashAccountCompexType input)
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
        if (Identification != null && Identification.Length > 256)
            yield return new ValidationResult("Invalid value for Identification, length must be less than 256.", new[] { "Identification" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CashAccountCompexType {\n");
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
        return Equals(input as CashAccountCompexType);
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
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
///     Подробная информация для идентификации счета
/// </summary>
[DataContract(Name = "AccountDetailsComplexType")]
public class AccountDetailsComplexType : IEquatable<AccountDetailsComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="AccountDetailsComplexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected AccountDetailsComplexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="AccountDetailsComplexType" /> class.
    /// </summary>
    /// <param name="schemeName">Наименование схемы идентификации счета (required).</param>
    /// <param name="identification">
    ///     Номер счета, присваивается организацией для идентификации счета. Эта идентификация
    ///     известна владельцу счета (required).
    /// </param>
    /// <param name="name">Название идентификатора счета.</param>
    public AccountDetailsComplexType(AccountIdentificationDynamicType schemeName = default,
        string identification = default, string name = default)
    {
        SchemeName = schemeName;
        // to ensure "identification" is required (not null)
        if (identification == null)
            throw new ArgumentNullException(
                "identification is a required property for AccountDetailsComplexType and cannot be null");
        Identification = identification;
        Name = name;
    }

    /// <summary>
    ///     Наименование схемы идентификации счета
    /// </summary>
    /// <value>Наименование схемы идентификации счета</value>
    [DataMember(Name = "schemeName", IsRequired = true, EmitDefaultValue = true)]
    public AccountIdentificationDynamicType SchemeName { get; set; }

    /// <summary>
    ///     Номер счета, присваивается организацией для идентификации счета. Эта идентификация известна владельцу счета
    /// </summary>
    /// <value>Номер счета, присваивается организацией для идентификации счета. Эта идентификация известна владельцу счета</value>
    [DataMember(Name = "identification", IsRequired = true, EmitDefaultValue = true)]
    public string Identification { get; set; }

    /// <summary>
    ///     Название идентификатора счета
    /// </summary>
    /// <value>Название идентификатора счета</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    ///     Returns true if AccountDetailsComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of AccountDetailsComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(AccountDetailsComplexType input)
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
            yield return new ValidationResult("Invalid value for Identification, length must be less than 256.",
                new[] { "Identification" });

        // Name (string) maxLength
        if (Name != null && Name.Length > 70)
            yield return new ValidationResult("Invalid value for Name, length must be less than 70.", new[] { "Name" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class AccountDetailsComplexType {\n");
        sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
        sb.Append("  Identification: ").Append(Identification).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(input as AccountDetailsComplexType);
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
            return hashCode;
        }
    }
}
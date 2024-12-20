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
///     Детальное описание карточного инструмента, использованного в транзакции
/// </summary>
[DataContract(Name = "TransactionCardInstrumentComplexType")]
public class TransactionCardInstrumentComplexType : IEquatable<TransactionCardInstrumentComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionCardInstrumentComplexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TransactionCardInstrumentComplexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionCardInstrumentComplexType" /> class.
    /// </summary>
    /// <param name="cardSchemeName">Название схемы (required).</param>
    /// <param name="authorisationType">Тип авторизации.</param>
    /// <param name="name">Имя владельца.</param>
    /// <param name="identification">Идентификационный номер.</param>
    public TransactionCardInstrumentComplexType(CardSchemeNameStaticType cardSchemeName = default, CardAuthorisationTypeStaticType? authorisationType = default,
        string name = default, string identification = default)
    {
        CardSchemeName = cardSchemeName;
        AuthorisationType = authorisationType;
        Name = name;
        Identification = identification;
    }

    /// <summary>
    ///     Название схемы
    /// </summary>
    /// <value>Название схемы</value>
    [DataMember(Name = "cardSchemeName", IsRequired = true, EmitDefaultValue = true)]
    public CardSchemeNameStaticType CardSchemeName { get; set; }

    /// <summary>
    ///     Тип авторизации
    /// </summary>
    /// <value>Тип авторизации</value>
    [DataMember(Name = "authorisationType", EmitDefaultValue = false)]
    public CardAuthorisationTypeStaticType? AuthorisationType { get; set; }

    /// <summary>
    ///     Имя владельца
    /// </summary>
    /// <value>Имя владельца</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    ///     Идентификационный номер
    /// </summary>
    /// <value>Идентификационный номер</value>
    [DataMember(Name = "identification", EmitDefaultValue = false)]
    public string Identification { get; set; }

    /// <summary>
    ///     Returns true if TransactionCardInstrumentComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of TransactionCardInstrumentComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TransactionCardInstrumentComplexType input)
    {
        if (input == null) return false;
        return
            (
                CardSchemeName == input.CardSchemeName ||
                CardSchemeName.Equals(input.CardSchemeName)
            ) &&
            (
                AuthorisationType == input.AuthorisationType ||
                AuthorisationType.Equals(input.AuthorisationType)
            ) &&
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
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
        // Name (string) maxLength
        if (Name != null && Name.Length > 70) yield return new ValidationResult("Invalid value for Name, length must be less than 70.", new[] { "Name" });

        // Identification (string) maxLength
        if (Identification != null && Identification.Length > 34)
            yield return new ValidationResult("Invalid value for Identification, length must be less than 34.", new[] { "Identification" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TransactionCardInstrumentComplexType {\n");
        sb.Append("  CardSchemeName: ").Append(CardSchemeName).Append("\n");
        sb.Append("  AuthorisationType: ").Append(AuthorisationType).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
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
        return Equals(input as TransactionCardInstrumentComplexType);
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
            hashCode = hashCode * 59 + CardSchemeName.GetHashCode();
            hashCode = hashCode * 59 + AuthorisationType.GetHashCode();
            if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
            if (Identification != null) hashCode = hashCode * 59 + Identification.GetHashCode();
            return hashCode;
        }
    }
}
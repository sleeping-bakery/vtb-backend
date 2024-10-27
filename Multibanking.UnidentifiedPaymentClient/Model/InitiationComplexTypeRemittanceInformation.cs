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
///     Предоставляемая информация, позволяющая сопоставить запись с позициями, для которых предназначен перевод, такими как коммерческие счета в системе дебиторской задолженности.
/// </summary>
[DataContract(Name = "InitiationComplexType_RemittanceInformation")]
public class InitiationComplexTypeRemittanceInformation : IEquatable<InitiationComplexTypeRemittanceInformation>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="InitiationComplexTypeRemittanceInformation" /> class.
    /// </summary>
    /// <param name="unstructured">
    ///     Информация, позволяющая сопоставлять / сверять записи с позициями, для которых предназначен платеж, такими как коммерческие счета в системе дебиторской
    ///     задолженности, в неструктурированной форме..
    /// </param>
    /// <param name="reference">Уникальная ссылка, присвоенная получателем, для однозначной ссылки на платежную транзакцию..</param>
    public InitiationComplexTypeRemittanceInformation(string unstructured = default, string reference = default)
    {
        Unstructured = unstructured;
        Reference = reference;
    }

    /// <summary>
    ///     Информация, позволяющая сопоставлять / сверять записи с позициями, для которых предназначен платеж, такими как коммерческие счета в системе дебиторской задолженности, в
    ///     неструктурированной форме.
    /// </summary>
    /// <value>
    ///     Информация, позволяющая сопоставлять / сверять записи с позициями, для которых предназначен платеж, такими как коммерческие счета в системе дебиторской задолженности, в
    ///     неструктурированной форме.
    /// </value>
    [DataMember(Name = "unstructured", EmitDefaultValue = false)]
    public string Unstructured { get; set; }

    /// <summary>
    ///     Уникальная ссылка, присвоенная получателем, для однозначной ссылки на платежную транзакцию.
    /// </summary>
    /// <value>Уникальная ссылка, присвоенная получателем, для однозначной ссылки на платежную транзакцию.</value>
    [DataMember(Name = "reference", EmitDefaultValue = false)]
    public string Reference { get; set; }

    /// <summary>
    ///     Returns true if InitiationComplexTypeRemittanceInformation instances are equal
    /// </summary>
    /// <param name="input">Instance of InitiationComplexTypeRemittanceInformation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(InitiationComplexTypeRemittanceInformation input)
    {
        if (input == null) return false;
        return
            (
                Unstructured == input.Unstructured ||
                (Unstructured != null &&
                 Unstructured.Equals(input.Unstructured))
            ) &&
            (
                Reference == input.Reference ||
                (Reference != null &&
                 Reference.Equals(input.Reference))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Unstructured (string) maxLength
        if (Unstructured != null && Unstructured.Length > 140)
            yield return new ValidationResult("Invalid value for Unstructured, length must be less than 140.", new[] { "Unstructured" });

        // Reference (string) maxLength
        if (Reference != null && Reference.Length > 35) yield return new ValidationResult("Invalid value for Reference, length must be less than 35.", new[] { "Reference" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class InitiationComplexTypeRemittanceInformation {\n");
        sb.Append("  Unstructured: ").Append(Unstructured).Append("\n");
        sb.Append("  Reference: ").Append(Reference).Append("\n");
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
        return Equals(input as InitiationComplexTypeRemittanceInformation);
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
            if (Unstructured != null) hashCode = hashCode * 59 + Unstructured.GetHashCode();
            if (Reference != null) hashCode = hashCode * 59 + Reference.GetHashCode();
            return hashCode;
        }
    }
}
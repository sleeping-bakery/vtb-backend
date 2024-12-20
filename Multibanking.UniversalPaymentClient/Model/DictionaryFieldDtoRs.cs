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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.UniversalPaymentClient.Model;

/// <summary>
///     Тип поля словарь
/// </summary>
[DataContract(Name = "DictionaryFieldDtoRs")]
public class DictionaryFieldDtoRs : IEquatable<DictionaryFieldDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DictionaryFieldDtoRs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DictionaryFieldDtoRs()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DictionaryFieldDtoRs" /> class.
    /// </summary>
    /// <param name="items">Значения словаря для выбора (required).</param>
    public DictionaryFieldDtoRs(List<DictionaryFieldValueDtoRs> items = default)
    {
        // to ensure "items" is required (not null)
        if (items == null) throw new ArgumentNullException("items is a required property for DictionaryFieldDtoRs and cannot be null");
        Items = items;
    }

    /// <summary>
    ///     Значения словаря для выбора
    /// </summary>
    /// <value>Значения словаря для выбора</value>
    [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
    public List<DictionaryFieldValueDtoRs> Items { get; set; }

    /// <summary>
    ///     Returns true if DictionaryFieldDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of DictionaryFieldDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DictionaryFieldDtoRs input)
    {
        if (input == null) return false;
        return
            Items == input.Items ||
            (Items != null &&
             input.Items != null &&
             Items.SequenceEqual(input.Items));
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DictionaryFieldDtoRs {\n");
        sb.Append("  Items: ").Append(Items).Append("\n");
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
        return Equals(input as DictionaryFieldDtoRs);
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
            if (Items != null) hashCode = hashCode * 59 + Items.GetHashCode();
            return hashCode;
        }
    }
}
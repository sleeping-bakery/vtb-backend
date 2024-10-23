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
///     ППУ предоставляет постраничный ответ для операций GET, которые возвращают множественные записи.
/// </summary>
[DataContract(Name = "LinksType")]
public class LinksType : IEquatable<LinksType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="LinksType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected LinksType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="LinksType" /> class.
    /// </summary>
    /// <param name="self">self (required).</param>
    /// <param name="first">first.</param>
    /// <param name="prev">prev.</param>
    /// <param name="next">next.</param>
    /// <param name="last">last.</param>
    public LinksType(string self = default, string first = default, string prev = default, string next = default,
        string last = default)
    {
        // to ensure "self" is required (not null)
        if (self == null)
            throw new ArgumentNullException("self is a required property for LinksType and cannot be null");
        Self = self;
        First = first;
        Prev = prev;
        Next = next;
        Last = last;
    }

    /// <summary>
    ///     Gets or Sets Self
    /// </summary>
    [DataMember(Name = "self", IsRequired = true, EmitDefaultValue = true)]
    public string Self { get; set; }

    /// <summary>
    ///     Gets or Sets First
    /// </summary>
    [DataMember(Name = "first", EmitDefaultValue = false)]
    public string First { get; set; }

    /// <summary>
    ///     Gets or Sets Prev
    /// </summary>
    [DataMember(Name = "prev", EmitDefaultValue = false)]
    public string Prev { get; set; }

    /// <summary>
    ///     Gets or Sets Next
    /// </summary>
    [DataMember(Name = "next", EmitDefaultValue = false)]
    public string Next { get; set; }

    /// <summary>
    ///     Gets or Sets Last
    /// </summary>
    [DataMember(Name = "last", EmitDefaultValue = false)]
    public string Last { get; set; }

    /// <summary>
    ///     Returns true if LinksType instances are equal
    /// </summary>
    /// <param name="input">Instance of LinksType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(LinksType input)
    {
        if (input == null) return false;
        return
            (
                Self == input.Self ||
                (Self != null &&
                 Self.Equals(input.Self))
            ) &&
            (
                First == input.First ||
                (First != null &&
                 First.Equals(input.First))
            ) &&
            (
                Prev == input.Prev ||
                (Prev != null &&
                 Prev.Equals(input.Prev))
            ) &&
            (
                Next == input.Next ||
                (Next != null &&
                 Next.Equals(input.Next))
            ) &&
            (
                Last == input.Last ||
                (Last != null &&
                 Last.Equals(input.Last))
            );
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
        sb.Append("class LinksType {\n");
        sb.Append("  Self: ").Append(Self).Append("\n");
        sb.Append("  First: ").Append(First).Append("\n");
        sb.Append("  Prev: ").Append(Prev).Append("\n");
        sb.Append("  Next: ").Append(Next).Append("\n");
        sb.Append("  Last: ").Append(Last).Append("\n");
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
        return Equals(input as LinksType);
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
            if (Self != null) hashCode = hashCode * 59 + Self.GetHashCode();
            if (First != null) hashCode = hashCode * 59 + First.GetHashCode();
            if (Prev != null) hashCode = hashCode * 59 + Prev.GetHashCode();
            if (Next != null) hashCode = hashCode * 59 + Next.GetHashCode();
            if (Last != null) hashCode = hashCode * 59 + Last.GetHashCode();
            return hashCode;
        }
    }
}
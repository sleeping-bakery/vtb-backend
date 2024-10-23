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
///     ConsentResponse
/// </summary>
[DataContract(Name = "ConsentResponse")]
public class ConsentResponse : IEquatable<ConsentResponse>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ConsentResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConsentResponse()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ConsentResponse" /> class.
    /// </summary>
    /// <param name="data">data (required).</param>
    /// <param name="risk">
    ///     Risk направляется инициирующей стороной на сторону ППУ. Используется для указания дополнительной
    ///     информации для скоринга рисков (required).
    /// </param>
    /// <param name="links">links (required).</param>
    /// <param name="meta">meta (required).</param>
    public ConsentResponse(DataConsentResponseType data = default, object risk = default, LinksType links = default,
        MetaType meta = default)
    {
        // to ensure "data" is required (not null)
        if (data == null)
            throw new ArgumentNullException("data is a required property for ConsentResponse and cannot be null");
        Data = data;
        // to ensure "risk" is required (not null)
        if (risk == null)
            throw new ArgumentNullException("risk is a required property for ConsentResponse and cannot be null");
        Risk = risk;
        // to ensure "links" is required (not null)
        if (links == null)
            throw new ArgumentNullException("links is a required property for ConsentResponse and cannot be null");
        Links = links;
        // to ensure "meta" is required (not null)
        if (meta == null)
            throw new ArgumentNullException("meta is a required property for ConsentResponse and cannot be null");
        Meta = meta;
    }

    /// <summary>
    ///     Gets or Sets Data
    /// </summary>
    [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
    public DataConsentResponseType Data { get; set; }

    /// <summary>
    ///     Risk направляется инициирующей стороной на сторону ППУ. Используется для указания дополнительной информации для
    ///     скоринга рисков
    /// </summary>
    /// <value>
    ///     Risk направляется инициирующей стороной на сторону ППУ. Используется для указания дополнительной информации для
    ///     скоринга рисков
    /// </value>
    [DataMember(Name = "Risk", IsRequired = true, EmitDefaultValue = true)]
    public object Risk { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "Links", IsRequired = true, EmitDefaultValue = true)]
    public LinksType Links { get; set; }

    /// <summary>
    ///     Gets or Sets Meta
    /// </summary>
    [DataMember(Name = "Meta", IsRequired = true, EmitDefaultValue = true)]
    public MetaType Meta { get; set; }

    /// <summary>
    ///     Returns true if ConsentResponse instances are equal
    /// </summary>
    /// <param name="input">Instance of ConsentResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsentResponse input)
    {
        if (input == null) return false;
        return
            (
                Data == input.Data ||
                (Data != null &&
                 Data.Equals(input.Data))
            ) &&
            (
                Risk == input.Risk ||
                (Risk != null &&
                 Risk.Equals(input.Risk))
            ) &&
            (
                Links == input.Links ||
                (Links != null &&
                 Links.Equals(input.Links))
            ) &&
            (
                Meta == input.Meta ||
                (Meta != null &&
                 Meta.Equals(input.Meta))
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
        sb.Append("class ConsentResponse {\n");
        sb.Append("  Data: ").Append(Data).Append("\n");
        sb.Append("  Risk: ").Append(Risk).Append("\n");
        sb.Append("  Links: ").Append(Links).Append("\n");
        sb.Append("  Meta: ").Append(Meta).Append("\n");
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
        return Equals(input as ConsentResponse);
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
            if (Data != null) hashCode = hashCode * 59 + Data.GetHashCode();
            if (Risk != null) hashCode = hashCode * 59 + Risk.GetHashCode();
            if (Links != null) hashCode = hashCode * 59 + Links.GetHashCode();
            if (Meta != null) hashCode = hashCode * 59 + Meta.GetHashCode();
            return hashCode;
        }
    }
}
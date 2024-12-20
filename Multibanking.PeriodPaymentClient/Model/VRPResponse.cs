/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Ответ на запрос создания ресурса ППДС
/// </summary>
[DataContract(Name = "VRPResponse")]
public class VRPResponse : IEquatable<VRPResponse>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected VRPResponse()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPResponse" /> class.
    /// </summary>
    /// <param name="data">data (required).</param>
    /// <param name="risk">risk (required).</param>
    /// <param name="links">links (required).</param>
    /// <param name="meta">meta (required).</param>
    public VRPResponse(VRPResponseData data = default, VRPConsentRequestRisk risk = default, VRPConsentResponseLinks links = default, VRPConsentResponseMeta meta = default)
    {
        // to ensure "data" is required (not null)
        if (data == null) throw new ArgumentNullException("data is a required property for VRPResponse and cannot be null");
        Data = data;
        // to ensure "risk" is required (not null)
        if (risk == null) throw new ArgumentNullException("risk is a required property for VRPResponse and cannot be null");
        Risk = risk;
        // to ensure "links" is required (not null)
        if (links == null) throw new ArgumentNullException("links is a required property for VRPResponse and cannot be null");
        Links = links;
        // to ensure "meta" is required (not null)
        if (meta == null) throw new ArgumentNullException("meta is a required property for VRPResponse and cannot be null");
        Meta = meta;
    }

    /// <summary>
    ///     Gets or Sets Data
    /// </summary>
    [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
    public VRPResponseData Data { get; set; }

    /// <summary>
    ///     Gets or Sets Risk
    /// </summary>
    [DataMember(Name = "Risk", IsRequired = true, EmitDefaultValue = true)]
    public VRPConsentRequestRisk Risk { get; set; }

    /// <summary>
    ///     Gets or Sets Links
    /// </summary>
    [DataMember(Name = "Links", IsRequired = true, EmitDefaultValue = true)]
    public VRPConsentResponseLinks Links { get; set; }

    /// <summary>
    ///     Gets or Sets Meta
    /// </summary>
    [DataMember(Name = "Meta", IsRequired = true, EmitDefaultValue = true)]
    public VRPConsentResponseMeta Meta { get; set; }

    /// <summary>
    ///     Returns true if VRPResponse instances are equal
    /// </summary>
    /// <param name="input">Instance of VRPResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VRPResponse input)
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
        sb.Append("class VRPResponse {\n");
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
        return Equals(input as VRPResponse);
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
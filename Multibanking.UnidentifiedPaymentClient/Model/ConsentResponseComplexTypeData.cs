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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.UnidentifiedPaymentClient.Model;

/// <summary>
///     ConsentResponseComplexTypeData
/// </summary>
[DataContract(Name = "ConsentResponseComplexType_Data")]
public class ConsentResponseComplexTypeData : IEquatable<ConsentResponseComplexTypeData>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ConsentResponseComplexTypeData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ConsentResponseComplexTypeData()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ConsentResponseComplexTypeData" /> class.
    /// </summary>
    /// <param name="consentId">Идентификатор ресурса согласия на проведение платежа, присвоенный на стороне ППУ. (required).</param>
    /// <param name="creationDateTime">Дата и время создания ресурса согласия на проведение платежа. (required).</param>
    /// <param name="status">Текущий статус ресурса согласия на проведение платежа. (required).</param>
    /// <param name="statusUpdateDateTime">Дата и время обновления статуса ресурса согласия на проведение платежа. (required).</param>
    /// <param name="cutOffDateTime">Дата и время актуальности согласия на проведение платежа (после этого согласие является не действующим)..</param>
    /// <param name="expectedExecutionDateTime">Ожидаемая дата и время исполнения платежа (платежного ресурса)..</param>
    /// <param name="expectedSettlementDateTime">Ожидаемая дата и время расчета платежа (платежного ресурса)..</param>
    /// <param name="charges">Сборы при проведении платежа..</param>
    /// <param name="initiation">initiation (required).</param>
    /// <param name="authorisation">authorisation.</param>
    /// <param name="sCASupportData">sCASupportData.</param>
    public ConsentResponseComplexTypeData(string consentId = default, DateTime creationDateTime = default, ConsentStatusStaticType status = default,
        DateTime statusUpdateDateTime = default, DateTime cutOffDateTime = default, DateTime expectedExecutionDateTime = default, DateTime expectedSettlementDateTime = default,
        List<ChargeComplexType> charges = default, DataConsentRequestComplexTypeInitiation initiation = default, DataConsentRequestComplexTypeAuthorisation authorisation = default,
        DataConsentRequestComplexTypeSCASupportData sCASupportData = default)
    {
        // to ensure "consentId" is required (not null)
        if (consentId == null) throw new ArgumentNullException("consentId is a required property for ConsentResponseComplexTypeData and cannot be null");
        ConsentId = consentId;
        CreationDateTime = creationDateTime;
        Status = status;
        StatusUpdateDateTime = statusUpdateDateTime;
        // to ensure "initiation" is required (not null)
        if (initiation == null) throw new ArgumentNullException("initiation is a required property for ConsentResponseComplexTypeData and cannot be null");
        Initiation = initiation;
        CutOffDateTime = cutOffDateTime;
        ExpectedExecutionDateTime = expectedExecutionDateTime;
        ExpectedSettlementDateTime = expectedSettlementDateTime;
        Charges = charges;
        Authorisation = authorisation;
        SCASupportData = sCASupportData;
    }

    /// <summary>
    ///     Текущий статус ресурса согласия на проведение платежа.
    /// </summary>
    /// <value>Текущий статус ресурса согласия на проведение платежа.</value>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public ConsentStatusStaticType Status { get; set; }

    /// <summary>
    ///     Идентификатор ресурса согласия на проведение платежа, присвоенный на стороне ППУ.
    /// </summary>
    /// <value>Идентификатор ресурса согласия на проведение платежа, присвоенный на стороне ППУ.</value>
    [DataMember(Name = "consentId", IsRequired = true, EmitDefaultValue = true)]
    public string ConsentId { get; set; }

    /// <summary>
    ///     Дата и время создания ресурса согласия на проведение платежа.
    /// </summary>
    /// <value>Дата и время создания ресурса согласия на проведение платежа.</value>
    [DataMember(Name = "creationDateTime", IsRequired = true, EmitDefaultValue = true)]
    public DateTime CreationDateTime { get; set; }

    /// <summary>
    ///     Дата и время обновления статуса ресурса согласия на проведение платежа.
    /// </summary>
    /// <value>Дата и время обновления статуса ресурса согласия на проведение платежа.</value>
    [DataMember(Name = "statusUpdateDateTime", IsRequired = true, EmitDefaultValue = true)]
    public DateTime StatusUpdateDateTime { get; set; }

    /// <summary>
    ///     Дата и время актуальности согласия на проведение платежа (после этого согласие является не действующим).
    /// </summary>
    /// <value>Дата и время актуальности согласия на проведение платежа (после этого согласие является не действующим).</value>
    [DataMember(Name = "cutOffDateTime", EmitDefaultValue = false)]
    public DateTime CutOffDateTime { get; set; }

    /// <summary>
    ///     Ожидаемая дата и время исполнения платежа (платежного ресурса).
    /// </summary>
    /// <value>Ожидаемая дата и время исполнения платежа (платежного ресурса).</value>
    [DataMember(Name = "expectedExecutionDateTime", EmitDefaultValue = false)]
    public DateTime ExpectedExecutionDateTime { get; set; }

    /// <summary>
    ///     Ожидаемая дата и время расчета платежа (платежного ресурса).
    /// </summary>
    /// <value>Ожидаемая дата и время расчета платежа (платежного ресурса).</value>
    [DataMember(Name = "expectedSettlementDateTime", EmitDefaultValue = false)]
    public DateTime ExpectedSettlementDateTime { get; set; }

    /// <summary>
    ///     Сборы при проведении платежа.
    /// </summary>
    /// <value>Сборы при проведении платежа.</value>
    [DataMember(Name = "Charges", EmitDefaultValue = false)]
    public List<ChargeComplexType> Charges { get; set; }

    /// <summary>
    ///     Gets or Sets Initiation
    /// </summary>
    [DataMember(Name = "Initiation", IsRequired = true, EmitDefaultValue = true)]
    public DataConsentRequestComplexTypeInitiation Initiation { get; set; }

    /// <summary>
    ///     Gets or Sets Authorisation
    /// </summary>
    [DataMember(Name = "Authorisation", EmitDefaultValue = false)]
    public DataConsentRequestComplexTypeAuthorisation Authorisation { get; set; }

    /// <summary>
    ///     Gets or Sets SCASupportData
    /// </summary>
    [DataMember(Name = "SCASupportData", EmitDefaultValue = false)]
    public DataConsentRequestComplexTypeSCASupportData SCASupportData { get; set; }

    /// <summary>
    ///     Returns true if ConsentResponseComplexTypeData instances are equal
    /// </summary>
    /// <param name="input">Instance of ConsentResponseComplexTypeData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ConsentResponseComplexTypeData input)
    {
        if (input == null) return false;
        return
            (
                ConsentId == input.ConsentId ||
                (ConsentId != null &&
                 ConsentId.Equals(input.ConsentId))
            ) &&
            (
                CreationDateTime == input.CreationDateTime ||
                (CreationDateTime != null &&
                 CreationDateTime.Equals(input.CreationDateTime))
            ) &&
            (
                Status == input.Status ||
                Status.Equals(input.Status)
            ) &&
            (
                StatusUpdateDateTime == input.StatusUpdateDateTime ||
                (StatusUpdateDateTime != null &&
                 StatusUpdateDateTime.Equals(input.StatusUpdateDateTime))
            ) &&
            (
                CutOffDateTime == input.CutOffDateTime ||
                (CutOffDateTime != null &&
                 CutOffDateTime.Equals(input.CutOffDateTime))
            ) &&
            (
                ExpectedExecutionDateTime == input.ExpectedExecutionDateTime ||
                (ExpectedExecutionDateTime != null &&
                 ExpectedExecutionDateTime.Equals(input.ExpectedExecutionDateTime))
            ) &&
            (
                ExpectedSettlementDateTime == input.ExpectedSettlementDateTime ||
                (ExpectedSettlementDateTime != null &&
                 ExpectedSettlementDateTime.Equals(input.ExpectedSettlementDateTime))
            ) &&
            (
                Charges == input.Charges ||
                (Charges != null &&
                 input.Charges != null &&
                 Charges.SequenceEqual(input.Charges))
            ) &&
            (
                Initiation == input.Initiation ||
                (Initiation != null &&
                 Initiation.Equals(input.Initiation))
            ) &&
            (
                Authorisation == input.Authorisation ||
                (Authorisation != null &&
                 Authorisation.Equals(input.Authorisation))
            ) &&
            (
                SCASupportData == input.SCASupportData ||
                (SCASupportData != null &&
                 SCASupportData.Equals(input.SCASupportData))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // ConsentId (string) maxLength
        if (ConsentId != null && ConsentId.Length > 128) yield return new ValidationResult("Invalid value for ConsentId, length must be less than 128.", new[] { "ConsentId" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class ConsentResponseComplexTypeData {\n");
        sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
        sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  StatusUpdateDateTime: ").Append(StatusUpdateDateTime).Append("\n");
        sb.Append("  CutOffDateTime: ").Append(CutOffDateTime).Append("\n");
        sb.Append("  ExpectedExecutionDateTime: ").Append(ExpectedExecutionDateTime).Append("\n");
        sb.Append("  ExpectedSettlementDateTime: ").Append(ExpectedSettlementDateTime).Append("\n");
        sb.Append("  Charges: ").Append(Charges).Append("\n");
        sb.Append("  Initiation: ").Append(Initiation).Append("\n");
        sb.Append("  Authorisation: ").Append(Authorisation).Append("\n");
        sb.Append("  SCASupportData: ").Append(SCASupportData).Append("\n");
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
        return Equals(input as ConsentResponseComplexTypeData);
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
            if (ConsentId != null) hashCode = hashCode * 59 + ConsentId.GetHashCode();
            if (CreationDateTime != null) hashCode = hashCode * 59 + CreationDateTime.GetHashCode();
            hashCode = hashCode * 59 + Status.GetHashCode();
            if (StatusUpdateDateTime != null) hashCode = hashCode * 59 + StatusUpdateDateTime.GetHashCode();
            if (CutOffDateTime != null) hashCode = hashCode * 59 + CutOffDateTime.GetHashCode();
            if (ExpectedExecutionDateTime != null) hashCode = hashCode * 59 + ExpectedExecutionDateTime.GetHashCode();
            if (ExpectedSettlementDateTime != null) hashCode = hashCode * 59 + ExpectedSettlementDateTime.GetHashCode();
            if (Charges != null) hashCode = hashCode * 59 + Charges.GetHashCode();
            if (Initiation != null) hashCode = hashCode * 59 + Initiation.GetHashCode();
            if (Authorisation != null) hashCode = hashCode * 59 + Authorisation.GetHashCode();
            if (SCASupportData != null) hashCode = hashCode * 59 + SCASupportData.GetHashCode();
            return hashCode;
        }
    }
}
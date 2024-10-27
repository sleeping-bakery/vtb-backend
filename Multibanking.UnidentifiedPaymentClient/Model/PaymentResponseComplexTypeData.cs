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
///     PaymentResponseComplexTypeData
/// </summary>
[DataContract(Name = "PaymentResponseComplexType_Data")]
public class PaymentResponseComplexTypeData : IEquatable<PaymentResponseComplexTypeData>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PaymentResponseComplexTypeData" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PaymentResponseComplexTypeData()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="PaymentResponseComplexTypeData" /> class.
    /// </summary>
    /// <param name="paymentId">paymentId (required).</param>
    /// <param name="consentId">Идентификатор ресурса согласия на проведение платежа, присвоенный на стороне ППУ. (required).</param>
    /// <param name="creationDateTime">Дата и время создания ресурса согласия на проведение платежа. (required).</param>
    /// <param name="status">Текущий статус ресурса согласия на проведение платежа. (required).</param>
    /// <param name="statusUpdateDateTime">Дата и время обновления статуса ресурса согласия на проведение платежа. (required).</param>
    /// <param name="expectedExecutionDateTime">Ожидаемая дата и время исполнения платежа (платежного ресурса)..</param>
    /// <param name="expectedSettlementDateTime">Ожидаемая дата и время расчета платежа (платежного ресурса)..</param>
    /// <param name="charges">Сборы при проведении платежа..</param>
    /// <param name="initiation">initiation (required).</param>
    /// <param name="multiAuthorisation">multiAuthorisation.</param>
    public PaymentResponseComplexTypeData(string paymentId = default, string consentId = default, DateTime creationDateTime = default, TransactionStatusStaticType status = default,
        DateTime statusUpdateDateTime = default, DateTime expectedExecutionDateTime = default, DateTime expectedSettlementDateTime = default,
        List<ChargeComplexType> charges = default, DataConsentRequestComplexTypeInitiation initiation = default,
        DataPaymentResponseComplexTypeMultiAuthorisation multiAuthorisation = default)
    {
        // to ensure "paymentId" is required (not null)
        if (paymentId == null) throw new ArgumentNullException("paymentId is a required property for PaymentResponseComplexTypeData and cannot be null");
        PaymentId = paymentId;
        // to ensure "consentId" is required (not null)
        if (consentId == null) throw new ArgumentNullException("consentId is a required property for PaymentResponseComplexTypeData and cannot be null");
        ConsentId = consentId;
        CreationDateTime = creationDateTime;
        Status = status;
        StatusUpdateDateTime = statusUpdateDateTime;
        // to ensure "initiation" is required (not null)
        if (initiation == null) throw new ArgumentNullException("initiation is a required property for PaymentResponseComplexTypeData and cannot be null");
        Initiation = initiation;
        ExpectedExecutionDateTime = expectedExecutionDateTime;
        ExpectedSettlementDateTime = expectedSettlementDateTime;
        Charges = charges;
        MultiAuthorisation = multiAuthorisation;
    }

    /// <summary>
    ///     Текущий статус ресурса согласия на проведение платежа.
    /// </summary>
    /// <value>Текущий статус ресурса согласия на проведение платежа.</value>
    [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
    public TransactionStatusStaticType Status { get; set; }

    /// <summary>
    ///     Gets or Sets PaymentId
    /// </summary>
    [DataMember(Name = "paymentId", IsRequired = true, EmitDefaultValue = true)]
    public string PaymentId { get; set; }

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
    ///     Gets or Sets MultiAuthorisation
    /// </summary>
    [DataMember(Name = "MultiAuthorisation", EmitDefaultValue = false)]
    public DataPaymentResponseComplexTypeMultiAuthorisation MultiAuthorisation { get; set; }

    /// <summary>
    ///     Returns true if PaymentResponseComplexTypeData instances are equal
    /// </summary>
    /// <param name="input">Instance of PaymentResponseComplexTypeData to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PaymentResponseComplexTypeData input)
    {
        if (input == null) return false;
        return
            (
                PaymentId == input.PaymentId ||
                (PaymentId != null &&
                 PaymentId.Equals(input.PaymentId))
            ) &&
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
                MultiAuthorisation == input.MultiAuthorisation ||
                (MultiAuthorisation != null &&
                 MultiAuthorisation.Equals(input.MultiAuthorisation))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // PaymentId (string) maxLength
        if (PaymentId != null && PaymentId.Length > 128) yield return new ValidationResult("Invalid value for PaymentId, length must be less than 128.", new[] { "PaymentId" });

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
        sb.Append("class PaymentResponseComplexTypeData {\n");
        sb.Append("  PaymentId: ").Append(PaymentId).Append("\n");
        sb.Append("  ConsentId: ").Append(ConsentId).Append("\n");
        sb.Append("  CreationDateTime: ").Append(CreationDateTime).Append("\n");
        sb.Append("  Status: ").Append(Status).Append("\n");
        sb.Append("  StatusUpdateDateTime: ").Append(StatusUpdateDateTime).Append("\n");
        sb.Append("  ExpectedExecutionDateTime: ").Append(ExpectedExecutionDateTime).Append("\n");
        sb.Append("  ExpectedSettlementDateTime: ").Append(ExpectedSettlementDateTime).Append("\n");
        sb.Append("  Charges: ").Append(Charges).Append("\n");
        sb.Append("  Initiation: ").Append(Initiation).Append("\n");
        sb.Append("  MultiAuthorisation: ").Append(MultiAuthorisation).Append("\n");
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
        return Equals(input as PaymentResponseComplexTypeData);
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
            if (PaymentId != null) hashCode = hashCode * 59 + PaymentId.GetHashCode();
            if (ConsentId != null) hashCode = hashCode * 59 + ConsentId.GetHashCode();
            if (CreationDateTime != null) hashCode = hashCode * 59 + CreationDateTime.GetHashCode();
            hashCode = hashCode * 59 + Status.GetHashCode();
            if (StatusUpdateDateTime != null) hashCode = hashCode * 59 + StatusUpdateDateTime.GetHashCode();
            if (ExpectedExecutionDateTime != null) hashCode = hashCode * 59 + ExpectedExecutionDateTime.GetHashCode();
            if (ExpectedSettlementDateTime != null) hashCode = hashCode * 59 + ExpectedSettlementDateTime.GetHashCode();
            if (Charges != null) hashCode = hashCode * 59 + Charges.GetHashCode();
            if (Initiation != null) hashCode = hashCode * 59 + Initiation.GetHashCode();
            if (MultiAuthorisation != null) hashCode = hashCode * 59 + MultiAuthorisation.GetHashCode();
            return hashCode;
        }
    }
}
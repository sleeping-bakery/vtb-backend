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
///     Полезная нагрузка отправляется инициирующей стороной в ППУ. Используется для запроса перевода средств со счета плательщика на счет получателя для одиночного внутреннего
///     платежа.
/// </summary>
[DataContract(Name = "DataConsentRequestComplexType_Initiation")]
public class DataConsentRequestComplexTypeInitiation : IEquatable<DataConsentRequestComplexTypeInitiation>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DataConsentRequestComplexTypeInitiation" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DataConsentRequestComplexTypeInitiation()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DataConsentRequestComplexTypeInitiation" /> class.
    /// </summary>
    /// <param name="instructionIdentification">
    ///     Уникальный идентификатор, присвоенный инструктирующей стороной для инструктируемой стороны для однозначного определения инструкции.
    ///     (required).
    /// </param>
    /// <param name="endToEndIdentification">
    ///     Уникальный идентификатор, присвоенный инициирующей стороной для однозначного определения транзакции. Эта идентификация передается без
    ///     изменений по всей сквозной цепочке. Использование: сквозная идентификация может использоваться для выверки или связывания задач, относящихся к транзакции. Это может быть
    ///     включено в несколько сообщений, связанных с транзакцией. (required).
    /// </param>
    /// <param name="localInstrument">
    ///     Этот элемент используется для указания локального инструмента, опции локального клиринга и / или дальнейшей квалификации услуги или уровня
    ///     обслуживания..
    /// </param>
    /// <param name="instructedAmount">instructedAmount (required).</param>
    /// <param name="debtorAccount">debtorAccount.</param>
    /// <param name="creditorParty">creditorParty.</param>
    /// <param name="creditorAgent">creditorAgent.</param>
    /// <param name="creditorAccount">creditorAccount (required).</param>
    /// <param name="remittanceInformation">remittanceInformation.</param>
    public DataConsentRequestComplexTypeInitiation(string instructionIdentification = default, string endToEndIdentification = default,
        ExternalLocalInstrument1Code? localInstrument = default, InitiationComplexTypeInstructedAmount instructedAmount = default,
        InitiationComplexTypeDebtorAccount debtorAccount = default, InitiationComplexTypeCreditorParty creditorParty = default,
        InitiationComplexTypeCreditorAgent creditorAgent = default, InitiationComplexTypeCreditorAccount creditorAccount = default,
        InitiationComplexTypeRemittanceInformation remittanceInformation = default)
    {
        // to ensure "instructionIdentification" is required (not null)
        if (instructionIdentification == null)
            throw new ArgumentNullException("instructionIdentification is a required property for DataConsentRequestComplexTypeInitiation and cannot be null");
        InstructionIdentification = instructionIdentification;
        // to ensure "endToEndIdentification" is required (not null)
        if (endToEndIdentification == null)
            throw new ArgumentNullException("endToEndIdentification is a required property for DataConsentRequestComplexTypeInitiation and cannot be null");
        EndToEndIdentification = endToEndIdentification;
        // to ensure "instructedAmount" is required (not null)
        if (instructedAmount == null) throw new ArgumentNullException("instructedAmount is a required property for DataConsentRequestComplexTypeInitiation and cannot be null");
        InstructedAmount = instructedAmount;
        // to ensure "creditorAccount" is required (not null)
        if (creditorAccount == null) throw new ArgumentNullException("creditorAccount is a required property for DataConsentRequestComplexTypeInitiation and cannot be null");
        CreditorAccount = creditorAccount;
        LocalInstrument = localInstrument;
        DebtorAccount = debtorAccount;
        CreditorParty = creditorParty;
        CreditorAgent = creditorAgent;
        RemittanceInformation = remittanceInformation;
    }

    /// <summary>
    ///     Этот элемент используется для указания локального инструмента, опции локального клиринга и / или дальнейшей квалификации услуги или уровня обслуживания.
    /// </summary>
    /// <value>Этот элемент используется для указания локального инструмента, опции локального клиринга и / или дальнейшей квалификации услуги или уровня обслуживания.</value>
    [DataMember(Name = "localInstrument", EmitDefaultValue = false)]
    public ExternalLocalInstrument1Code? LocalInstrument { get; set; }

    /// <summary>
    ///     Уникальный идентификатор, присвоенный инструктирующей стороной для инструктируемой стороны для однозначного определения инструкции.
    /// </summary>
    /// <value>Уникальный идентификатор, присвоенный инструктирующей стороной для инструктируемой стороны для однозначного определения инструкции.</value>
    [DataMember(Name = "instructionIdentification", IsRequired = true, EmitDefaultValue = true)]
    public string InstructionIdentification { get; set; }

    /// <summary>
    ///     Уникальный идентификатор, присвоенный инициирующей стороной для однозначного определения транзакции. Эта идентификация передается без изменений по всей сквозной цепочке.
    ///     Использование: сквозная идентификация может использоваться для выверки или связывания задач, относящихся к транзакции. Это может быть включено в несколько сообщений, связанных
    ///     с транзакцией.
    /// </summary>
    /// <value>
    ///     Уникальный идентификатор, присвоенный инициирующей стороной для однозначного определения транзакции. Эта идентификация передается без изменений по всей сквозной цепочке.
    ///     Использование: сквозная идентификация может использоваться для выверки или связывания задач, относящихся к транзакции. Это может быть включено в несколько сообщений, связанных
    ///     с транзакцией.
    /// </value>
    [DataMember(Name = "endToEndIdentification", IsRequired = true, EmitDefaultValue = true)]
    public string EndToEndIdentification { get; set; }

    /// <summary>
    ///     Gets or Sets InstructedAmount
    /// </summary>
    [DataMember(Name = "InstructedAmount", IsRequired = true, EmitDefaultValue = true)]
    public InitiationComplexTypeInstructedAmount InstructedAmount { get; set; }

    /// <summary>
    ///     Gets or Sets DebtorAccount
    /// </summary>
    [DataMember(Name = "DebtorAccount", EmitDefaultValue = false)]
    public InitiationComplexTypeDebtorAccount DebtorAccount { get; set; }

    /// <summary>
    ///     Gets or Sets CreditorParty
    /// </summary>
    [DataMember(Name = "CreditorParty", EmitDefaultValue = false)]
    public InitiationComplexTypeCreditorParty CreditorParty { get; set; }

    /// <summary>
    ///     Gets or Sets CreditorAgent
    /// </summary>
    [DataMember(Name = "CreditorAgent", EmitDefaultValue = false)]
    public InitiationComplexTypeCreditorAgent CreditorAgent { get; set; }

    /// <summary>
    ///     Gets or Sets CreditorAccount
    /// </summary>
    [DataMember(Name = "CreditorAccount", IsRequired = true, EmitDefaultValue = true)]
    public InitiationComplexTypeCreditorAccount CreditorAccount { get; set; }

    /// <summary>
    ///     Gets or Sets RemittanceInformation
    /// </summary>
    [DataMember(Name = "RemittanceInformation", EmitDefaultValue = false)]
    public InitiationComplexTypeRemittanceInformation RemittanceInformation { get; set; }

    /// <summary>
    ///     Returns true if DataConsentRequestComplexTypeInitiation instances are equal
    /// </summary>
    /// <param name="input">Instance of DataConsentRequestComplexTypeInitiation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataConsentRequestComplexTypeInitiation input)
    {
        if (input == null) return false;
        return
            (
                InstructionIdentification == input.InstructionIdentification ||
                (InstructionIdentification != null &&
                 InstructionIdentification.Equals(input.InstructionIdentification))
            ) &&
            (
                EndToEndIdentification == input.EndToEndIdentification ||
                (EndToEndIdentification != null &&
                 EndToEndIdentification.Equals(input.EndToEndIdentification))
            ) &&
            (
                LocalInstrument == input.LocalInstrument ||
                LocalInstrument.Equals(input.LocalInstrument)
            ) &&
            (
                InstructedAmount == input.InstructedAmount ||
                (InstructedAmount != null &&
                 InstructedAmount.Equals(input.InstructedAmount))
            ) &&
            (
                DebtorAccount == input.DebtorAccount ||
                (DebtorAccount != null &&
                 DebtorAccount.Equals(input.DebtorAccount))
            ) &&
            (
                CreditorParty == input.CreditorParty ||
                (CreditorParty != null &&
                 CreditorParty.Equals(input.CreditorParty))
            ) &&
            (
                CreditorAgent == input.CreditorAgent ||
                (CreditorAgent != null &&
                 CreditorAgent.Equals(input.CreditorAgent))
            ) &&
            (
                CreditorAccount == input.CreditorAccount ||
                (CreditorAccount != null &&
                 CreditorAccount.Equals(input.CreditorAccount))
            ) &&
            (
                RemittanceInformation == input.RemittanceInformation ||
                (RemittanceInformation != null &&
                 RemittanceInformation.Equals(input.RemittanceInformation))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // InstructionIdentification (string) maxLength
        if (InstructionIdentification != null && InstructionIdentification.Length > 35)
            yield return new ValidationResult("Invalid value for InstructionIdentification, length must be less than 35.", new[] { "InstructionIdentification" });

        // EndToEndIdentification (string) maxLength
        if (EndToEndIdentification != null && EndToEndIdentification.Length > 35)
            yield return new ValidationResult("Invalid value for EndToEndIdentification, length must be less than 35.", new[] { "EndToEndIdentification" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class DataConsentRequestComplexTypeInitiation {\n");
        sb.Append("  InstructionIdentification: ").Append(InstructionIdentification).Append("\n");
        sb.Append("  EndToEndIdentification: ").Append(EndToEndIdentification).Append("\n");
        sb.Append("  LocalInstrument: ").Append(LocalInstrument).Append("\n");
        sb.Append("  InstructedAmount: ").Append(InstructedAmount).Append("\n");
        sb.Append("  DebtorAccount: ").Append(DebtorAccount).Append("\n");
        sb.Append("  CreditorParty: ").Append(CreditorParty).Append("\n");
        sb.Append("  CreditorAgent: ").Append(CreditorAgent).Append("\n");
        sb.Append("  CreditorAccount: ").Append(CreditorAccount).Append("\n");
        sb.Append("  RemittanceInformation: ").Append(RemittanceInformation).Append("\n");
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
        return Equals(input as DataConsentRequestComplexTypeInitiation);
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
            if (InstructionIdentification != null) hashCode = hashCode * 59 + InstructionIdentification.GetHashCode();
            if (EndToEndIdentification != null) hashCode = hashCode * 59 + EndToEndIdentification.GetHashCode();
            hashCode = hashCode * 59 + LocalInstrument.GetHashCode();
            if (InstructedAmount != null) hashCode = hashCode * 59 + InstructedAmount.GetHashCode();
            if (DebtorAccount != null) hashCode = hashCode * 59 + DebtorAccount.GetHashCode();
            if (CreditorParty != null) hashCode = hashCode * 59 + CreditorParty.GetHashCode();
            if (CreditorAgent != null) hashCode = hashCode * 59 + CreditorAgent.GetHashCode();
            if (CreditorAccount != null) hashCode = hashCode * 59 + CreditorAccount.GetHashCode();
            if (RemittanceInformation != null) hashCode = hashCode * 59 + RemittanceInformation.GetHashCode();
            return hashCode;
        }
    }
}
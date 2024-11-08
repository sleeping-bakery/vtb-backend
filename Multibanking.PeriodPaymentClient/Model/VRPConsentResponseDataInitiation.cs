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
///     Реквизиты платежного распоряжения, которые должны быть привязаны к Согласию на инициирование и оставаться неизменными для каждого ППДС
/// </summary>
[DataContract(Name = "VRPConsentResponse_Data_Initiation")]
public class VRPConsentResponseDataInitiation : IEquatable<VRPConsentResponseDataInitiation>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPConsentResponseDataInitiation" /> class.
    /// </summary>
    /// <param name="debtorAccount">debtorAccount.</param>
    /// <param name="creditorAgent">creditorAgent.</param>
    /// <param name="creditorAccount">creditorAccount.</param>
    /// <param name="creditorAgentAccount">creditorAgentAccount.</param>
    /// <param name="creditor">creditor.</param>
    /// <param name="remittanceInformation">remittanceInformation.</param>
    public VRPConsentResponseDataInitiation(VRPInitiationDebtorAccount debtorAccount = default, VRPInitiationCreditorAgent creditorAgent = default,
        VRPInitiationCreditorAccount creditorAccount = default, VRPInitiationCreditorAgentAccount creditorAgentAccount = default, VRPInitiationCreditor creditor = default,
        VRPInitiationRemittanceInformation remittanceInformation = default)
    {
        DebtorAccount = debtorAccount;
        CreditorAgent = creditorAgent;
        CreditorAccount = creditorAccount;
        CreditorAgentAccount = creditorAgentAccount;
        Creditor = creditor;
        RemittanceInformation = remittanceInformation;
    }

    /// <summary>
    ///     Gets or Sets DebtorAccount
    /// </summary>
    [DataMember(Name = "DebtorAccount", EmitDefaultValue = false)]
    public VRPInitiationDebtorAccount DebtorAccount { get; set; }

    /// <summary>
    ///     Gets or Sets CreditorAgent
    /// </summary>
    [DataMember(Name = "CreditorAgent", EmitDefaultValue = false)]
    public VRPInitiationCreditorAgent CreditorAgent { get; set; }

    /// <summary>
    ///     Gets or Sets CreditorAccount
    /// </summary>
    [DataMember(Name = "CreditorAccount", EmitDefaultValue = false)]
    public VRPInitiationCreditorAccount CreditorAccount { get; set; }

    /// <summary>
    ///     Gets or Sets CreditorAgentAccount
    /// </summary>
    [DataMember(Name = "CreditorAgentAccount", EmitDefaultValue = false)]
    public VRPInitiationCreditorAgentAccount CreditorAgentAccount { get; set; }

    /// <summary>
    ///     Gets or Sets Creditor
    /// </summary>
    [DataMember(Name = "Creditor", EmitDefaultValue = false)]
    public VRPInitiationCreditor Creditor { get; set; }

    /// <summary>
    ///     Gets or Sets RemittanceInformation
    /// </summary>
    [DataMember(Name = "RemittanceInformation", EmitDefaultValue = false)]
    public VRPInitiationRemittanceInformation RemittanceInformation { get; set; }

    /// <summary>
    ///     Returns true if VRPConsentResponseDataInitiation instances are equal
    /// </summary>
    /// <param name="input">Instance of VRPConsentResponseDataInitiation to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VRPConsentResponseDataInitiation input)
    {
        if (input == null) return false;
        return
            (
                DebtorAccount == input.DebtorAccount ||
                (DebtorAccount != null &&
                 DebtorAccount.Equals(input.DebtorAccount))
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
                CreditorAgentAccount == input.CreditorAgentAccount ||
                (CreditorAgentAccount != null &&
                 CreditorAgentAccount.Equals(input.CreditorAgentAccount))
            ) &&
            (
                Creditor == input.Creditor ||
                (Creditor != null &&
                 Creditor.Equals(input.Creditor))
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
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VRPConsentResponseDataInitiation {\n");
        sb.Append("  DebtorAccount: ").Append(DebtorAccount).Append("\n");
        sb.Append("  CreditorAgent: ").Append(CreditorAgent).Append("\n");
        sb.Append("  CreditorAccount: ").Append(CreditorAccount).Append("\n");
        sb.Append("  CreditorAgentAccount: ").Append(CreditorAgentAccount).Append("\n");
        sb.Append("  Creditor: ").Append(Creditor).Append("\n");
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
        return Equals(input as VRPConsentResponseDataInitiation);
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
            if (DebtorAccount != null) hashCode = hashCode * 59 + DebtorAccount.GetHashCode();
            if (CreditorAgent != null) hashCode = hashCode * 59 + CreditorAgent.GetHashCode();
            if (CreditorAccount != null) hashCode = hashCode * 59 + CreditorAccount.GetHashCode();
            if (CreditorAgentAccount != null) hashCode = hashCode * 59 + CreditorAgentAccount.GetHashCode();
            if (Creditor != null) hashCode = hashCode * 59 + Creditor.GetHashCode();
            if (RemittanceInformation != null) hashCode = hashCode * 59 + RemittanceInformation.GetHashCode();
            return hashCode;
        }
    }
}
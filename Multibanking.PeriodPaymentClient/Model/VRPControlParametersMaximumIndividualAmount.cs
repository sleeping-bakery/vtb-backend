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
///     Максимальная сумма единичного  перевода денежных средств
/// </summary>
[DataContract(Name = "VRPControlParameters_MaximumIndividualAmount")]
public class VRPControlParametersMaximumIndividualAmount : IEquatable<VRPControlParametersMaximumIndividualAmount>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPControlParametersMaximumIndividualAmount" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected VRPControlParametersMaximumIndividualAmount()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPControlParametersMaximumIndividualAmount" /> class.
    /// </summary>
    /// <param name="amount">Сумма денежных средств (required).</param>
    /// <param name="currency">Код валюты, соответствующий международного стандарта ISO 4217 (required).</param>
    public VRPControlParametersMaximumIndividualAmount(string amount = default, string currency = default)
    {
        // to ensure "amount" is required (not null)
        if (amount == null) throw new ArgumentNullException("amount is a required property for VRPControlParametersMaximumIndividualAmount and cannot be null");
        Amount = amount;
        // to ensure "currency" is required (not null)
        if (currency == null) throw new ArgumentNullException("currency is a required property for VRPControlParametersMaximumIndividualAmount and cannot be null");
        Currency = currency;
    }

    /// <summary>
    ///     Сумма денежных средств
    /// </summary>
    /// <value>Сумма денежных средств</value>
    [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
    public string Amount { get; set; }

    /// <summary>
    ///     Код валюты, соответствующий международного стандарта ISO 4217
    /// </summary>
    /// <value>Код валюты, соответствующий международного стандарта ISO 4217</value>
    [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
    public string Currency { get; set; }

    /// <summary>
    ///     Returns true if VRPControlParametersMaximumIndividualAmount instances are equal
    /// </summary>
    /// <param name="input">Instance of VRPControlParametersMaximumIndividualAmount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VRPControlParametersMaximumIndividualAmount input)
    {
        if (input == null) return false;
        return
            (
                Amount == input.Amount ||
                (Amount != null &&
                 Amount.Equals(input.Amount))
            ) &&
            (
                Currency == input.Currency ||
                (Currency != null &&
                 Currency.Equals(input.Currency))
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
        sb.Append("class VRPControlParametersMaximumIndividualAmount {\n");
        sb.Append("  Amount: ").Append(Amount).Append("\n");
        sb.Append("  Currency: ").Append(Currency).Append("\n");
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
        return Equals(input as VRPControlParametersMaximumIndividualAmount);
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
            if (Amount != null) hashCode = hashCode * 59 + Amount.GetHashCode();
            if (Currency != null) hashCode = hashCode * 59 + Currency.GetHashCode();
            return hashCode;
        }
    }
}
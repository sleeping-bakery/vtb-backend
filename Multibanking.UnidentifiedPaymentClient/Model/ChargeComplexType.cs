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
///     Набор элементов, используемый для предоставления деталей о плате за инициацию платежа. Сколько будет стоит для пользователя проведение платежа.
/// </summary>
[DataContract(Name = "ChargeComplexType")]
public class ChargeComplexType : IEquatable<ChargeComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ChargeComplexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected ChargeComplexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="ChargeComplexType" /> class.
    /// </summary>
    /// <param name="chargeBearer">chargeBearer (required).</param>
    /// <param name="type">type (required).</param>
    /// <param name="amount">amount (required).</param>
    public ChargeComplexType(ChargeBearerType1Code chargeBearer = default, ExternalChargeType1Code type = default, ActiveOrHistoricCurrencyAndAmount amount = default)
    {
        ChargeBearer = chargeBearer;
        Type = type;
        // to ensure "amount" is required (not null)
        if (amount == null) throw new ArgumentNullException("amount is a required property for ChargeComplexType and cannot be null");
        Amount = amount;
    }

    /// <summary>
    ///     Gets or Sets ChargeBearer
    /// </summary>
    [DataMember(Name = "chargeBearer", IsRequired = true, EmitDefaultValue = true)]
    public ChargeBearerType1Code ChargeBearer { get; set; }

    /// <summary>
    ///     Gets or Sets Type
    /// </summary>
    [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
    public ExternalChargeType1Code Type { get; set; }

    /// <summary>
    ///     Gets or Sets Amount
    /// </summary>
    [DataMember(Name = "Amount", IsRequired = true, EmitDefaultValue = true)]
    public ActiveOrHistoricCurrencyAndAmount Amount { get; set; }

    /// <summary>
    ///     Returns true if ChargeComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of ChargeComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ChargeComplexType input)
    {
        if (input == null) return false;
        return
            (
                ChargeBearer == input.ChargeBearer ||
                ChargeBearer.Equals(input.ChargeBearer)
            ) &&
            (
                Type == input.Type ||
                Type.Equals(input.Type)
            ) &&
            (
                Amount == input.Amount ||
                (Amount != null &&
                 Amount.Equals(input.Amount))
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
        sb.Append("class ChargeComplexType {\n");
        sb.Append("  ChargeBearer: ").Append(ChargeBearer).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  Amount: ").Append(Amount).Append("\n");
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
        return Equals(input as ChargeComplexType);
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
            hashCode = hashCode * 59 + ChargeBearer.GetHashCode();
            hashCode = hashCode * 59 + Type.GetHashCode();
            if (Amount != null) hashCode = hashCode * 59 + Amount.GetHashCode();
            return hashCode;
        }
    }
}
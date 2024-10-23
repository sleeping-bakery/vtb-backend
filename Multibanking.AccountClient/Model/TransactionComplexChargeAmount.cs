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
///     Комиссионные за транзакцию
/// </summary>
[DataContract(Name = "TransactionComplex_ChargeAmount")]
public class TransactionComplexChargeAmount : IEquatable<TransactionComplexChargeAmount>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionComplexChargeAmount" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected TransactionComplexChargeAmount()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="TransactionComplexChargeAmount" /> class.
    /// </summary>
    /// <param name="amount">Сумма (required).</param>
    /// <param name="currency">Валюта счета. Используется стандарт ISO 4217 (required).</param>
    public TransactionComplexChargeAmount(string amount = default, string currency = default)
    {
        // to ensure "amount" is required (not null)
        if (amount == null) throw new ArgumentNullException("amount is a required property for TransactionComplexChargeAmount and cannot be null");
        Amount = amount;
        // to ensure "currency" is required (not null)
        if (currency == null) throw new ArgumentNullException("currency is a required property for TransactionComplexChargeAmount and cannot be null");
        Currency = currency;
    }

    /// <summary>
    ///     Сумма
    /// </summary>
    /// <value>Сумма</value>
    [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
    public string Amount { get; set; }

    /// <summary>
    ///     Валюта счета. Используется стандарт ISO 4217
    /// </summary>
    /// <value>Валюта счета. Используется стандарт ISO 4217</value>
    [DataMember(Name = "currency", IsRequired = true, EmitDefaultValue = true)]
    public string Currency { get; set; }

    /// <summary>
    ///     Returns true if TransactionComplexChargeAmount instances are equal
    /// </summary>
    /// <param name="input">Instance of TransactionComplexChargeAmount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TransactionComplexChargeAmount input)
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
        sb.Append("class TransactionComplexChargeAmount {\n");
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
        return Equals(input as TransactionComplexChargeAmount);
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
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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.AccountClient.Model;

/// <summary>
///     BalanceComplexType
/// </summary>
[DataContract(Name = "BalanceComplexType")]
public class BalanceComplexType : IEquatable<BalanceComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="BalanceComplexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected BalanceComplexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="BalanceComplexType" /> class.
    /// </summary>
    /// <param name="accountId">Уникальный и неизменный идентификатор, используемый для идентификации ресурса &#39;accounts&#39; (required).</param>
    /// <param name="creditDebitIndicator">Определяет является баланс кредитовым или дебетовым (required).</param>
    /// <param name="type">Тип баланса, заполняется согласно ISO 20022 (required).</param>
    /// <param name="dateTime">Дата и время построения отчета. Используется стандарт ISO8601 (required).</param>
    /// <param name="amount">amount (required).</param>
    /// <param name="creditLine">Подробная информация о кредитной линии.</param>
    public BalanceComplexType(string accountId = default, CreditDebitIndicatorStaticType creditDebitIndicator = default, BalanceTypeStaticType type = default,
        DateTime dateTime = default, TransactionCashBalanceComplexTypeAmount amount = default, List<CreditLineComplexType> creditLine = default)
    {
        // to ensure "accountId" is required (not null)
        if (accountId == null) throw new ArgumentNullException("accountId is a required property for BalanceComplexType and cannot be null");
        AccountId = accountId;
        CreditDebitIndicator = creditDebitIndicator;
        Type = type;
        DateTime = dateTime;
        // to ensure "amount" is required (not null)
        if (amount == null) throw new ArgumentNullException("amount is a required property for BalanceComplexType and cannot be null");
        Amount = amount;
        CreditLine = creditLine;
    }

    /// <summary>
    ///     Определяет является баланс кредитовым или дебетовым
    /// </summary>
    /// <value>Определяет является баланс кредитовым или дебетовым</value>
    [DataMember(Name = "creditDebitIndicator", IsRequired = true, EmitDefaultValue = true)]
    public CreditDebitIndicatorStaticType CreditDebitIndicator { get; set; }

    /// <summary>
    ///     Тип баланса, заполняется согласно ISO 20022
    /// </summary>
    /// <value>Тип баланса, заполняется согласно ISO 20022</value>
    [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
    public BalanceTypeStaticType Type { get; set; }

    /// <summary>
    ///     Уникальный и неизменный идентификатор, используемый для идентификации ресурса &#39;accounts&#39;
    /// </summary>
    /// <value>Уникальный и неизменный идентификатор, используемый для идентификации ресурса &#39;accounts&#39;</value>
    [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = true)]
    public string AccountId { get; set; }

    /// <summary>
    ///     Дата и время построения отчета. Используется стандарт ISO8601
    /// </summary>
    /// <value>Дата и время построения отчета. Используется стандарт ISO8601</value>
    [DataMember(Name = "dateTime", IsRequired = true, EmitDefaultValue = true)]
    public DateTime DateTime { get; set; }

    /// <summary>
    ///     Gets or Sets Amount
    /// </summary>
    [DataMember(Name = "Amount", IsRequired = true, EmitDefaultValue = true)]
    public TransactionCashBalanceComplexTypeAmount Amount { get; set; }

    /// <summary>
    ///     Подробная информация о кредитной линии
    /// </summary>
    /// <value>Подробная информация о кредитной линии</value>
    [DataMember(Name = "CreditLine", EmitDefaultValue = false)]
    public List<CreditLineComplexType> CreditLine { get; set; }

    /// <summary>
    ///     Returns true if BalanceComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of BalanceComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(BalanceComplexType input)
    {
        if (input == null) return false;
        return
            (
                AccountId == input.AccountId ||
                (AccountId != null &&
                 AccountId.Equals(input.AccountId))
            ) &&
            (
                CreditDebitIndicator == input.CreditDebitIndicator ||
                CreditDebitIndicator.Equals(input.CreditDebitIndicator)
            ) &&
            (
                Type == input.Type ||
                Type.Equals(input.Type)
            ) &&
            (
                DateTime == input.DateTime ||
                (DateTime != null &&
                 DateTime.Equals(input.DateTime))
            ) &&
            (
                Amount == input.Amount ||
                (Amount != null &&
                 Amount.Equals(input.Amount))
            ) &&
            (
                CreditLine == input.CreditLine ||
                (CreditLine != null &&
                 input.CreditLine != null &&
                 CreditLine.SequenceEqual(input.CreditLine))
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
        sb.Append("class BalanceComplexType {\n");
        sb.Append("  AccountId: ").Append(AccountId).Append("\n");
        sb.Append("  CreditDebitIndicator: ").Append(CreditDebitIndicator).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  DateTime: ").Append(DateTime).Append("\n");
        sb.Append("  Amount: ").Append(Amount).Append("\n");
        sb.Append("  CreditLine: ").Append(CreditLine).Append("\n");
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
        return Equals(input as BalanceComplexType);
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
            if (AccountId != null) hashCode = hashCode * 59 + AccountId.GetHashCode();
            hashCode = hashCode * 59 + CreditDebitIndicator.GetHashCode();
            hashCode = hashCode * 59 + Type.GetHashCode();
            if (DateTime != null) hashCode = hashCode * 59 + DateTime.GetHashCode();
            if (Amount != null) hashCode = hashCode * 59 + Amount.GetHashCode();
            if (CreditLine != null) hashCode = hashCode * 59 + CreditLine.GetHashCode();
            return hashCode;
        }
    }
}
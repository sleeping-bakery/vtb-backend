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
///     StatementInitReqComplexType
/// </summary>
[DataContract(Name = "StatementInitReqComplexType")]
public class StatementInitReqComplexType : IEquatable<StatementInitReqComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="StatementInitReqComplexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected StatementInitReqComplexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="StatementInitReqComplexType" /> class.
    /// </summary>
    /// <param name="accountId">Идентификатор ресурса счета (required).</param>
    /// <param name="fromBookingDateTime">Дата и время начала выписки (required).</param>
    /// <param name="toBookingDateTime">Дата и время окончания выписки (required).</param>
    public StatementInitReqComplexType(string accountId = default, DateTime fromBookingDateTime = default, DateTime toBookingDateTime = default)
    {
        // to ensure "accountId" is required (not null)
        if (accountId == null) throw new ArgumentNullException("accountId is a required property for StatementInitReqComplexType and cannot be null");
        AccountId = accountId;
        FromBookingDateTime = fromBookingDateTime;
        ToBookingDateTime = toBookingDateTime;
    }

    /// <summary>
    ///     Идентификатор ресурса счета
    /// </summary>
    /// <value>Идентификатор ресурса счета</value>
    [DataMember(Name = "accountId", IsRequired = true, EmitDefaultValue = true)]
    public string AccountId { get; set; }

    /// <summary>
    ///     Дата и время начала выписки
    /// </summary>
    /// <value>Дата и время начала выписки</value>
    [DataMember(Name = "fromBookingDateTime", IsRequired = true, EmitDefaultValue = true)]
    public DateTime FromBookingDateTime { get; set; }

    /// <summary>
    ///     Дата и время окончания выписки
    /// </summary>
    /// <value>Дата и время окончания выписки</value>
    [DataMember(Name = "toBookingDateTime", IsRequired = true, EmitDefaultValue = true)]
    public DateTime ToBookingDateTime { get; set; }

    /// <summary>
    ///     Returns true if StatementInitReqComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of StatementInitReqComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(StatementInitReqComplexType input)
    {
        if (input == null) return false;
        return
            (
                AccountId == input.AccountId ||
                (AccountId != null &&
                 AccountId.Equals(input.AccountId))
            ) &&
            (
                FromBookingDateTime == input.FromBookingDateTime ||
                (FromBookingDateTime != null &&
                 FromBookingDateTime.Equals(input.FromBookingDateTime))
            ) &&
            (
                ToBookingDateTime == input.ToBookingDateTime ||
                (ToBookingDateTime != null &&
                 ToBookingDateTime.Equals(input.ToBookingDateTime))
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
        sb.Append("class StatementInitReqComplexType {\n");
        sb.Append("  AccountId: ").Append(AccountId).Append("\n");
        sb.Append("  FromBookingDateTime: ").Append(FromBookingDateTime).Append("\n");
        sb.Append("  ToBookingDateTime: ").Append(ToBookingDateTime).Append("\n");
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
        return Equals(input as StatementInitReqComplexType);
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
            if (FromBookingDateTime != null) hashCode = hashCode * 59 + FromBookingDateTime.GetHashCode();
            if (ToBookingDateTime != null) hashCode = hashCode * 59 + ToBookingDateTime.GetHashCode();
            return hashCode;
        }
    }
}
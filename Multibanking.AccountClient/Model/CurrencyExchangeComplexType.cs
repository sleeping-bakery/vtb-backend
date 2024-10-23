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
///     Подробная информация об обмене валюты
/// </summary>
[DataContract(Name = "CurrencyExchangeComplexType")]
public class CurrencyExchangeComplexType : IEquatable<CurrencyExchangeComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CurrencyExchangeComplexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CurrencyExchangeComplexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="CurrencyExchangeComplexType" /> class.
    /// </summary>
    /// <param name="sourceCurrency">Валюта, из которой необходимо конвертировать сумму. Используется стандарт ISO 4217 (required).</param>
    /// <param name="targetCurrency">Валюта, в которую необходимо конвертировать сумму. Используется стандарт ISO 4217.</param>
    /// <param name="unitCurrency">Валюта, в которой обменный курс выражен. Используется стандарт ISO 4217.</param>
    /// <param name="exchangeRate">
    ///     Коэффициент, используемый для перевода суммы из одной валюты в другую. Это отражает цену, по которой одна валюта была куплена за другую валюту.
    ///     (required).
    /// </param>
    /// <param name="contractIdentification">Идентификатор для однозначного определения валютного контракта..</param>
    /// <param name="quotationDate">Дата и время обменного курса. Используется стандарт ISO8601.</param>
    /// <param name="instructedAmount">instructedAmount.</param>
    public CurrencyExchangeComplexType(string sourceCurrency = default, string targetCurrency = default, string unitCurrency = default, BaseOneRate exchangeRate = default,
        string contractIdentification = default, DateTime quotationDate = default, CurrencyExchangeComplexTypeInstructedAmount instructedAmount = default)
    {
        // to ensure "sourceCurrency" is required (not null)
        if (sourceCurrency == null) throw new ArgumentNullException("sourceCurrency is a required property for CurrencyExchangeComplexType and cannot be null");
        SourceCurrency = sourceCurrency;
        ExchangeRate = exchangeRate;
        TargetCurrency = targetCurrency;
        UnitCurrency = unitCurrency;
        ContractIdentification = contractIdentification;
        QuotationDate = quotationDate;
        InstructedAmount = instructedAmount;
    }

    /// <summary>
    ///     Коэффициент, используемый для перевода суммы из одной валюты в другую. Это отражает цену, по которой одна валюта была куплена за другую валюту.
    /// </summary>
    /// <value>Коэффициент, используемый для перевода суммы из одной валюты в другую. Это отражает цену, по которой одна валюта была куплена за другую валюту.</value>
    [DataMember(Name = "exchangeRate", IsRequired = true, EmitDefaultValue = true)]
    public BaseOneRate ExchangeRate { get; set; }

    /// <summary>
    ///     Валюта, из которой необходимо конвертировать сумму. Используется стандарт ISO 4217
    /// </summary>
    /// <value>Валюта, из которой необходимо конвертировать сумму. Используется стандарт ISO 4217</value>
    [DataMember(Name = "sourceCurrency", IsRequired = true, EmitDefaultValue = true)]
    public string SourceCurrency { get; set; }

    /// <summary>
    ///     Валюта, в которую необходимо конвертировать сумму. Используется стандарт ISO 4217
    /// </summary>
    /// <value>Валюта, в которую необходимо конвертировать сумму. Используется стандарт ISO 4217</value>
    [DataMember(Name = "targetCurrency", EmitDefaultValue = false)]
    public string TargetCurrency { get; set; }

    /// <summary>
    ///     Валюта, в которой обменный курс выражен. Используется стандарт ISO 4217
    /// </summary>
    /// <value>Валюта, в которой обменный курс выражен. Используется стандарт ISO 4217</value>
    [DataMember(Name = "unitCurrency", EmitDefaultValue = false)]
    public string UnitCurrency { get; set; }

    /// <summary>
    ///     Идентификатор для однозначного определения валютного контракта.
    /// </summary>
    /// <value>Идентификатор для однозначного определения валютного контракта.</value>
    [DataMember(Name = "contractIdentification", EmitDefaultValue = false)]
    public string ContractIdentification { get; set; }

    /// <summary>
    ///     Дата и время обменного курса. Используется стандарт ISO8601
    /// </summary>
    /// <value>Дата и время обменного курса. Используется стандарт ISO8601</value>
    [DataMember(Name = "quotationDate", EmitDefaultValue = false)]
    public DateTime QuotationDate { get; set; }

    /// <summary>
    ///     Gets or Sets InstructedAmount
    /// </summary>
    [DataMember(Name = "InstructedAmount", EmitDefaultValue = false)]
    public CurrencyExchangeComplexTypeInstructedAmount InstructedAmount { get; set; }

    /// <summary>
    ///     Returns true if CurrencyExchangeComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of CurrencyExchangeComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CurrencyExchangeComplexType input)
    {
        if (input == null) return false;
        return
            (
                SourceCurrency == input.SourceCurrency ||
                (SourceCurrency != null &&
                 SourceCurrency.Equals(input.SourceCurrency))
            ) &&
            (
                TargetCurrency == input.TargetCurrency ||
                (TargetCurrency != null &&
                 TargetCurrency.Equals(input.TargetCurrency))
            ) &&
            (
                UnitCurrency == input.UnitCurrency ||
                (UnitCurrency != null &&
                 UnitCurrency.Equals(input.UnitCurrency))
            ) &&
            (
                ExchangeRate == input.ExchangeRate ||
                ExchangeRate.Equals(input.ExchangeRate)
            ) &&
            (
                ContractIdentification == input.ContractIdentification ||
                (ContractIdentification != null &&
                 ContractIdentification.Equals(input.ContractIdentification))
            ) &&
            (
                QuotationDate == input.QuotationDate ||
                (QuotationDate != null &&
                 QuotationDate.Equals(input.QuotationDate))
            ) &&
            (
                InstructedAmount == input.InstructedAmount ||
                (InstructedAmount != null &&
                 InstructedAmount.Equals(input.InstructedAmount))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // ContractIdentification (string) maxLength
        if (ContractIdentification != null && ContractIdentification.Length > 35)
            yield return new ValidationResult("Invalid value for ContractIdentification, length must be less than 35.", new[] { "ContractIdentification" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CurrencyExchangeComplexType {\n");
        sb.Append("  SourceCurrency: ").Append(SourceCurrency).Append("\n");
        sb.Append("  TargetCurrency: ").Append(TargetCurrency).Append("\n");
        sb.Append("  UnitCurrency: ").Append(UnitCurrency).Append("\n");
        sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
        sb.Append("  ContractIdentification: ").Append(ContractIdentification).Append("\n");
        sb.Append("  QuotationDate: ").Append(QuotationDate).Append("\n");
        sb.Append("  InstructedAmount: ").Append(InstructedAmount).Append("\n");
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
        return Equals(input as CurrencyExchangeComplexType);
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
            if (SourceCurrency != null) hashCode = hashCode * 59 + SourceCurrency.GetHashCode();
            if (TargetCurrency != null) hashCode = hashCode * 59 + TargetCurrency.GetHashCode();
            if (UnitCurrency != null) hashCode = hashCode * 59 + UnitCurrency.GetHashCode();
            hashCode = hashCode * 59 + ExchangeRate.GetHashCode();
            if (ContractIdentification != null) hashCode = hashCode * 59 + ContractIdentification.GetHashCode();
            if (QuotationDate != null) hashCode = hashCode * 59 + QuotationDate.GetHashCode();
            if (InstructedAmount != null) hashCode = hashCode * 59 + InstructedAmount.GetHashCode();
            return hashCode;
        }
    }
}
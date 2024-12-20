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
///     Информация о НДС
/// </summary>
[DataContract(Name = "TaxAmount")]
public class TaxAmount : IEquatable<TaxAmount>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TaxAmount" /> class.
    /// </summary>
    /// <param name="rate">Ставка НДС (Номер реквизита 14.3).</param>
    /// <param name="totalAmount">Сумма НДС (Номер реквизита 14.4).</param>
    public TaxAmount(string rate = default, string totalAmount = default)
    {
        Rate = rate;
        TotalAmount = totalAmount;
    }

    /// <summary>
    ///     Ставка НДС (Номер реквизита 14.3)
    /// </summary>
    /// <value>Ставка НДС (Номер реквизита 14.3)</value>
    [DataMember(Name = "rate", EmitDefaultValue = false)]
    public string Rate { get; set; }

    /// <summary>
    ///     Сумма НДС (Номер реквизита 14.4)
    /// </summary>
    /// <value>Сумма НДС (Номер реквизита 14.4)</value>
    [DataMember(Name = "totalAmount", EmitDefaultValue = false)]
    public string TotalAmount { get; set; }

    /// <summary>
    ///     Returns true if TaxAmount instances are equal
    /// </summary>
    /// <param name="input">Instance of TaxAmount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TaxAmount input)
    {
        if (input == null) return false;
        return
            (
                Rate == input.Rate ||
                (Rate != null &&
                 Rate.Equals(input.Rate))
            ) &&
            (
                TotalAmount == input.TotalAmount ||
                (TotalAmount != null &&
                 TotalAmount.Equals(input.TotalAmount))
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
        sb.Append("class TaxAmount {\n");
        sb.Append("  Rate: ").Append(Rate).Append("\n");
        sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
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
        return Equals(input as TaxAmount);
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
            if (Rate != null) hashCode = hashCode * 59 + Rate.GetHashCode();
            if (TotalAmount != null) hashCode = hashCode * 59 + TotalAmount.GetHashCode();
            return hashCode;
        }
    }
}
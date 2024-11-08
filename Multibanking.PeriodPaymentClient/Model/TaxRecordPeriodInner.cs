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
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     TaxRecordPeriodInner
/// </summary>
[DataContract(Name = "TaxRecord_Period_inner")]
public class TaxRecordPeriodInner : IEquatable<TaxRecordPeriodInner>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TaxRecordPeriodInner" /> class.
    /// </summary>
    /// <param name="year">Год, к которому относится налог.</param>
    /// <param name="type">Тип налогового периода (реквизит 107).</param>
    /// <param name="fromDate">Дата уплаты налогового платежа.</param>
    /// <param name="toDate">Дата уплаты налогового платежа.</param>
    public TaxRecordPeriodInner(string year = default, TaxRecordPeriodCode? type = default, DateTime fromDate = default, DateTime toDate = default)
    {
        Year = year;
        Type = type;
        FromDate = fromDate;
        ToDate = toDate;
    }

    /// <summary>
    ///     Тип налогового периода (реквизит 107)
    /// </summary>
    /// <value>Тип налогового периода (реквизит 107)</value>
    [DataMember(Name = "type", EmitDefaultValue = false)]
    public TaxRecordPeriodCode? Type { get; set; }

    /// <summary>
    ///     Год, к которому относится налог
    /// </summary>
    /// <value>Год, к которому относится налог</value>
    [DataMember(Name = "year", EmitDefaultValue = false)]
    public string Year { get; set; }

    /// <summary>
    ///     Дата уплаты налогового платежа
    /// </summary>
    /// <value>Дата уплаты налогового платежа</value>
    [DataMember(Name = "fromDate", EmitDefaultValue = false)]
    public DateTime FromDate { get; set; }

    /// <summary>
    ///     Дата уплаты налогового платежа
    /// </summary>
    /// <value>Дата уплаты налогового платежа</value>
    [DataMember(Name = "toDate", EmitDefaultValue = false)]
    public DateTime ToDate { get; set; }

    /// <summary>
    ///     Returns true if TaxRecordPeriodInner instances are equal
    /// </summary>
    /// <param name="input">Instance of TaxRecordPeriodInner to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TaxRecordPeriodInner input)
    {
        if (input == null) return false;
        return
            (
                Year == input.Year ||
                (Year != null &&
                 Year.Equals(input.Year))
            ) &&
            (
                Type == input.Type ||
                Type.Equals(input.Type)
            ) &&
            (
                FromDate == input.FromDate ||
                (FromDate != null &&
                 FromDate.Equals(input.FromDate))
            ) &&
            (
                ToDate == input.ToDate ||
                (ToDate != null &&
                 ToDate.Equals(input.ToDate))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Year (string) pattern
        var regexYear = new Regex(@"([1-9][0-9]{3,}|0[0-9]{3})-01-01", RegexOptions.CultureInvariant);
        if (false == regexYear.Match(Year).Success) yield return new ValidationResult("Invalid value for Year, must match a pattern of " + regexYear, new[] { "Year" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TaxRecordPeriodInner {\n");
        sb.Append("  Year: ").Append(Year).Append("\n");
        sb.Append("  Type: ").Append(Type).Append("\n");
        sb.Append("  FromDate: ").Append(FromDate).Append("\n");
        sb.Append("  ToDate: ").Append(ToDate).Append("\n");
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
        return Equals(input as TaxRecordPeriodInner);
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
            if (Year != null) hashCode = hashCode * 59 + Year.GetHashCode();
            hashCode = hashCode * 59 + Type.GetHashCode();
            if (FromDate != null) hashCode = hashCode * 59 + FromDate.GetHashCode();
            if (ToDate != null) hashCode = hashCode * 59 + ToDate.GetHashCode();
            return hashCode;
        }
    }
}
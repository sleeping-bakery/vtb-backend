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
///     Налоговая информация об участнике перевода денежных средств
/// </summary>
[DataContract(Name = "TaxParty")]
public class TaxParty : IEquatable<TaxParty>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="TaxParty" /> class.
    /// </summary>
    /// <param name="taxType">Код причины постановки на учет (КПП).</param>
    /// <param name="registrationIdentification">Реквизит 107. Код таможенного органа (Поле заполняется для распоряжений по уплате таможенных платежей).</param>
    public TaxParty(string taxType = default, string registrationIdentification = default)
    {
        TaxType = taxType;
        RegistrationIdentification = registrationIdentification;
    }

    /// <summary>
    ///     Код причины постановки на учет (КПП)
    /// </summary>
    /// <value>Код причины постановки на учет (КПП)</value>
    [DataMember(Name = "taxType", EmitDefaultValue = false)]
    public string TaxType { get; set; }

    /// <summary>
    ///     Реквизит 107. Код таможенного органа (Поле заполняется для распоряжений по уплате таможенных платежей)
    /// </summary>
    /// <value>Реквизит 107. Код таможенного органа (Поле заполняется для распоряжений по уплате таможенных платежей)</value>
    [DataMember(Name = "registrationIdentification", EmitDefaultValue = false)]
    public string RegistrationIdentification { get; set; }

    /// <summary>
    ///     Returns true if TaxParty instances are equal
    /// </summary>
    /// <param name="input">Instance of TaxParty to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(TaxParty input)
    {
        if (input == null) return false;
        return
            (
                TaxType == input.TaxType ||
                (TaxType != null &&
                 TaxType.Equals(input.TaxType))
            ) &&
            (
                RegistrationIdentification == input.RegistrationIdentification ||
                (RegistrationIdentification != null &&
                 RegistrationIdentification.Equals(input.RegistrationIdentification))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // TaxType (string) maxLength
        if (TaxType != null && TaxType.Length > 9) yield return new ValidationResult("Invalid value for TaxType, length must be less than 9.", new[] { "TaxType" });

        // TaxType (string) pattern
        var regexTaxType = new Regex(@"^\\d{9}$", RegexOptions.CultureInvariant);
        if (false == regexTaxType.Match(TaxType).Success)
            yield return new ValidationResult("Invalid value for TaxType, must match a pattern of " + regexTaxType, new[] { "TaxType" });

        // RegistrationIdentification (string) maxLength
        if (RegistrationIdentification != null && RegistrationIdentification.Length > 35)
            yield return new ValidationResult("Invalid value for RegistrationIdentification, length must be less than 35.", new[] { "RegistrationIdentification" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class TaxParty {\n");
        sb.Append("  TaxType: ").Append(TaxType).Append("\n");
        sb.Append("  RegistrationIdentification: ").Append(RegistrationIdentification).Append("\n");
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
        return Equals(input as TaxParty);
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
            if (TaxType != null) hashCode = hashCode * 59 + TaxType.GetHashCode();
            if (RegistrationIdentification != null) hashCode = hashCode * 59 + RegistrationIdentification.GetHashCode();
            return hashCode;
        }
    }
}
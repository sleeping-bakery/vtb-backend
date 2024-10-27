/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Multibanking.PeriodPaymentClient.Client.OpenAPIDateConverter;

namespace Multibanking.PeriodPaymentClient.Model
{
    /// <summary>
    /// Налоговая информация о получателе средств
    /// </summary>
    [DataContract(Name = "TaxInformation_creditor")]
    public partial class TaxInformationCreditor : IEquatable<TaxInformationCreditor>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxInformationCreditor" /> class.
        /// </summary>
        /// <param name="taxType">Код причины постановки на учет (КПП).</param>
        /// <param name="registrationIdentification">Реквизит 107. Код таможенного органа (Поле заполняется для распоряжений по уплате таможенных платежей).</param>
        public TaxInformationCreditor(string taxType = default(string), string registrationIdentification = default(string))
        {
            this.TaxType = taxType;
            this.RegistrationIdentification = registrationIdentification;
        }

        /// <summary>
        /// Код причины постановки на учет (КПП)
        /// </summary>
        /// <value>Код причины постановки на учет (КПП)</value>
        [DataMember(Name = "taxType", EmitDefaultValue = false)]
        public string TaxType { get; set; }

        /// <summary>
        /// Реквизит 107. Код таможенного органа (Поле заполняется для распоряжений по уплате таможенных платежей)
        /// </summary>
        /// <value>Реквизит 107. Код таможенного органа (Поле заполняется для распоряжений по уплате таможенных платежей)</value>
        [DataMember(Name = "registrationIdentification", EmitDefaultValue = false)]
        public string RegistrationIdentification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxInformationCreditor {\n");
            sb.Append("  TaxType: ").Append(TaxType).Append("\n");
            sb.Append("  RegistrationIdentification: ").Append(RegistrationIdentification).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as TaxInformationCreditor);
        }

        /// <summary>
        /// Returns true if TaxInformationCreditor instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxInformationCreditor to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxInformationCreditor input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.TaxType == input.TaxType ||
                    (this.TaxType != null &&
                    this.TaxType.Equals(input.TaxType))
                ) && 
                (
                    this.RegistrationIdentification == input.RegistrationIdentification ||
                    (this.RegistrationIdentification != null &&
                    this.RegistrationIdentification.Equals(input.RegistrationIdentification))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.TaxType != null)
                {
                    hashCode = (hashCode * 59) + this.TaxType.GetHashCode();
                }
                if (this.RegistrationIdentification != null)
                {
                    hashCode = (hashCode * 59) + this.RegistrationIdentification.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // TaxType (string) maxLength
            if (this.TaxType != null && this.TaxType.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxType, length must be less than 9.", new [] { "TaxType" });
            }

            // TaxType (string) pattern
            Regex regexTaxType = new Regex(@"^\\d{9}$", RegexOptions.CultureInvariant);
            if (false == regexTaxType.Match(this.TaxType).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxType, must match a pattern of " + regexTaxType, new [] { "TaxType" });
            }

            // RegistrationIdentification (string) maxLength
            if (this.RegistrationIdentification != null && this.RegistrationIdentification.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RegistrationIdentification, length must be less than 35.", new [] { "RegistrationIdentification" });
            }

            yield break;
        }
    }

}

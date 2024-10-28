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
    /// TaxRecordPeriodInner
    /// </summary>
    [DataContract(Name = "TaxRecord_Period_inner")]
    public partial class TaxRecordPeriodInner : IEquatable<TaxRecordPeriodInner>, IValidatableObject
    {

        /// <summary>
        /// Тип налогового периода (реквизит 107)
        /// </summary>
        /// <value>Тип налогового периода (реквизит 107)</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public TaxRecordPeriodCode? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaxRecordPeriodInner" /> class.
        /// </summary>
        /// <param name="year">Год, к которому относится налог.</param>
        /// <param name="type">Тип налогового периода (реквизит 107).</param>
        /// <param name="fromDate">Дата уплаты налогового платежа.</param>
        /// <param name="toDate">Дата уплаты налогового платежа.</param>
        public TaxRecordPeriodInner(string year = default(string), TaxRecordPeriodCode? type = default(TaxRecordPeriodCode?), DateTime fromDate = default(DateTime), DateTime toDate = default(DateTime))
        {
            this.Year = year;
            this.Type = type;
            this.FromDate = fromDate;
            this.ToDate = toDate;
        }

        /// <summary>
        /// Год, к которому относится налог
        /// </summary>
        /// <value>Год, к которому относится налог</value>
        [DataMember(Name = "year", EmitDefaultValue = false)]
        public string Year { get; set; }

        /// <summary>
        /// Дата уплаты налогового платежа
        /// </summary>
        /// <value>Дата уплаты налогового платежа</value>
        [DataMember(Name = "fromDate", EmitDefaultValue = false)]
        public DateTime FromDate { get; set; }

        /// <summary>
        /// Дата уплаты налогового платежа
        /// </summary>
        /// <value>Дата уплаты налогового платежа</value>
        [DataMember(Name = "toDate", EmitDefaultValue = false)]
        public DateTime ToDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaxRecordPeriodInner {\n");
            sb.Append("  Year: ").Append(Year).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  FromDate: ").Append(FromDate).Append("\n");
            sb.Append("  ToDate: ").Append(ToDate).Append("\n");
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
            return this.Equals(input as TaxRecordPeriodInner);
        }

        /// <summary>
        /// Returns true if TaxRecordPeriodInner instances are equal
        /// </summary>
        /// <param name="input">Instance of TaxRecordPeriodInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaxRecordPeriodInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Year == input.Year ||
                    (this.Year != null &&
                    this.Year.Equals(input.Year))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.FromDate == input.FromDate ||
                    (this.FromDate != null &&
                    this.FromDate.Equals(input.FromDate))
                ) && 
                (
                    this.ToDate == input.ToDate ||
                    (this.ToDate != null &&
                    this.ToDate.Equals(input.ToDate))
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
                if (this.Year != null)
                {
                    hashCode = (hashCode * 59) + this.Year.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.FromDate != null)
                {
                    hashCode = (hashCode * 59) + this.FromDate.GetHashCode();
                }
                if (this.ToDate != null)
                {
                    hashCode = (hashCode * 59) + this.ToDate.GetHashCode();
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
            // Year (string) pattern
            Regex regexYear = new Regex(@"([1-9][0-9]{3,}|0[0-9]{3})-01-01", RegexOptions.CultureInvariant);
            if (false == regexYear.Match(this.Year).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Year, must match a pattern of " + regexYear, new [] { "Year" });
            }

            yield break;
        }
    }

}
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
    /// PeriodicLimitsInner
    /// </summary>
    [DataContract(Name = "PeriodicLimits_inner")]
    public partial class PeriodicLimitsInner : IEquatable<PeriodicLimitsInner>, IValidatableObject
    {
        /// <summary>
        /// Тип периода установки ограничения
        /// </summary>
        /// <value>Тип периода установки ограничения</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodTypeEnum
        {
            /// <summary>
            /// Enum Day for value: Day
            /// </summary>
            [EnumMember(Value = "Day")]
            Day = 1,

            /// <summary>
            /// Enum Week for value: Week
            /// </summary>
            [EnumMember(Value = "Week")]
            Week = 2,

            /// <summary>
            /// Enum Fortnight for value: Fortnight
            /// </summary>
            [EnumMember(Value = "Fortnight")]
            Fortnight = 3,

            /// <summary>
            /// Enum Month for value: Month
            /// </summary>
            [EnumMember(Value = "Month")]
            Month = 4,

            /// <summary>
            /// Enum HalfYear for value: Half-year
            /// </summary>
            [EnumMember(Value = "Half-year")]
            HalfYear = 5,

            /// <summary>
            /// Enum Year for value: Year
            /// </summary>
            [EnumMember(Value = "Year")]
            Year = 6

        }


        /// <summary>
        /// Тип периода установки ограничения
        /// </summary>
        /// <value>Тип периода установки ограничения</value>
        [DataMember(Name = "periodType", IsRequired = true, EmitDefaultValue = true)]
        public PeriodTypeEnum PeriodType { get; set; }
        /// <summary>
        /// Определяет привязку периода либо к началу действия Согласия на инициирование, либо к календарным датам
        /// </summary>
        /// <value>Определяет привязку периода либо к началу действия Согласия на инициирование, либо к календарным датам</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PeriodAlignmentEnum
        {
            /// <summary>
            /// Enum Consent for value: Consent
            /// </summary>
            [EnumMember(Value = "Consent")]
            Consent = 1,

            /// <summary>
            /// Enum Calendar for value: Calendar
            /// </summary>
            [EnumMember(Value = "Calendar")]
            Calendar = 2

        }


        /// <summary>
        /// Определяет привязку периода либо к началу действия Согласия на инициирование, либо к календарным датам
        /// </summary>
        /// <value>Определяет привязку периода либо к началу действия Согласия на инициирование, либо к календарным датам</value>
        [DataMember(Name = "periodAlignment", IsRequired = true, EmitDefaultValue = true)]
        public PeriodAlignmentEnum PeriodAlignment { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodicLimitsInner" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PeriodicLimitsInner() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PeriodicLimitsInner" /> class.
        /// </summary>
        /// <param name="periodType">Тип периода установки ограничения (required).</param>
        /// <param name="periodAlignment">Определяет привязку периода либо к началу действия Согласия на инициирование, либо к календарным датам (required).</param>
        /// <param name="amount">amount (required).</param>
        public PeriodicLimitsInner(PeriodTypeEnum periodType = default(PeriodTypeEnum), PeriodAlignmentEnum periodAlignment = default(PeriodAlignmentEnum), PeriodicLimitsInnerAmount amount = default(PeriodicLimitsInnerAmount))
        {
            this.PeriodType = periodType;
            this.PeriodAlignment = periodAlignment;
            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new ArgumentNullException("amount is a required property for PeriodicLimitsInner and cannot be null");
            }
            this.Amount = amount;
        }

        /// <summary>
        /// Gets or Sets Amount
        /// </summary>
        [DataMember(Name = "Amount", IsRequired = true, EmitDefaultValue = true)]
        public PeriodicLimitsInnerAmount Amount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PeriodicLimitsInner {\n");
            sb.Append("  PeriodType: ").Append(PeriodType).Append("\n");
            sb.Append("  PeriodAlignment: ").Append(PeriodAlignment).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
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
            return this.Equals(input as PeriodicLimitsInner);
        }

        /// <summary>
        /// Returns true if PeriodicLimitsInner instances are equal
        /// </summary>
        /// <param name="input">Instance of PeriodicLimitsInner to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PeriodicLimitsInner input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PeriodType == input.PeriodType ||
                    this.PeriodType.Equals(input.PeriodType)
                ) && 
                (
                    this.PeriodAlignment == input.PeriodAlignment ||
                    this.PeriodAlignment.Equals(input.PeriodAlignment)
                ) && 
                (
                    this.Amount == input.Amount ||
                    (this.Amount != null &&
                    this.Amount.Equals(input.Amount))
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
                hashCode = (hashCode * 59) + this.PeriodType.GetHashCode();
                hashCode = (hashCode * 59) + this.PeriodAlignment.GetHashCode();
                if (this.Amount != null)
                {
                    hashCode = (hashCode * 59) + this.Amount.GetHashCode();
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
            yield break;
        }
    }

}
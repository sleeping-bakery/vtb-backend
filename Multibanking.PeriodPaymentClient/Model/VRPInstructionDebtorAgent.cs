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
    /// Финансовая организация, обслуживающая счет плательщика
    /// </summary>
    [DataContract(Name = "VRPInstruction_DebtorAgent")]
    public partial class VRPInstructionDebtorAgent : IEquatable<VRPInstructionDebtorAgent>, IValidatableObject
    {

        /// <summary>
        /// Наименование идентификационной схемы финансового учереждения
        /// </summary>
        /// <value>Наименование идентификационной схемы финансового учереждения</value>
        [DataMember(Name = "schemeName", IsRequired = true, EmitDefaultValue = true)]
        public FinancialInstitutionIdentificationCode SchemeName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPInstructionDebtorAgent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VRPInstructionDebtorAgent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPInstructionDebtorAgent" /> class.
        /// </summary>
        /// <param name="schemeName">Наименование идентификационной схемы финансового учереждения (required).</param>
        /// <param name="identification">Банковский идентификационный код (БИК) или другой идентификатор финансового учереждения (required).</param>
        public VRPInstructionDebtorAgent(FinancialInstitutionIdentificationCode schemeName = default(FinancialInstitutionIdentificationCode), string identification = default(string))
        {
            this.SchemeName = schemeName;
            // to ensure "identification" is required (not null)
            if (identification == null)
            {
                throw new ArgumentNullException("identification is a required property for VRPInstructionDebtorAgent and cannot be null");
            }
            this.Identification = identification;
        }

        /// <summary>
        /// Банковский идентификационный код (БИК) или другой идентификатор финансового учереждения
        /// </summary>
        /// <value>Банковский идентификационный код (БИК) или другой идентификатор финансового учереждения</value>
        [DataMember(Name = "identification", IsRequired = true, EmitDefaultValue = true)]
        public string Identification { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VRPInstructionDebtorAgent {\n");
            sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
            sb.Append("  Identification: ").Append(Identification).Append("\n");
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
            return this.Equals(input as VRPInstructionDebtorAgent);
        }

        /// <summary>
        /// Returns true if VRPInstructionDebtorAgent instances are equal
        /// </summary>
        /// <param name="input">Instance of VRPInstructionDebtorAgent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VRPInstructionDebtorAgent input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SchemeName == input.SchemeName ||
                    this.SchemeName.Equals(input.SchemeName)
                ) && 
                (
                    this.Identification == input.Identification ||
                    (this.Identification != null &&
                    this.Identification.Equals(input.Identification))
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
                hashCode = (hashCode * 59) + this.SchemeName.GetHashCode();
                if (this.Identification != null)
                {
                    hashCode = (hashCode * 59) + this.Identification.GetHashCode();
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
            // Identification (string) maxLength
            if (this.Identification != null && this.Identification.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Identification, length must be less than 35.", new [] { "Identification" });
            }

            yield break;
        }
    }

}

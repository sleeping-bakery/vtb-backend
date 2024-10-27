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
    /// Информация о референсах, предоставленная получателем денежных средств, позволяющая идентифицировать исходные документы.
    /// </summary>
    [DataContract(Name = "CreditorReferenceInformation")]
    public partial class CreditorReferenceInformation : IEquatable<CreditorReferenceInformation>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditorReferenceInformation" /> class.
        /// </summary>
        /// <param name="type">Тип идентификатора платежа (Номер реквизита 15.6.n).</param>
        /// <param name="reference">Значение идентификатора платежа (Номер реквизита 15.7.n). Ссылка, присвоенная получателем денежных средств, которая является основанием для осуществления перевода.</param>
        public CreditorReferenceInformation(string type = default(string), string reference = default(string))
        {
            this.Type = type;
            this.Reference = reference;
        }

        /// <summary>
        /// Тип идентификатора платежа (Номер реквизита 15.6.n)
        /// </summary>
        /// <value>Тип идентификатора платежа (Номер реквизита 15.6.n)</value>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public string Type { get; set; }

        /// <summary>
        /// Значение идентификатора платежа (Номер реквизита 15.7.n). Ссылка, присвоенная получателем денежных средств, которая является основанием для осуществления перевода
        /// </summary>
        /// <value>Значение идентификатора платежа (Номер реквизита 15.7.n). Ссылка, присвоенная получателем денежных средств, которая является основанием для осуществления перевода</value>
        [DataMember(Name = "reference", EmitDefaultValue = false)]
        public string Reference { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreditorReferenceInformation {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Reference: ").Append(Reference).Append("\n");
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
            return this.Equals(input as CreditorReferenceInformation);
        }

        /// <summary>
        /// Returns true if CreditorReferenceInformation instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditorReferenceInformation to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditorReferenceInformation input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Reference == input.Reference ||
                    (this.Reference != null &&
                    this.Reference.Equals(input.Reference))
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
                if (this.Type != null)
                {
                    hashCode = (hashCode * 59) + this.Type.GetHashCode();
                }
                if (this.Reference != null)
                {
                    hashCode = (hashCode * 59) + this.Reference.GetHashCode();
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
            // Type (string) maxLength
            if (this.Type != null && this.Type.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be less than 35.", new [] { "Type" });
            }

            // Reference (string) maxLength
            if (this.Reference != null && this.Reference.Length > 35)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Reference, length must be less than 35.", new [] { "Reference" });
            }

            yield break;
        }
    }

}

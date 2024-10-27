/*
 * Cервис платежа с базовым сценарием оплаты
 *
 * сервис платежа с базовым сценарием оплаты
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Multibanking.UniversalPaymentClient.Client.OpenAPIDateConverter;

namespace Multibanking.UniversalPaymentClient.Model
{
    /// <summary>
    /// Чек платежа
    /// </summary>
    [DataContract(Name = "PaymentCheckDtoRs")]
    public partial class PaymentCheckDtoRs : IEquatable<PaymentCheckDtoRs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCheckDtoRs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentCheckDtoRs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentCheckDtoRs" /> class.
        /// </summary>
        /// <param name="pdf">Чек в формате pdf, закодированный в base64 (required).</param>
        public PaymentCheckDtoRs(string pdf = default(string))
        {
            // to ensure "pdf" is required (not null)
            if (pdf == null)
            {
                throw new ArgumentNullException("pdf is a required property for PaymentCheckDtoRs and cannot be null");
            }
            this.Pdf = pdf;
        }

        /// <summary>
        /// Чек в формате pdf, закодированный в base64
        /// </summary>
        /// <value>Чек в формате pdf, закодированный в base64</value>
        [DataMember(Name = "pdf", IsRequired = true, EmitDefaultValue = true)]
        public string Pdf { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentCheckDtoRs {\n");
            sb.Append("  Pdf: ").Append(Pdf).Append("\n");
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
            return this.Equals(input as PaymentCheckDtoRs);
        }

        /// <summary>
        /// Returns true if PaymentCheckDtoRs instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentCheckDtoRs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentCheckDtoRs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Pdf == input.Pdf ||
                    (this.Pdf != null &&
                    this.Pdf.Equals(input.Pdf))
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
                if (this.Pdf != null)
                {
                    hashCode = (hashCode * 59) + this.Pdf.GetHashCode();
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
            // Pdf (string) maxLength
            if (this.Pdf != null && this.Pdf.Length > 5000000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Pdf, length must be less than 5000000.", new [] { "Pdf" });
            }

            yield break;
        }
    }

}
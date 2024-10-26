/*
 * Инициирование перевода денежных средств клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по переводам.
 *
 * The version of the OpenAPI document: 1.1.0
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
using OpenAPIDateConverter = Multibanking.UnidentifiedPaymentClient.Client.OpenAPIDateConverter;

namespace Multibanking.UnidentifiedPaymentClient.Model
{
    /// <summary>
    /// PaymentRequestComplexType
    /// </summary>
    [DataContract(Name = "PaymentRequestComplexType")]
    public partial class PaymentRequestComplexType : IEquatable<PaymentRequestComplexType>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestComplexType" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PaymentRequestComplexType() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentRequestComplexType" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="risk">risk (required).</param>
        public PaymentRequestComplexType(PaymentRequestComplexTypeData data = default(PaymentRequestComplexTypeData), ConsentRequestComplexTypeRisk risk = default(ConsentRequestComplexTypeRisk))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for PaymentRequestComplexType and cannot be null");
            }
            this.Data = data;
            // to ensure "risk" is required (not null)
            if (risk == null)
            {
                throw new ArgumentNullException("risk is a required property for PaymentRequestComplexType and cannot be null");
            }
            this.Risk = risk;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
        public PaymentRequestComplexTypeData Data { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name = "Risk", IsRequired = true, EmitDefaultValue = true)]
        public ConsentRequestComplexTypeRisk Risk { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentRequestComplexType {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
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
            return this.Equals(input as PaymentRequestComplexType);
        }

        /// <summary>
        /// Returns true if PaymentRequestComplexType instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentRequestComplexType to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentRequestComplexType input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Risk == input.Risk ||
                    (this.Risk != null &&
                    this.Risk.Equals(input.Risk))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
                }
                if (this.Risk != null)
                {
                    hashCode = (hashCode * 59) + this.Risk.GetHashCode();
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

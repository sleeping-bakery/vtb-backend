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
    /// Ответ старта оплаты
    /// </summary>
    [DataContract(Name = "StartPaymentDtoRs")]
    public partial class StartPaymentDtoRs : IEquatable<StartPaymentDtoRs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StartPaymentDtoRs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartPaymentDtoRs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartPaymentDtoRs" /> class.
        /// </summary>
        /// <param name="fields">Список полей необходимый для оплаты услуги ПУ (required).</param>
        /// <param name="paySum">paySum (required).</param>
        public StartPaymentDtoRs(List<InputFieldDtoRs> fields = default(List<InputFieldDtoRs>), PaySumDtoRs paySum = default(PaySumDtoRs))
        {
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for StartPaymentDtoRs and cannot be null");
            }
            this.Fields = fields;
            // to ensure "paySum" is required (not null)
            if (paySum == null)
            {
                throw new ArgumentNullException("paySum is a required property for StartPaymentDtoRs and cannot be null");
            }
            this.PaySum = paySum;
        }

        /// <summary>
        /// Список полей необходимый для оплаты услуги ПУ
        /// </summary>
        /// <value>Список полей необходимый для оплаты услуги ПУ</value>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public List<InputFieldDtoRs> Fields { get; set; }

        /// <summary>
        /// Gets or Sets PaySum
        /// </summary>
        [DataMember(Name = "paySum", IsRequired = true, EmitDefaultValue = true)]
        public PaySumDtoRs PaySum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class StartPaymentDtoRs {\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  PaySum: ").Append(PaySum).Append("\n");
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
            return this.Equals(input as StartPaymentDtoRs);
        }

        /// <summary>
        /// Returns true if StartPaymentDtoRs instances are equal
        /// </summary>
        /// <param name="input">Instance of StartPaymentDtoRs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartPaymentDtoRs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.PaySum == input.PaySum ||
                    (this.PaySum != null &&
                    this.PaySum.Equals(input.PaySum))
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
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.PaySum != null)
                {
                    hashCode = (hashCode * 59) + this.PaySum.GetHashCode();
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

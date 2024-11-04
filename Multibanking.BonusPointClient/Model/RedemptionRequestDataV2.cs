/*
 * Оплата баллами бонусов
 *
 * Позволяет пользователям просматривать и использовать свои награды.
 *
 * The version of the OpenAPI document: 2.0
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
using OpenAPIDateConverter = Multibanking.BonusPointClient.Client.OpenAPIDateConverter;

namespace Multibanking.BonusPointClient.Model
{
    /// <summary>
    /// Корневой объект, содержащий сумму выписки по кредиту и связанные атрибуты программы.
    /// </summary>
    [DataContract(Name = "RedemptionRequestDataV2")]
    public partial class RedemptionRequestDataV2 : IEquatable<RedemptionRequestDataV2>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionRequestDataV2" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RedemptionRequestDataV2() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RedemptionRequestDataV2" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        public RedemptionRequestDataV2(RedemptionRequestV2 data = default(RedemptionRequestV2))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for RedemptionRequestDataV2 and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = true)]
        public RedemptionRequestV2 Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RedemptionRequestDataV2 {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as RedemptionRequestDataV2);
        }

        /// <summary>
        /// Returns true if RedemptionRequestDataV2 instances are equal
        /// </summary>
        /// <param name="input">Instance of RedemptionRequestDataV2 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RedemptionRequestDataV2 input)
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
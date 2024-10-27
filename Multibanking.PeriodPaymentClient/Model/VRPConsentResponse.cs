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
    /// Ответ согласия на проведения платежа
    /// </summary>
    [DataContract(Name = "VRPConsentResponse")]
    public partial class VRPConsentResponse : IEquatable<VRPConsentResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPConsentResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VRPConsentResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPConsentResponse" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        /// <param name="risk">risk (required).</param>
        /// <param name="links">links (required).</param>
        /// <param name="meta">meta (required).</param>
        public VRPConsentResponse(VRPConsentResponseData data = default(VRPConsentResponseData), VRPConsentRequestRisk risk = default(VRPConsentRequestRisk), VRPConsentResponseLinks links = default(VRPConsentResponseLinks), VRPConsentResponseMeta meta = default(VRPConsentResponseMeta))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for VRPConsentResponse and cannot be null");
            }
            this.Data = data;
            // to ensure "risk" is required (not null)
            if (risk == null)
            {
                throw new ArgumentNullException("risk is a required property for VRPConsentResponse and cannot be null");
            }
            this.Risk = risk;
            // to ensure "links" is required (not null)
            if (links == null)
            {
                throw new ArgumentNullException("links is a required property for VRPConsentResponse and cannot be null");
            }
            this.Links = links;
            // to ensure "meta" is required (not null)
            if (meta == null)
            {
                throw new ArgumentNullException("meta is a required property for VRPConsentResponse and cannot be null");
            }
            this.Meta = meta;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
        public VRPConsentResponseData Data { get; set; }

        /// <summary>
        /// Gets or Sets Risk
        /// </summary>
        [DataMember(Name = "Risk", IsRequired = true, EmitDefaultValue = true)]
        public VRPConsentRequestRisk Risk { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "Links", IsRequired = true, EmitDefaultValue = true)]
        public VRPConsentResponseLinks Links { get; set; }

        /// <summary>
        /// Gets or Sets Meta
        /// </summary>
        [DataMember(Name = "Meta", IsRequired = true, EmitDefaultValue = true)]
        public VRPConsentResponseMeta Meta { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VRPConsentResponse {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Risk: ").Append(Risk).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
            sb.Append("  Meta: ").Append(Meta).Append("\n");
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
            return this.Equals(input as VRPConsentResponse);
        }

        /// <summary>
        /// Returns true if VRPConsentResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of VRPConsentResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VRPConsentResponse input)
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
                ) && 
                (
                    this.Links == input.Links ||
                    (this.Links != null &&
                    this.Links.Equals(input.Links))
                ) && 
                (
                    this.Meta == input.Meta ||
                    (this.Meta != null &&
                    this.Meta.Equals(input.Meta))
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
                if (this.Links != null)
                {
                    hashCode = (hashCode * 59) + this.Links.GetHashCode();
                }
                if (this.Meta != null)
                {
                    hashCode = (hashCode * 59) + this.Meta.GetHashCode();
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

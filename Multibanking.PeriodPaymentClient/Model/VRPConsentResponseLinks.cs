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
    /// VRPConsentResponseLinks
    /// </summary>
    [DataContract(Name = "VRPConsentResponse_Links")]
    public partial class VRPConsentResponseLinks : IEquatable<VRPConsentResponseLinks>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPConsentResponseLinks" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VRPConsentResponseLinks() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPConsentResponseLinks" /> class.
        /// </summary>
        /// <param name="self">self (required).</param>
        /// <param name="first">first.</param>
        /// <param name="prev">prev.</param>
        /// <param name="next">next.</param>
        /// <param name="last">last.</param>
        public VRPConsentResponseLinks(string self = default(string), string first = default(string), string prev = default(string), string next = default(string), string last = default(string))
        {
            // to ensure "self" is required (not null)
            if (self == null)
            {
                throw new ArgumentNullException("self is a required property for VRPConsentResponseLinks and cannot be null");
            }
            this.Self = self;
            this.First = first;
            this.Prev = prev;
            this.Next = next;
            this.Last = last;
        }

        /// <summary>
        /// Gets or Sets Self
        /// </summary>
        [DataMember(Name = "self", IsRequired = true, EmitDefaultValue = true)]
        public string Self { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name = "first", EmitDefaultValue = false)]
        public string First { get; set; }

        /// <summary>
        /// Gets or Sets Prev
        /// </summary>
        [DataMember(Name = "prev", EmitDefaultValue = false)]
        public string Prev { get; set; }

        /// <summary>
        /// Gets or Sets Next
        /// </summary>
        [DataMember(Name = "next", EmitDefaultValue = false)]
        public string Next { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name = "last", EmitDefaultValue = false)]
        public string Last { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VRPConsentResponseLinks {\n");
            sb.Append("  Self: ").Append(Self).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Prev: ").Append(Prev).Append("\n");
            sb.Append("  Next: ").Append(Next).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
            return this.Equals(input as VRPConsentResponseLinks);
        }

        /// <summary>
        /// Returns true if VRPConsentResponseLinks instances are equal
        /// </summary>
        /// <param name="input">Instance of VRPConsentResponseLinks to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VRPConsentResponseLinks input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Self == input.Self ||
                    (this.Self != null &&
                    this.Self.Equals(input.Self))
                ) && 
                (
                    this.First == input.First ||
                    (this.First != null &&
                    this.First.Equals(input.First))
                ) && 
                (
                    this.Prev == input.Prev ||
                    (this.Prev != null &&
                    this.Prev.Equals(input.Prev))
                ) && 
                (
                    this.Next == input.Next ||
                    (this.Next != null &&
                    this.Next.Equals(input.Next))
                ) && 
                (
                    this.Last == input.Last ||
                    (this.Last != null &&
                    this.Last.Equals(input.Last))
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
                if (this.Self != null)
                {
                    hashCode = (hashCode * 59) + this.Self.GetHashCode();
                }
                if (this.First != null)
                {
                    hashCode = (hashCode * 59) + this.First.GetHashCode();
                }
                if (this.Prev != null)
                {
                    hashCode = (hashCode * 59) + this.Prev.GetHashCode();
                }
                if (this.Next != null)
                {
                    hashCode = (hashCode * 59) + this.Next.GetHashCode();
                }
                if (this.Last != null)
                {
                    hashCode = (hashCode * 59) + this.Last.GetHashCode();
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
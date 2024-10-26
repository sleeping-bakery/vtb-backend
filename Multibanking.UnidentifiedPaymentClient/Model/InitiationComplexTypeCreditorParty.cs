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
    /// Информация о контрагенте.
    /// </summary>
    [DataContract(Name = "InitiationComplexType_CreditorParty")]
    public partial class InitiationComplexTypeCreditorParty : IEquatable<InitiationComplexTypeCreditorParty>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiationComplexTypeCreditorParty" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitiationComplexTypeCreditorParty() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitiationComplexTypeCreditorParty" /> class.
        /// </summary>
        /// <param name="name">Наименование контрагента. (required).</param>
        /// <param name="postalAddress">postalAddress.</param>
        public InitiationComplexTypeCreditorParty(string name = default(string), PartyIdentificationCompexTypePostalAddress postalAddress = default(PartyIdentificationCompexTypePostalAddress))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for InitiationComplexTypeCreditorParty and cannot be null");
            }
            this.Name = name;
            this.PostalAddress = postalAddress;
        }

        /// <summary>
        /// Наименование контрагента.
        /// </summary>
        /// <value>Наименование контрагента.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets PostalAddress
        /// </summary>
        [DataMember(Name = "PostalAddress", EmitDefaultValue = false)]
        public PartyIdentificationCompexTypePostalAddress PostalAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class InitiationComplexTypeCreditorParty {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
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
            return this.Equals(input as InitiationComplexTypeCreditorParty);
        }

        /// <summary>
        /// Returns true if InitiationComplexTypeCreditorParty instances are equal
        /// </summary>
        /// <param name="input">Instance of InitiationComplexTypeCreditorParty to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitiationComplexTypeCreditorParty input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.PostalAddress == input.PostalAddress ||
                    (this.PostalAddress != null &&
                    this.PostalAddress.Equals(input.PostalAddress))
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
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.PostalAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PostalAddress.GetHashCode();
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
            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 160)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 160.", new [] { "Name" });
            }

            yield break;
        }
    }

}

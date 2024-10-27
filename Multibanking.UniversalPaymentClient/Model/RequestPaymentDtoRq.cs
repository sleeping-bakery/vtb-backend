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
    /// Запрос на оплату услуги ПУ
    /// </summary>
    [DataContract(Name = "RequestPaymentDtoRq")]
    public partial class RequestPaymentDtoRq : IEquatable<RequestPaymentDtoRq>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPaymentDtoRq" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RequestPaymentDtoRq() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RequestPaymentDtoRq" /> class.
        /// </summary>
        /// <param name="providerService">providerService (required).</param>
        /// <param name="fields">Набор полей для оплаты (required).</param>
        /// <param name="paySum">paySum (required).</param>
        /// <param name="clientProduct">clientProduct (required).</param>
        public RequestPaymentDtoRq(ProviderServiceDtoRq providerService = default(ProviderServiceDtoRq), List<InputFieldDtoRq> fields = default(List<InputFieldDtoRq>), MoneyDto paySum = default(MoneyDto), ClientProductDtoRq clientProduct = default(ClientProductDtoRq))
        {
            // to ensure "providerService" is required (not null)
            if (providerService == null)
            {
                throw new ArgumentNullException("providerService is a required property for RequestPaymentDtoRq and cannot be null");
            }
            this.ProviderService = providerService;
            // to ensure "fields" is required (not null)
            if (fields == null)
            {
                throw new ArgumentNullException("fields is a required property for RequestPaymentDtoRq and cannot be null");
            }
            this.Fields = fields;
            // to ensure "paySum" is required (not null)
            if (paySum == null)
            {
                throw new ArgumentNullException("paySum is a required property for RequestPaymentDtoRq and cannot be null");
            }
            this.PaySum = paySum;
            // to ensure "clientProduct" is required (not null)
            if (clientProduct == null)
            {
                throw new ArgumentNullException("clientProduct is a required property for RequestPaymentDtoRq and cannot be null");
            }
            this.ClientProduct = clientProduct;
        }

        /// <summary>
        /// Gets or Sets ProviderService
        /// </summary>
        [DataMember(Name = "providerService", IsRequired = true, EmitDefaultValue = true)]
        public ProviderServiceDtoRq ProviderService { get; set; }

        /// <summary>
        /// Набор полей для оплаты
        /// </summary>
        /// <value>Набор полей для оплаты</value>
        [DataMember(Name = "fields", IsRequired = true, EmitDefaultValue = true)]
        public List<InputFieldDtoRq> Fields { get; set; }

        /// <summary>
        /// Gets or Sets PaySum
        /// </summary>
        [DataMember(Name = "paySum", IsRequired = true, EmitDefaultValue = true)]
        public MoneyDto PaySum { get; set; }

        /// <summary>
        /// Gets or Sets ClientProduct
        /// </summary>
        [DataMember(Name = "clientProduct", IsRequired = true, EmitDefaultValue = true)]
        public ClientProductDtoRq ClientProduct { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RequestPaymentDtoRq {\n");
            sb.Append("  ProviderService: ").Append(ProviderService).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  PaySum: ").Append(PaySum).Append("\n");
            sb.Append("  ClientProduct: ").Append(ClientProduct).Append("\n");
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
            return this.Equals(input as RequestPaymentDtoRq);
        }

        /// <summary>
        /// Returns true if RequestPaymentDtoRq instances are equal
        /// </summary>
        /// <param name="input">Instance of RequestPaymentDtoRq to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RequestPaymentDtoRq input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ProviderService == input.ProviderService ||
                    (this.ProviderService != null &&
                    this.ProviderService.Equals(input.ProviderService))
                ) && 
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
                ) && 
                (
                    this.ClientProduct == input.ClientProduct ||
                    (this.ClientProduct != null &&
                    this.ClientProduct.Equals(input.ClientProduct))
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
                if (this.ProviderService != null)
                {
                    hashCode = (hashCode * 59) + this.ProviderService.GetHashCode();
                }
                if (this.Fields != null)
                {
                    hashCode = (hashCode * 59) + this.Fields.GetHashCode();
                }
                if (this.PaySum != null)
                {
                    hashCode = (hashCode * 59) + this.PaySum.GetHashCode();
                }
                if (this.ClientProduct != null)
                {
                    hashCode = (hashCode * 59) + this.ClientProduct.GetHashCode();
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

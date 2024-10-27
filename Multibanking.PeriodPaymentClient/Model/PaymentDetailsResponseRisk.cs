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
    /// Раздел Risk отправляется инициатором платежа в ППИУ, используется для указания дополнительных деталей для оценки рисков при проведении платежей
    /// </summary>
    [DataContract(Name = "PaymentDetailsResponse_Risk")]
    public partial class PaymentDetailsResponseRisk : IEquatable<PaymentDetailsResponseRisk>, IValidatableObject
    {

        /// <summary>
        /// Контекст проведения платежа
        /// </summary>
        /// <value>Контекст проведения платежа</value>
        [DataMember(Name = "paymentContextCode", EmitDefaultValue = false)]
        public PaymentContextCode? PaymentContextCode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentDetailsResponseRisk" /> class.
        /// </summary>
        /// <param name="paymentContextCode">Контекст проведения платежа.</param>
        /// <param name="merchantCategoryCode">Код категории соответствует ISO 18245 и относится к типу услуг или товаров, которые продавец предоставляет для транзакции.</param>
        /// <param name="merchantCustomerIdentification">Уникальный идентификатор покупателя, который продавец присвоил Пользователю.</param>
        /// <param name="deliveryAddress">Почтовый адрес.</param>
        public PaymentDetailsResponseRisk(PaymentContextCode? paymentContextCode = default(PaymentContextCode?), string merchantCategoryCode = default(string), string merchantCustomerIdentification = default(string), List<RiskDeliveryAddressInner> deliveryAddress = default(List<RiskDeliveryAddressInner>))
        {
            this.PaymentContextCode = paymentContextCode;
            this.MerchantCategoryCode = merchantCategoryCode;
            this.MerchantCustomerIdentification = merchantCustomerIdentification;
            this.DeliveryAddress = deliveryAddress;
        }

        /// <summary>
        /// Код категории соответствует ISO 18245 и относится к типу услуг или товаров, которые продавец предоставляет для транзакции
        /// </summary>
        /// <value>Код категории соответствует ISO 18245 и относится к типу услуг или товаров, которые продавец предоставляет для транзакции</value>
        [DataMember(Name = "merchantCategoryCode", EmitDefaultValue = false)]
        public string MerchantCategoryCode { get; set; }

        /// <summary>
        /// Уникальный идентификатор покупателя, который продавец присвоил Пользователю
        /// </summary>
        /// <value>Уникальный идентификатор покупателя, который продавец присвоил Пользователю</value>
        [DataMember(Name = "merchantCustomerIdentification", EmitDefaultValue = false)]
        public string MerchantCustomerIdentification { get; set; }

        /// <summary>
        /// Почтовый адрес
        /// </summary>
        /// <value>Почтовый адрес</value>
        [DataMember(Name = "DeliveryAddress", EmitDefaultValue = false)]
        public List<RiskDeliveryAddressInner> DeliveryAddress { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentDetailsResponseRisk {\n");
            sb.Append("  PaymentContextCode: ").Append(PaymentContextCode).Append("\n");
            sb.Append("  MerchantCategoryCode: ").Append(MerchantCategoryCode).Append("\n");
            sb.Append("  MerchantCustomerIdentification: ").Append(MerchantCustomerIdentification).Append("\n");
            sb.Append("  DeliveryAddress: ").Append(DeliveryAddress).Append("\n");
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
            return this.Equals(input as PaymentDetailsResponseRisk);
        }

        /// <summary>
        /// Returns true if PaymentDetailsResponseRisk instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentDetailsResponseRisk to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentDetailsResponseRisk input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PaymentContextCode == input.PaymentContextCode ||
                    this.PaymentContextCode.Equals(input.PaymentContextCode)
                ) && 
                (
                    this.MerchantCategoryCode == input.MerchantCategoryCode ||
                    (this.MerchantCategoryCode != null &&
                    this.MerchantCategoryCode.Equals(input.MerchantCategoryCode))
                ) && 
                (
                    this.MerchantCustomerIdentification == input.MerchantCustomerIdentification ||
                    (this.MerchantCustomerIdentification != null &&
                    this.MerchantCustomerIdentification.Equals(input.MerchantCustomerIdentification))
                ) && 
                (
                    this.DeliveryAddress == input.DeliveryAddress ||
                    this.DeliveryAddress != null &&
                    input.DeliveryAddress != null &&
                    this.DeliveryAddress.SequenceEqual(input.DeliveryAddress)
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
                hashCode = (hashCode * 59) + this.PaymentContextCode.GetHashCode();
                if (this.MerchantCategoryCode != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCategoryCode.GetHashCode();
                }
                if (this.MerchantCustomerIdentification != null)
                {
                    hashCode = (hashCode * 59) + this.MerchantCustomerIdentification.GetHashCode();
                }
                if (this.DeliveryAddress != null)
                {
                    hashCode = (hashCode * 59) + this.DeliveryAddress.GetHashCode();
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
            // MerchantCategoryCode (string) pattern
            Regex regexMerchantCategoryCode = new Regex(@"^\\d{3,4}$", RegexOptions.CultureInvariant);
            if (false == regexMerchantCategoryCode.Match(this.MerchantCategoryCode).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantCategoryCode, must match a pattern of " + regexMerchantCategoryCode, new [] { "MerchantCategoryCode" });
            }

            // MerchantCustomerIdentification (string) maxLength
            if (this.MerchantCustomerIdentification != null && this.MerchantCustomerIdentification.Length > 70)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for MerchantCustomerIdentification, length must be less than 70.", new [] { "MerchantCustomerIdentification" });
            }

            yield break;
        }
    }

}

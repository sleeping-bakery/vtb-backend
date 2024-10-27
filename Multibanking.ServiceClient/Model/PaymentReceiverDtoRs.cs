/*
 * Поисковые сервисы каталога поставщиков услуг
 *
 * Поисковые сервисы каталога поставщиков услуг
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
using OpenAPIDateConverter = Multibanking.ServiceClient.Client.OpenAPIDateConverter;

namespace Multibanking.ServiceClient.Model
{
    /// <summary>
    /// Получатель платежа
    /// </summary>
    [DataContract(Name = "PaymentReceiverDtoRs")]
    public partial class PaymentReceiverDtoRs : IEquatable<PaymentReceiverDtoRs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PaymentReceiverDtoRs" /> class.
        /// </summary>
        /// <param name="inn">ИНН получателя платежа.</param>
        /// <param name="kpp">КПП получателя платежа.</param>
        /// <param name="account">Номер счета получателя платежа.</param>
        /// <param name="bank">bank.</param>
        public PaymentReceiverDtoRs(string inn = default(string), string kpp = default(string), string account = default(string), BankDtoRs bank = default(BankDtoRs))
        {
            this.Inn = inn;
            this.Kpp = kpp;
            this.Account = account;
            this.Bank = bank;
        }

        /// <summary>
        /// ИНН получателя платежа
        /// </summary>
        /// <value>ИНН получателя платежа</value>
        [DataMember(Name = "inn", EmitDefaultValue = false)]
        public string Inn { get; set; }

        /// <summary>
        /// КПП получателя платежа
        /// </summary>
        /// <value>КПП получателя платежа</value>
        [DataMember(Name = "kpp", EmitDefaultValue = false)]
        public string Kpp { get; set; }

        /// <summary>
        /// Номер счета получателя платежа
        /// </summary>
        /// <value>Номер счета получателя платежа</value>
        [DataMember(Name = "account", EmitDefaultValue = false)]
        public string Account { get; set; }

        /// <summary>
        /// Gets or Sets Bank
        /// </summary>
        [DataMember(Name = "bank", EmitDefaultValue = false)]
        public BankDtoRs Bank { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PaymentReceiverDtoRs {\n");
            sb.Append("  Inn: ").Append(Inn).Append("\n");
            sb.Append("  Kpp: ").Append(Kpp).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Bank: ").Append(Bank).Append("\n");
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
            return this.Equals(input as PaymentReceiverDtoRs);
        }

        /// <summary>
        /// Returns true if PaymentReceiverDtoRs instances are equal
        /// </summary>
        /// <param name="input">Instance of PaymentReceiverDtoRs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PaymentReceiverDtoRs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Inn == input.Inn ||
                    (this.Inn != null &&
                    this.Inn.Equals(input.Inn))
                ) && 
                (
                    this.Kpp == input.Kpp ||
                    (this.Kpp != null &&
                    this.Kpp.Equals(input.Kpp))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Bank == input.Bank ||
                    (this.Bank != null &&
                    this.Bank.Equals(input.Bank))
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
                if (this.Inn != null)
                {
                    hashCode = (hashCode * 59) + this.Inn.GetHashCode();
                }
                if (this.Kpp != null)
                {
                    hashCode = (hashCode * 59) + this.Kpp.GetHashCode();
                }
                if (this.Account != null)
                {
                    hashCode = (hashCode * 59) + this.Account.GetHashCode();
                }
                if (this.Bank != null)
                {
                    hashCode = (hashCode * 59) + this.Bank.GetHashCode();
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
            // Inn (string) maxLength
            if (this.Inn != null && this.Inn.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Inn, length must be less than 12.", new [] { "Inn" });
            }

            // Kpp (string) maxLength
            if (this.Kpp != null && this.Kpp.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Kpp, length must be less than 9.", new [] { "Kpp" });
            }

            // Account (string) maxLength
            if (this.Account != null && this.Account.Length > 20)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Account, length must be less than 20.", new [] { "Account" });
            }

            yield break;
        }
    }

}
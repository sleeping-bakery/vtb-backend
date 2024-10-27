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
    /// Информация о продукте клиента
    /// </summary>
    [DataContract(Name = "ClientProductsDtoRs")]
    public partial class ClientProductsDtoRs : IEquatable<ClientProductsDtoRs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ClientProductsDtoRs" /> class.
        /// </summary>
        /// <param name="accounts">Список счетов клиента.</param>
        /// <param name="cards">Список карт клиента.</param>
        public ClientProductsDtoRs(List<AccountDtoRs> accounts = default(List<AccountDtoRs>), List<CardDtoRs> cards = default(List<CardDtoRs>))
        {
            this.Accounts = accounts;
            this.Cards = cards;
        }

        /// <summary>
        /// Список счетов клиента
        /// </summary>
        /// <value>Список счетов клиента</value>
        [DataMember(Name = "accounts", EmitDefaultValue = false)]
        public List<AccountDtoRs> Accounts { get; set; }

        /// <summary>
        /// Список карт клиента
        /// </summary>
        /// <value>Список карт клиента</value>
        [DataMember(Name = "cards", EmitDefaultValue = false)]
        public List<CardDtoRs> Cards { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ClientProductsDtoRs {\n");
            sb.Append("  Accounts: ").Append(Accounts).Append("\n");
            sb.Append("  Cards: ").Append(Cards).Append("\n");
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
            return this.Equals(input as ClientProductsDtoRs);
        }

        /// <summary>
        /// Returns true if ClientProductsDtoRs instances are equal
        /// </summary>
        /// <param name="input">Instance of ClientProductsDtoRs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ClientProductsDtoRs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Accounts == input.Accounts ||
                    this.Accounts != null &&
                    input.Accounts != null &&
                    this.Accounts.SequenceEqual(input.Accounts)
                ) && 
                (
                    this.Cards == input.Cards ||
                    this.Cards != null &&
                    input.Cards != null &&
                    this.Cards.SequenceEqual(input.Cards)
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
                if (this.Accounts != null)
                {
                    hashCode = (hashCode * 59) + this.Accounts.GetHashCode();
                }
                if (this.Cards != null)
                {
                    hashCode = (hashCode * 59) + this.Cards.GetHashCode();
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

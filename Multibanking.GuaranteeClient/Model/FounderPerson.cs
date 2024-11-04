/*
 * Система рассмотрения заявок на экспресс-гарантии, полученных от партнеров банка
 *
 * Функционал выдачи экспресс гарантий позволяет реализовать след. сервисы:  - Создание клиентом заявки в личном кабинете на выдачу экспресс-гарантии - Отображение информации о закупке по минимальному набору введенных атрибутов - Загрузка и прикрепление документов к заявке - Формирование заявления на выдачу экспресс-гарантии для подписания клиентом - Подписание клиентом заявления с использованием УНЭП - Отображение в Интернет банке статусов заявки - Получение и передача заявок от партнеров - Создание сотрудником банка заявки на гарантию - Формирование проекта решения по заявке на гарантию 
 *
 * The version of the OpenAPI document: 1.4.1
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
using OpenAPIDateConverter = Multibanking.GuaranteeClient.Client.OpenAPIDateConverter;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    /// Данные учредителя
    /// </summary>
    [DataContract(Name = "FounderPerson")]
    public partial class FounderPerson : IEquatable<FounderPerson>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FounderPerson" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FounderPerson() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FounderPerson" /> class.
        /// </summary>
        /// <param name="id">Id (required).</param>
        /// <param name="phone">Телефон (required).</param>
        /// <param name="identityDocument">identityDocument (required).</param>
        /// <param name="personData">personData.</param>
        /// <param name="sharePercent">Доля, % (required).</param>
        /// <param name="shareSum">Доля, руб.</param>
        public FounderPerson(string id = default(string), string phone = default(string), IdentityDocument identityDocument = default(IdentityDocument), PersonData personData = default(PersonData), decimal sharePercent = default(decimal), decimal shareSum = default(decimal))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for FounderPerson and cannot be null");
            }
            this.Id = id;
            // to ensure "phone" is required (not null)
            if (phone == null)
            {
                throw new ArgumentNullException("phone is a required property for FounderPerson and cannot be null");
            }
            this.Phone = phone;
            // to ensure "identityDocument" is required (not null)
            if (identityDocument == null)
            {
                throw new ArgumentNullException("identityDocument is a required property for FounderPerson and cannot be null");
            }
            this.IdentityDocument = identityDocument;
            this.SharePercent = sharePercent;
            this.PersonData = personData;
            this.ShareSum = shareSum;
        }

        /// <summary>
        /// Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Телефон
        /// </summary>
        /// <value>Телефон</value>
        [DataMember(Name = "phone", IsRequired = true, EmitDefaultValue = true)]
        public string Phone { get; set; }

        /// <summary>
        /// Gets or Sets IdentityDocument
        /// </summary>
        [DataMember(Name = "identityDocument", IsRequired = true, EmitDefaultValue = true)]
        public IdentityDocument IdentityDocument { get; set; }

        /// <summary>
        /// Gets or Sets PersonData
        /// </summary>
        [DataMember(Name = "personData", EmitDefaultValue = false)]
        public PersonData PersonData { get; set; }

        /// <summary>
        /// Доля, %
        /// </summary>
        /// <value>Доля, %</value>
        [DataMember(Name = "sharePercent", IsRequired = true, EmitDefaultValue = true)]
        public decimal SharePercent { get; set; }

        /// <summary>
        /// Доля, руб
        /// </summary>
        /// <value>Доля, руб</value>
        [DataMember(Name = "shareSum", EmitDefaultValue = false)]
        public decimal ShareSum { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FounderPerson {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Phone: ").Append(Phone).Append("\n");
            sb.Append("  IdentityDocument: ").Append(IdentityDocument).Append("\n");
            sb.Append("  PersonData: ").Append(PersonData).Append("\n");
            sb.Append("  SharePercent: ").Append(SharePercent).Append("\n");
            sb.Append("  ShareSum: ").Append(ShareSum).Append("\n");
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
            return this.Equals(input as FounderPerson);
        }

        /// <summary>
        /// Returns true if FounderPerson instances are equal
        /// </summary>
        /// <param name="input">Instance of FounderPerson to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FounderPerson input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Phone == input.Phone ||
                    (this.Phone != null &&
                    this.Phone.Equals(input.Phone))
                ) && 
                (
                    this.IdentityDocument == input.IdentityDocument ||
                    (this.IdentityDocument != null &&
                    this.IdentityDocument.Equals(input.IdentityDocument))
                ) && 
                (
                    this.PersonData == input.PersonData ||
                    (this.PersonData != null &&
                    this.PersonData.Equals(input.PersonData))
                ) && 
                (
                    this.SharePercent == input.SharePercent ||
                    this.SharePercent.Equals(input.SharePercent)
                ) && 
                (
                    this.ShareSum == input.ShareSum ||
                    this.ShareSum.Equals(input.ShareSum)
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.Phone != null)
                {
                    hashCode = (hashCode * 59) + this.Phone.GetHashCode();
                }
                if (this.IdentityDocument != null)
                {
                    hashCode = (hashCode * 59) + this.IdentityDocument.GetHashCode();
                }
                if (this.PersonData != null)
                {
                    hashCode = (hashCode * 59) + this.PersonData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SharePercent.GetHashCode();
                hashCode = (hashCode * 59) + this.ShareSum.GetHashCode();
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

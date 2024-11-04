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
    /// Данные о физ лице
    /// </summary>
    [DataContract(Name = "PersonData")]
    public partial class PersonData : IEquatable<PersonData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PersonData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PersonData" /> class.
        /// </summary>
        /// <param name="lastName">Фамилия (required).</param>
        /// <param name="firstName">Имя (required).</param>
        /// <param name="secondName">Отчество.</param>
        /// <param name="personAttributes">personAttributes.</param>
        public PersonData(string lastName = default(string), string firstName = default(string), string secondName = default(string), PersonAttributes personAttributes = default(PersonAttributes))
        {
            // to ensure "lastName" is required (not null)
            if (lastName == null)
            {
                throw new ArgumentNullException("lastName is a required property for PersonData and cannot be null");
            }
            this.LastName = lastName;
            // to ensure "firstName" is required (not null)
            if (firstName == null)
            {
                throw new ArgumentNullException("firstName is a required property for PersonData and cannot be null");
            }
            this.FirstName = firstName;
            this.SecondName = secondName;
            this.PersonAttributes = personAttributes;
        }

        /// <summary>
        /// Фамилия
        /// </summary>
        /// <value>Фамилия</value>
        [DataMember(Name = "lastName", IsRequired = true, EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Имя
        /// </summary>
        /// <value>Имя</value>
        [DataMember(Name = "firstName", IsRequired = true, EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Отчество
        /// </summary>
        /// <value>Отчество</value>
        [DataMember(Name = "secondName", EmitDefaultValue = false)]
        public string SecondName { get; set; }

        /// <summary>
        /// Gets or Sets PersonAttributes
        /// </summary>
        [DataMember(Name = "personAttributes", EmitDefaultValue = false)]
        public PersonAttributes PersonAttributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PersonData {\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  SecondName: ").Append(SecondName).Append("\n");
            sb.Append("  PersonAttributes: ").Append(PersonAttributes).Append("\n");
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
            return this.Equals(input as PersonData);
        }

        /// <summary>
        /// Returns true if PersonData instances are equal
        /// </summary>
        /// <param name="input">Instance of PersonData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PersonData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.SecondName == input.SecondName ||
                    (this.SecondName != null &&
                    this.SecondName.Equals(input.SecondName))
                ) && 
                (
                    this.PersonAttributes == input.PersonAttributes ||
                    (this.PersonAttributes != null &&
                    this.PersonAttributes.Equals(input.PersonAttributes))
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
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.SecondName != null)
                {
                    hashCode = (hashCode * 59) + this.SecondName.GetHashCode();
                }
                if (this.PersonAttributes != null)
                {
                    hashCode = (hashCode * 59) + this.PersonAttributes.GetHashCode();
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
            // LastName (string) maxLength
            if (this.LastName != null && this.LastName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be less than 255.", new [] { "LastName" });
            }

            // LastName (string) minLength
            if (this.LastName != null && this.LastName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for LastName, length must be greater than 1.", new [] { "LastName" });
            }

            // FirstName (string) maxLength
            if (this.FirstName != null && this.FirstName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be less than 255.", new [] { "FirstName" });
            }

            // FirstName (string) minLength
            if (this.FirstName != null && this.FirstName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FirstName, length must be greater than 1.", new [] { "FirstName" });
            }

            // SecondName (string) maxLength
            if (this.SecondName != null && this.SecondName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondName, length must be less than 255.", new [] { "SecondName" });
            }

            // SecondName (string) minLength
            if (this.SecondName != null && this.SecondName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SecondName, length must be greater than 1.", new [] { "SecondName" });
            }

            yield break;
        }
    }

}
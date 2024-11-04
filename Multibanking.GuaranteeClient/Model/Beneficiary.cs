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
    /// Данные о бенефициаре
    /// </summary>
    [DataContract(Name = "Beneficiary")]
    public partial class Beneficiary : IEquatable<Beneficiary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Beneficiary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Beneficiary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Beneficiary" /> class.
        /// </summary>
        /// <param name="fullName">Название (required).</param>
        /// <param name="shortName">Название (required).</param>
        /// <param name="inn">ИНН (required).</param>
        /// <param name="kpp">КПП.</param>
        /// <param name="ogrn">ОГРН (required).</param>
        /// <param name="okopf">ОКОПФ (required).</param>
        /// <param name="oktmo">ОКТМО (required).</param>
        /// <param name="okpo">ОКПО (required).</param>
        /// <param name="okved">ОКВЭД (required).</param>
        /// <param name="okvedName">Наименование ОКВЭД.</param>
        /// <param name="addresses">addresses (required).</param>
        public Beneficiary(string fullName = default(string), string shortName = default(string), string inn = default(string), string kpp = default(string), string ogrn = default(string), string okopf = default(string), string oktmo = default(string), string okpo = default(string), string okved = default(string), string okvedName = default(string), List<GuaranteeAddress> addresses = default(List<GuaranteeAddress>))
        {
            // to ensure "fullName" is required (not null)
            if (fullName == null)
            {
                throw new ArgumentNullException("fullName is a required property for Beneficiary and cannot be null");
            }
            this.FullName = fullName;
            // to ensure "shortName" is required (not null)
            if (shortName == null)
            {
                throw new ArgumentNullException("shortName is a required property for Beneficiary and cannot be null");
            }
            this.ShortName = shortName;
            // to ensure "inn" is required (not null)
            if (inn == null)
            {
                throw new ArgumentNullException("inn is a required property for Beneficiary and cannot be null");
            }
            this.Inn = inn;
            // to ensure "ogrn" is required (not null)
            if (ogrn == null)
            {
                throw new ArgumentNullException("ogrn is a required property for Beneficiary and cannot be null");
            }
            this.Ogrn = ogrn;
            // to ensure "okopf" is required (not null)
            if (okopf == null)
            {
                throw new ArgumentNullException("okopf is a required property for Beneficiary and cannot be null");
            }
            this.Okopf = okopf;
            // to ensure "oktmo" is required (not null)
            if (oktmo == null)
            {
                throw new ArgumentNullException("oktmo is a required property for Beneficiary and cannot be null");
            }
            this.Oktmo = oktmo;
            // to ensure "okpo" is required (not null)
            if (okpo == null)
            {
                throw new ArgumentNullException("okpo is a required property for Beneficiary and cannot be null");
            }
            this.Okpo = okpo;
            // to ensure "okved" is required (not null)
            if (okved == null)
            {
                throw new ArgumentNullException("okved is a required property for Beneficiary and cannot be null");
            }
            this.Okved = okved;
            // to ensure "addresses" is required (not null)
            if (addresses == null)
            {
                throw new ArgumentNullException("addresses is a required property for Beneficiary and cannot be null");
            }
            this.Addresses = addresses;
            this.Kpp = kpp;
            this.OkvedName = okvedName;
        }

        /// <summary>
        /// Название
        /// </summary>
        /// <value>Название</value>
        [DataMember(Name = "fullName", IsRequired = true, EmitDefaultValue = true)]
        public string FullName { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        /// <value>Название</value>
        [DataMember(Name = "shortName", IsRequired = true, EmitDefaultValue = true)]
        public string ShortName { get; set; }

        /// <summary>
        /// ИНН
        /// </summary>
        /// <value>ИНН</value>
        [DataMember(Name = "inn", IsRequired = true, EmitDefaultValue = true)]
        public string Inn { get; set; }

        /// <summary>
        /// КПП
        /// </summary>
        /// <value>КПП</value>
        [DataMember(Name = "kpp", EmitDefaultValue = false)]
        public string Kpp { get; set; }

        /// <summary>
        /// ОГРН
        /// </summary>
        /// <value>ОГРН</value>
        [DataMember(Name = "ogrn", IsRequired = true, EmitDefaultValue = true)]
        public string Ogrn { get; set; }

        /// <summary>
        /// ОКОПФ
        /// </summary>
        /// <value>ОКОПФ</value>
        [DataMember(Name = "okopf", IsRequired = true, EmitDefaultValue = true)]
        public string Okopf { get; set; }

        /// <summary>
        /// ОКТМО
        /// </summary>
        /// <value>ОКТМО</value>
        [DataMember(Name = "oktmo", IsRequired = true, EmitDefaultValue = true)]
        public string Oktmo { get; set; }

        /// <summary>
        /// ОКПО
        /// </summary>
        /// <value>ОКПО</value>
        [DataMember(Name = "okpo", IsRequired = true, EmitDefaultValue = true)]
        public string Okpo { get; set; }

        /// <summary>
        /// ОКВЭД
        /// </summary>
        /// <value>ОКВЭД</value>
        [DataMember(Name = "okved", IsRequired = true, EmitDefaultValue = true)]
        public string Okved { get; set; }

        /// <summary>
        /// Наименование ОКВЭД
        /// </summary>
        /// <value>Наименование ОКВЭД</value>
        [DataMember(Name = "okvedName", EmitDefaultValue = false)]
        public string OkvedName { get; set; }

        /// <summary>
        /// Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = true)]
        public List<GuaranteeAddress> Addresses { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Beneficiary {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Inn: ").Append(Inn).Append("\n");
            sb.Append("  Kpp: ").Append(Kpp).Append("\n");
            sb.Append("  Ogrn: ").Append(Ogrn).Append("\n");
            sb.Append("  Okopf: ").Append(Okopf).Append("\n");
            sb.Append("  Oktmo: ").Append(Oktmo).Append("\n");
            sb.Append("  Okpo: ").Append(Okpo).Append("\n");
            sb.Append("  Okved: ").Append(Okved).Append("\n");
            sb.Append("  OkvedName: ").Append(OkvedName).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
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
            return this.Equals(input as Beneficiary);
        }

        /// <summary>
        /// Returns true if Beneficiary instances are equal
        /// </summary>
        /// <param name="input">Instance of Beneficiary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Beneficiary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.FullName == input.FullName ||
                    (this.FullName != null &&
                    this.FullName.Equals(input.FullName))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
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
                    this.Ogrn == input.Ogrn ||
                    (this.Ogrn != null &&
                    this.Ogrn.Equals(input.Ogrn))
                ) && 
                (
                    this.Okopf == input.Okopf ||
                    (this.Okopf != null &&
                    this.Okopf.Equals(input.Okopf))
                ) && 
                (
                    this.Oktmo == input.Oktmo ||
                    (this.Oktmo != null &&
                    this.Oktmo.Equals(input.Oktmo))
                ) && 
                (
                    this.Okpo == input.Okpo ||
                    (this.Okpo != null &&
                    this.Okpo.Equals(input.Okpo))
                ) && 
                (
                    this.Okved == input.Okved ||
                    (this.Okved != null &&
                    this.Okved.Equals(input.Okved))
                ) && 
                (
                    this.OkvedName == input.OkvedName ||
                    (this.OkvedName != null &&
                    this.OkvedName.Equals(input.OkvedName))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
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
                if (this.FullName != null)
                {
                    hashCode = (hashCode * 59) + this.FullName.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Inn != null)
                {
                    hashCode = (hashCode * 59) + this.Inn.GetHashCode();
                }
                if (this.Kpp != null)
                {
                    hashCode = (hashCode * 59) + this.Kpp.GetHashCode();
                }
                if (this.Ogrn != null)
                {
                    hashCode = (hashCode * 59) + this.Ogrn.GetHashCode();
                }
                if (this.Okopf != null)
                {
                    hashCode = (hashCode * 59) + this.Okopf.GetHashCode();
                }
                if (this.Oktmo != null)
                {
                    hashCode = (hashCode * 59) + this.Oktmo.GetHashCode();
                }
                if (this.Okpo != null)
                {
                    hashCode = (hashCode * 59) + this.Okpo.GetHashCode();
                }
                if (this.Okved != null)
                {
                    hashCode = (hashCode * 59) + this.Okved.GetHashCode();
                }
                if (this.OkvedName != null)
                {
                    hashCode = (hashCode * 59) + this.OkvedName.GetHashCode();
                }
                if (this.Addresses != null)
                {
                    hashCode = (hashCode * 59) + this.Addresses.GetHashCode();
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
            // FullName (string) maxLength
            if (this.FullName != null && this.FullName.Length > 1000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FullName, length must be less than 1000.", new [] { "FullName" });
            }

            // FullName (string) minLength
            if (this.FullName != null && this.FullName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FullName, length must be greater than 1.", new [] { "FullName" });
            }

            // ShortName (string) maxLength
            if (this.ShortName != null && this.ShortName.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortName, length must be less than 500.", new [] { "ShortName" });
            }

            // ShortName (string) minLength
            if (this.ShortName != null && this.ShortName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortName, length must be greater than 1.", new [] { "ShortName" });
            }

            // Inn (string) maxLength
            if (this.Inn != null && this.Inn.Length > 12)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Inn, length must be less than 12.", new [] { "Inn" });
            }

            // Inn (string) minLength
            if (this.Inn != null && this.Inn.Length < 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Inn, length must be greater than 10.", new [] { "Inn" });
            }

            // Kpp (string) maxLength
            if (this.Kpp != null && this.Kpp.Length > 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Kpp, length must be less than 9.", new [] { "Kpp" });
            }

            // Kpp (string) minLength
            if (this.Kpp != null && this.Kpp.Length < 9)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Kpp, length must be greater than 9.", new [] { "Kpp" });
            }

            // Ogrn (string) maxLength
            if (this.Ogrn != null && this.Ogrn.Length > 15)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ogrn, length must be less than 15.", new [] { "Ogrn" });
            }

            // Ogrn (string) minLength
            if (this.Ogrn != null && this.Ogrn.Length < 13)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Ogrn, length must be greater than 13.", new [] { "Ogrn" });
            }

            // Okopf (string) maxLength
            if (this.Okopf != null && this.Okopf.Length > 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Okopf, length must be less than 5.", new [] { "Okopf" });
            }

            // Okopf (string) minLength
            if (this.Okopf != null && this.Okopf.Length < 5)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Okopf, length must be greater than 5.", new [] { "Okopf" });
            }

            // Oktmo (string) maxLength
            if (this.Oktmo != null && this.Oktmo.Length > 11)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Oktmo, length must be less than 11.", new [] { "Oktmo" });
            }

            // Oktmo (string) minLength
            if (this.Oktmo != null && this.Oktmo.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Oktmo, length must be greater than 8.", new [] { "Oktmo" });
            }

            // Okpo (string) maxLength
            if (this.Okpo != null && this.Okpo.Length > 10)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Okpo, length must be less than 10.", new [] { "Okpo" });
            }

            // Okpo (string) minLength
            if (this.Okpo != null && this.Okpo.Length < 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Okpo, length must be greater than 8.", new [] { "Okpo" });
            }

            // Okved (string) maxLength
            if (this.Okved != null && this.Okved.Length > 8)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Okved, length must be less than 8.", new [] { "Okved" });
            }

            // Okved (string) minLength
            if (this.Okved != null && this.Okved.Length < 2)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Okved, length must be greater than 2.", new [] { "Okved" });
            }

            // OkvedName (string) maxLength
            if (this.OkvedName != null && this.OkvedName.Length > 700)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OkvedName, length must be less than 700.", new [] { "OkvedName" });
            }

            // OkvedName (string) minLength
            if (this.OkvedName != null && this.OkvedName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OkvedName, length must be greater than 1.", new [] { "OkvedName" });
            }

            yield break;
        }
    }

}

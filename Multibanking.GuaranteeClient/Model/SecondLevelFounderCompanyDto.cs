/*
 * Система рассмотрения заявок на экспресс-гарантии, полученных от партнеров банка
 *
 * Функционал выдачи экспресс гарантий позволяет реализовать след. сервисы:  - Создание клиентом заявки в личном кабинете на выдачу экспресс-гарантии - Отображение информации о закупке по минимальному набору введенных атрибутов - Загрузка и прикрепление документов к заявке - Формирование заявления на выдачу экспресс-гарантии для подписания клиентом - Подписание клиентом заявления с использованием УНЭП - Отображение в Интернет банке статусов заявки - Получение и передача заявок от партнеров - Создание сотрудником банка заявки на гарантию - Формирование проекта решения по заявке на гарантию
 *
 * The version of the OpenAPI document: 1.4.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    ///     Данные об Учредителе Юр лице/ИП второго уровня
    /// </summary>
    [DataContract(Name = "SecondLevelFounderCompanyDto")]
    public class SecondLevelFounderCompanyDto : IEquatable<SecondLevelFounderCompanyDto>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SecondLevelFounderCompanyDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SecondLevelFounderCompanyDto()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="SecondLevelFounderCompanyDto" /> class.
        /// </summary>
        /// <param name="id">Id (required).</param>
        /// <param name="guaranteeCompanyInfo">guaranteeCompanyInfo (required).</param>
        /// <param name="addresses">addresses (required).</param>
        /// <param name="sharePercent">Доля, % (required).</param>
        /// <param name="shareSum">Доля, руб.</param>
        /// <param name="founderPersons">founderPersons.</param>
        public SecondLevelFounderCompanyDto(string id = default, GuaranteeCompanyInfo guaranteeCompanyInfo = default, List<GuaranteeAddress> addresses = default,
            decimal sharePercent = default, decimal shareSum = default, List<FounderPerson> founderPersons = default)
        {
            // to ensure "id" is required (not null)
            if (id == null) throw new ArgumentNullException("id is a required property for SecondLevelFounderCompanyDto and cannot be null");
            Id = id;
            // to ensure "guaranteeCompanyInfo" is required (not null)
            if (guaranteeCompanyInfo == null) throw new ArgumentNullException("guaranteeCompanyInfo is a required property for SecondLevelFounderCompanyDto and cannot be null");
            GuaranteeCompanyInfo = guaranteeCompanyInfo;
            // to ensure "addresses" is required (not null)
            if (addresses == null) throw new ArgumentNullException("addresses is a required property for SecondLevelFounderCompanyDto and cannot be null");
            Addresses = addresses;
            SharePercent = sharePercent;
            ShareSum = shareSum;
            FounderPersons = founderPersons;
        }

        /// <summary>
        ///     Id
        /// </summary>
        /// <value>Id</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        ///     Gets or Sets GuaranteeCompanyInfo
        /// </summary>
        [DataMember(Name = "guaranteeCompanyInfo", IsRequired = true, EmitDefaultValue = true)]
        public GuaranteeCompanyInfo GuaranteeCompanyInfo { get; set; }

        /// <summary>
        ///     Gets or Sets Addresses
        /// </summary>
        [DataMember(Name = "addresses", IsRequired = true, EmitDefaultValue = true)]
        public List<GuaranteeAddress> Addresses { get; set; }

        /// <summary>
        ///     Доля, %
        /// </summary>
        /// <value>Доля, %</value>
        [DataMember(Name = "sharePercent", IsRequired = true, EmitDefaultValue = true)]
        public decimal SharePercent { get; set; }

        /// <summary>
        ///     Доля, руб
        /// </summary>
        /// <value>Доля, руб</value>
        [DataMember(Name = "shareSum", EmitDefaultValue = false)]
        public decimal ShareSum { get; set; }

        /// <summary>
        ///     Gets or Sets FounderPersons
        /// </summary>
        [DataMember(Name = "founderPersons", EmitDefaultValue = false)]
        public List<FounderPerson> FounderPersons { get; set; }

        /// <summary>
        ///     Returns true if SecondLevelFounderCompanyDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SecondLevelFounderCompanyDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SecondLevelFounderCompanyDto input)
        {
            if (input == null) return false;
            return
                (
                    Id == input.Id ||
                    (Id != null &&
                     Id.Equals(input.Id))
                ) &&
                (
                    GuaranteeCompanyInfo == input.GuaranteeCompanyInfo ||
                    (GuaranteeCompanyInfo != null &&
                     GuaranteeCompanyInfo.Equals(input.GuaranteeCompanyInfo))
                ) &&
                (
                    Addresses == input.Addresses ||
                    (Addresses != null &&
                     input.Addresses != null &&
                     Addresses.SequenceEqual(input.Addresses))
                ) &&
                (
                    SharePercent == input.SharePercent ||
                    SharePercent.Equals(input.SharePercent)
                ) &&
                (
                    ShareSum == input.ShareSum ||
                    ShareSum.Equals(input.ShareSum)
                ) &&
                (
                    FounderPersons == input.FounderPersons ||
                    (FounderPersons != null &&
                     input.FounderPersons != null &&
                     FounderPersons.SequenceEqual(input.FounderPersons))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Id (string) maxLength
            if (Id != null && Id.Length > 36) yield return new ValidationResult("Invalid value for Id, length must be less than 36.", new[] { "Id" });

            // Id (string) minLength
            if (Id != null && Id.Length < 36) yield return new ValidationResult("Invalid value for Id, length must be greater than 36.", new[] { "Id" });

            // Id (string) pattern
            var regexId = new Regex(@"^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", RegexOptions.CultureInvariant);
            if (false == regexId.Match(Id).Success) yield return new ValidationResult("Invalid value for Id, must match a pattern of " + regexId, new[] { "Id" });

            // SharePercent (decimal) maximum
            if (SharePercent > 100) yield return new ValidationResult("Invalid value for SharePercent, must be a value less than or equal to 100.", new[] { "SharePercent" });

            // SharePercent (decimal) minimum
            if (SharePercent < 0) yield return new ValidationResult("Invalid value for SharePercent, must be a value greater than or equal to 0.", new[] { "SharePercent" });

            // ShareSum (decimal) maximum
            if (ShareSum > 9007199254740991)
                yield return new ValidationResult("Invalid value for ShareSum, must be a value less than or equal to 9007199254740991.", new[] { "ShareSum" });

            // ShareSum (decimal) minimum
            if (ShareSum < 0) yield return new ValidationResult("Invalid value for ShareSum, must be a value greater than or equal to 0.", new[] { "ShareSum" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SecondLevelFounderCompanyDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GuaranteeCompanyInfo: ").Append(GuaranteeCompanyInfo).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  SharePercent: ").Append(SharePercent).Append("\n");
            sb.Append("  ShareSum: ").Append(ShareSum).Append("\n");
            sb.Append("  FounderPersons: ").Append(FounderPersons).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        ///     Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        ///     Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return Equals(input as SecondLevelFounderCompanyDto);
        }

        /// <summary>
        ///     Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                var hashCode = 41;
                if (Id != null) hashCode = hashCode * 59 + Id.GetHashCode();
                if (GuaranteeCompanyInfo != null) hashCode = hashCode * 59 + GuaranteeCompanyInfo.GetHashCode();
                if (Addresses != null) hashCode = hashCode * 59 + Addresses.GetHashCode();
                hashCode = hashCode * 59 + SharePercent.GetHashCode();
                hashCode = hashCode * 59 + ShareSum.GetHashCode();
                if (FounderPersons != null) hashCode = hashCode * 59 + FounderPersons.GetHashCode();
                return hashCode;
            }
        }
    }
}
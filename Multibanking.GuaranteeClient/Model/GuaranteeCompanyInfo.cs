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
    /// Информация об организации
    /// </summary>
    [DataContract(Name = "GuaranteeCompanyInfo")]
    public partial class GuaranteeCompanyInfo : IEquatable<GuaranteeCompanyInfo>, IValidatableObject
    {
        /// <summary>
        /// Тип организации
        /// </summary>
        /// <value>Тип организации</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GuaranteeOrgTypeEnum
        {
            /// <summary>
            /// Enum UL for value: UL
            /// </summary>
            [EnumMember(Value = "UL")]
            UL = 1,

            /// <summary>
            /// Enum IP for value: IP
            /// </summary>
            [EnumMember(Value = "IP")]
            IP = 2

        }


        /// <summary>
        /// Тип организации
        /// </summary>
        /// <value>Тип организации</value>
        [DataMember(Name = "guaranteeOrgType", IsRequired = true, EmitDefaultValue = true)]
        public GuaranteeOrgTypeEnum GuaranteeOrgType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteeCompanyInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuaranteeCompanyInfo() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GuaranteeCompanyInfo" /> class.
        /// </summary>
        /// <param name="fullName">Название (required).</param>
        /// <param name="shortName">Название (required).</param>
        /// <param name="guaranteeOrgType">Тип организации (required).</param>
        /// <param name="okopf">ОКОПФ (required).</param>
        /// <param name="okfs">ОКФС (required).</param>
        /// <param name="okpo">ОКПО (required).</param>
        /// <param name="okved">ОКВЭД (required).</param>
        /// <param name="okvedName">Наименование ОКВЭД.</param>
        /// <param name="inn">ИНН (required).</param>
        /// <param name="kpp">КПП.</param>
        /// <param name="ogrn">ОГРН (required).</param>
        /// <param name="regDateBefore01072002">Дата регистрации, до 01 июля 2002 г. Заполнить, если дата регистрации, до 01 июля 2002 г..</param>
        /// <param name="regDate">Дата регистрации (required).</param>
        public GuaranteeCompanyInfo(string fullName = default(string), string shortName = default(string), GuaranteeOrgTypeEnum guaranteeOrgType = default(GuaranteeOrgTypeEnum), string okopf = default(string), string okfs = default(string), string okpo = default(string), string okved = default(string), string okvedName = default(string), string inn = default(string), string kpp = default(string), string ogrn = default(string), DateTime regDateBefore01072002 = default(DateTime), DateTime regDate = default(DateTime))
        {
            // to ensure "fullName" is required (not null)
            if (fullName == null)
            {
                throw new ArgumentNullException("fullName is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.FullName = fullName;
            // to ensure "shortName" is required (not null)
            if (shortName == null)
            {
                throw new ArgumentNullException("shortName is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.ShortName = shortName;
            this.GuaranteeOrgType = guaranteeOrgType;
            // to ensure "okopf" is required (not null)
            if (okopf == null)
            {
                throw new ArgumentNullException("okopf is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.Okopf = okopf;
            // to ensure "okfs" is required (not null)
            if (okfs == null)
            {
                throw new ArgumentNullException("okfs is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.Okfs = okfs;
            // to ensure "okpo" is required (not null)
            if (okpo == null)
            {
                throw new ArgumentNullException("okpo is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.Okpo = okpo;
            // to ensure "okved" is required (not null)
            if (okved == null)
            {
                throw new ArgumentNullException("okved is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.Okved = okved;
            // to ensure "inn" is required (not null)
            if (inn == null)
            {
                throw new ArgumentNullException("inn is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.Inn = inn;
            // to ensure "ogrn" is required (not null)
            if (ogrn == null)
            {
                throw new ArgumentNullException("ogrn is a required property for GuaranteeCompanyInfo and cannot be null");
            }
            this.Ogrn = ogrn;
            this.RegDate = regDate;
            this.OkvedName = okvedName;
            this.Kpp = kpp;
            this.RegDateBefore01072002 = regDateBefore01072002;
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
        /// ОКОПФ
        /// </summary>
        /// <value>ОКОПФ</value>
        [DataMember(Name = "okopf", IsRequired = true, EmitDefaultValue = true)]
        public string Okopf { get; set; }

        /// <summary>
        /// ОКФС
        /// </summary>
        /// <value>ОКФС</value>
        [DataMember(Name = "okfs", IsRequired = true, EmitDefaultValue = true)]
        public string Okfs { get; set; }

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
        /// Дата регистрации, до 01 июля 2002 г. Заполнить, если дата регистрации, до 01 июля 2002 г.
        /// </summary>
        /// <value>Дата регистрации, до 01 июля 2002 г. Заполнить, если дата регистрации, до 01 июля 2002 г.</value>
        [DataMember(Name = "regDateBefore01072002", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime RegDateBefore01072002 { get; set; }

        /// <summary>
        /// Дата регистрации
        /// </summary>
        /// <value>Дата регистрации</value>
        [DataMember(Name = "regDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime RegDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GuaranteeCompanyInfo {\n");
            sb.Append("  FullName: ").Append(FullName).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  GuaranteeOrgType: ").Append(GuaranteeOrgType).Append("\n");
            sb.Append("  Okopf: ").Append(Okopf).Append("\n");
            sb.Append("  Okfs: ").Append(Okfs).Append("\n");
            sb.Append("  Okpo: ").Append(Okpo).Append("\n");
            sb.Append("  Okved: ").Append(Okved).Append("\n");
            sb.Append("  OkvedName: ").Append(OkvedName).Append("\n");
            sb.Append("  Inn: ").Append(Inn).Append("\n");
            sb.Append("  Kpp: ").Append(Kpp).Append("\n");
            sb.Append("  Ogrn: ").Append(Ogrn).Append("\n");
            sb.Append("  RegDateBefore01072002: ").Append(RegDateBefore01072002).Append("\n");
            sb.Append("  RegDate: ").Append(RegDate).Append("\n");
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
            return this.Equals(input as GuaranteeCompanyInfo);
        }

        /// <summary>
        /// Returns true if GuaranteeCompanyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GuaranteeCompanyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuaranteeCompanyInfo input)
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
                    this.GuaranteeOrgType == input.GuaranteeOrgType ||
                    this.GuaranteeOrgType.Equals(input.GuaranteeOrgType)
                ) && 
                (
                    this.Okopf == input.Okopf ||
                    (this.Okopf != null &&
                    this.Okopf.Equals(input.Okopf))
                ) && 
                (
                    this.Okfs == input.Okfs ||
                    (this.Okfs != null &&
                    this.Okfs.Equals(input.Okfs))
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
                    this.RegDateBefore01072002 == input.RegDateBefore01072002 ||
                    (this.RegDateBefore01072002 != null &&
                    this.RegDateBefore01072002.Equals(input.RegDateBefore01072002))
                ) && 
                (
                    this.RegDate == input.RegDate ||
                    (this.RegDate != null &&
                    this.RegDate.Equals(input.RegDate))
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
                hashCode = (hashCode * 59) + this.GuaranteeOrgType.GetHashCode();
                if (this.Okopf != null)
                {
                    hashCode = (hashCode * 59) + this.Okopf.GetHashCode();
                }
                if (this.Okfs != null)
                {
                    hashCode = (hashCode * 59) + this.Okfs.GetHashCode();
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
                if (this.RegDateBefore01072002 != null)
                {
                    hashCode = (hashCode * 59) + this.RegDateBefore01072002.GetHashCode();
                }
                if (this.RegDate != null)
                {
                    hashCode = (hashCode * 59) + this.RegDate.GetHashCode();
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
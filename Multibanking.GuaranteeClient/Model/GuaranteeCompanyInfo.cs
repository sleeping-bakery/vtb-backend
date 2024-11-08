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
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Multibanking.GuaranteeClient.Client.OpenAPIDateConverter;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    ///     Информация об организации
    /// </summary>
    [DataContract(Name = "GuaranteeCompanyInfo")]
    public class GuaranteeCompanyInfo : IEquatable<GuaranteeCompanyInfo>, IValidatableObject
    {
        /// <summary>
        ///     Тип организации
        /// </summary>
        /// <value>Тип организации</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GuaranteeOrgTypeEnum
        {
            /// <summary>
            ///     Enum UL for value: UL
            /// </summary>
            [EnumMember(Value = "UL")] UL = 1,

            /// <summary>
            ///     Enum IP for value: IP
            /// </summary>
            [EnumMember(Value = "IP")] IP = 2
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="GuaranteeCompanyInfo" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GuaranteeCompanyInfo()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="GuaranteeCompanyInfo" /> class.
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
        public GuaranteeCompanyInfo(string fullName = default, string shortName = default, GuaranteeOrgTypeEnum guaranteeOrgType = default, string okopf = default,
            string okfs = default, string okpo = default, string okved = default, string okvedName = default, string inn = default, string kpp = default, string ogrn = default,
            DateTime regDateBefore01072002 = default, DateTime regDate = default)
        {
            // to ensure "fullName" is required (not null)
            if (fullName == null) throw new ArgumentNullException("fullName is a required property for GuaranteeCompanyInfo and cannot be null");
            FullName = fullName;
            // to ensure "shortName" is required (not null)
            if (shortName == null) throw new ArgumentNullException("shortName is a required property for GuaranteeCompanyInfo and cannot be null");
            ShortName = shortName;
            GuaranteeOrgType = guaranteeOrgType;
            // to ensure "okopf" is required (not null)
            if (okopf == null) throw new ArgumentNullException("okopf is a required property for GuaranteeCompanyInfo and cannot be null");
            Okopf = okopf;
            // to ensure "okfs" is required (not null)
            if (okfs == null) throw new ArgumentNullException("okfs is a required property for GuaranteeCompanyInfo and cannot be null");
            Okfs = okfs;
            // to ensure "okpo" is required (not null)
            if (okpo == null) throw new ArgumentNullException("okpo is a required property for GuaranteeCompanyInfo and cannot be null");
            Okpo = okpo;
            // to ensure "okved" is required (not null)
            if (okved == null) throw new ArgumentNullException("okved is a required property for GuaranteeCompanyInfo and cannot be null");
            Okved = okved;
            // to ensure "inn" is required (not null)
            if (inn == null) throw new ArgumentNullException("inn is a required property for GuaranteeCompanyInfo and cannot be null");
            Inn = inn;
            // to ensure "ogrn" is required (not null)
            if (ogrn == null) throw new ArgumentNullException("ogrn is a required property for GuaranteeCompanyInfo and cannot be null");
            Ogrn = ogrn;
            RegDate = regDate;
            OkvedName = okvedName;
            Kpp = kpp;
            RegDateBefore01072002 = regDateBefore01072002;
        }


        /// <summary>
        ///     Тип организации
        /// </summary>
        /// <value>Тип организации</value>
        [DataMember(Name = "guaranteeOrgType", IsRequired = true, EmitDefaultValue = true)]
        public GuaranteeOrgTypeEnum GuaranteeOrgType { get; set; }

        /// <summary>
        ///     Название
        /// </summary>
        /// <value>Название</value>
        [DataMember(Name = "fullName", IsRequired = true, EmitDefaultValue = true)]
        public string FullName { get; set; }

        /// <summary>
        ///     Название
        /// </summary>
        /// <value>Название</value>
        [DataMember(Name = "shortName", IsRequired = true, EmitDefaultValue = true)]
        public string ShortName { get; set; }

        /// <summary>
        ///     ОКОПФ
        /// </summary>
        /// <value>ОКОПФ</value>
        [DataMember(Name = "okopf", IsRequired = true, EmitDefaultValue = true)]
        public string Okopf { get; set; }

        /// <summary>
        ///     ОКФС
        /// </summary>
        /// <value>ОКФС</value>
        [DataMember(Name = "okfs", IsRequired = true, EmitDefaultValue = true)]
        public string Okfs { get; set; }

        /// <summary>
        ///     ОКПО
        /// </summary>
        /// <value>ОКПО</value>
        [DataMember(Name = "okpo", IsRequired = true, EmitDefaultValue = true)]
        public string Okpo { get; set; }

        /// <summary>
        ///     ОКВЭД
        /// </summary>
        /// <value>ОКВЭД</value>
        [DataMember(Name = "okved", IsRequired = true, EmitDefaultValue = true)]
        public string Okved { get; set; }

        /// <summary>
        ///     Наименование ОКВЭД
        /// </summary>
        /// <value>Наименование ОКВЭД</value>
        [DataMember(Name = "okvedName", EmitDefaultValue = false)]
        public string OkvedName { get; set; }

        /// <summary>
        ///     ИНН
        /// </summary>
        /// <value>ИНН</value>
        [DataMember(Name = "inn", IsRequired = true, EmitDefaultValue = true)]
        public string Inn { get; set; }

        /// <summary>
        ///     КПП
        /// </summary>
        /// <value>КПП</value>
        [DataMember(Name = "kpp", EmitDefaultValue = false)]
        public string Kpp { get; set; }

        /// <summary>
        ///     ОГРН
        /// </summary>
        /// <value>ОГРН</value>
        [DataMember(Name = "ogrn", IsRequired = true, EmitDefaultValue = true)]
        public string Ogrn { get; set; }

        /// <summary>
        ///     Дата регистрации, до 01 июля 2002 г. Заполнить, если дата регистрации, до 01 июля 2002 г.
        /// </summary>
        /// <value>Дата регистрации, до 01 июля 2002 г. Заполнить, если дата регистрации, до 01 июля 2002 г.</value>
        [DataMember(Name = "regDateBefore01072002", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime RegDateBefore01072002 { get; set; }

        /// <summary>
        ///     Дата регистрации
        /// </summary>
        /// <value>Дата регистрации</value>
        [DataMember(Name = "regDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime RegDate { get; set; }

        /// <summary>
        ///     Returns true if GuaranteeCompanyInfo instances are equal
        /// </summary>
        /// <param name="input">Instance of GuaranteeCompanyInfo to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GuaranteeCompanyInfo input)
        {
            if (input == null) return false;
            return
                (
                    FullName == input.FullName ||
                    (FullName != null &&
                     FullName.Equals(input.FullName))
                ) &&
                (
                    ShortName == input.ShortName ||
                    (ShortName != null &&
                     ShortName.Equals(input.ShortName))
                ) &&
                (
                    GuaranteeOrgType == input.GuaranteeOrgType ||
                    GuaranteeOrgType.Equals(input.GuaranteeOrgType)
                ) &&
                (
                    Okopf == input.Okopf ||
                    (Okopf != null &&
                     Okopf.Equals(input.Okopf))
                ) &&
                (
                    Okfs == input.Okfs ||
                    (Okfs != null &&
                     Okfs.Equals(input.Okfs))
                ) &&
                (
                    Okpo == input.Okpo ||
                    (Okpo != null &&
                     Okpo.Equals(input.Okpo))
                ) &&
                (
                    Okved == input.Okved ||
                    (Okved != null &&
                     Okved.Equals(input.Okved))
                ) &&
                (
                    OkvedName == input.OkvedName ||
                    (OkvedName != null &&
                     OkvedName.Equals(input.OkvedName))
                ) &&
                (
                    Inn == input.Inn ||
                    (Inn != null &&
                     Inn.Equals(input.Inn))
                ) &&
                (
                    Kpp == input.Kpp ||
                    (Kpp != null &&
                     Kpp.Equals(input.Kpp))
                ) &&
                (
                    Ogrn == input.Ogrn ||
                    (Ogrn != null &&
                     Ogrn.Equals(input.Ogrn))
                ) &&
                (
                    RegDateBefore01072002 == input.RegDateBefore01072002 ||
                    (RegDateBefore01072002 != null &&
                     RegDateBefore01072002.Equals(input.RegDateBefore01072002))
                ) &&
                (
                    RegDate == input.RegDate ||
                    (RegDate != null &&
                     RegDate.Equals(input.RegDate))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
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
            return Equals(input as GuaranteeCompanyInfo);
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
                if (FullName != null) hashCode = hashCode * 59 + FullName.GetHashCode();
                if (ShortName != null) hashCode = hashCode * 59 + ShortName.GetHashCode();
                hashCode = hashCode * 59 + GuaranteeOrgType.GetHashCode();
                if (Okopf != null) hashCode = hashCode * 59 + Okopf.GetHashCode();
                if (Okfs != null) hashCode = hashCode * 59 + Okfs.GetHashCode();
                if (Okpo != null) hashCode = hashCode * 59 + Okpo.GetHashCode();
                if (Okved != null) hashCode = hashCode * 59 + Okved.GetHashCode();
                if (OkvedName != null) hashCode = hashCode * 59 + OkvedName.GetHashCode();
                if (Inn != null) hashCode = hashCode * 59 + Inn.GetHashCode();
                if (Kpp != null) hashCode = hashCode * 59 + Kpp.GetHashCode();
                if (Ogrn != null) hashCode = hashCode * 59 + Ogrn.GetHashCode();
                if (RegDateBefore01072002 != null) hashCode = hashCode * 59 + RegDateBefore01072002.GetHashCode();
                if (RegDate != null) hashCode = hashCode * 59 + RegDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
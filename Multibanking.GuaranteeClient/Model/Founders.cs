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
using Newtonsoft.Json;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    ///     Данные об Учредителях. Должен быть установлен хотя бы один учредитель физическое лицо с долей не менее 20%.
    /// </summary>
    [DataContract(Name = "Founders")]
    public class Founders : IEquatable<Founders>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Founders" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Founders()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Founders" /> class.
        /// </summary>
        /// <param name="founderCompanies">founderCompanies.</param>
        /// <param name="founderPersons">founderPersons (required).</param>
        public Founders(List<FounderCompany> founderCompanies = default, List<FounderPerson> founderPersons = default)
        {
            // to ensure "founderPersons" is required (not null)
            if (founderPersons == null) throw new ArgumentNullException("founderPersons is a required property for Founders and cannot be null");
            FounderPersons = founderPersons;
            FounderCompanies = founderCompanies;
        }

        /// <summary>
        ///     Gets or Sets FounderCompanies
        /// </summary>
        [DataMember(Name = "founderCompanies", EmitDefaultValue = false)]
        public List<FounderCompany> FounderCompanies { get; set; }

        /// <summary>
        ///     Gets or Sets FounderPersons
        /// </summary>
        [DataMember(Name = "founderPersons", IsRequired = true, EmitDefaultValue = true)]
        public List<FounderPerson> FounderPersons { get; set; }

        /// <summary>
        ///     Returns true if Founders instances are equal
        /// </summary>
        /// <param name="input">Instance of Founders to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Founders input)
        {
            if (input == null) return false;
            return
                (
                    FounderCompanies == input.FounderCompanies ||
                    (FounderCompanies != null &&
                     input.FounderCompanies != null &&
                     FounderCompanies.SequenceEqual(input.FounderCompanies))
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
            yield break;
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Founders {\n");
            sb.Append("  FounderCompanies: ").Append(FounderCompanies).Append("\n");
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
            return Equals(input as Founders);
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
                if (FounderCompanies != null) hashCode = hashCode * 59 + FounderCompanies.GetHashCode();
                if (FounderPersons != null) hashCode = hashCode * 59 + FounderPersons.GetHashCode();
                return hashCode;
            }
        }
    }
}
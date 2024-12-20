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

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    ///     Данные на отказ клиента от заявки
    /// </summary>
    [DataContract(Name = "DeclineOrderDto")]
    public class DeclineOrderDto : IEquatable<DeclineOrderDto>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DeclineOrderDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeclineOrderDto()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="DeclineOrderDto" /> class.
        /// </summary>
        /// <param name="comment">Комментарий.</param>
        /// <param name="reasonForRefusal">Причина отказа (required).</param>
        public DeclineOrderDto(string comment = default, string reasonForRefusal = default)
        {
            // to ensure "reasonForRefusal" is required (not null)
            if (reasonForRefusal == null) throw new ArgumentNullException("reasonForRefusal is a required property for DeclineOrderDto and cannot be null");
            ReasonForRefusal = reasonForRefusal;
            Comment = comment;
        }

        /// <summary>
        ///     Комментарий
        /// </summary>
        /// <value>Комментарий</value>
        [DataMember(Name = "comment", EmitDefaultValue = false)]
        public string Comment { get; set; }

        /// <summary>
        ///     Причина отказа
        /// </summary>
        /// <value>Причина отказа</value>
        [DataMember(Name = "reasonForRefusal", IsRequired = true, EmitDefaultValue = true)]
        public string ReasonForRefusal { get; set; }

        /// <summary>
        ///     Returns true if DeclineOrderDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DeclineOrderDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeclineOrderDto input)
        {
            if (input == null) return false;
            return
                (
                    Comment == input.Comment ||
                    (Comment != null &&
                     Comment.Equals(input.Comment))
                ) &&
                (
                    ReasonForRefusal == input.ReasonForRefusal ||
                    (ReasonForRefusal != null &&
                     ReasonForRefusal.Equals(input.ReasonForRefusal))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // Comment (string) maxLength
            if (Comment != null && Comment.Length > 1500) yield return new ValidationResult("Invalid value for Comment, length must be less than 1500.", new[] { "Comment" });

            // Comment (string) minLength
            if (Comment != null && Comment.Length < 1) yield return new ValidationResult("Invalid value for Comment, length must be greater than 1.", new[] { "Comment" });

            // ReasonForRefusal (string) maxLength
            if (ReasonForRefusal != null && ReasonForRefusal.Length > 255)
                yield return new ValidationResult("Invalid value for ReasonForRefusal, length must be less than 255.", new[] { "ReasonForRefusal" });

            // ReasonForRefusal (string) minLength
            if (ReasonForRefusal != null && ReasonForRefusal.Length < 1)
                yield return new ValidationResult("Invalid value for ReasonForRefusal, length must be greater than 1.", new[] { "ReasonForRefusal" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeclineOrderDto {\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("  ReasonForRefusal: ").Append(ReasonForRefusal).Append("\n");
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
            return Equals(input as DeclineOrderDto);
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
                if (Comment != null) hashCode = hashCode * 59 + Comment.GetHashCode();
                if (ReasonForRefusal != null) hashCode = hashCode * 59 + ReasonForRefusal.GetHashCode();
                return hashCode;
            }
        }
    }
}
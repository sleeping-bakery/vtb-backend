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
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    ///     Документы в рамках чата с клиентом
    /// </summary>
    [DataContract(Name = "CommentFileDto")]
    public class CommentFileDto : IEquatable<CommentFileDto>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="CommentFileDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommentFileDto()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CommentFileDto" /> class.
        /// </summary>
        /// <param name="fileName">Имя документа (required).</param>
        /// <param name="requestId">Идентификатор запроса на создание документа (required).</param>
        public CommentFileDto(string fileName = default, long requestId = default)
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null) throw new ArgumentNullException("fileName is a required property for CommentFileDto and cannot be null");
            FileName = fileName;
            RequestId = requestId;
        }

        /// <summary>
        ///     Имя документа
        /// </summary>
        /// <value>Имя документа</value>
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        ///     Идентификатор запроса на создание документа
        /// </summary>
        /// <value>Идентификатор запроса на создание документа</value>
        [DataMember(Name = "requestId", IsRequired = true, EmitDefaultValue = true)]
        public long RequestId { get; set; }

        /// <summary>
        ///     Returns true if CommentFileDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CommentFileDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommentFileDto input)
        {
            if (input == null) return false;
            return
                (
                    FileName == input.FileName ||
                    (FileName != null &&
                     FileName.Equals(input.FileName))
                ) &&
                (
                    RequestId == input.RequestId ||
                    RequestId.Equals(input.RequestId)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // FileName (string) maxLength
            if (FileName != null && FileName.Length > 255) yield return new ValidationResult("Invalid value for FileName, length must be less than 255.", new[] { "FileName" });

            // FileName (string) minLength
            if (FileName != null && FileName.Length < 1) yield return new ValidationResult("Invalid value for FileName, length must be greater than 1.", new[] { "FileName" });

            // FileName (string) pattern
            var regexFileName = new Regex(@"^[А-ЯЁа-яё\\w\\s-]+(\\(\\d+\\))*\\.[A-Za-z\\w]{1,4}$", RegexOptions.CultureInvariant);
            if (false == regexFileName.Match(FileName).Success)
                yield return new ValidationResult("Invalid value for FileName, must match a pattern of " + regexFileName, new[] { "FileName" });

            // RequestId (long) maximum
            if (RequestId > 9007199254740991)
                yield return new ValidationResult("Invalid value for RequestId, must be a value less than or equal to 9007199254740991.", new[] { "RequestId" });

            // RequestId (long) minimum
            if (RequestId < 0) yield return new ValidationResult("Invalid value for RequestId, must be a value greater than or equal to 0.", new[] { "RequestId" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommentFileDto {\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  RequestId: ").Append(RequestId).Append("\n");
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
            return Equals(input as CommentFileDto);
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
                if (FileName != null) hashCode = hashCode * 59 + FileName.GetHashCode();
                hashCode = hashCode * 59 + RequestId.GetHashCode();
                return hashCode;
            }
        }
    }
}
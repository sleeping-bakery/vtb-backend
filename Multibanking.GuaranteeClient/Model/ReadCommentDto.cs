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
    /// Данные для подписания оферты
    /// </summary>
    [DataContract(Name = "ReadCommentDto")]
    public partial class ReadCommentDto : IEquatable<ReadCommentDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCommentDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ReadCommentDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReadCommentDto" /> class.
        /// </summary>
        /// <param name="commentId">Идентификатор комментария (required).</param>
        public ReadCommentDto(string commentId = default(string))
        {
            // to ensure "commentId" is required (not null)
            if (commentId == null)
            {
                throw new ArgumentNullException("commentId is a required property for ReadCommentDto and cannot be null");
            }
            this.CommentId = commentId;
        }

        /// <summary>
        /// Идентификатор комментария
        /// </summary>
        /// <value>Идентификатор комментария</value>
        [DataMember(Name = "commentId", IsRequired = true, EmitDefaultValue = true)]
        public string CommentId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ReadCommentDto {\n");
            sb.Append("  CommentId: ").Append(CommentId).Append("\n");
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
            return this.Equals(input as ReadCommentDto);
        }

        /// <summary>
        /// Returns true if ReadCommentDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ReadCommentDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReadCommentDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CommentId == input.CommentId ||
                    (this.CommentId != null &&
                    this.CommentId.Equals(input.CommentId))
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
                if (this.CommentId != null)
                {
                    hashCode = (hashCode * 59) + this.CommentId.GetHashCode();
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
            // CommentId (string) maxLength
            if (this.CommentId != null && this.CommentId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommentId, length must be less than 36.", new [] { "CommentId" });
            }

            // CommentId (string) minLength
            if (this.CommentId != null && this.CommentId.Length < 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommentId, length must be greater than 36.", new [] { "CommentId" });
            }

            // CommentId (string) pattern
            Regex regexCommentId = new Regex(@"^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", RegexOptions.CultureInvariant);
            if (false == regexCommentId.Match(this.CommentId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CommentId, must match a pattern of " + regexCommentId, new [] { "CommentId" });
            }

            yield break;
        }
    }

}

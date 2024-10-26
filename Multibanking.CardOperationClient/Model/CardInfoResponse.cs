/*
 * Сервис управления картой ФЛ, операционные запросы
 *
 * Микросервис реализующий базовые операции с банковскими картами
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Multibanking.CardOperationClient.Client.OpenAPIDateConverter;

namespace Multibanking.CardOperationClient.Model
{
    /// <summary>
    /// Общая информация
    /// </summary>
    [DataContract(Name = "CardInfoResponse")]
    public partial class CardInfoResponse : IEquatable<CardInfoResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CardInfoResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CardInfoResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CardInfoResponse" /> class.
        /// </summary>
        /// <param name="correlationId">Идентификатор сообщения, на которое дается ответ.</param>
        /// <param name="errorCode">Код ошибки (required).</param>
        /// <param name="errorText">Текст ошибки.</param>
        /// <param name="requestTime">Дата и время формирования сообщения.</param>
        public CardInfoResponse(string correlationId = default(string), string errorCode = default(string), string errorText = default(string), DateTime requestTime = default(DateTime))
        {
            // to ensure "errorCode" is required (not null)
            if (errorCode == null)
            {
                throw new ArgumentNullException("errorCode is a required property for CardInfoResponse and cannot be null");
            }
            this.ErrorCode = errorCode;
            this.CorrelationId = correlationId;
            this.ErrorText = errorText;
            this.RequestTime = requestTime;
        }

        /// <summary>
        /// Идентификатор сообщения, на которое дается ответ
        /// </summary>
        /// <value>Идентификатор сообщения, на которое дается ответ</value>
        [DataMember(Name = "correlationId", EmitDefaultValue = false)]
        public string CorrelationId { get; set; }

        /// <summary>
        /// Код ошибки
        /// </summary>
        /// <value>Код ошибки</value>
        [DataMember(Name = "errorCode", IsRequired = true, EmitDefaultValue = true)]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Текст ошибки
        /// </summary>
        /// <value>Текст ошибки</value>
        [DataMember(Name = "errorText", EmitDefaultValue = false)]
        public string ErrorText { get; set; }

        /// <summary>
        /// Дата и время формирования сообщения
        /// </summary>
        /// <value>Дата и время формирования сообщения</value>
        [DataMember(Name = "requestTime", EmitDefaultValue = false)]
        public DateTime RequestTime { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CardInfoResponse {\n");
            sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
            sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
            sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
            sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
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
            return this.Equals(input as CardInfoResponse);
        }

        /// <summary>
        /// Returns true if CardInfoResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CardInfoResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CardInfoResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CorrelationId == input.CorrelationId ||
                    (this.CorrelationId != null &&
                    this.CorrelationId.Equals(input.CorrelationId))
                ) && 
                (
                    this.ErrorCode == input.ErrorCode ||
                    (this.ErrorCode != null &&
                    this.ErrorCode.Equals(input.ErrorCode))
                ) && 
                (
                    this.ErrorText == input.ErrorText ||
                    (this.ErrorText != null &&
                    this.ErrorText.Equals(input.ErrorText))
                ) && 
                (
                    this.RequestTime == input.RequestTime ||
                    (this.RequestTime != null &&
                    this.RequestTime.Equals(input.RequestTime))
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
                if (this.CorrelationId != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationId.GetHashCode();
                }
                if (this.ErrorCode != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorCode.GetHashCode();
                }
                if (this.ErrorText != null)
                {
                    hashCode = (hashCode * 59) + this.ErrorText.GetHashCode();
                }
                if (this.RequestTime != null)
                {
                    hashCode = (hashCode * 59) + this.RequestTime.GetHashCode();
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
            // CorrelationId (string) maxLength
            if (this.CorrelationId != null && this.CorrelationId.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for CorrelationId, length must be less than 500.", new [] { "CorrelationId" });
            }

            // ErrorCode (string) maxLength
            if (this.ErrorCode != null && this.ErrorCode.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ErrorCode, length must be less than 500.", new [] { "ErrorCode" });
            }

            // ErrorText (string) maxLength
            if (this.ErrorText != null && this.ErrorText.Length > 5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ErrorText, length must be less than 5000.", new [] { "ErrorText" });
            }

            // RequestTime (DateTime) maxLength
            if (this.RequestTime != null && this.RequestTime.ToString().Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestTime, length must be less than 500.", new [] { "RequestTime" });
            }

            // RequestTime (DateTime) pattern
            Regex regexRequestTime = new Regex(@"([0-9]{1,4}-[0-9]{1,2}-[0-9]{1,2}[A-Z][0-9]{1,2}:[0-9]{1,2}:[0-9]{1,2}.[0-9]{1,3}[A-Z])", RegexOptions.CultureInvariant);
            if (false == regexRequestTime.Match(this.RequestTime.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for RequestTime, must match a pattern of " + regexRequestTime, new [] { "RequestTime" });
            }

            yield break;
        }
    }

}

/*
 * Сервис управления картой ФЛ, операционные запросы
 *
 * Микросервис реализующий базовые операции с банковскими картами
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Multibanking.CardOperationClient.Model;

/// <summary>
///     Общая информация
/// </summary>
[DataContract(Name = "CardInfoResponse")]
public class CardInfoResponse : IEquatable<CardInfoResponse>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CardInfoResponse" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CardInfoResponse()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="CardInfoResponse" /> class.
    /// </summary>
    /// <param name="correlationId">Идентификатор сообщения, на которое дается ответ.</param>
    /// <param name="errorCode">Код ошибки (required).</param>
    /// <param name="errorText">Текст ошибки.</param>
    /// <param name="requestTime">Дата и время формирования сообщения.</param>
    public CardInfoResponse(string correlationId = default, string errorCode = default, string errorText = default, DateTime requestTime = default)
    {
        // to ensure "errorCode" is required (not null)
        if (errorCode == null) throw new ArgumentNullException("errorCode is a required property for CardInfoResponse and cannot be null");
        ErrorCode = errorCode;
        CorrelationId = correlationId;
        ErrorText = errorText;
        RequestTime = requestTime;
    }

    /// <summary>
    ///     Идентификатор сообщения, на которое дается ответ
    /// </summary>
    /// <value>Идентификатор сообщения, на которое дается ответ</value>
    [DataMember(Name = "correlationId", EmitDefaultValue = false)]
    public string CorrelationId { get; set; }

    /// <summary>
    ///     Код ошибки
    /// </summary>
    /// <value>Код ошибки</value>
    [DataMember(Name = "errorCode", IsRequired = true, EmitDefaultValue = true)]
    public string ErrorCode { get; set; }

    /// <summary>
    ///     Текст ошибки
    /// </summary>
    /// <value>Текст ошибки</value>
    [DataMember(Name = "errorText", EmitDefaultValue = false)]
    public string ErrorText { get; set; }

    /// <summary>
    ///     Дата и время формирования сообщения
    /// </summary>
    /// <value>Дата и время формирования сообщения</value>
    [DataMember(Name = "requestTime", EmitDefaultValue = false)]
    public DateTime RequestTime { get; set; }

    /// <summary>
    ///     Returns true if CardInfoResponse instances are equal
    /// </summary>
    /// <param name="input">Instance of CardInfoResponse to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CardInfoResponse input)
    {
        if (input == null) return false;
        return
            (
                CorrelationId == input.CorrelationId ||
                (CorrelationId != null &&
                 CorrelationId.Equals(input.CorrelationId))
            ) &&
            (
                ErrorCode == input.ErrorCode ||
                (ErrorCode != null &&
                 ErrorCode.Equals(input.ErrorCode))
            ) &&
            (
                ErrorText == input.ErrorText ||
                (ErrorText != null &&
                 ErrorText.Equals(input.ErrorText))
            ) &&
            (
                RequestTime == input.RequestTime ||
                (RequestTime != null &&
                 RequestTime.Equals(input.RequestTime))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // CorrelationId (string) maxLength
        if (CorrelationId != null && CorrelationId.Length > 500)
            yield return new ValidationResult("Invalid value for CorrelationId, length must be less than 500.", new[] { "CorrelationId" });

        // ErrorCode (string) maxLength
        if (ErrorCode != null && ErrorCode.Length > 500) yield return new ValidationResult("Invalid value for ErrorCode, length must be less than 500.", new[] { "ErrorCode" });

        // ErrorText (string) maxLength
        if (ErrorText != null && ErrorText.Length > 5000) yield return new ValidationResult("Invalid value for ErrorText, length must be less than 5000.", new[] { "ErrorText" });

        // RequestTime (DateTime) maxLength
        if (RequestTime != null && RequestTime.ToString().Length > 500)
            yield return new ValidationResult("Invalid value for RequestTime, length must be less than 500.", new[] { "RequestTime" });

        // RequestTime (DateTime) pattern
        var regexRequestTime = new Regex(@"([0-9]{1,4}-[0-9]{1,2}-[0-9]{1,2}[A-Z][0-9]{1,2}:[0-9]{1,2}:[0-9]{1,2}.[0-9]{1,3}[A-Z])", RegexOptions.CultureInvariant);
        if (false == regexRequestTime.Match(RequestTime.ToString()).Success)
            yield return new ValidationResult("Invalid value for RequestTime, must match a pattern of " + regexRequestTime, new[] { "RequestTime" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CardInfoResponse {\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  ErrorCode: ").Append(ErrorCode).Append("\n");
        sb.Append("  ErrorText: ").Append(ErrorText).Append("\n");
        sb.Append("  RequestTime: ").Append(RequestTime).Append("\n");
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
        return Equals(input as CardInfoResponse);
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
            if (CorrelationId != null) hashCode = hashCode * 59 + CorrelationId.GetHashCode();
            if (ErrorCode != null) hashCode = hashCode * 59 + ErrorCode.GetHashCode();
            if (ErrorText != null) hashCode = hashCode * 59 + ErrorText.GetHashCode();
            if (RequestTime != null) hashCode = hashCode * 59 + RequestTime.GetHashCode();
            return hashCode;
        }
    }
}
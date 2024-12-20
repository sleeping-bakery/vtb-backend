/*
 * Сервис управления картой ФЛ, информационные запросы
 *
 * Микросервис реализующий базовые операции с банковскими картами
 *
 * The version of the OpenAPI document: 1.0.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Multibanking.CardInformationClient.Model;

/// <summary>
///     Данные для формирования зашифрованных параметров
/// </summary>
[DataContract(Name = "GenerateWalletTokenRequest")]
public class GenerateWalletTokenRequest : IEquatable<GenerateWalletTokenRequest>, IValidatableObject
{
    /// <summary>
    ///     Вид кошелька
    /// </summary>
    /// <value>Вид кошелька</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MobilePayServiceEnum
    {
        /// <summary>
        ///     Enum APPLEPAY for value: APPLEPAY
        /// </summary>
        [EnumMember(Value = "APPLEPAY")] APPLEPAY = 1,

        /// <summary>
        ///     Enum GOOGLEPAY for value: GOOGLEPAY
        /// </summary>
        [EnumMember(Value = "GOOGLEPAY")] GOOGLEPAY = 2
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="GenerateWalletTokenRequest" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected GenerateWalletTokenRequest()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="GenerateWalletTokenRequest" /> class.
    /// </summary>
    /// <param name="callId">Идентификатор вызова (required).</param>
    /// <param name="correlationId">Идентификатор для отслеживания цепочки вызовов.</param>
    /// <param name="inputParameters">Входные параметры (required).</param>
    /// <param name="mobilePayService">Вид кошелька (required).</param>
    /// <param name="sessionId">Идентификатор сессии (required).</param>
    public GenerateWalletTokenRequest(string callId = default, string correlationId = default, List<ParameterDto> inputParameters = default,
        MobilePayServiceEnum mobilePayService = default, string sessionId = default)
    {
        // to ensure "callId" is required (not null)
        if (callId == null) throw new ArgumentNullException("callId is a required property for GenerateWalletTokenRequest and cannot be null");
        CallId = callId;
        // to ensure "inputParameters" is required (not null)
        if (inputParameters == null) throw new ArgumentNullException("inputParameters is a required property for GenerateWalletTokenRequest and cannot be null");
        InputParameters = inputParameters;
        MobilePayService = mobilePayService;
        // to ensure "sessionId" is required (not null)
        if (sessionId == null) throw new ArgumentNullException("sessionId is a required property for GenerateWalletTokenRequest and cannot be null");
        SessionId = sessionId;
        CorrelationId = correlationId;
    }


    /// <summary>
    ///     Вид кошелька
    /// </summary>
    /// <value>Вид кошелька</value>
    [DataMember(Name = "mobilePayService", IsRequired = true, EmitDefaultValue = true)]
    public MobilePayServiceEnum MobilePayService { get; set; }

    /// <summary>
    ///     Идентификатор вызова
    /// </summary>
    /// <value>Идентификатор вызова</value>
    [DataMember(Name = "callId", IsRequired = true, EmitDefaultValue = true)]
    public string CallId { get; set; }

    /// <summary>
    ///     Идентификатор для отслеживания цепочки вызовов
    /// </summary>
    /// <value>Идентификатор для отслеживания цепочки вызовов</value>
    [DataMember(Name = "correlationId", EmitDefaultValue = false)]
    public string CorrelationId { get; set; }

    /// <summary>
    ///     Входные параметры
    /// </summary>
    /// <value>Входные параметры</value>
    [DataMember(Name = "inputParameters", IsRequired = true, EmitDefaultValue = true)]
    public List<ParameterDto> InputParameters { get; set; }

    /// <summary>
    ///     Идентификатор сессии
    /// </summary>
    /// <value>Идентификатор сессии</value>
    [DataMember(Name = "sessionId", IsRequired = true, EmitDefaultValue = true)]
    public string SessionId { get; set; }

    /// <summary>
    ///     Returns true if GenerateWalletTokenRequest instances are equal
    /// </summary>
    /// <param name="input">Instance of GenerateWalletTokenRequest to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(GenerateWalletTokenRequest input)
    {
        if (input == null) return false;
        return
            (
                CallId == input.CallId ||
                (CallId != null &&
                 CallId.Equals(input.CallId))
            ) &&
            (
                CorrelationId == input.CorrelationId ||
                (CorrelationId != null &&
                 CorrelationId.Equals(input.CorrelationId))
            ) &&
            (
                InputParameters == input.InputParameters ||
                (InputParameters != null &&
                 input.InputParameters != null &&
                 InputParameters.SequenceEqual(input.InputParameters))
            ) &&
            (
                MobilePayService == input.MobilePayService ||
                MobilePayService.Equals(input.MobilePayService)
            ) &&
            (
                SessionId == input.SessionId ||
                (SessionId != null &&
                 SessionId.Equals(input.SessionId))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // CallId (string) maxLength
        if (CallId != null && CallId.Length > 50) yield return new ValidationResult("Invalid value for CallId, length must be less than 50.", new[] { "CallId" });

        // CorrelationId (string) maxLength
        if (CorrelationId != null && CorrelationId.Length > 50)
            yield return new ValidationResult("Invalid value for CorrelationId, length must be less than 50.", new[] { "CorrelationId" });

        // SessionId (string) maxLength
        if (SessionId != null && SessionId.Length > 50) yield return new ValidationResult("Invalid value for SessionId, length must be less than 50.", new[] { "SessionId" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class GenerateWalletTokenRequest {\n");
        sb.Append("  CallId: ").Append(CallId).Append("\n");
        sb.Append("  CorrelationId: ").Append(CorrelationId).Append("\n");
        sb.Append("  InputParameters: ").Append(InputParameters).Append("\n");
        sb.Append("  MobilePayService: ").Append(MobilePayService).Append("\n");
        sb.Append("  SessionId: ").Append(SessionId).Append("\n");
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
        return Equals(input as GenerateWalletTokenRequest);
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
            if (CallId != null) hashCode = hashCode * 59 + CallId.GetHashCode();
            if (CorrelationId != null) hashCode = hashCode * 59 + CorrelationId.GetHashCode();
            if (InputParameters != null) hashCode = hashCode * 59 + InputParameters.GetHashCode();
            hashCode = hashCode * 59 + MobilePayService.GetHashCode();
            if (SessionId != null) hashCode = hashCode * 59 + SessionId.GetHashCode();
            return hashCode;
        }
    }
}
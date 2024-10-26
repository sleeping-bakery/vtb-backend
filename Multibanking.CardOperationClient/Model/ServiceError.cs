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
    /// Ошибка сервиса
    /// </summary>
    [DataContract(Name = "ServiceError")]
    public partial class ServiceError : IEquatable<ServiceError>, IValidatableObject
    {
        /// <summary>
        /// Статус ошибки
        /// </summary>
        /// <value>Статус ошибки</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum _100CONTINUE for value: 100 CONTINUE
            /// </summary>
            [EnumMember(Value = "100 CONTINUE")]
            _100CONTINUE = 1,

            /// <summary>
            /// Enum _101SWITCHINGPROTOCOLS for value: 101 SWITCHING_PROTOCOLS
            /// </summary>
            [EnumMember(Value = "101 SWITCHING_PROTOCOLS")]
            _101SWITCHINGPROTOCOLS = 2,

            /// <summary>
            /// Enum _102PROCESSING for value: 102 PROCESSING
            /// </summary>
            [EnumMember(Value = "102 PROCESSING")]
            _102PROCESSING = 3,

            /// <summary>
            /// Enum _103CHECKPOINT for value: 103 CHECKPOINT
            /// </summary>
            [EnumMember(Value = "103 CHECKPOINT")]
            _103CHECKPOINT = 4,

            /// <summary>
            /// Enum _200OK for value: 200 OK
            /// </summary>
            [EnumMember(Value = "200 OK")]
            _200OK = 5,

            /// <summary>
            /// Enum _201CREATED for value: 201 CREATED
            /// </summary>
            [EnumMember(Value = "201 CREATED")]
            _201CREATED = 6,

            /// <summary>
            /// Enum _202ACCEPTED for value: 202 ACCEPTED
            /// </summary>
            [EnumMember(Value = "202 ACCEPTED")]
            _202ACCEPTED = 7,

            /// <summary>
            /// Enum _203NONAUTHORITATIVEINFORMATION for value: 203 NON_AUTHORITATIVE_INFORMATION
            /// </summary>
            [EnumMember(Value = "203 NON_AUTHORITATIVE_INFORMATION")]
            _203NONAUTHORITATIVEINFORMATION = 8,

            /// <summary>
            /// Enum _204NOCONTENT for value: 204 NO_CONTENT
            /// </summary>
            [EnumMember(Value = "204 NO_CONTENT")]
            _204NOCONTENT = 9,

            /// <summary>
            /// Enum _205RESETCONTENT for value: 205 RESET_CONTENT
            /// </summary>
            [EnumMember(Value = "205 RESET_CONTENT")]
            _205RESETCONTENT = 10,

            /// <summary>
            /// Enum _206PARTIALCONTENT for value: 206 PARTIAL_CONTENT
            /// </summary>
            [EnumMember(Value = "206 PARTIAL_CONTENT")]
            _206PARTIALCONTENT = 11,

            /// <summary>
            /// Enum _207MULTISTATUS for value: 207 MULTI_STATUS
            /// </summary>
            [EnumMember(Value = "207 MULTI_STATUS")]
            _207MULTISTATUS = 12,

            /// <summary>
            /// Enum _208ALREADYREPORTED for value: 208 ALREADY_REPORTED
            /// </summary>
            [EnumMember(Value = "208 ALREADY_REPORTED")]
            _208ALREADYREPORTED = 13,

            /// <summary>
            /// Enum _226IMUSED for value: 226 IM_USED
            /// </summary>
            [EnumMember(Value = "226 IM_USED")]
            _226IMUSED = 14,

            /// <summary>
            /// Enum _300MULTIPLECHOICES for value: 300 MULTIPLE_CHOICES
            /// </summary>
            [EnumMember(Value = "300 MULTIPLE_CHOICES")]
            _300MULTIPLECHOICES = 15,

            /// <summary>
            /// Enum _301MOVEDPERMANENTLY for value: 301 MOVED_PERMANENTLY
            /// </summary>
            [EnumMember(Value = "301 MOVED_PERMANENTLY")]
            _301MOVEDPERMANENTLY = 16,

            /// <summary>
            /// Enum _302FOUND for value: 302 FOUND
            /// </summary>
            [EnumMember(Value = "302 FOUND")]
            _302FOUND = 17,

            /// <summary>
            /// Enum _302MOVEDTEMPORARILY for value: 302 MOVED_TEMPORARILY
            /// </summary>
            [EnumMember(Value = "302 MOVED_TEMPORARILY")]
            _302MOVEDTEMPORARILY = 18,

            /// <summary>
            /// Enum _303SEEOTHER for value: 303 SEE_OTHER
            /// </summary>
            [EnumMember(Value = "303 SEE_OTHER")]
            _303SEEOTHER = 19,

            /// <summary>
            /// Enum _304NOTMODIFIED for value: 304 NOT_MODIFIED
            /// </summary>
            [EnumMember(Value = "304 NOT_MODIFIED")]
            _304NOTMODIFIED = 20,

            /// <summary>
            /// Enum _305USEPROXY for value: 305 USE_PROXY
            /// </summary>
            [EnumMember(Value = "305 USE_PROXY")]
            _305USEPROXY = 21,

            /// <summary>
            /// Enum _307TEMPORARYREDIRECT for value: 307 TEMPORARY_REDIRECT
            /// </summary>
            [EnumMember(Value = "307 TEMPORARY_REDIRECT")]
            _307TEMPORARYREDIRECT = 22,

            /// <summary>
            /// Enum _308PERMANENTREDIRECT for value: 308 PERMANENT_REDIRECT
            /// </summary>
            [EnumMember(Value = "308 PERMANENT_REDIRECT")]
            _308PERMANENTREDIRECT = 23,

            /// <summary>
            /// Enum _400BADREQUEST for value: 400 BAD_REQUEST
            /// </summary>
            [EnumMember(Value = "400 BAD_REQUEST")]
            _400BADREQUEST = 24,

            /// <summary>
            /// Enum _401UNAUTHORIZED for value: 401 UNAUTHORIZED
            /// </summary>
            [EnumMember(Value = "401 UNAUTHORIZED")]
            _401UNAUTHORIZED = 25,

            /// <summary>
            /// Enum _402PAYMENTREQUIRED for value: 402 PAYMENT_REQUIRED
            /// </summary>
            [EnumMember(Value = "402 PAYMENT_REQUIRED")]
            _402PAYMENTREQUIRED = 26,

            /// <summary>
            /// Enum _403FORBIDDEN for value: 403 FORBIDDEN
            /// </summary>
            [EnumMember(Value = "403 FORBIDDEN")]
            _403FORBIDDEN = 27,

            /// <summary>
            /// Enum _404NOTFOUND for value: 404 NOT_FOUND
            /// </summary>
            [EnumMember(Value = "404 NOT_FOUND")]
            _404NOTFOUND = 28,

            /// <summary>
            /// Enum _405METHODNOTALLOWED for value: 405 METHOD_NOT_ALLOWED
            /// </summary>
            [EnumMember(Value = "405 METHOD_NOT_ALLOWED")]
            _405METHODNOTALLOWED = 29,

            /// <summary>
            /// Enum _406NOTACCEPTABLE for value: 406 NOT_ACCEPTABLE
            /// </summary>
            [EnumMember(Value = "406 NOT_ACCEPTABLE")]
            _406NOTACCEPTABLE = 30,

            /// <summary>
            /// Enum _407PROXYAUTHENTICATIONREQUIRED for value: 407 PROXY_AUTHENTICATION_REQUIRED
            /// </summary>
            [EnumMember(Value = "407 PROXY_AUTHENTICATION_REQUIRED")]
            _407PROXYAUTHENTICATIONREQUIRED = 31,

            /// <summary>
            /// Enum _408REQUESTTIMEOUT for value: 408 REQUEST_TIMEOUT
            /// </summary>
            [EnumMember(Value = "408 REQUEST_TIMEOUT")]
            _408REQUESTTIMEOUT = 32,

            /// <summary>
            /// Enum _409CONFLICT for value: 409 CONFLICT
            /// </summary>
            [EnumMember(Value = "409 CONFLICT")]
            _409CONFLICT = 33,

            /// <summary>
            /// Enum _410GONE for value: 410 GONE
            /// </summary>
            [EnumMember(Value = "410 GONE")]
            _410GONE = 34,

            /// <summary>
            /// Enum _411LENGTHREQUIRED for value: 411 LENGTH_REQUIRED
            /// </summary>
            [EnumMember(Value = "411 LENGTH_REQUIRED")]
            _411LENGTHREQUIRED = 35,

            /// <summary>
            /// Enum _412PRECONDITIONFAILED for value: 412 PRECONDITION_FAILED
            /// </summary>
            [EnumMember(Value = "412 PRECONDITION_FAILED")]
            _412PRECONDITIONFAILED = 36,

            /// <summary>
            /// Enum _413PAYLOADTOOLARGE for value: 413 PAYLOAD_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "413 PAYLOAD_TOO_LARGE")]
            _413PAYLOADTOOLARGE = 37,

            /// <summary>
            /// Enum _413REQUESTENTITYTOOLARGE for value: 413 REQUEST_ENTITY_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "413 REQUEST_ENTITY_TOO_LARGE")]
            _413REQUESTENTITYTOOLARGE = 38,

            /// <summary>
            /// Enum _414URITOOLONG for value: 414 URI_TOO_LONG
            /// </summary>
            [EnumMember(Value = "414 URI_TOO_LONG")]
            _414URITOOLONG = 39,

            /// <summary>
            /// Enum _414REQUESTURITOOLONG for value: 414 REQUEST_URI_TOO_LONG
            /// </summary>
            [EnumMember(Value = "414 REQUEST_URI_TOO_LONG")]
            _414REQUESTURITOOLONG = 40,

            /// <summary>
            /// Enum _415UNSUPPORTEDMEDIATYPE for value: 415 UNSUPPORTED_MEDIA_TYPE
            /// </summary>
            [EnumMember(Value = "415 UNSUPPORTED_MEDIA_TYPE")]
            _415UNSUPPORTEDMEDIATYPE = 41,

            /// <summary>
            /// Enum _416REQUESTEDRANGENOTSATISFIABLE for value: 416 REQUESTED_RANGE_NOT_SATISFIABLE
            /// </summary>
            [EnumMember(Value = "416 REQUESTED_RANGE_NOT_SATISFIABLE")]
            _416REQUESTEDRANGENOTSATISFIABLE = 42,

            /// <summary>
            /// Enum _417EXPECTATIONFAILED for value: 417 EXPECTATION_FAILED
            /// </summary>
            [EnumMember(Value = "417 EXPECTATION_FAILED")]
            _417EXPECTATIONFAILED = 43,

            /// <summary>
            /// Enum _418IAMATEAPOT for value: 418 I_AM_A_TEAPOT
            /// </summary>
            [EnumMember(Value = "418 I_AM_A_TEAPOT")]
            _418IAMATEAPOT = 44,

            /// <summary>
            /// Enum _419INSUFFICIENTSPACEONRESOURCE for value: 419 INSUFFICIENT_SPACE_ON_RESOURCE
            /// </summary>
            [EnumMember(Value = "419 INSUFFICIENT_SPACE_ON_RESOURCE")]
            _419INSUFFICIENTSPACEONRESOURCE = 45,

            /// <summary>
            /// Enum _420METHODFAILURE for value: 420 METHOD_FAILURE
            /// </summary>
            [EnumMember(Value = "420 METHOD_FAILURE")]
            _420METHODFAILURE = 46,

            /// <summary>
            /// Enum _421DESTINATIONLOCKED for value: 421 DESTINATION_LOCKED
            /// </summary>
            [EnumMember(Value = "421 DESTINATION_LOCKED")]
            _421DESTINATIONLOCKED = 47,

            /// <summary>
            /// Enum _422UNPROCESSABLEENTITY for value: 422 UNPROCESSABLE_ENTITY
            /// </summary>
            [EnumMember(Value = "422 UNPROCESSABLE_ENTITY")]
            _422UNPROCESSABLEENTITY = 48,

            /// <summary>
            /// Enum _423LOCKED for value: 423 LOCKED
            /// </summary>
            [EnumMember(Value = "423 LOCKED")]
            _423LOCKED = 49,

            /// <summary>
            /// Enum _424FAILEDDEPENDENCY for value: 424 FAILED_DEPENDENCY
            /// </summary>
            [EnumMember(Value = "424 FAILED_DEPENDENCY")]
            _424FAILEDDEPENDENCY = 50,

            /// <summary>
            /// Enum _425TOOEARLY for value: 425 TOO_EARLY
            /// </summary>
            [EnumMember(Value = "425 TOO_EARLY")]
            _425TOOEARLY = 51,

            /// <summary>
            /// Enum _426UPGRADEREQUIRED for value: 426 UPGRADE_REQUIRED
            /// </summary>
            [EnumMember(Value = "426 UPGRADE_REQUIRED")]
            _426UPGRADEREQUIRED = 52,

            /// <summary>
            /// Enum _428PRECONDITIONREQUIRED for value: 428 PRECONDITION_REQUIRED
            /// </summary>
            [EnumMember(Value = "428 PRECONDITION_REQUIRED")]
            _428PRECONDITIONREQUIRED = 53,

            /// <summary>
            /// Enum _429TOOMANYREQUESTS for value: 429 TOO_MANY_REQUESTS
            /// </summary>
            [EnumMember(Value = "429 TOO_MANY_REQUESTS")]
            _429TOOMANYREQUESTS = 54,

            /// <summary>
            /// Enum _431REQUESTHEADERFIELDSTOOLARGE for value: 431 REQUEST_HEADER_FIELDS_TOO_LARGE
            /// </summary>
            [EnumMember(Value = "431 REQUEST_HEADER_FIELDS_TOO_LARGE")]
            _431REQUESTHEADERFIELDSTOOLARGE = 55,

            /// <summary>
            /// Enum _451UNAVAILABLEFORLEGALREASONS for value: 451 UNAVAILABLE_FOR_LEGAL_REASONS
            /// </summary>
            [EnumMember(Value = "451 UNAVAILABLE_FOR_LEGAL_REASONS")]
            _451UNAVAILABLEFORLEGALREASONS = 56,

            /// <summary>
            /// Enum _500INTERNALSERVERERROR for value: 500 INTERNAL_SERVER_ERROR
            /// </summary>
            [EnumMember(Value = "500 INTERNAL_SERVER_ERROR")]
            _500INTERNALSERVERERROR = 57,

            /// <summary>
            /// Enum _501NOTIMPLEMENTED for value: 501 NOT_IMPLEMENTED
            /// </summary>
            [EnumMember(Value = "501 NOT_IMPLEMENTED")]
            _501NOTIMPLEMENTED = 58,

            /// <summary>
            /// Enum _502BADGATEWAY for value: 502 BAD_GATEWAY
            /// </summary>
            [EnumMember(Value = "502 BAD_GATEWAY")]
            _502BADGATEWAY = 59,

            /// <summary>
            /// Enum _503SERVICEUNAVAILABLE for value: 503 SERVICE_UNAVAILABLE
            /// </summary>
            [EnumMember(Value = "503 SERVICE_UNAVAILABLE")]
            _503SERVICEUNAVAILABLE = 60,

            /// <summary>
            /// Enum _504GATEWAYTIMEOUT for value: 504 GATEWAY_TIMEOUT
            /// </summary>
            [EnumMember(Value = "504 GATEWAY_TIMEOUT")]
            _504GATEWAYTIMEOUT = 61,

            /// <summary>
            /// Enum _505HTTPVERSIONNOTSUPPORTED for value: 505 HTTP_VERSION_NOT_SUPPORTED
            /// </summary>
            [EnumMember(Value = "505 HTTP_VERSION_NOT_SUPPORTED")]
            _505HTTPVERSIONNOTSUPPORTED = 62,

            /// <summary>
            /// Enum _506VARIANTALSONEGOTIATES for value: 506 VARIANT_ALSO_NEGOTIATES
            /// </summary>
            [EnumMember(Value = "506 VARIANT_ALSO_NEGOTIATES")]
            _506VARIANTALSONEGOTIATES = 63,

            /// <summary>
            /// Enum _507INSUFFICIENTSTORAGE for value: 507 INSUFFICIENT_STORAGE
            /// </summary>
            [EnumMember(Value = "507 INSUFFICIENT_STORAGE")]
            _507INSUFFICIENTSTORAGE = 64,

            /// <summary>
            /// Enum _508LOOPDETECTED for value: 508 LOOP_DETECTED
            /// </summary>
            [EnumMember(Value = "508 LOOP_DETECTED")]
            _508LOOPDETECTED = 65,

            /// <summary>
            /// Enum _509BANDWIDTHLIMITEXCEEDED for value: 509 BANDWIDTH_LIMIT_EXCEEDED
            /// </summary>
            [EnumMember(Value = "509 BANDWIDTH_LIMIT_EXCEEDED")]
            _509BANDWIDTHLIMITEXCEEDED = 66,

            /// <summary>
            /// Enum _510NOTEXTENDED for value: 510 NOT_EXTENDED
            /// </summary>
            [EnumMember(Value = "510 NOT_EXTENDED")]
            _510NOTEXTENDED = 67,

            /// <summary>
            /// Enum _511NETWORKAUTHENTICATIONREQUIRED for value: 511 NETWORK_AUTHENTICATION_REQUIRED
            /// </summary>
            [EnumMember(Value = "511 NETWORK_AUTHENTICATION_REQUIRED")]
            _511NETWORKAUTHENTICATIONREQUIRED = 68

        }


        /// <summary>
        /// Статус ошибки
        /// </summary>
        /// <value>Статус ошибки</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceError" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceError() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceError" /> class.
        /// </summary>
        /// <param name="debugMessage">Подробное сообщение об ошибке.</param>
        /// <param name="message">Сообщение об ошибке.</param>
        /// <param name="status">Статус ошибки (required).</param>
        /// <param name="subErrors">Ошибки по цепочке вызовов.</param>
        /// <param name="timestamp">Время возникновения ошибки.</param>
        public ServiceError(string debugMessage = default(string), string message = default(string), StatusEnum status = default(StatusEnum), List<ServiceSubError> subErrors = default(List<ServiceSubError>), DateTime timestamp = default(DateTime))
        {
            this.Status = status;
            this.DebugMessage = debugMessage;
            this.Message = message;
            this.SubErrors = subErrors;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// Подробное сообщение об ошибке
        /// </summary>
        /// <value>Подробное сообщение об ошибке</value>
        [DataMember(Name = "debugMessage", EmitDefaultValue = false)]
        public string DebugMessage { get; set; }

        /// <summary>
        /// Сообщение об ошибке
        /// </summary>
        /// <value>Сообщение об ошибке</value>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Ошибки по цепочке вызовов
        /// </summary>
        /// <value>Ошибки по цепочке вызовов</value>
        [DataMember(Name = "subErrors", EmitDefaultValue = false)]
        public List<ServiceSubError> SubErrors { get; set; }

        /// <summary>
        /// Время возникновения ошибки
        /// </summary>
        /// <value>Время возникновения ошибки</value>
        [DataMember(Name = "timestamp", EmitDefaultValue = false)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceError {\n");
            sb.Append("  DebugMessage: ").Append(DebugMessage).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SubErrors: ").Append(SubErrors).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
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
            return this.Equals(input as ServiceError);
        }

        /// <summary>
        /// Returns true if ServiceError instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceError input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DebugMessage == input.DebugMessage ||
                    (this.DebugMessage != null &&
                    this.DebugMessage.Equals(input.DebugMessage))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SubErrors == input.SubErrors ||
                    this.SubErrors != null &&
                    input.SubErrors != null &&
                    this.SubErrors.SequenceEqual(input.SubErrors)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                if (this.DebugMessage != null)
                {
                    hashCode = (hashCode * 59) + this.DebugMessage.GetHashCode();
                }
                if (this.Message != null)
                {
                    hashCode = (hashCode * 59) + this.Message.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SubErrors != null)
                {
                    hashCode = (hashCode * 59) + this.SubErrors.GetHashCode();
                }
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
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
            // DebugMessage (string) maxLength
            if (this.DebugMessage != null && this.DebugMessage.Length > 5000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DebugMessage, length must be less than 5000.", new [] { "DebugMessage" });
            }

            // Message (string) maxLength
            if (this.Message != null && this.Message.Length > 500)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Message, length must be less than 500.", new [] { "Message" });
            }

            // Timestamp (DateTime) maxLength
            if (this.Timestamp != null && this.Timestamp.ToString().Length > 50)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timestamp, length must be less than 50.", new [] { "Timestamp" });
            }

            // Timestamp (DateTime) pattern
            Regex regexTimestamp = new Regex(@"([0-9]{1,4}-[0-9]{1,2}-[0-9]{1,2}[A-Z][0-9]{1,2}:[0-9]{1,2}:[0-9]{1,2}.[0-9]{1,3}[A-Z])", RegexOptions.CultureInvariant);
            if (false == regexTimestamp.Match(this.Timestamp.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timestamp, must match a pattern of " + regexTimestamp, new [] { "Timestamp" });
            }

            yield break;
        }
    }

}

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
using System.Reflection;

namespace Multibanking.CardOperationClient.Model
{
    /// <summary>
    /// UpdateCloseCard400Response
    /// </summary>
    [JsonConverter(typeof(UpdateCloseCard400ResponseJsonConverter))]
    [DataContract(Name = "updateCloseCard_400_response")]
    public partial class UpdateCloseCard400Response : AbstractOpenAPISchema, IEquatable<UpdateCloseCard400Response>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCloseCard400Response" /> class
        /// with the <see cref="ServiceError" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of ServiceError.</param>
        public UpdateCloseCard400Response(ServiceError actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateCloseCard400Response" /> class
        /// with the <see cref="TykErrorResponse" /> class
        /// </summary>
        /// <param name="actualInstance">An instance of TykErrorResponse.</param>
        public UpdateCloseCard400Response(TykErrorResponse actualInstance)
        {
            this.IsNullable = false;
            this.SchemaType= "oneOf";
            this.ActualInstance = actualInstance ?? throw new ArgumentException("Invalid instance found. Must not be null.");
        }


        private Object _actualInstance;

        /// <summary>
        /// Gets or Sets ActualInstance
        /// </summary>
        public override Object ActualInstance
        {
            get
            {
                return _actualInstance;
            }
            set
            {
                if (value.GetType() == typeof(ServiceError))
                {
                    this._actualInstance = value;
                }
                else if (value.GetType() == typeof(TykErrorResponse))
                {
                    this._actualInstance = value;
                }
                else
                {
                    throw new ArgumentException("Invalid instance found. Must be the following types: ServiceError, TykErrorResponse");
                }
            }
        }

        /// <summary>
        /// Get the actual instance of `ServiceError`. If the actual instance is not `ServiceError`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of ServiceError</returns>
        public ServiceError GetServiceError()
        {
            return (ServiceError)this.ActualInstance;
        }

        /// <summary>
        /// Get the actual instance of `TykErrorResponse`. If the actual instance is not `TykErrorResponse`,
        /// the InvalidClassException will be thrown
        /// </summary>
        /// <returns>An instance of TykErrorResponse</returns>
        public TykErrorResponse GetTykErrorResponse()
        {
            return (TykErrorResponse)this.ActualInstance;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateCloseCard400Response {\n");
            sb.Append("  ActualInstance: ").Append(this.ActualInstance).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
        {
            return JsonConvert.SerializeObject(this.ActualInstance, UpdateCloseCard400Response.SerializerSettings);
        }

        /// <summary>
        /// Converts the JSON string into an instance of UpdateCloseCard400Response
        /// </summary>
        /// <param name="jsonString">JSON string</param>
        /// <returns>An instance of UpdateCloseCard400Response</returns>
        public static UpdateCloseCard400Response FromJson(string jsonString)
        {
            UpdateCloseCard400Response newUpdateCloseCard400Response = null;

            if (string.IsNullOrEmpty(jsonString))
            {
                return newUpdateCloseCard400Response;
            }
            int match = 0;
            List<string> matchedTypes = new List<string>();

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(ServiceError).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateCloseCard400Response = new UpdateCloseCard400Response(JsonConvert.DeserializeObject<ServiceError>(jsonString, UpdateCloseCard400Response.SerializerSettings));
                }
                else
                {
                    newUpdateCloseCard400Response = new UpdateCloseCard400Response(JsonConvert.DeserializeObject<ServiceError>(jsonString, UpdateCloseCard400Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("ServiceError");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into ServiceError: {1}", jsonString, exception.ToString()));
            }

            try
            {
                // if it does not contains "AdditionalProperties", use SerializerSettings to deserialize
                if (typeof(TykErrorResponse).GetProperty("AdditionalProperties") == null)
                {
                    newUpdateCloseCard400Response = new UpdateCloseCard400Response(JsonConvert.DeserializeObject<TykErrorResponse>(jsonString, UpdateCloseCard400Response.SerializerSettings));
                }
                else
                {
                    newUpdateCloseCard400Response = new UpdateCloseCard400Response(JsonConvert.DeserializeObject<TykErrorResponse>(jsonString, UpdateCloseCard400Response.AdditionalPropertiesSerializerSettings));
                }
                matchedTypes.Add("TykErrorResponse");
                match++;
            }
            catch (Exception exception)
            {
                // deserialization failed, try the next one
                System.Diagnostics.Debug.WriteLine(string.Format("Failed to deserialize `{0}` into TykErrorResponse: {1}", jsonString, exception.ToString()));
            }

            if (match == 0)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` cannot be deserialized into any schema defined.");
            }
            else if (match > 1)
            {
                throw new InvalidDataException("The JSON string `" + jsonString + "` incorrectly matches more than one schema (should be exactly one match): " + matchedTypes);
            }

            // deserialization is considered successful at this point if no exception has been thrown.
            return newUpdateCloseCard400Response;
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as UpdateCloseCard400Response);
        }

        /// <summary>
        /// Returns true if UpdateCloseCard400Response instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateCloseCard400Response to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateCloseCard400Response input)
        {
            if (input == null)
                return false;

            return this.ActualInstance.Equals(input.ActualInstance);
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
                if (this.ActualInstance != null)
                    hashCode = hashCode * 59 + this.ActualInstance.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

    /// <summary>
    /// Custom JSON converter for UpdateCloseCard400Response
    /// </summary>
    public class UpdateCloseCard400ResponseJsonConverter : JsonConverter
    {
        /// <summary>
        /// To write the JSON string
        /// </summary>
        /// <param name="writer">JSON writer</param>
        /// <param name="value">Object to be converted into a JSON string</param>
        /// <param name="serializer">JSON Serializer</param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteRawValue((string)(typeof(UpdateCloseCard400Response).GetMethod("ToJson").Invoke(value, null)));
        }

        /// <summary>
        /// To convert a JSON string into an object
        /// </summary>
        /// <param name="reader">JSON reader</param>
        /// <param name="objectType">Object type</param>
        /// <param name="existingValue">Existing value</param>
        /// <param name="serializer">JSON Serializer</param>
        /// <returns>The object converted from the JSON string</returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if(reader.TokenType != JsonToken.Null)
            {
                return UpdateCloseCard400Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
            }
            return null;
        }

        /// <summary>
        /// Check if the object can be converted
        /// </summary>
        /// <param name="objectType">Object type</param>
        /// <returns>True if the object can be converted</returns>
        public override bool CanConvert(Type objectType)
        {
            return false;
        }
    }

}
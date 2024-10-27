/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
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
using OpenAPIDateConverter = Multibanking.PeriodPaymentClient.Client.OpenAPIDateConverter;

namespace Multibanking.PeriodPaymentClient.Model
{
    /// <summary>
    /// Запрос наличия необходимого количества средств на счете Плательщика, который связан с Согласием на инициирование
    /// </summary>
    [DataContract(Name = "VRPFundsConfirmationRequest")]
    public partial class VRPFundsConfirmationRequest : IEquatable<VRPFundsConfirmationRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPFundsConfirmationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VRPFundsConfirmationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VRPFundsConfirmationRequest" /> class.
        /// </summary>
        /// <param name="data">data (required).</param>
        public VRPFundsConfirmationRequest(VRPFundsConfirmationRequestData data = default(VRPFundsConfirmationRequestData))
        {
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new ArgumentNullException("data is a required property for VRPFundsConfirmationRequest and cannot be null");
            }
            this.Data = data;
        }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name = "Data", IsRequired = true, EmitDefaultValue = true)]
        public VRPFundsConfirmationRequestData Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class VRPFundsConfirmationRequest {\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as VRPFundsConfirmationRequest);
        }

        /// <summary>
        /// Returns true if VRPFundsConfirmationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of VRPFundsConfirmationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VRPFundsConfirmationRequest input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
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
                if (this.Data != null)
                {
                    hashCode = (hashCode * 59) + this.Data.GetHashCode();
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
            yield break;
        }
    }

}

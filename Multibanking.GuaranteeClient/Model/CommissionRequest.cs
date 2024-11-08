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
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Multibanking.GuaranteeClient.Client.OpenAPIDateConverter;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    ///     Информация о комиссии
    /// </summary>
    [DataContract(Name = "CommissionRequest")]
    public class CommissionRequest : IEquatable<CommissionRequest>, IValidatableObject
    {
        /// <summary>
        ///     Вид банковской гарантии. TENDER - тендерная гарантия, GOVERNMENT_CONTRACTS_EXECUTION - Обеспечение исполнения обязательств по контракту, ADVANCE_REFUND - Обеспечение на
        ///     возврат аванса, OBLIGATIONS_EXECUTION - Банковская гарантия на обеспечение гарантийных обязательств, PAYMENT - Гарантия платежа
        /// </summary>
        /// <value>
        ///     Вид банковской гарантии. TENDER - тендерная гарантия, GOVERNMENT_CONTRACTS_EXECUTION - Обеспечение исполнения обязательств по контракту, ADVANCE_REFUND - Обеспечение на
        ///     возврат аванса, OBLIGATIONS_EXECUTION - Банковская гарантия на обеспечение гарантийных обязательств, PAYMENT - Гарантия платежа
        /// </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BankGuaranteeTypeEnum
        {
            /// <summary>
            ///     Enum TENDER for value: TENDER
            /// </summary>
            [EnumMember(Value = "TENDER")] TENDER = 1,

            /// <summary>
            ///     Enum GOVERNMENTCONTRACTSEXECUTION for value: GOVERNMENT_CONTRACTS_EXECUTION
            /// </summary>
            [EnumMember(Value = "GOVERNMENT_CONTRACTS_EXECUTION")]
            GOVERNMENTCONTRACTSEXECUTION = 2,

            /// <summary>
            ///     Enum ADVANCEREFUND for value: ADVANCE_REFUND
            /// </summary>
            [EnumMember(Value = "ADVANCE_REFUND")] ADVANCEREFUND = 3,

            /// <summary>
            ///     Enum OBLIGATIONSEXECUTION for value: OBLIGATIONS_EXECUTION
            /// </summary>
            [EnumMember(Value = "OBLIGATIONS_EXECUTION")]
            OBLIGATIONSEXECUTION = 4,

            /// <summary>
            ///     Enum PAYMENT for value: PAYMENT
            /// </summary>
            [EnumMember(Value = "PAYMENT")] PAYMENT = 5
        }

        /// <summary>
        ///     Тип закупки
        /// </summary>
        /// <value>Тип закупки</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcurementGuaranteeTypeEnum
        {
            /// <summary>
            ///     Enum FZ44 for value: FZ_44
            /// </summary>
            [EnumMember(Value = "FZ_44")] FZ44 = 1,

            /// <summary>
            ///     Enum FZ223 for value: FZ_223
            /// </summary>
            [EnumMember(Value = "FZ_223")] FZ223 = 2,

            /// <summary>
            ///     Enum COMMERCIAL for value: COMMERCIAL
            /// </summary>
            [EnumMember(Value = "COMMERCIAL")] COMMERCIAL = 3,

            /// <summary>
            ///     Enum PP615 for value: PP_615
            /// </summary>
            [EnumMember(Value = "PP_615")] PP615 = 4
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CommissionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CommissionRequest()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="CommissionRequest" /> class.
        /// </summary>
        /// <param name="procurementGuaranteeType">Тип закупки (required).</param>
        /// <param name="bankGuaranteeSum">Сумма гарантии (required).</param>
        /// <param name="bankGuaranteeType">
        ///     Вид банковской гарантии. TENDER - тендерная гарантия, GOVERNMENT_CONTRACTS_EXECUTION - Обеспечение исполнения обязательств по контракту,
        ///     ADVANCE_REFUND - Обеспечение на возврат аванса, OBLIGATIONS_EXECUTION - Банковская гарантия на обеспечение гарантийных обязательств, PAYMENT - Гарантия платежа (required).
        /// </param>
        /// <param name="endDate">Дата окончания банковской гарантии. Не может быть ранее текущей даты. (required).</param>
        /// <param name="startDate">Дата начала банковской гарантии. Не может быть ранее текущей даты. Должна быть меньше даты окончания гарантии (required).</param>
        public CommissionRequest(ProcurementGuaranteeTypeEnum procurementGuaranteeType = default, decimal bankGuaranteeSum = default,
            BankGuaranteeTypeEnum bankGuaranteeType = default, DateTime endDate = default, DateTime startDate = default)
        {
            ProcurementGuaranteeType = procurementGuaranteeType;
            BankGuaranteeSum = bankGuaranteeSum;
            BankGuaranteeType = bankGuaranteeType;
            EndDate = endDate;
            StartDate = startDate;
        }


        /// <summary>
        ///     Тип закупки
        /// </summary>
        /// <value>Тип закупки</value>
        [DataMember(Name = "procurementGuaranteeType", IsRequired = true, EmitDefaultValue = true)]
        public ProcurementGuaranteeTypeEnum ProcurementGuaranteeType { get; set; }


        /// <summary>
        ///     Вид банковской гарантии. TENDER - тендерная гарантия, GOVERNMENT_CONTRACTS_EXECUTION - Обеспечение исполнения обязательств по контракту, ADVANCE_REFUND - Обеспечение на
        ///     возврат аванса, OBLIGATIONS_EXECUTION - Банковская гарантия на обеспечение гарантийных обязательств, PAYMENT - Гарантия платежа
        /// </summary>
        /// <value>
        ///     Вид банковской гарантии. TENDER - тендерная гарантия, GOVERNMENT_CONTRACTS_EXECUTION - Обеспечение исполнения обязательств по контракту, ADVANCE_REFUND - Обеспечение на
        ///     возврат аванса, OBLIGATIONS_EXECUTION - Банковская гарантия на обеспечение гарантийных обязательств, PAYMENT - Гарантия платежа
        /// </value>
        [DataMember(Name = "bankGuaranteeClientType", IsRequired = true, EmitDefaultValue = true)]
        public BankGuaranteeTypeEnum BankGuaranteeType { get; set; }

        /// <summary>
        ///     Сумма гарантии
        /// </summary>
        /// <value>Сумма гарантии</value>
        [DataMember(Name = "bankGuaranteeSum", IsRequired = true, EmitDefaultValue = true)]
        public decimal BankGuaranteeSum { get; set; }

        /// <summary>
        ///     Дата окончания банковской гарантии. Не может быть ранее текущей даты.
        /// </summary>
        /// <value>Дата окончания банковской гарантии. Не может быть ранее текущей даты.</value>
        [DataMember(Name = "endDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime EndDate { get; set; }

        /// <summary>
        ///     Дата начала банковской гарантии. Не может быть ранее текущей даты. Должна быть меньше даты окончания гарантии
        /// </summary>
        /// <value>Дата начала банковской гарантии. Не может быть ранее текущей даты. Должна быть меньше даты окончания гарантии</value>
        [DataMember(Name = "startDate", IsRequired = true, EmitDefaultValue = true)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime StartDate { get; set; }

        /// <summary>
        ///     Returns true if CommissionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CommissionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CommissionRequest input)
        {
            if (input == null) return false;
            return
                (
                    ProcurementGuaranteeType == input.ProcurementGuaranteeType ||
                    ProcurementGuaranteeType.Equals(input.ProcurementGuaranteeType)
                ) &&
                (
                    BankGuaranteeSum == input.BankGuaranteeSum ||
                    BankGuaranteeSum.Equals(input.BankGuaranteeSum)
                ) &&
                (
                    BankGuaranteeType == input.BankGuaranteeType ||
                    BankGuaranteeType.Equals(input.BankGuaranteeType)
                ) &&
                (
                    EndDate == input.EndDate ||
                    (EndDate != null &&
                     EndDate.Equals(input.EndDate))
                ) &&
                (
                    StartDate == input.StartDate ||
                    (StartDate != null &&
                     StartDate.Equals(input.StartDate))
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // BankGuaranteeSum (decimal) maximum
            if (BankGuaranteeSum > 9007199254740991)
                yield return new ValidationResult("Invalid value for BankGuaranteeSum, must be a value less than or equal to 9007199254740991.", new[] { "BankGuaranteeSum" });

            // BankGuaranteeSum (decimal) minimum
            if (BankGuaranteeSum < 0)
                yield return new ValidationResult("Invalid value for BankGuaranteeSum, must be a value greater than or equal to 0.", new[] { "BankGuaranteeSum" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CommissionRequest {\n");
            sb.Append("  ProcurementGuaranteeType: ").Append(ProcurementGuaranteeType).Append("\n");
            sb.Append("  BankGuaranteeSum: ").Append(BankGuaranteeSum).Append("\n");
            sb.Append("  BankGuaranteeClientType: ").Append(BankGuaranteeType).Append("\n");
            sb.Append("  EndDate: ").Append(EndDate).Append("\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
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
            return Equals(input as CommissionRequest);
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
                hashCode = hashCode * 59 + ProcurementGuaranteeType.GetHashCode();
                hashCode = hashCode * 59 + BankGuaranteeSum.GetHashCode();
                hashCode = hashCode * 59 + BankGuaranteeType.GetHashCode();
                if (EndDate != null) hashCode = hashCode * 59 + EndDate.GetHashCode();
                if (StartDate != null) hashCode = hashCode * 59 + StartDate.GetHashCode();
                return hashCode;
            }
        }
    }
}
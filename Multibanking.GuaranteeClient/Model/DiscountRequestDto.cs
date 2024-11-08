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
    ///     Запрос на получение скидки
    /// </summary>
    [DataContract(Name = "DiscountRequestDto")]
    public class DiscountRequestDto : IEquatable<DiscountRequestDto>, IValidatableObject
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="DiscountRequestDto" /> class.
        /// </summary>
        /// <param name="annualInterestRate">Запрошенная ставка комиссии, в % годовых.</param>
        /// <param name="commissionAmount">Запрошенная сумма комиссии.</param>
        public DiscountRequestDto(decimal annualInterestRate = default, decimal commissionAmount = default)
        {
            AnnualInterestRate = annualInterestRate;
            CommissionAmount = commissionAmount;
        }

        /// <summary>
        ///     Запрошенная ставка комиссии, в % годовых
        /// </summary>
        /// <value>Запрошенная ставка комиссии, в % годовых</value>
        [DataMember(Name = "annualInterestRate", EmitDefaultValue = false)]
        public decimal AnnualInterestRate { get; set; }

        /// <summary>
        ///     Запрошенная сумма комиссии
        /// </summary>
        /// <value>Запрошенная сумма комиссии</value>
        [DataMember(Name = "commissionAmount", EmitDefaultValue = false)]
        public decimal CommissionAmount { get; set; }

        /// <summary>
        ///     Returns true if DiscountRequestDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DiscountRequestDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DiscountRequestDto input)
        {
            if (input == null) return false;
            return
                (
                    AnnualInterestRate == input.AnnualInterestRate ||
                    AnnualInterestRate.Equals(input.AnnualInterestRate)
                ) &&
                (
                    CommissionAmount == input.CommissionAmount ||
                    CommissionAmount.Equals(input.CommissionAmount)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // AnnualInterestRate (decimal) maximum
            if (AnnualInterestRate > 99)
                yield return new ValidationResult("Invalid value for AnnualInterestRate, must be a value less than or equal to 99.", new[] { "AnnualInterestRate" });

            // AnnualInterestRate (decimal) minimum
            if (AnnualInterestRate < 0)
                yield return new ValidationResult("Invalid value for AnnualInterestRate, must be a value greater than or equal to 0.", new[] { "AnnualInterestRate" });

            // CommissionAmount (decimal) maximum
            if (CommissionAmount > 9007199254740991)
                yield return new ValidationResult("Invalid value for CommissionAmount, must be a value less than or equal to 9007199254740991.", new[] { "CommissionAmount" });

            // CommissionAmount (decimal) minimum
            if (CommissionAmount < 500)
                yield return new ValidationResult("Invalid value for CommissionAmount, must be a value greater than or equal to 500.", new[] { "CommissionAmount" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DiscountRequestDto {\n");
            sb.Append("  AnnualInterestRate: ").Append(AnnualInterestRate).Append("\n");
            sb.Append("  CommissionAmount: ").Append(CommissionAmount).Append("\n");
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
            return Equals(input as DiscountRequestDto);
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
                hashCode = hashCode * 59 + AnnualInterestRate.GetHashCode();
                hashCode = hashCode * 59 + CommissionAmount.GetHashCode();
                return hashCode;
            }
        }
    }
}
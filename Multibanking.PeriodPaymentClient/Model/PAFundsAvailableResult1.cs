/*
 * Периодические  переводы денежных средств с переменными реквизитами
 *
 * Спецификация содержит описание элементов, которые являются общими для всех API на периодические  переводы денежных средств с переменными реквизитами (далее по тексту ППДС). В соответствии со стандартом ППДС Пользователь имеет право предоставить долгосрочное согласие на Услугу «Платежный сервис» СППУ с целью инициирования переводов средств от их имени, без необходимости аутентификации каждого отдельного платежа Пользователем у ППИУ. При этом ППИУ и СППУ реализуют взаимодействие для осуществления ППДС используя API.
 *
 * The version of the OpenAPI document: 1.3.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Результат доступности, четко указывающий на наличие средств на сумму, указанную в запросе
/// </summary>
[DataContract(Name = "PAFundsAvailableResult1")]
public class PAFundsAvailableResult1 : IEquatable<PAFundsAvailableResult1>, IValidatableObject
{
    /// <summary>
    ///     Результат доступности, четко указывающий на наличие средств на сумму, указанную в запросе
    /// </summary>
    /// <value>Результат доступности, четко указывающий на наличие средств на сумму, указанную в запросе</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum FundsAvailableEnum
    {
        /// <summary>
        ///     Enum Available for value: Available
        /// </summary>
        [EnumMember(Value = "Available")] Available = 1,

        /// <summary>
        ///     Enum AvailablaWithOverdraft for value: AvailablaWithOverdraft
        /// </summary>
        [EnumMember(Value = "AvailablaWithOverdraft")]
        AvailablaWithOverdraft = 2,

        /// <summary>
        ///     Enum NotAvailable for value: NotAvailable
        /// </summary>
        [EnumMember(Value = "NotAvailable")] NotAvailable = 3
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="PAFundsAvailableResult1" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected PAFundsAvailableResult1()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="PAFundsAvailableResult1" /> class.
    /// </summary>
    /// <param name="fundsAvailableDateTime">Дата и время проведение проверки наличия средств (required).</param>
    /// <param name="fundsAvailable">Результат доступности, четко указывающий на наличие средств на сумму, указанную в запросе (required).</param>
    public PAFundsAvailableResult1(DateTime fundsAvailableDateTime = default, FundsAvailableEnum fundsAvailable = default)
    {
        FundsAvailableDateTime = fundsAvailableDateTime;
        FundsAvailable = fundsAvailable;
    }


    /// <summary>
    ///     Результат доступности, четко указывающий на наличие средств на сумму, указанную в запросе
    /// </summary>
    /// <value>Результат доступности, четко указывающий на наличие средств на сумму, указанную в запросе</value>
    [DataMember(Name = "fundsAvailable", IsRequired = true, EmitDefaultValue = true)]
    public FundsAvailableEnum FundsAvailable { get; set; }

    /// <summary>
    ///     Дата и время проведение проверки наличия средств
    /// </summary>
    /// <value>Дата и время проведение проверки наличия средств</value>
    [DataMember(Name = "fundsAvailableDateTime", IsRequired = true, EmitDefaultValue = true)]
    public DateTime FundsAvailableDateTime { get; set; }

    /// <summary>
    ///     Returns true if PAFundsAvailableResult1 instances are equal
    /// </summary>
    /// <param name="input">Instance of PAFundsAvailableResult1 to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PAFundsAvailableResult1 input)
    {
        if (input == null) return false;
        return
            (
                FundsAvailableDateTime == input.FundsAvailableDateTime ||
                (FundsAvailableDateTime != null &&
                 FundsAvailableDateTime.Equals(input.FundsAvailableDateTime))
            ) &&
            (
                FundsAvailable == input.FundsAvailable ||
                FundsAvailable.Equals(input.FundsAvailable)
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        yield break;
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PAFundsAvailableResult1 {\n");
        sb.Append("  FundsAvailableDateTime: ").Append(FundsAvailableDateTime).Append("\n");
        sb.Append("  FundsAvailable: ").Append(FundsAvailable).Append("\n");
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
        return Equals(input as PAFundsAvailableResult1);
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
            if (FundsAvailableDateTime != null) hashCode = hashCode * 59 + FundsAvailableDateTime.GetHashCode();
            hashCode = hashCode * 59 + FundsAvailable.GetHashCode();
            return hashCode;
        }
    }
}
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

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Однозначная идентификация счета банка получателя средств у обслуживающего его банка, по которому будет выполнена кредитовая запись в результате платежной операции
/// </summary>
[DataContract(Name = "VRPInitiation_CreditorAgentAccount")]
public class VRPInitiationCreditorAgentAccount : IEquatable<VRPInitiationCreditorAgentAccount>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPInitiationCreditorAgentAccount" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected VRPInitiationCreditorAgentAccount()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPInitiationCreditorAgentAccount" /> class.
    /// </summary>
    /// <param name="name">Наименование счета, присвоенное учреждением, обслуживающим счет, по согласованию с владельцем счета  для обеспечения дополнительных средств идентификации счета.</param>
    /// <param name="schemeName">Наименование схемы идентификации счета (required).</param>
    /// <param name="identification">
    ///     Идентификатор счета соответствующий схеме идентификации, известный владельцу счета (номер банковского счета, номер карты, номер телефона ...)
    ///     (required).
    /// </param>
    public VRPInitiationCreditorAgentAccount(string name = default, AccountIdentificationCode schemeName = default, string identification = default)
    {
        SchemeName = schemeName;
        // to ensure "identification" is required (not null)
        if (identification == null) throw new ArgumentNullException("identification is a required property for VRPInitiationCreditorAgentAccount and cannot be null");
        Identification = identification;
        Name = name;
    }

    /// <summary>
    ///     Наименование схемы идентификации счета
    /// </summary>
    /// <value>Наименование схемы идентификации счета</value>
    [DataMember(Name = "schemeName", IsRequired = true, EmitDefaultValue = true)]
    public AccountIdentificationCode SchemeName { get; set; }

    /// <summary>
    ///     Наименование счета, присвоенное учреждением, обслуживающим счет, по согласованию с владельцем счета  для обеспечения дополнительных средств идентификации счета
    /// </summary>
    /// <value>Наименование счета, присвоенное учреждением, обслуживающим счет, по согласованию с владельцем счета  для обеспечения дополнительных средств идентификации счета</value>
    [DataMember(Name = "name", EmitDefaultValue = false)]
    public string Name { get; set; }

    /// <summary>
    ///     Идентификатор счета соответствующий схеме идентификации, известный владельцу счета (номер банковского счета, номер карты, номер телефона ...)
    /// </summary>
    /// <value>Идентификатор счета соответствующий схеме идентификации, известный владельцу счета (номер банковского счета, номер карты, номер телефона ...)</value>
    [DataMember(Name = "identification", IsRequired = true, EmitDefaultValue = true)]
    public string Identification { get; set; }

    /// <summary>
    ///     Returns true if VRPInitiationCreditorAgentAccount instances are equal
    /// </summary>
    /// <param name="input">Instance of VRPInitiationCreditorAgentAccount to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VRPInitiationCreditorAgentAccount input)
    {
        if (input == null) return false;
        return
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
            ) &&
            (
                SchemeName == input.SchemeName ||
                SchemeName.Equals(input.SchemeName)
            ) &&
            (
                Identification == input.Identification ||
                (Identification != null &&
                 Identification.Equals(input.Identification))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Name (string) maxLength
        if (Name != null && Name.Length > 70) yield return new ValidationResult("Invalid value for Name, length must be less than 70.", new[] { "Name" });

        // Identification (string) maxLength
        if (Identification != null && Identification.Length > 256)
            yield return new ValidationResult("Invalid value for Identification, length must be less than 256.", new[] { "Identification" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VRPInitiationCreditorAgentAccount {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  SchemeName: ").Append(SchemeName).Append("\n");
        sb.Append("  Identification: ").Append(Identification).Append("\n");
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
        return Equals(input as VRPInitiationCreditorAgentAccount);
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
            if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
            hashCode = hashCode * 59 + SchemeName.GetHashCode();
            if (Identification != null) hashCode = hashCode * 59 + Identification.GetHashCode();
            return hashCode;
        }
    }
}
/*
 * Поисковые сервисы каталога поставщиков услуг
 *
 * Поисковые сервисы каталога поставщиков услуг
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

namespace Multibanking.ServiceClient.Model;

/// <summary>
///     Настройки для платежного сценария по услуге
/// </summary>
[DataContract(Name = "PaymentSettingsDetailDtoRs")]
public class PaymentSettingsDetailDtoRs : IEquatable<PaymentSettingsDetailDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Ограничения для совершения платежа по типу аутентификации клиента
    /// </summary>
    /// <value>Ограничения для совершения платежа по типу аутентификации клиента</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ClientRolePayRestrictionsEnum
    {
        /// <summary>
        ///     Enum ANONYMCLIENT for value: ANONYM_CLIENT
        /// </summary>
        [EnumMember(Value = "ANONYM_CLIENT")] ANONYMCLIENT = 1,

        /// <summary>
        ///     Enum UPRIDCLIENT for value: UPRID_CLIENT
        /// </summary>
        [EnumMember(Value = "UPRID_CLIENT")] UPRIDCLIENT = 2
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="PaymentSettingsDetailDtoRs" /> class.
    /// </summary>
    /// <param name="acceptanceKey">Ключ-наименование микросервиса для оплаты услуги.</param>
    /// <param name="clientRolePayRestrictions">Ограничения для совершения платежа по типу аутентификации клиента.</param>
    public PaymentSettingsDetailDtoRs(string acceptanceKey = default, List<ClientRolePayRestrictionsEnum> clientRolePayRestrictions = default)
    {
        AcceptanceKey = acceptanceKey;
        ClientRolePayRestrictions = clientRolePayRestrictions;
    }


    /// <summary>
    ///     Ограничения для совершения платежа по типу аутентификации клиента
    /// </summary>
    /// <value>Ограничения для совершения платежа по типу аутентификации клиента</value>
    [DataMember(Name = "clientRolePayRestrictions", EmitDefaultValue = false)]
    public List<ClientRolePayRestrictionsEnum> ClientRolePayRestrictions { get; set; }

    /// <summary>
    ///     Ключ-наименование микросервиса для оплаты услуги
    /// </summary>
    /// <value>Ключ-наименование микросервиса для оплаты услуги</value>
    [DataMember(Name = "acceptanceKey", EmitDefaultValue = false)]
    public string AcceptanceKey { get; set; }

    /// <summary>
    ///     Returns true if PaymentSettingsDetailDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of PaymentSettingsDetailDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PaymentSettingsDetailDtoRs input)
    {
        if (input == null) return false;
        return
            (
                AcceptanceKey == input.AcceptanceKey ||
                (AcceptanceKey != null &&
                 AcceptanceKey.Equals(input.AcceptanceKey))
            ) &&
            (
                ClientRolePayRestrictions == input.ClientRolePayRestrictions ||
                ClientRolePayRestrictions.SequenceEqual(input.ClientRolePayRestrictions)
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // AcceptanceKey (string) maxLength
        if (AcceptanceKey != null && AcceptanceKey.Length > 64)
            yield return new ValidationResult("Invalid value for AcceptanceKey, length must be less than 64.", new[] { "AcceptanceKey" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PaymentSettingsDetailDtoRs {\n");
        sb.Append("  AcceptanceKey: ").Append(AcceptanceKey).Append("\n");
        sb.Append("  ClientRolePayRestrictions: ").Append(ClientRolePayRestrictions).Append("\n");
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
        return Equals(input as PaymentSettingsDetailDtoRs);
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
            if (AcceptanceKey != null) hashCode = hashCode * 59 + AcceptanceKey.GetHashCode();
            hashCode = hashCode * 59 + ClientRolePayRestrictions.GetHashCode();
            return hashCode;
        }
    }
}
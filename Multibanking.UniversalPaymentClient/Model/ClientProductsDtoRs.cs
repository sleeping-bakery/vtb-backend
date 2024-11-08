/*
 * Cервис платежа с базовым сценарием оплаты
 *
 * сервис платежа с базовым сценарием оплаты
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

namespace Multibanking.UniversalPaymentClient.Model;

/// <summary>
///     Информация о продукте клиента
/// </summary>
[DataContract(Name = "ClientProductsDtoRs")]
public class ClientProductsDtoRs : IEquatable<ClientProductsDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="ClientProductsDtoRs" /> class.
    /// </summary>
    /// <param name="accounts">Список счетов клиента.</param>
    /// <param name="cards">Список карт клиента.</param>
    public ClientProductsDtoRs(List<AccountDtoRs> accounts = default, List<CardDtoRs> cards = default)
    {
        Accounts = accounts;
        Cards = cards;
    }

    /// <summary>
    ///     Список счетов клиента
    /// </summary>
    /// <value>Список счетов клиента</value>
    [DataMember(Name = "accounts", EmitDefaultValue = false)]
    public List<AccountDtoRs> Accounts { get; set; }

    /// <summary>
    ///     Список карт клиента
    /// </summary>
    /// <value>Список карт клиента</value>
    [DataMember(Name = "cards", EmitDefaultValue = false)]
    public List<CardDtoRs> Cards { get; set; }

    /// <summary>
    ///     Returns true if ClientProductsDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of ClientProductsDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(ClientProductsDtoRs input)
    {
        if (input == null) return false;
        return
            (
                Accounts == input.Accounts ||
                (Accounts != null &&
                 input.Accounts != null &&
                 Accounts.SequenceEqual(input.Accounts))
            ) &&
            (
                Cards == input.Cards ||
                (Cards != null &&
                 input.Cards != null &&
                 Cards.SequenceEqual(input.Cards))
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
        sb.Append("class ClientProductsDtoRs {\n");
        sb.Append("  Accounts: ").Append(Accounts).Append("\n");
        sb.Append("  Cards: ").Append(Cards).Append("\n");
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
        return Equals(input as ClientProductsDtoRs);
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
            if (Accounts != null) hashCode = hashCode * 59 + Accounts.GetHashCode();
            if (Cards != null) hashCode = hashCode * 59 + Cards.GetHashCode();
            return hashCode;
        }
    }
}
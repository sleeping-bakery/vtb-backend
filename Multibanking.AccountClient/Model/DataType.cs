/*
 * Получение информации о счете клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по счетам и транзакциям.
 *
 * The version of the OpenAPI document: 1.2.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.AccountClient.Model;

/// <summary>
///     DataType
/// </summary>
[DataContract(Name = "DataType")]
public class DataType : IEquatable<DataType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DataType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DataType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DataType" /> class.
    /// </summary>
    /// <param name="permissions">
    ///     Указание типов данных доступа к счетам Пользователя. Это список доменов данных, которые были
    ///     одобрены Пользователем и запрошены для авторизации на стороне ППУ. (required).
    /// </param>
    /// <param name="expirationDateTime">
    ///     Дата и время истечения срока действия разрешений.Если он не заполнен, разрешения будет
    ///     с открытой датой..
    /// </param>
    /// <param name="transactionFromDateTime">
    ///     Дата и время начала периода запроса транзакции.Если он не заполнен, дата начала
    ///     будет с открытой датой, и данные будутвозвращены с самой ранней из доступных транзакций..
    /// </param>
    /// <param name="transactionToDateTime">
    ///     Дата и время окончания периода запроса транзакции.Если он не заполнен, дата
    ///     окончания будет открытой, и данные будутвозвращены в самую последнюю доступную транзакцию..
    /// </param>
    public DataType(Collection<PermissionsType> permissions = default, DateTime expirationDateTime = default,
        DateTime transactionFromDateTime = default, DateTime transactionToDateTime = default)
    {
        // to ensure "permissions" is required (not null)
        if (permissions == null)
            throw new ArgumentNullException("permissions is a required property for DataType and cannot be null");
        Permissions = permissions;
        ExpirationDateTime = expirationDateTime;
        TransactionFromDateTime = transactionFromDateTime;
        TransactionToDateTime = transactionToDateTime;
    }

    /// <summary>
    ///     Указание типов данных доступа к счетам Пользователя. Это список доменов данных, которые были одобрены Пользователем
    ///     и запрошены для авторизации на стороне ППУ.
    /// </summary>
    /// <value>
    ///     Указание типов данных доступа к счетам Пользователя. Это список доменов данных, которые были одобрены
    ///     Пользователем и запрошены для авторизации на стороне ППУ.
    /// </value>
    [DataMember(Name = "permissions", IsRequired = true, EmitDefaultValue = true)]
    public Collection<PermissionsType> Permissions { get; set; }

    /// <summary>
    ///     Дата и время истечения срока действия разрешений.Если он не заполнен, разрешения будет с открытой датой.
    /// </summary>
    /// <value>Дата и время истечения срока действия разрешений.Если он не заполнен, разрешения будет с открытой датой.</value>
    [DataMember(Name = "expirationDateTime", EmitDefaultValue = false)]
    public DateTime ExpirationDateTime { get; set; }

    /// <summary>
    ///     Дата и время начала периода запроса транзакции.Если он не заполнен, дата начала будет с открытой датой, и данные
    ///     будутвозвращены с самой ранней из доступных транзакций.
    /// </summary>
    /// <value>
    ///     Дата и время начала периода запроса транзакции.Если он не заполнен, дата начала будет с открытой датой, и данные
    ///     будутвозвращены с самой ранней из доступных транзакций.
    /// </value>
    [DataMember(Name = "transactionFromDateTime", EmitDefaultValue = false)]
    public DateTime TransactionFromDateTime { get; set; }

    /// <summary>
    ///     Дата и время окончания периода запроса транзакции.Если он не заполнен, дата окончания будет открытой, и данные
    ///     будутвозвращены в самую последнюю доступную транзакцию.
    /// </summary>
    /// <value>
    ///     Дата и время окончания периода запроса транзакции.Если он не заполнен, дата окончания будет открытой, и данные
    ///     будутвозвращены в самую последнюю доступную транзакцию.
    /// </value>
    [DataMember(Name = "transactionToDateTime", EmitDefaultValue = false)]
    public DateTime TransactionToDateTime { get; set; }

    /// <summary>
    ///     Returns true if DataType instances are equal
    /// </summary>
    /// <param name="input">Instance of DataType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataType input)
    {
        if (input == null) return false;
        return
            (
                Permissions == input.Permissions ||
                (Permissions != null &&
                 input.Permissions != null &&
                 Permissions.SequenceEqual(input.Permissions))
            ) &&
            (
                ExpirationDateTime == input.ExpirationDateTime ||
                (ExpirationDateTime != null &&
                 ExpirationDateTime.Equals(input.ExpirationDateTime))
            ) &&
            (
                TransactionFromDateTime == input.TransactionFromDateTime ||
                (TransactionFromDateTime != null &&
                 TransactionFromDateTime.Equals(input.TransactionFromDateTime))
            ) &&
            (
                TransactionToDateTime == input.TransactionToDateTime ||
                (TransactionToDateTime != null &&
                 TransactionToDateTime.Equals(input.TransactionToDateTime))
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
        sb.Append("class DataType {\n");
        sb.Append("  Permissions: ").Append(Permissions).Append("\n");
        sb.Append("  ExpirationDateTime: ").Append(ExpirationDateTime).Append("\n");
        sb.Append("  TransactionFromDateTime: ").Append(TransactionFromDateTime).Append("\n");
        sb.Append("  TransactionToDateTime: ").Append(TransactionToDateTime).Append("\n");
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
        return Equals(input as DataType);
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
            if (Permissions != null) hashCode = hashCode * 59 + Permissions.GetHashCode();
            if (ExpirationDateTime != null) hashCode = hashCode * 59 + ExpirationDateTime.GetHashCode();
            if (TransactionFromDateTime != null) hashCode = hashCode * 59 + TransactionFromDateTime.GetHashCode();
            if (TransactionToDateTime != null) hashCode = hashCode * 59 + TransactionToDateTime.GetHashCode();
            return hashCode;
        }
    }
}
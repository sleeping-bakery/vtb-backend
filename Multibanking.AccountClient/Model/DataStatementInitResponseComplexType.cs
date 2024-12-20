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
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.AccountClient.Model;

/// <summary>
///     Контейнер для данных
/// </summary>
[DataContract(Name = "DataStatementInitResponseComplexType")]
public class DataStatementInitResponseComplexType : IEquatable<DataStatementInitResponseComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="DataStatementInitResponseComplexType" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected DataStatementInitResponseComplexType()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="DataStatementInitResponseComplexType" /> class.
    /// </summary>
    /// <param name="statement">statement (required).</param>
    public DataStatementInitResponseComplexType(StatementInitRespComplex statement = default)
    {
        // to ensure "statement" is required (not null)
        if (statement == null) throw new ArgumentNullException("statement is a required property for DataStatementInitResponseComplexType and cannot be null");
        Statement = statement;
    }

    /// <summary>
    ///     Gets or Sets Statement
    /// </summary>
    [DataMember(Name = "Statement", IsRequired = true, EmitDefaultValue = true)]
    public StatementInitRespComplex Statement { get; set; }

    /// <summary>
    ///     Returns true if DataStatementInitResponseComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of DataStatementInitResponseComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(DataStatementInitResponseComplexType input)
    {
        if (input == null) return false;
        return
            Statement == input.Statement ||
            (Statement != null &&
             Statement.Equals(input.Statement));
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
        sb.Append("class DataStatementInitResponseComplexType {\n");
        sb.Append("  Statement: ").Append(Statement).Append("\n");
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
        return Equals(input as DataStatementInitResponseComplexType);
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
            if (Statement != null) hashCode = hashCode * 59 + Statement.GetHashCode();
            return hashCode;
        }
    }
}
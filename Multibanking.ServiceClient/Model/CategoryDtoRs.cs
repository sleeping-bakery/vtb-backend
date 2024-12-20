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

namespace Multibanking.ServiceClient.Model;

/// <summary>
///     Категория ПУ
/// </summary>
[DataContract(Name = "CategoryDtoRs")]
public class CategoryDtoRs : IEquatable<CategoryDtoRs>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="CategoryDtoRs" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected CategoryDtoRs()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="CategoryDtoRs" /> class.
    /// </summary>
    /// <param name="id">ID категории ПУ (required).</param>
    /// <param name="name">Название категории ПУ (required).</param>
    /// <param name="nameKey">Уникальный текстовой код категории.</param>
    /// <param name="serviceProviders">Список услуг.</param>
    public CategoryDtoRs(string id = default, string name = default, string nameKey = default, List<ServiceProviderSearchDtoRs> serviceProviders = default)
    {
        // to ensure "id" is required (not null)
        if (id == null) throw new ArgumentNullException("id is a required property for CategoryDtoRs and cannot be null");
        Id = id;
        // to ensure "name" is required (not null)
        if (name == null) throw new ArgumentNullException("name is a required property for CategoryDtoRs and cannot be null");
        Name = name;
        NameKey = nameKey;
        ServiceProviders = serviceProviders;
    }

    /// <summary>
    ///     ID категории ПУ
    /// </summary>
    /// <value>ID категории ПУ</value>
    [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
    public string Id { get; set; }

    /// <summary>
    ///     Название категории ПУ
    /// </summary>
    /// <value>Название категории ПУ</value>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Уникальный текстовой код категории
    /// </summary>
    /// <value>Уникальный текстовой код категории</value>
    [DataMember(Name = "nameKey", EmitDefaultValue = false)]
    public string NameKey { get; set; }

    /// <summary>
    ///     Список услуг
    /// </summary>
    /// <value>Список услуг</value>
    [DataMember(Name = "serviceProviders", EmitDefaultValue = false)]
    public List<ServiceProviderSearchDtoRs> ServiceProviders { get; set; }

    /// <summary>
    ///     Returns true if CategoryDtoRs instances are equal
    /// </summary>
    /// <param name="input">Instance of CategoryDtoRs to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(CategoryDtoRs input)
    {
        if (input == null) return false;
        return
            (
                Id == input.Id ||
                (Id != null &&
                 Id.Equals(input.Id))
            ) &&
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
            ) &&
            (
                NameKey == input.NameKey ||
                (NameKey != null &&
                 NameKey.Equals(input.NameKey))
            ) &&
            (
                ServiceProviders == input.ServiceProviders ||
                (ServiceProviders != null &&
                 input.ServiceProviders != null &&
                 ServiceProviders.SequenceEqual(input.ServiceProviders))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Id (string) maxLength
        if (Id != null && Id.Length > 16) yield return new ValidationResult("Invalid value for Id, length must be less than 16.", new[] { "Id" });

        // Name (string) maxLength
        if (Name != null && Name.Length > 255) yield return new ValidationResult("Invalid value for Name, length must be less than 255.", new[] { "Name" });

        // NameKey (string) maxLength
        if (NameKey != null && NameKey.Length > 64) yield return new ValidationResult("Invalid value for NameKey, length must be less than 64.", new[] { "NameKey" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class CategoryDtoRs {\n");
        sb.Append("  Id: ").Append(Id).Append("\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  NameKey: ").Append(NameKey).Append("\n");
        sb.Append("  ServiceProviders: ").Append(ServiceProviders).Append("\n");
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
        return Equals(input as CategoryDtoRs);
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
            if (Id != null) hashCode = hashCode * 59 + Id.GetHashCode();
            if (Name != null) hashCode = hashCode * 59 + Name.GetHashCode();
            if (NameKey != null) hashCode = hashCode * 59 + NameKey.GetHashCode();
            if (ServiceProviders != null) hashCode = hashCode * 59 + ServiceProviders.GetHashCode();
            return hashCode;
        }
    }
}
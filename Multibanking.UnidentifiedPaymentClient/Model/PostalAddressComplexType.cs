/*
 * Инициирование перевода денежных средств клиента третьей стороной
 *
 * Содержит описываются API для Открытых банковских интерфейсов по переводам.
 *
 * The version of the OpenAPI document: 1.1.0
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.UnidentifiedPaymentClient.Model;

/// <summary>
///     Адрес финансовой организации, обслуживающая счет получателя средств
/// </summary>
[DataContract(Name = "PostalAddressComplexType")]
public class PostalAddressComplexType : IEquatable<PostalAddressComplexType>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PostalAddressComplexType" /> class.
    /// </summary>
    /// <param name="addressType">Тип адреса.</param>
    /// <param name="department">department.</param>
    /// <param name="subDepartment">subDepartment.</param>
    /// <param name="streetName">streetName.</param>
    /// <param name="buildingNumber">buildingNumber.</param>
    /// <param name="postCode">postCode.</param>
    /// <param name="townName">townName.</param>
    /// <param name="countrySubDivision">countrySubDivision.</param>
    /// <param name="country">Страна. Справочник кодов ISO3166, Alpha-3 code..</param>
    /// <param name="addressLine">addressLine.</param>
    public PostalAddressComplexType(AddressTypeStaticType? addressType = default, string department = default, string subDepartment = default, string streetName = default,
        string buildingNumber = default, string postCode = default, string townName = default, string countrySubDivision = default, string country = default,
        List<string> addressLine = default)
    {
        AddressType = addressType;
        Department = department;
        SubDepartment = subDepartment;
        StreetName = streetName;
        BuildingNumber = buildingNumber;
        PostCode = postCode;
        TownName = townName;
        CountrySubDivision = countrySubDivision;
        Country = country;
        AddressLine = addressLine;
    }

    /// <summary>
    ///     Тип адреса
    /// </summary>
    /// <value>Тип адреса</value>
    [DataMember(Name = "addressType", EmitDefaultValue = false)]
    public AddressTypeStaticType? AddressType { get; set; }

    /// <summary>
    ///     Gets or Sets Department
    /// </summary>
    [DataMember(Name = "department", EmitDefaultValue = false)]
    public string Department { get; set; }

    /// <summary>
    ///     Gets or Sets SubDepartment
    /// </summary>
    [DataMember(Name = "subDepartment", EmitDefaultValue = false)]
    public string SubDepartment { get; set; }

    /// <summary>
    ///     Gets or Sets StreetName
    /// </summary>
    [DataMember(Name = "streetName", EmitDefaultValue = false)]
    public string StreetName { get; set; }

    /// <summary>
    ///     Gets or Sets BuildingNumber
    /// </summary>
    [DataMember(Name = "buildingNumber", EmitDefaultValue = false)]
    public string BuildingNumber { get; set; }

    /// <summary>
    ///     Gets or Sets PostCode
    /// </summary>
    [DataMember(Name = "postCode", EmitDefaultValue = false)]
    public string PostCode { get; set; }

    /// <summary>
    ///     Gets or Sets TownName
    /// </summary>
    [DataMember(Name = "townName", EmitDefaultValue = false)]
    public string TownName { get; set; }

    /// <summary>
    ///     Gets or Sets CountrySubDivision
    /// </summary>
    [DataMember(Name = "countrySubDivision", EmitDefaultValue = false)]
    public string CountrySubDivision { get; set; }

    /// <summary>
    ///     Страна. Справочник кодов ISO3166, Alpha-3 code.
    /// </summary>
    /// <value>Страна. Справочник кодов ISO3166, Alpha-3 code.</value>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    public string Country { get; set; }

    /// <summary>
    ///     Gets or Sets AddressLine
    /// </summary>
    [DataMember(Name = "addressLine", EmitDefaultValue = false)]
    public List<string> AddressLine { get; set; }

    /// <summary>
    ///     Returns true if PostalAddressComplexType instances are equal
    /// </summary>
    /// <param name="input">Instance of PostalAddressComplexType to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PostalAddressComplexType input)
    {
        if (input == null) return false;
        return
            (
                AddressType == input.AddressType ||
                AddressType.Equals(input.AddressType)
            ) &&
            (
                Department == input.Department ||
                (Department != null &&
                 Department.Equals(input.Department))
            ) &&
            (
                SubDepartment == input.SubDepartment ||
                (SubDepartment != null &&
                 SubDepartment.Equals(input.SubDepartment))
            ) &&
            (
                StreetName == input.StreetName ||
                (StreetName != null &&
                 StreetName.Equals(input.StreetName))
            ) &&
            (
                BuildingNumber == input.BuildingNumber ||
                (BuildingNumber != null &&
                 BuildingNumber.Equals(input.BuildingNumber))
            ) &&
            (
                PostCode == input.PostCode ||
                (PostCode != null &&
                 PostCode.Equals(input.PostCode))
            ) &&
            (
                TownName == input.TownName ||
                (TownName != null &&
                 TownName.Equals(input.TownName))
            ) &&
            (
                CountrySubDivision == input.CountrySubDivision ||
                (CountrySubDivision != null &&
                 CountrySubDivision.Equals(input.CountrySubDivision))
            ) &&
            (
                Country == input.Country ||
                (Country != null &&
                 Country.Equals(input.Country))
            ) &&
            (
                AddressLine == input.AddressLine ||
                (AddressLine != null &&
                 input.AddressLine != null &&
                 AddressLine.SequenceEqual(input.AddressLine))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // Department (string) maxLength
        if (Department != null && Department.Length > 70) yield return new ValidationResult("Invalid value for Department, length must be less than 70.", new[] { "Department" });

        // SubDepartment (string) maxLength
        if (SubDepartment != null && SubDepartment.Length > 70)
            yield return new ValidationResult("Invalid value for SubDepartment, length must be less than 70.", new[] { "SubDepartment" });

        // StreetName (string) maxLength
        if (StreetName != null && StreetName.Length > 70) yield return new ValidationResult("Invalid value for StreetName, length must be less than 70.", new[] { "StreetName" });

        // BuildingNumber (string) maxLength
        if (BuildingNumber != null && BuildingNumber.Length > 16)
            yield return new ValidationResult("Invalid value for BuildingNumber, length must be less than 16.", new[] { "BuildingNumber" });

        // PostCode (string) maxLength
        if (PostCode != null && PostCode.Length > 16) yield return new ValidationResult("Invalid value for PostCode, length must be less than 16.", new[] { "PostCode" });

        // TownName (string) maxLength
        if (TownName != null && TownName.Length > 35) yield return new ValidationResult("Invalid value for TownName, length must be less than 35.", new[] { "TownName" });

        // CountrySubDivision (string) maxLength
        if (CountrySubDivision != null && CountrySubDivision.Length > 35)
            yield return new ValidationResult("Invalid value for CountrySubDivision, length must be less than 35.", new[] { "CountrySubDivision" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PostalAddressComplexType {\n");
        sb.Append("  AddressType: ").Append(AddressType).Append("\n");
        sb.Append("  Department: ").Append(Department).Append("\n");
        sb.Append("  SubDepartment: ").Append(SubDepartment).Append("\n");
        sb.Append("  StreetName: ").Append(StreetName).Append("\n");
        sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
        sb.Append("  PostCode: ").Append(PostCode).Append("\n");
        sb.Append("  TownName: ").Append(TownName).Append("\n");
        sb.Append("  CountrySubDivision: ").Append(CountrySubDivision).Append("\n");
        sb.Append("  Country: ").Append(Country).Append("\n");
        sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
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
        return Equals(input as PostalAddressComplexType);
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
            hashCode = hashCode * 59 + AddressType.GetHashCode();
            if (Department != null) hashCode = hashCode * 59 + Department.GetHashCode();
            if (SubDepartment != null) hashCode = hashCode * 59 + SubDepartment.GetHashCode();
            if (StreetName != null) hashCode = hashCode * 59 + StreetName.GetHashCode();
            if (BuildingNumber != null) hashCode = hashCode * 59 + BuildingNumber.GetHashCode();
            if (PostCode != null) hashCode = hashCode * 59 + PostCode.GetHashCode();
            if (TownName != null) hashCode = hashCode * 59 + TownName.GetHashCode();
            if (CountrySubDivision != null) hashCode = hashCode * 59 + CountrySubDivision.GetHashCode();
            if (Country != null) hashCode = hashCode * 59 + Country.GetHashCode();
            if (AddressLine != null) hashCode = hashCode * 59 + AddressLine.GetHashCode();
            return hashCode;
        }
    }
}
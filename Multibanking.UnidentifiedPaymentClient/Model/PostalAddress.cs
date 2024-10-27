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
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Multibanking.UnidentifiedPaymentClient.Model;

/// <summary>
///     Информация, которая находит и идентифицирует определенный адрес, как определено почтовыми службами или в произвольном текстовом формате.
/// </summary>
[DataContract(Name = "PostalAddress")]
public class PostalAddress : IEquatable<PostalAddress>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="PostalAddress" /> class.
    /// </summary>
    /// <param name="addressLine">addressLine.</param>
    /// <param name="streetName">streetName.</param>
    /// <param name="buildingNumber">buildingNumber.</param>
    /// <param name="postCode">postCode.</param>
    /// <param name="townName">townName.</param>
    /// <param name="countrySubDivision">countrySubDivision.</param>
    /// <param name="country">country.</param>
    public PostalAddress(List<string> addressLine = default, string streetName = default, string buildingNumber = default, string postCode = default, string townName = default,
        List<string> countrySubDivision = default, string country = default)
    {
        AddressLine = addressLine;
        StreetName = streetName;
        BuildingNumber = buildingNumber;
        PostCode = postCode;
        TownName = townName;
        CountrySubDivision = countrySubDivision;
        Country = country;
    }

    /// <summary>
    ///     Gets or Sets AddressLine
    /// </summary>
    [DataMember(Name = "addressLine", EmitDefaultValue = false)]
    public List<string> AddressLine { get; set; }

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
    public List<string> CountrySubDivision { get; set; }

    /// <summary>
    ///     Gets or Sets Country
    /// </summary>
    [DataMember(Name = "country", EmitDefaultValue = false)]
    public string Country { get; set; }

    /// <summary>
    ///     Returns true if PostalAddress instances are equal
    /// </summary>
    /// <param name="input">Instance of PostalAddress to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(PostalAddress input)
    {
        if (input == null) return false;
        return
            (
                AddressLine == input.AddressLine ||
                (AddressLine != null &&
                 input.AddressLine != null &&
                 AddressLine.SequenceEqual(input.AddressLine))
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
                 input.CountrySubDivision != null &&
                 CountrySubDivision.SequenceEqual(input.CountrySubDivision))
            ) &&
            (
                Country == input.Country ||
                (Country != null &&
                 Country.Equals(input.Country))
            );
    }

    /// <summary>
    ///     To validate all properties of the instance
    /// </summary>
    /// <param name="validationContext">Validation context</param>
    /// <returns>Validation Result</returns>
    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        // StreetName (string) maxLength
        if (StreetName != null && StreetName.Length > 70) yield return new ValidationResult("Invalid value for StreetName, length must be less than 70.", new[] { "StreetName" });

        // BuildingNumber (string) maxLength
        if (BuildingNumber != null && BuildingNumber.Length > 16)
            yield return new ValidationResult("Invalid value for BuildingNumber, length must be less than 16.", new[] { "BuildingNumber" });

        // PostCode (string) maxLength
        if (PostCode != null && PostCode.Length > 16) yield return new ValidationResult("Invalid value for PostCode, length must be less than 16.", new[] { "PostCode" });

        // TownName (string) maxLength
        if (TownName != null && TownName.Length > 35) yield return new ValidationResult("Invalid value for TownName, length must be less than 35.", new[] { "TownName" });

        // Country (string) maxLength
        if (Country != null && Country.Length > 2) yield return new ValidationResult("Invalid value for Country, length must be less than 2.", new[] { "Country" });

        // Country (string) pattern
        var regexCountry = new Regex(@"^[A-Z]{2}$", RegexOptions.CultureInvariant);
        if (false == regexCountry.Match(Country).Success)
            yield return new ValidationResult("Invalid value for Country, must match a pattern of " + regexCountry, new[] { "Country" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class PostalAddress {\n");
        sb.Append("  AddressLine: ").Append(AddressLine).Append("\n");
        sb.Append("  StreetName: ").Append(StreetName).Append("\n");
        sb.Append("  BuildingNumber: ").Append(BuildingNumber).Append("\n");
        sb.Append("  PostCode: ").Append(PostCode).Append("\n");
        sb.Append("  TownName: ").Append(TownName).Append("\n");
        sb.Append("  CountrySubDivision: ").Append(CountrySubDivision).Append("\n");
        sb.Append("  Country: ").Append(Country).Append("\n");
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
        return Equals(input as PostalAddress);
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
            if (AddressLine != null) hashCode = hashCode * 59 + AddressLine.GetHashCode();
            if (StreetName != null) hashCode = hashCode * 59 + StreetName.GetHashCode();
            if (BuildingNumber != null) hashCode = hashCode * 59 + BuildingNumber.GetHashCode();
            if (PostCode != null) hashCode = hashCode * 59 + PostCode.GetHashCode();
            if (TownName != null) hashCode = hashCode * 59 + TownName.GetHashCode();
            if (CountrySubDivision != null) hashCode = hashCode * 59 + CountrySubDivision.GetHashCode();
            if (Country != null) hashCode = hashCode * 59 + Country.GetHashCode();
            return hashCode;
        }
    }
}
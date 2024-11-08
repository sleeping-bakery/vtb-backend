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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using Newtonsoft.Json;

namespace Multibanking.PeriodPaymentClient.Model;

/// <summary>
///     Сторона, которой причитается сумма средств
/// </summary>
[DataContract(Name = "VRPInstruction_Creditor")]
public class VRPInstructionCreditor : IEquatable<VRPInstructionCreditor>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPInstructionCreditor" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected VRPInstructionCreditor()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="VRPInstructionCreditor" /> class.
    /// </summary>
    /// <param name="name">Наименование организации или имя физического лица (required).</param>
    /// <param name="mobileNumber">Номер мобильного телефона.</param>
    /// <param name="countryOfResidence">Страна проживания.</param>
    /// <param name="countryOfBirth">Место рождения (страна).</param>
    /// <param name="provinceOfBirth">Место рождения (область)..</param>
    /// <param name="cityOfBirth">Место рождения (город)..</param>
    /// <param name="birthDate">Дата рождения..</param>
    /// <param name="identification">Идентификация юридического или физического лица. (required).</param>
    /// <param name="postalAddress">postalAddress.</param>
    public VRPInstructionCreditor(string name = default, string mobileNumber = default, string countryOfResidence = default, string countryOfBirth = default,
        string provinceOfBirth = default, string cityOfBirth = default, DateTime birthDate = default, List<PartyIdentificationIdentificationInner> identification = default,
        PartyIdentificationPostalAddress postalAddress = default)
    {
        // to ensure "name" is required (not null)
        if (name == null) throw new ArgumentNullException("name is a required property for VRPInstructionCreditor and cannot be null");
        Name = name;
        // to ensure "identification" is required (not null)
        if (identification == null) throw new ArgumentNullException("identification is a required property for VRPInstructionCreditor and cannot be null");
        Identification = identification;
        MobileNumber = mobileNumber;
        CountryOfResidence = countryOfResidence;
        CountryOfBirth = countryOfBirth;
        ProvinceOfBirth = provinceOfBirth;
        CityOfBirth = cityOfBirth;
        BirthDate = birthDate;
        PostalAddress = postalAddress;
    }

    /// <summary>
    ///     Наименование организации или имя физического лица
    /// </summary>
    /// <value>Наименование организации или имя физического лица</value>
    [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
    public string Name { get; set; }

    /// <summary>
    ///     Номер мобильного телефона
    /// </summary>
    /// <value>Номер мобильного телефона</value>
    [DataMember(Name = "mobileNumber", EmitDefaultValue = false)]
    public string MobileNumber { get; set; }

    /// <summary>
    ///     Страна проживания
    /// </summary>
    /// <value>Страна проживания</value>
    [DataMember(Name = "countryOfResidence", EmitDefaultValue = false)]
    public string CountryOfResidence { get; set; }

    /// <summary>
    ///     Место рождения (страна)
    /// </summary>
    /// <value>Место рождения (страна)</value>
    [DataMember(Name = "countryOfBirth", EmitDefaultValue = false)]
    public string CountryOfBirth { get; set; }

    /// <summary>
    ///     Место рождения (область).
    /// </summary>
    /// <value>Место рождения (область).</value>
    [DataMember(Name = "provinceOfBirth", EmitDefaultValue = false)]
    public string ProvinceOfBirth { get; set; }

    /// <summary>
    ///     Место рождения (город).
    /// </summary>
    /// <value>Место рождения (город).</value>
    [DataMember(Name = "cityOfBirth", EmitDefaultValue = false)]
    public string CityOfBirth { get; set; }

    /// <summary>
    ///     Дата рождения.
    /// </summary>
    /// <value>Дата рождения.</value>
    [DataMember(Name = "birthDate", EmitDefaultValue = false)]
    public DateTime BirthDate { get; set; }

    /// <summary>
    ///     Идентификация юридического или физического лица.
    /// </summary>
    /// <value>Идентификация юридического или физического лица.</value>
    [DataMember(Name = "Identification", IsRequired = true, EmitDefaultValue = true)]
    public List<PartyIdentificationIdentificationInner> Identification { get; set; }

    /// <summary>
    ///     Gets or Sets PostalAddress
    /// </summary>
    [DataMember(Name = "PostalAddress", EmitDefaultValue = false)]
    public PartyIdentificationPostalAddress PostalAddress { get; set; }

    /// <summary>
    ///     Returns true if VRPInstructionCreditor instances are equal
    /// </summary>
    /// <param name="input">Instance of VRPInstructionCreditor to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(VRPInstructionCreditor input)
    {
        if (input == null) return false;
        return
            (
                Name == input.Name ||
                (Name != null &&
                 Name.Equals(input.Name))
            ) &&
            (
                MobileNumber == input.MobileNumber ||
                (MobileNumber != null &&
                 MobileNumber.Equals(input.MobileNumber))
            ) &&
            (
                CountryOfResidence == input.CountryOfResidence ||
                (CountryOfResidence != null &&
                 CountryOfResidence.Equals(input.CountryOfResidence))
            ) &&
            (
                CountryOfBirth == input.CountryOfBirth ||
                (CountryOfBirth != null &&
                 CountryOfBirth.Equals(input.CountryOfBirth))
            ) &&
            (
                ProvinceOfBirth == input.ProvinceOfBirth ||
                (ProvinceOfBirth != null &&
                 ProvinceOfBirth.Equals(input.ProvinceOfBirth))
            ) &&
            (
                CityOfBirth == input.CityOfBirth ||
                (CityOfBirth != null &&
                 CityOfBirth.Equals(input.CityOfBirth))
            ) &&
            (
                BirthDate == input.BirthDate ||
                (BirthDate != null &&
                 BirthDate.Equals(input.BirthDate))
            ) &&
            (
                Identification == input.Identification ||
                (Identification != null &&
                 input.Identification != null &&
                 Identification.SequenceEqual(input.Identification))
            ) &&
            (
                PostalAddress == input.PostalAddress ||
                (PostalAddress != null &&
                 PostalAddress.Equals(input.PostalAddress))
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
        if (Name != null && Name.Length > 160) yield return new ValidationResult("Invalid value for Name, length must be less than 160.", new[] { "Name" });

        // MobileNumber (string) maxLength
        if (MobileNumber != null && MobileNumber.Length > 15)
            yield return new ValidationResult("Invalid value for MobileNumber, length must be less than 15.", new[] { "MobileNumber" });

        // ProvinceOfBirth (string) maxLength
        if (ProvinceOfBirth != null && ProvinceOfBirth.Length > 35)
            yield return new ValidationResult("Invalid value for ProvinceOfBirth, length must be less than 35.", new[] { "ProvinceOfBirth" });

        // CityOfBirth (string) maxLength
        if (CityOfBirth != null && CityOfBirth.Length > 35)
            yield return new ValidationResult("Invalid value for CityOfBirth, length must be less than 35.", new[] { "CityOfBirth" });
    }

    /// <summary>
    ///     Returns the string presentation of the object
    /// </summary>
    /// <returns>String presentation of the object</returns>
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("class VRPInstructionCreditor {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
        sb.Append("  CountryOfResidence: ").Append(CountryOfResidence).Append("\n");
        sb.Append("  CountryOfBirth: ").Append(CountryOfBirth).Append("\n");
        sb.Append("  ProvinceOfBirth: ").Append(ProvinceOfBirth).Append("\n");
        sb.Append("  CityOfBirth: ").Append(CityOfBirth).Append("\n");
        sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
        sb.Append("  Identification: ").Append(Identification).Append("\n");
        sb.Append("  PostalAddress: ").Append(PostalAddress).Append("\n");
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
        return Equals(input as VRPInstructionCreditor);
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
            if (MobileNumber != null) hashCode = hashCode * 59 + MobileNumber.GetHashCode();
            if (CountryOfResidence != null) hashCode = hashCode * 59 + CountryOfResidence.GetHashCode();
            if (CountryOfBirth != null) hashCode = hashCode * 59 + CountryOfBirth.GetHashCode();
            if (ProvinceOfBirth != null) hashCode = hashCode * 59 + ProvinceOfBirth.GetHashCode();
            if (CityOfBirth != null) hashCode = hashCode * 59 + CityOfBirth.GetHashCode();
            if (BirthDate != null) hashCode = hashCode * 59 + BirthDate.GetHashCode();
            if (Identification != null) hashCode = hashCode * 59 + Identification.GetHashCode();
            if (PostalAddress != null) hashCode = hashCode * 59 + PostalAddress.GetHashCode();
            return hashCode;
        }
    }
}
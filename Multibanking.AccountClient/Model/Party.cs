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
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;

namespace Multibanking.AccountClient.Model;

/// <summary>
///     Информация об участнике, используемая для идентификации юридического или физического лица
/// </summary>
[DataContract(Name = "Party")]
public class Party : IEquatable<Party>, IValidatableObject
{
    /// <summary>
    ///     Initializes a new instance of the <see cref="Party" /> class.
    /// </summary>
    [JsonConstructorAttribute]
    protected Party()
    {
    }

    /// <summary>
    ///     Initializes a new instance of the <see cref="Party" /> class.
    /// </summary>
    /// <param name="name">Наименование организации или имя физического лица (required).</param>
    /// <param name="mobileNumber">Набор данных, который определяет номер мобильного телефона в формате,  назначаемом оператором связи. Начинается с «+7-».</param>
    /// <param name="countryOfResidence">Код страны.</param>
    /// <param name="countryOfBirth">Код страны.</param>
    /// <param name="provinceOfBirth">Место рождения (область)..</param>
    /// <param name="cityOfBirth">Место рождения (город)..</param>
    /// <param name="birthDate">Формат даты и времени.</param>
    /// <param name="partyIdentification">Идентификация юридического или физического лица. (required).</param>
    /// <param name="postalAddress">
    ///     Указывается адрес места нахождения юридического лица, места жительства (регистрации)  или места пребывания физического лица, индивидуального
    ///     предпринимателя, физического  лица, занимающегося в установленном порядке частной практикой, в случаях, установленных  законодательством или договором. При указании адреса
    ///     допускается использовать сокращения,  позволяющие определенно установить данную информацию .
    /// </param>
    public Party(string name = default, string mobileNumber = default, string countryOfResidence = default, string countryOfBirth = default, string provinceOfBirth = default,
        string cityOfBirth = default, DateTime birthDate = default, List<PeriodPaymentPartyIdentification> partyIdentification = default,
        List<PostalAddressComplexType> postalAddress = default)
    {
        // to ensure "name" is required (not null)
        if (name == null) throw new ArgumentNullException("name is a required property for Party and cannot be null");
        Name = name;
        // to ensure "partyIdentification" is required (not null)
        if (partyIdentification == null) throw new ArgumentNullException("partyIdentification is a required property for Party and cannot be null");
        PartyIdentification = partyIdentification;
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
    ///     Набор данных, который определяет номер мобильного телефона в формате,  назначаемом оператором связи. Начинается с «+7-»
    /// </summary>
    /// <value>Набор данных, который определяет номер мобильного телефона в формате,  назначаемом оператором связи. Начинается с «+7-»</value>
    [DataMember(Name = "mobileNumber", EmitDefaultValue = false)]
    public string MobileNumber { get; set; }

    /// <summary>
    ///     Код страны
    /// </summary>
    /// <value>Код страны</value>
    [DataMember(Name = "countryOfResidence", EmitDefaultValue = false)]
    public string CountryOfResidence { get; set; }

    /// <summary>
    ///     Код страны
    /// </summary>
    /// <value>Код страны</value>
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
    ///     Формат даты и времени
    /// </summary>
    /// <value>Формат даты и времени</value>
    [DataMember(Name = "birthDate", EmitDefaultValue = false)]
    public DateTime BirthDate { get; set; }

    /// <summary>
    ///     Идентификация юридического или физического лица.
    /// </summary>
    /// <value>Идентификация юридического или физического лица.</value>
    [DataMember(Name = "PeriodPaymentPartyIdentification", IsRequired = true, EmitDefaultValue = true)]
    public List<PeriodPaymentPartyIdentification> PartyIdentification { get; set; }

    /// <summary>
    ///     Указывается адрес места нахождения юридического лица, места жительства (регистрации)  или места пребывания физического лица, индивидуального предпринимателя, физического
    ///     лица, занимающегося в установленном порядке частной практикой, в случаях, установленных  законодательством или договором. При указании адреса допускается использовать
    ///     сокращения,  позволяющие определенно установить данную информацию
    /// </summary>
    /// <value>
    ///     Указывается адрес места нахождения юридического лица, места жительства (регистрации)  или места пребывания физического лица, индивидуального предпринимателя, физического
    ///     лица, занимающегося в установленном порядке частной практикой, в случаях, установленных  законодательством или договором. При указании адреса допускается использовать
    ///     сокращения,  позволяющие определенно установить данную информацию
    /// </value>
    [DataMember(Name = "PostalAddress", EmitDefaultValue = false)]
    public List<PostalAddressComplexType> PostalAddress { get; set; }

    /// <summary>
    ///     Returns true if Party instances are equal
    /// </summary>
    /// <param name="input">Instance of Party to be compared</param>
    /// <returns>Boolean</returns>
    public bool Equals(Party input)
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
                PartyIdentification == input.PartyIdentification ||
                (PartyIdentification != null &&
                 input.PartyIdentification != null &&
                 PartyIdentification.SequenceEqual(input.PartyIdentification))
            ) &&
            (
                PostalAddress == input.PostalAddress ||
                (PostalAddress != null &&
                 input.PostalAddress != null &&
                 PostalAddress.SequenceEqual(input.PostalAddress))
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

        // CountryOfResidence (string) pattern
        var regexCountryOfResidence = new Regex(@"^[A-Z]{2,2}$", RegexOptions.CultureInvariant);
        if (false == regexCountryOfResidence.Match(CountryOfResidence).Success)
            yield return new ValidationResult("Invalid value for CountryOfResidence, must match a pattern of " + regexCountryOfResidence, new[] { "CountryOfResidence" });

        // CountryOfBirth (string) pattern
        var regexCountryOfBirth = new Regex(@"^[A-Z]{2,2}$", RegexOptions.CultureInvariant);
        if (false == regexCountryOfBirth.Match(CountryOfBirth).Success)
            yield return new ValidationResult("Invalid value for CountryOfBirth, must match a pattern of " + regexCountryOfBirth, new[] { "CountryOfBirth" });

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
        sb.Append("class Party {\n");
        sb.Append("  Name: ").Append(Name).Append("\n");
        sb.Append("  MobileNumber: ").Append(MobileNumber).Append("\n");
        sb.Append("  CountryOfResidence: ").Append(CountryOfResidence).Append("\n");
        sb.Append("  CountryOfBirth: ").Append(CountryOfBirth).Append("\n");
        sb.Append("  ProvinceOfBirth: ").Append(ProvinceOfBirth).Append("\n");
        sb.Append("  CityOfBirth: ").Append(CityOfBirth).Append("\n");
        sb.Append("  BirthDate: ").Append(BirthDate).Append("\n");
        sb.Append("  PeriodPaymentPartyIdentification: ").Append(PartyIdentification).Append("\n");
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
        return Equals(input as Party);
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
            if (PartyIdentification != null) hashCode = hashCode * 59 + PartyIdentification.GetHashCode();
            if (PostalAddress != null) hashCode = hashCode * 59 + PostalAddress.GetHashCode();
            return hashCode;
        }
    }
}
/*
 * Система рассмотрения заявок на экспресс-гарантии, полученных от партнеров банка
 *
 * Функционал выдачи экспресс гарантий позволяет реализовать след. сервисы:  - Создание клиентом заявки в личном кабинете на выдачу экспресс-гарантии - Отображение информации о закупке по минимальному набору введенных атрибутов - Загрузка и прикрепление документов к заявке - Формирование заявления на выдачу экспресс-гарантии для подписания клиентом - Подписание клиентом заявления с использованием УНЭП - Отображение в Интернет банке статусов заявки - Получение и передача заявок от партнеров - Создание сотрудником банка заявки на гарантию - Формирование проекта решения по заявке на гарантию
 *
 * The version of the OpenAPI document: 1.4.1
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
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = Multibanking.GuaranteeClient.Client.OpenAPIDateConverter;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    ///     Информация по закупке
    /// </summary>
    [DataContract(Name = "Procurement")]
    public class Procurement : IEquatable<Procurement>, IValidatableObject
    {
        /// <summary>
        ///     GOODS_SUPPLY - Поставка товаров, WORK_EXECUTION - Выполнение работ, SERVICE_PROVISION - Оказание услуг. Использовать только для коммерческих гарантий
        /// </summary>
        /// <value>GOODS_SUPPLY - Поставка товаров, WORK_EXECUTION - Выполнение работ, SERVICE_PROVISION - Оказание услуг. Использовать только для коммерческих гарантий</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ContractCommercialObjectTypeEnum
        {
            /// <summary>
            ///     Enum GOODSSUPPLY for value: GOODS_SUPPLY
            /// </summary>
            [EnumMember(Value = "GOODS_SUPPLY")] GOODSSUPPLY = 1,

            /// <summary>
            ///     Enum WORKEXECUTION for value: WORK_EXECUTION
            /// </summary>
            [EnumMember(Value = "WORK_EXECUTION")] WORKEXECUTION = 2,

            /// <summary>
            ///     Enum SERVICEPROVISION for value: SERVICE_PROVISION
            /// </summary>
            [EnumMember(Value = "SERVICE_PROVISION")]
            SERVICEPROVISION = 3
        }

        /// <summary>
        ///     Тип закупки
        /// </summary>
        /// <value>Тип закупки</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProcurementTypeEnum
        {
            /// <summary>
            ///     Enum FZ44 for value: FZ_44
            /// </summary>
            [EnumMember(Value = "FZ_44")] FZ44 = 1,

            /// <summary>
            ///     Enum FZ223 for value: FZ_223
            /// </summary>
            [EnumMember(Value = "FZ_223")] FZ223 = 2,

            /// <summary>
            ///     Enum COMMERCIAL for value: COMMERCIAL
            /// </summary>
            [EnumMember(Value = "COMMERCIAL")] COMMERCIAL = 3,

            /// <summary>
            ///     Enum PP615 for value: PP_615
            /// </summary>
            [EnumMember(Value = "PP_615")] PP615 = 4
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Procurement" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Procurement()
        {
        }

        /// <summary>
        ///     Initializes a new instance of the <see cref="Procurement" /> class.
        /// </summary>
        /// <param name="procurementType">Тип закупки (required).</param>
        /// <param name="tenderType">Способ размещения.</param>
        /// <param name="tenderDate">Дата тендера (аукциона).</param>
        /// <param name="purchaseNumber">Реестровый номер торгов.</param>
        /// <param name="ikz">Идентификационный код закупки.</param>
        /// <param name="purchasePublishedDate">Дата размещения.</param>
        /// <param name="subject">Объект закупки.</param>
        /// <param name="contractMaxPrice">НМЦК (Начальная максимальная цена контракта).</param>
        /// <param name="lotNumber">Номер лота.</param>
        /// <param name="lotName">Объект закупки лота.</param>
        /// <param name="okpd">okpd.</param>
        /// <param name="tenderContractNumber">№ контракта.</param>
        /// <param name="tenderContractRegNumber">Реестровый № контракта.</param>
        /// <param name="tenderContractSignedDate">Дата контракта.</param>
        /// <param name="tenderContractSubject">Предмет контракта.</param>
        /// <param name="contractCommercialObjectType">
        ///     GOODS_SUPPLY - Поставка товаров, WORK_EXECUTION - Выполнение работ, SERVICE_PROVISION - Оказание услуг. Использовать только для
        ///     коммерческих гарантий.
        /// </param>
        /// <param name="contractCommercialObjectDescription">Описание предмета. Использовать только для коммерческих гарантий.</param>
        /// <param name="contractCommercialNumber">Номер договора. Использовать только для коммерческих гарантий.</param>
        /// <param name="contractCommercialDate">Дата договора. Использовать только для коммерческих гарантий.</param>
        /// <param name="withoutNumber">Признак отсутствия номера.</param>
        public Procurement(ProcurementTypeEnum procurementType = default, string tenderType = default, DateTime tenderDate = default, string purchaseNumber = default,
            string ikz = default, DateTime purchasePublishedDate = default, string subject = default, decimal contractMaxPrice = default, string lotNumber = default,
            string lotName = default, List<Okpd> okpd = default, string tenderContractNumber = default, string tenderContractRegNumber = default,
            DateTime tenderContractSignedDate = default, string tenderContractSubject = default, ContractCommercialObjectTypeEnum? contractCommercialObjectType = default,
            string contractCommercialObjectDescription = default, string contractCommercialNumber = default, DateTime contractCommercialDate = default,
            bool withoutNumber = default)
        {
            ProcurementType = procurementType;
            TenderType = tenderType;
            TenderDate = tenderDate;
            PurchaseNumber = purchaseNumber;
            Ikz = ikz;
            PurchasePublishedDate = purchasePublishedDate;
            Subject = subject;
            ContractMaxPrice = contractMaxPrice;
            LotNumber = lotNumber;
            LotName = lotName;
            Okpd = okpd;
            TenderContractNumber = tenderContractNumber;
            TenderContractRegNumber = tenderContractRegNumber;
            TenderContractSignedDate = tenderContractSignedDate;
            TenderContractSubject = tenderContractSubject;
            ContractCommercialObjectType = contractCommercialObjectType;
            ContractCommercialObjectDescription = contractCommercialObjectDescription;
            ContractCommercialNumber = contractCommercialNumber;
            ContractCommercialDate = contractCommercialDate;
            WithoutNumber = withoutNumber;
        }


        /// <summary>
        ///     Тип закупки
        /// </summary>
        /// <value>Тип закупки</value>
        [DataMember(Name = "procurementGuaranteeType", IsRequired = true, EmitDefaultValue = true)]
        public ProcurementTypeEnum ProcurementType { get; set; }


        /// <summary>
        ///     GOODS_SUPPLY - Поставка товаров, WORK_EXECUTION - Выполнение работ, SERVICE_PROVISION - Оказание услуг. Использовать только для коммерческих гарантий
        /// </summary>
        /// <value>GOODS_SUPPLY - Поставка товаров, WORK_EXECUTION - Выполнение работ, SERVICE_PROVISION - Оказание услуг. Использовать только для коммерческих гарантий</value>
        [DataMember(Name = "contractCommercialObjectType", EmitDefaultValue = false)]
        public ContractCommercialObjectTypeEnum? ContractCommercialObjectType { get; set; }

        /// <summary>
        ///     Способ размещения
        /// </summary>
        /// <value>Способ размещения</value>
        [DataMember(Name = "tenderType", EmitDefaultValue = false)]
        public string TenderType { get; set; }

        /// <summary>
        ///     Дата тендера (аукциона)
        /// </summary>
        /// <value>Дата тендера (аукциона)</value>
        [DataMember(Name = "tenderDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime TenderDate { get; set; }

        /// <summary>
        ///     Реестровый номер торгов
        /// </summary>
        /// <value>Реестровый номер торгов</value>
        [DataMember(Name = "purchaseNumber", EmitDefaultValue = false)]
        public string PurchaseNumber { get; set; }

        /// <summary>
        ///     Идентификационный код закупки
        /// </summary>
        /// <value>Идентификационный код закупки</value>
        [DataMember(Name = "ikz", EmitDefaultValue = false)]
        public string Ikz { get; set; }

        /// <summary>
        ///     Дата размещения
        /// </summary>
        /// <value>Дата размещения</value>
        [DataMember(Name = "purchasePublishedDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime PurchasePublishedDate { get; set; }

        /// <summary>
        ///     Объект закупки
        /// </summary>
        /// <value>Объект закупки</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        ///     НМЦК (Начальная максимальная цена контракта)
        /// </summary>
        /// <value>НМЦК (Начальная максимальная цена контракта)</value>
        [DataMember(Name = "contractMaxPrice", EmitDefaultValue = false)]
        public decimal ContractMaxPrice { get; set; }

        /// <summary>
        ///     Номер лота
        /// </summary>
        /// <value>Номер лота</value>
        [DataMember(Name = "lotNumber", EmitDefaultValue = false)]
        public string LotNumber { get; set; }

        /// <summary>
        ///     Объект закупки лота
        /// </summary>
        /// <value>Объект закупки лота</value>
        [DataMember(Name = "lotName", EmitDefaultValue = false)]
        public string LotName { get; set; }

        /// <summary>
        ///     Gets or Sets Okpd
        /// </summary>
        [DataMember(Name = "okpd", EmitDefaultValue = false)]
        public List<Okpd> Okpd { get; set; }

        /// <summary>
        ///     № контракта
        /// </summary>
        /// <value>№ контракта</value>
        [DataMember(Name = "tenderContractNumber", EmitDefaultValue = false)]
        public string TenderContractNumber { get; set; }

        /// <summary>
        ///     Реестровый № контракта
        /// </summary>
        /// <value>Реестровый № контракта</value>
        [DataMember(Name = "tenderContractRegNumber", EmitDefaultValue = false)]
        public string TenderContractRegNumber { get; set; }

        /// <summary>
        ///     Дата контракта
        /// </summary>
        /// <value>Дата контракта</value>
        [DataMember(Name = "tenderContractSignedDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime TenderContractSignedDate { get; set; }

        /// <summary>
        ///     Предмет контракта
        /// </summary>
        /// <value>Предмет контракта</value>
        [DataMember(Name = "tenderContractSubject", EmitDefaultValue = false)]
        public string TenderContractSubject { get; set; }

        /// <summary>
        ///     Описание предмета. Использовать только для коммерческих гарантий
        /// </summary>
        /// <value>Описание предмета. Использовать только для коммерческих гарантий</value>
        [DataMember(Name = "contractCommercialObjectDescription", EmitDefaultValue = false)]
        public string ContractCommercialObjectDescription { get; set; }

        /// <summary>
        ///     Номер договора. Использовать только для коммерческих гарантий
        /// </summary>
        /// <value>Номер договора. Использовать только для коммерческих гарантий</value>
        [DataMember(Name = "contractCommercialNumber", EmitDefaultValue = false)]
        public string ContractCommercialNumber { get; set; }

        /// <summary>
        ///     Дата договора. Использовать только для коммерческих гарантий
        /// </summary>
        /// <value>Дата договора. Использовать только для коммерческих гарантий</value>
        [DataMember(Name = "contractCommercialDate", EmitDefaultValue = false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime ContractCommercialDate { get; set; }

        /// <summary>
        ///     Признак отсутствия номера
        /// </summary>
        /// <value>Признак отсутствия номера</value>
        [DataMember(Name = "withoutNumber", EmitDefaultValue = true)]
        public bool WithoutNumber { get; set; }

        /// <summary>
        ///     Returns true if Procurement instances are equal
        /// </summary>
        /// <param name="input">Instance of Procurement to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Procurement input)
        {
            if (input == null) return false;
            return
                (
                    ProcurementType == input.ProcurementType ||
                    ProcurementType.Equals(input.ProcurementType)
                ) &&
                (
                    TenderType == input.TenderType ||
                    (TenderType != null &&
                     TenderType.Equals(input.TenderType))
                ) &&
                (
                    TenderDate == input.TenderDate ||
                    (TenderDate != null &&
                     TenderDate.Equals(input.TenderDate))
                ) &&
                (
                    PurchaseNumber == input.PurchaseNumber ||
                    (PurchaseNumber != null &&
                     PurchaseNumber.Equals(input.PurchaseNumber))
                ) &&
                (
                    Ikz == input.Ikz ||
                    (Ikz != null &&
                     Ikz.Equals(input.Ikz))
                ) &&
                (
                    PurchasePublishedDate == input.PurchasePublishedDate ||
                    (PurchasePublishedDate != null &&
                     PurchasePublishedDate.Equals(input.PurchasePublishedDate))
                ) &&
                (
                    Subject == input.Subject ||
                    (Subject != null &&
                     Subject.Equals(input.Subject))
                ) &&
                (
                    ContractMaxPrice == input.ContractMaxPrice ||
                    ContractMaxPrice.Equals(input.ContractMaxPrice)
                ) &&
                (
                    LotNumber == input.LotNumber ||
                    (LotNumber != null &&
                     LotNumber.Equals(input.LotNumber))
                ) &&
                (
                    LotName == input.LotName ||
                    (LotName != null &&
                     LotName.Equals(input.LotName))
                ) &&
                (
                    Okpd == input.Okpd ||
                    (Okpd != null &&
                     input.Okpd != null &&
                     Okpd.SequenceEqual(input.Okpd))
                ) &&
                (
                    TenderContractNumber == input.TenderContractNumber ||
                    (TenderContractNumber != null &&
                     TenderContractNumber.Equals(input.TenderContractNumber))
                ) &&
                (
                    TenderContractRegNumber == input.TenderContractRegNumber ||
                    (TenderContractRegNumber != null &&
                     TenderContractRegNumber.Equals(input.TenderContractRegNumber))
                ) &&
                (
                    TenderContractSignedDate == input.TenderContractSignedDate ||
                    (TenderContractSignedDate != null &&
                     TenderContractSignedDate.Equals(input.TenderContractSignedDate))
                ) &&
                (
                    TenderContractSubject == input.TenderContractSubject ||
                    (TenderContractSubject != null &&
                     TenderContractSubject.Equals(input.TenderContractSubject))
                ) &&
                (
                    ContractCommercialObjectType == input.ContractCommercialObjectType ||
                    ContractCommercialObjectType.Equals(input.ContractCommercialObjectType)
                ) &&
                (
                    ContractCommercialObjectDescription == input.ContractCommercialObjectDescription ||
                    (ContractCommercialObjectDescription != null &&
                     ContractCommercialObjectDescription.Equals(input.ContractCommercialObjectDescription))
                ) &&
                (
                    ContractCommercialNumber == input.ContractCommercialNumber ||
                    (ContractCommercialNumber != null &&
                     ContractCommercialNumber.Equals(input.ContractCommercialNumber))
                ) &&
                (
                    ContractCommercialDate == input.ContractCommercialDate ||
                    (ContractCommercialDate != null &&
                     ContractCommercialDate.Equals(input.ContractCommercialDate))
                ) &&
                (
                    WithoutNumber == input.WithoutNumber ||
                    WithoutNumber.Equals(input.WithoutNumber)
                );
        }

        /// <summary>
        ///     To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            // TenderType (string) maxLength
            if (TenderType != null && TenderType.Length > 700)
                yield return new ValidationResult("Invalid value for TenderType, length must be less than 700.", new[] { "TenderType" });

            // TenderType (string) minLength
            if (TenderType != null && TenderType.Length < 1)
                yield return new ValidationResult("Invalid value for TenderType, length must be greater than 1.", new[] { "TenderType" });

            // TenderDate (DateTime) maxLength
            if (TenderDate != null && TenderDate.ToString().Length > 10)
                yield return new ValidationResult("Invalid value for TenderDate, length must be less than 10.", new[] { "TenderDate" });

            // TenderDate (DateTime) minLength
            if (TenderDate != null && TenderDate.ToString().Length < 10)
                yield return new ValidationResult("Invalid value for TenderDate, length must be greater than 10.", new[] { "TenderDate" });

            // TenderDate (DateTime) pattern
            var regexTenderDate = new Regex(@"^[0-9]{4}-[0-9]{2}-[0-9]{2}$", RegexOptions.CultureInvariant);
            if (false == regexTenderDate.Match(TenderDate.ToString()).Success)
                yield return new ValidationResult("Invalid value for TenderDate, must match a pattern of " + regexTenderDate, new[] { "TenderDate" });

            // PurchaseNumber (string) maxLength
            if (PurchaseNumber != null && PurchaseNumber.Length > 255)
                yield return new ValidationResult("Invalid value for PurchaseNumber, length must be less than 255.", new[] { "PurchaseNumber" });

            // PurchaseNumber (string) minLength
            if (PurchaseNumber != null && PurchaseNumber.Length < 1)
                yield return new ValidationResult("Invalid value for PurchaseNumber, length must be greater than 1.", new[] { "PurchaseNumber" });

            // Ikz (string) maxLength
            if (Ikz != null && Ikz.Length > 50) yield return new ValidationResult("Invalid value for Ikz, length must be less than 50.", new[] { "Ikz" });

            // Ikz (string) minLength
            if (Ikz != null && Ikz.Length < 1) yield return new ValidationResult("Invalid value for Ikz, length must be greater than 1.", new[] { "Ikz" });

            // PurchasePublishedDate (DateTime) maxLength
            if (PurchasePublishedDate != null && PurchasePublishedDate.ToString().Length > 10)
                yield return new ValidationResult("Invalid value for PurchasePublishedDate, length must be less than 10.", new[] { "PurchasePublishedDate" });

            // PurchasePublishedDate (DateTime) minLength
            if (PurchasePublishedDate != null && PurchasePublishedDate.ToString().Length < 10)
                yield return new ValidationResult("Invalid value for PurchasePublishedDate, length must be greater than 10.", new[] { "PurchasePublishedDate" });

            // PurchasePublishedDate (DateTime) pattern
            var regexPurchasePublishedDate = new Regex(@"^[0-9]{4}-[0-9]{2}-[0-9]{2}$", RegexOptions.CultureInvariant);
            if (false == regexPurchasePublishedDate.Match(PurchasePublishedDate.ToString()).Success)
                yield return new ValidationResult("Invalid value for PurchasePublishedDate, must match a pattern of " + regexPurchasePublishedDate,
                    new[] { "PurchasePublishedDate" });

            // Subject (string) maxLength
            if (Subject != null && Subject.Length > 4000) yield return new ValidationResult("Invalid value for Subject, length must be less than 4000.", new[] { "Subject" });

            // Subject (string) minLength
            if (Subject != null && Subject.Length < 1) yield return new ValidationResult("Invalid value for Subject, length must be greater than 1.", new[] { "Subject" });

            // ContractMaxPrice (decimal) maximum
            if (ContractMaxPrice > 9007199254740991)
                yield return new ValidationResult("Invalid value for ContractMaxPrice, must be a value less than or equal to 9007199254740991.", new[] { "ContractMaxPrice" });

            // ContractMaxPrice (decimal) minimum
            if (ContractMaxPrice < 0)
                yield return new ValidationResult("Invalid value for ContractMaxPrice, must be a value greater than or equal to 0.", new[] { "ContractMaxPrice" });

            // LotNumber (string) maxLength
            if (LotNumber != null && LotNumber.Length > 10) yield return new ValidationResult("Invalid value for LotNumber, length must be less than 10.", new[] { "LotNumber" });

            // LotNumber (string) minLength
            if (LotNumber != null && LotNumber.Length < 1) yield return new ValidationResult("Invalid value for LotNumber, length must be greater than 1.", new[] { "LotNumber" });

            // LotName (string) maxLength
            if (LotName != null && LotName.Length > 4000) yield return new ValidationResult("Invalid value for LotName, length must be less than 4000.", new[] { "LotName" });

            // LotName (string) minLength
            if (LotName != null && LotName.Length < 1) yield return new ValidationResult("Invalid value for LotName, length must be greater than 1.", new[] { "LotName" });

            // TenderContractNumber (string) maxLength
            if (TenderContractNumber != null && TenderContractNumber.Length > 255)
                yield return new ValidationResult("Invalid value for TenderContractNumber, length must be less than 255.", new[] { "TenderContractNumber" });

            // TenderContractNumber (string) minLength
            if (TenderContractNumber != null && TenderContractNumber.Length < 1)
                yield return new ValidationResult("Invalid value for TenderContractNumber, length must be greater than 1.", new[] { "TenderContractNumber" });

            // TenderContractRegNumber (string) maxLength
            if (TenderContractRegNumber != null && TenderContractRegNumber.Length > 255)
                yield return new ValidationResult("Invalid value for TenderContractRegNumber, length must be less than 255.", new[] { "TenderContractRegNumber" });

            // TenderContractRegNumber (string) minLength
            if (TenderContractRegNumber != null && TenderContractRegNumber.Length < 1)
                yield return new ValidationResult("Invalid value for TenderContractRegNumber, length must be greater than 1.", new[] { "TenderContractRegNumber" });

            // TenderContractSignedDate (DateTime) maxLength
            if (TenderContractSignedDate != null && TenderContractSignedDate.ToString().Length > 10)
                yield return new ValidationResult("Invalid value for TenderContractSignedDate, length must be less than 10.", new[] { "TenderContractSignedDate" });

            // TenderContractSignedDate (DateTime) minLength
            if (TenderContractSignedDate != null && TenderContractSignedDate.ToString().Length < 10)
                yield return new ValidationResult("Invalid value for TenderContractSignedDate, length must be greater than 10.", new[] { "TenderContractSignedDate" });

            // TenderContractSignedDate (DateTime) pattern
            var regexTenderContractSignedDate = new Regex(@"^[0-9]{4}-[0-9]{2}-[0-9]{2}$", RegexOptions.CultureInvariant);
            if (false == regexTenderContractSignedDate.Match(TenderContractSignedDate.ToString()).Success)
                yield return new ValidationResult("Invalid value for TenderContractSignedDate, must match a pattern of " + regexTenderContractSignedDate,
                    new[] { "TenderContractSignedDate" });

            // TenderContractSubject (string) maxLength
            if (TenderContractSubject != null && TenderContractSubject.Length > 4000)
                yield return new ValidationResult("Invalid value for TenderContractSubject, length must be less than 4000.", new[] { "TenderContractSubject" });

            // TenderContractSubject (string) minLength
            if (TenderContractSubject != null && TenderContractSubject.Length < 1)
                yield return new ValidationResult("Invalid value for TenderContractSubject, length must be greater than 1.", new[] { "TenderContractSubject" });

            // ContractCommercialObjectDescription (string) maxLength
            if (ContractCommercialObjectDescription != null && ContractCommercialObjectDescription.Length > 4000)
                yield return new ValidationResult("Invalid value for ContractCommercialObjectDescription, length must be less than 4000.",
                    new[] { "ContractCommercialObjectDescription" });

            // ContractCommercialObjectDescription (string) minLength
            if (ContractCommercialObjectDescription != null && ContractCommercialObjectDescription.Length < 1)
                yield return new ValidationResult("Invalid value for ContractCommercialObjectDescription, length must be greater than 1.",
                    new[] { "ContractCommercialObjectDescription" });

            // ContractCommercialNumber (string) maxLength
            if (ContractCommercialNumber != null && ContractCommercialNumber.Length > 255)
                yield return new ValidationResult("Invalid value for ContractCommercialNumber, length must be less than 255.", new[] { "ContractCommercialNumber" });

            // ContractCommercialNumber (string) minLength
            if (ContractCommercialNumber != null && ContractCommercialNumber.Length < 1)
                yield return new ValidationResult("Invalid value for ContractCommercialNumber, length must be greater than 1.", new[] { "ContractCommercialNumber" });

            // ContractCommercialDate (DateTime) maxLength
            if (ContractCommercialDate != null && ContractCommercialDate.ToString().Length > 10)
                yield return new ValidationResult("Invalid value for ContractCommercialDate, length must be less than 10.", new[] { "ContractCommercialDate" });

            // ContractCommercialDate (DateTime) minLength
            if (ContractCommercialDate != null && ContractCommercialDate.ToString().Length < 10)
                yield return new ValidationResult("Invalid value for ContractCommercialDate, length must be greater than 10.", new[] { "ContractCommercialDate" });

            // ContractCommercialDate (DateTime) pattern
            var regexContractCommercialDate = new Regex(@"^[0-9]{4}-[0-9]{2}-[0-9]{2}$", RegexOptions.CultureInvariant);
            if (false == regexContractCommercialDate.Match(ContractCommercialDate.ToString()).Success)
                yield return new ValidationResult("Invalid value for ContractCommercialDate, must match a pattern of " + regexContractCommercialDate,
                    new[] { "ContractCommercialDate" });
        }

        /// <summary>
        ///     Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Procurement {\n");
            sb.Append("  ProcurementGuaranteeType: ").Append(ProcurementType).Append("\n");
            sb.Append("  TenderType: ").Append(TenderType).Append("\n");
            sb.Append("  TenderDate: ").Append(TenderDate).Append("\n");
            sb.Append("  PurchaseNumber: ").Append(PurchaseNumber).Append("\n");
            sb.Append("  Ikz: ").Append(Ikz).Append("\n");
            sb.Append("  PurchasePublishedDate: ").Append(PurchasePublishedDate).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  ContractMaxPrice: ").Append(ContractMaxPrice).Append("\n");
            sb.Append("  LotNumber: ").Append(LotNumber).Append("\n");
            sb.Append("  LotName: ").Append(LotName).Append("\n");
            sb.Append("  Okpd: ").Append(Okpd).Append("\n");
            sb.Append("  TenderContractNumber: ").Append(TenderContractNumber).Append("\n");
            sb.Append("  TenderContractRegNumber: ").Append(TenderContractRegNumber).Append("\n");
            sb.Append("  TenderContractSignedDate: ").Append(TenderContractSignedDate).Append("\n");
            sb.Append("  TenderContractSubject: ").Append(TenderContractSubject).Append("\n");
            sb.Append("  ContractCommercialObjectType: ").Append(ContractCommercialObjectType).Append("\n");
            sb.Append("  ContractCommercialObjectDescription: ").Append(ContractCommercialObjectDescription).Append("\n");
            sb.Append("  ContractCommercialNumber: ").Append(ContractCommercialNumber).Append("\n");
            sb.Append("  ContractCommercialDate: ").Append(ContractCommercialDate).Append("\n");
            sb.Append("  WithoutNumber: ").Append(WithoutNumber).Append("\n");
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
            return Equals(input as Procurement);
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
                hashCode = hashCode * 59 + ProcurementType.GetHashCode();
                if (TenderType != null) hashCode = hashCode * 59 + TenderType.GetHashCode();
                if (TenderDate != null) hashCode = hashCode * 59 + TenderDate.GetHashCode();
                if (PurchaseNumber != null) hashCode = hashCode * 59 + PurchaseNumber.GetHashCode();
                if (Ikz != null) hashCode = hashCode * 59 + Ikz.GetHashCode();
                if (PurchasePublishedDate != null) hashCode = hashCode * 59 + PurchasePublishedDate.GetHashCode();
                if (Subject != null) hashCode = hashCode * 59 + Subject.GetHashCode();
                hashCode = hashCode * 59 + ContractMaxPrice.GetHashCode();
                if (LotNumber != null) hashCode = hashCode * 59 + LotNumber.GetHashCode();
                if (LotName != null) hashCode = hashCode * 59 + LotName.GetHashCode();
                if (Okpd != null) hashCode = hashCode * 59 + Okpd.GetHashCode();
                if (TenderContractNumber != null) hashCode = hashCode * 59 + TenderContractNumber.GetHashCode();
                if (TenderContractRegNumber != null) hashCode = hashCode * 59 + TenderContractRegNumber.GetHashCode();
                if (TenderContractSignedDate != null) hashCode = hashCode * 59 + TenderContractSignedDate.GetHashCode();
                if (TenderContractSubject != null) hashCode = hashCode * 59 + TenderContractSubject.GetHashCode();
                hashCode = hashCode * 59 + ContractCommercialObjectType.GetHashCode();
                if (ContractCommercialObjectDescription != null) hashCode = hashCode * 59 + ContractCommercialObjectDescription.GetHashCode();
                if (ContractCommercialNumber != null) hashCode = hashCode * 59 + ContractCommercialNumber.GetHashCode();
                if (ContractCommercialDate != null) hashCode = hashCode * 59 + ContractCommercialDate.GetHashCode();
                hashCode = hashCode * 59 + WithoutNumber.GetHashCode();
                return hashCode;
            }
        }
    }
}
/*
 * Система рассмотрения заявок на экспресс-гарантии, полученных от партнеров банка
 *
 * Функционал выдачи экспресс гарантий позволяет реализовать след. сервисы:  - Создание клиентом заявки в личном кабинете на выдачу экспресс-гарантии - Отображение информации о закупке по минимальному набору введенных атрибутов - Загрузка и прикрепление документов к заявке - Формирование заявления на выдачу экспресс-гарантии для подписания клиентом - Подписание клиентом заявления с использованием УНЭП - Отображение в Интернет банке статусов заявки - Получение и передача заявок от партнеров - Создание сотрудником банка заявки на гарантию - Формирование проекта решения по заявке на гарантию 
 *
 * The version of the OpenAPI document: 1.4.1
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Multibanking.GuaranteeClient.Client.OpenAPIDateConverter;

namespace Multibanking.GuaranteeClient.Model
{
    /// <summary>
    /// Документы для заявки на получение банковской гарантии
    /// </summary>
    [DataContract(Name = "FileDownload")]
    public partial class FileDownload : IEquatable<FileDownload>, IValidatableObject
    {
        /// <summary>
        /// Группа документа
        /// </summary>
        /// <value>Группа документа</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum GroupEnum
        {
            /// <summary>
            /// Enum PERSON for value: PERSON
            /// </summary>
            [EnumMember(Value = "PERSON")]
            PERSON = 1,

            /// <summary>
            /// Enum COMPANY for value: COMPANY
            /// </summary>
            [EnumMember(Value = "COMPANY")]
            COMPANY = 2,

            /// <summary>
            /// Enum GUARANTEE for value: GUARANTEE
            /// </summary>
            [EnumMember(Value = "GUARANTEE")]
            GUARANTEE = 3

        }


        /// <summary>
        /// Группа документа
        /// </summary>
        /// <value>Группа документа</value>
        [DataMember(Name = "group", IsRequired = true, EmitDefaultValue = true)]
        public GroupEnum Group { get; set; }
        /// <summary>
        /// Тип документа. PASSPORT - паспорт, CORPORATE_CHARTER - устав, QUARTERLY_FINANCIAL_REPORT - квартальная отчетность, ANNUAL_FINANCIAL_REPORT - годовая отчетность, SHAREHOLDER_REGISTRY_EXTRACT - выписка из реестра акционеров, APPLICATION - заявление на банковскую гарантию, GUARANTEE_DOCX - проект гарантии в формате .docx, GUARANTEE_PDF - проект гарантии в формате .pdf, GUARANTEE_BANK_SIGNATURE - документ подписи сотрудника к гарантии, GUARANTEE_OFFER_DOCX - оферта в формате .docx, GUARANTEE_OFFER_PDF - оферта в формате .pdf, GUARANTEE_OFFER_BANK_SIGNATURE - документ подписи сотрудника к оферте, QUESTIONNAIRE_COMPANY - вопросник принципала (ЮЛ/ИП), QUESTIONNAIRE_PERSON - вопросник бенефициарного владельца (ФЛ), OTHER - прочий документ, ACCESSION_CONVENTION - заявление о присоединении – заполняется только один раз при первичном обращении, ORDER_APPOINTMENT_POSITION - копия решения и приказа о назначении на должность исполнительного органа, DEAL_SIZE_APPROVEMENT - документ одобрения крупной сделки, CONTRACT_CONCLUDED - заключённый договор, PROCUREMENT_DOCUMENTATION - документация по закупке, GUARANTEE_PROJECT_PDF - проект гарантии в формате .pdfPROCUREMENT_DOCUMENTATION - документация по закупке
        /// </summary>
        /// <value>Тип документа. PASSPORT - паспорт, CORPORATE_CHARTER - устав, QUARTERLY_FINANCIAL_REPORT - квартальная отчетность, ANNUAL_FINANCIAL_REPORT - годовая отчетность, SHAREHOLDER_REGISTRY_EXTRACT - выписка из реестра акционеров, APPLICATION - заявление на банковскую гарантию, GUARANTEE_DOCX - проект гарантии в формате .docx, GUARANTEE_PDF - проект гарантии в формате .pdf, GUARANTEE_BANK_SIGNATURE - документ подписи сотрудника к гарантии, GUARANTEE_OFFER_DOCX - оферта в формате .docx, GUARANTEE_OFFER_PDF - оферта в формате .pdf, GUARANTEE_OFFER_BANK_SIGNATURE - документ подписи сотрудника к оферте, QUESTIONNAIRE_COMPANY - вопросник принципала (ЮЛ/ИП), QUESTIONNAIRE_PERSON - вопросник бенефициарного владельца (ФЛ), OTHER - прочий документ, ACCESSION_CONVENTION - заявление о присоединении – заполняется только один раз при первичном обращении, ORDER_APPOINTMENT_POSITION - копия решения и приказа о назначении на должность исполнительного органа, DEAL_SIZE_APPROVEMENT - документ одобрения крупной сделки, CONTRACT_CONCLUDED - заключённый договор, PROCUREMENT_DOCUMENTATION - документация по закупке, GUARANTEE_PROJECT_PDF - проект гарантии в формате .pdfPROCUREMENT_DOCUMENTATION - документация по закупке</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum PASSPORT for value: PASSPORT
            /// </summary>
            [EnumMember(Value = "PASSPORT")]
            PASSPORT = 1,

            /// <summary>
            /// Enum CORPORATECHARTER for value: CORPORATE_CHARTER
            /// </summary>
            [EnumMember(Value = "CORPORATE_CHARTER")]
            CORPORATECHARTER = 2,

            /// <summary>
            /// Enum QUARTERLYFINANCIALREPORT for value: QUARTERLY_FINANCIAL_REPORT
            /// </summary>
            [EnumMember(Value = "QUARTERLY_FINANCIAL_REPORT")]
            QUARTERLYFINANCIALREPORT = 3,

            /// <summary>
            /// Enum ANNUALFINANCIALREPORT for value: ANNUAL_FINANCIAL_REPORT
            /// </summary>
            [EnumMember(Value = "ANNUAL_FINANCIAL_REPORT")]
            ANNUALFINANCIALREPORT = 4,

            /// <summary>
            /// Enum SHAREHOLDERREGISTRYEXTRACT for value: SHAREHOLDER_REGISTRY_EXTRACT
            /// </summary>
            [EnumMember(Value = "SHAREHOLDER_REGISTRY_EXTRACT")]
            SHAREHOLDERREGISTRYEXTRACT = 5,

            /// <summary>
            /// Enum APPLICATION for value: APPLICATION
            /// </summary>
            [EnumMember(Value = "APPLICATION")]
            APPLICATION = 6,

            /// <summary>
            /// Enum GUARANTEEDOCX for value: GUARANTEE_DOCX
            /// </summary>
            [EnumMember(Value = "GUARANTEE_DOCX")]
            GUARANTEEDOCX = 7,

            /// <summary>
            /// Enum GUARANTEEPDF for value: GUARANTEE_PDF
            /// </summary>
            [EnumMember(Value = "GUARANTEE_PDF")]
            GUARANTEEPDF = 8,

            /// <summary>
            /// Enum GUARANTEEBANKSIGNATURE for value: GUARANTEE_BANK_SIGNATURE
            /// </summary>
            [EnumMember(Value = "GUARANTEE_BANK_SIGNATURE")]
            GUARANTEEBANKSIGNATURE = 9,

            /// <summary>
            /// Enum GUARANTEEOFFERDOCX for value: GUARANTEE_OFFER_DOCX
            /// </summary>
            [EnumMember(Value = "GUARANTEE_OFFER_DOCX")]
            GUARANTEEOFFERDOCX = 10,

            /// <summary>
            /// Enum GUARANTEEOFFERPDF for value: GUARANTEE_OFFER_PDF
            /// </summary>
            [EnumMember(Value = "GUARANTEE_OFFER_PDF")]
            GUARANTEEOFFERPDF = 11,

            /// <summary>
            /// Enum GUARANTEEOFFERBANKSIGNATURE for value: GUARANTEE_OFFER_BANK_SIGNATURE
            /// </summary>
            [EnumMember(Value = "GUARANTEE_OFFER_BANK_SIGNATURE")]
            GUARANTEEOFFERBANKSIGNATURE = 12,

            /// <summary>
            /// Enum QUESTIONNAIRECOMPANY for value: QUESTIONNAIRE_COMPANY
            /// </summary>
            [EnumMember(Value = "QUESTIONNAIRE_COMPANY")]
            QUESTIONNAIRECOMPANY = 13,

            /// <summary>
            /// Enum QUESTIONNAIREPERSON for value: QUESTIONNAIRE_PERSON
            /// </summary>
            [EnumMember(Value = "QUESTIONNAIRE_PERSON")]
            QUESTIONNAIREPERSON = 14,

            /// <summary>
            /// Enum OTHER for value: OTHER
            /// </summary>
            [EnumMember(Value = "OTHER")]
            OTHER = 15,

            /// <summary>
            /// Enum ACCESSIONCONVENTION for value: ACCESSION_CONVENTION
            /// </summary>
            [EnumMember(Value = "ACCESSION_CONVENTION")]
            ACCESSIONCONVENTION = 16,

            /// <summary>
            /// Enum ORDERAPPOINTMENTPOSITION for value: ORDER_APPOINTMENT_POSITION
            /// </summary>
            [EnumMember(Value = "ORDER_APPOINTMENT_POSITION")]
            ORDERAPPOINTMENTPOSITION = 17,

            /// <summary>
            /// Enum DEALSIZEAPPROVEMENT for value: DEAL_SIZE_APPROVEMENT
            /// </summary>
            [EnumMember(Value = "DEAL_SIZE_APPROVEMENT")]
            DEALSIZEAPPROVEMENT = 18,

            /// <summary>
            /// Enum CONTRACTCONCLUDED for value: CONTRACT_CONCLUDED
            /// </summary>
            [EnumMember(Value = "CONTRACT_CONCLUDED")]
            CONTRACTCONCLUDED = 19,

            /// <summary>
            /// Enum PROCUREMENTDOCUMENTATION for value: PROCUREMENT_DOCUMENTATION
            /// </summary>
            [EnumMember(Value = "PROCUREMENT_DOCUMENTATION")]
            PROCUREMENTDOCUMENTATION = 20,

            /// <summary>
            /// Enum GUARANTEEPROJECTPDF for value: GUARANTEE_PROJECT_PDF
            /// </summary>
            [EnumMember(Value = "GUARANTEE_PROJECT_PDF")]
            GUARANTEEPROJECTPDF = 21

        }


        /// <summary>
        /// Тип документа. PASSPORT - паспорт, CORPORATE_CHARTER - устав, QUARTERLY_FINANCIAL_REPORT - квартальная отчетность, ANNUAL_FINANCIAL_REPORT - годовая отчетность, SHAREHOLDER_REGISTRY_EXTRACT - выписка из реестра акционеров, APPLICATION - заявление на банковскую гарантию, GUARANTEE_DOCX - проект гарантии в формате .docx, GUARANTEE_PDF - проект гарантии в формате .pdf, GUARANTEE_BANK_SIGNATURE - документ подписи сотрудника к гарантии, GUARANTEE_OFFER_DOCX - оферта в формате .docx, GUARANTEE_OFFER_PDF - оферта в формате .pdf, GUARANTEE_OFFER_BANK_SIGNATURE - документ подписи сотрудника к оферте, QUESTIONNAIRE_COMPANY - вопросник принципала (ЮЛ/ИП), QUESTIONNAIRE_PERSON - вопросник бенефициарного владельца (ФЛ), OTHER - прочий документ, ACCESSION_CONVENTION - заявление о присоединении – заполняется только один раз при первичном обращении, ORDER_APPOINTMENT_POSITION - копия решения и приказа о назначении на должность исполнительного органа, DEAL_SIZE_APPROVEMENT - документ одобрения крупной сделки, CONTRACT_CONCLUDED - заключённый договор, PROCUREMENT_DOCUMENTATION - документация по закупке, GUARANTEE_PROJECT_PDF - проект гарантии в формате .pdfPROCUREMENT_DOCUMENTATION - документация по закупке
        /// </summary>
        /// <value>Тип документа. PASSPORT - паспорт, CORPORATE_CHARTER - устав, QUARTERLY_FINANCIAL_REPORT - квартальная отчетность, ANNUAL_FINANCIAL_REPORT - годовая отчетность, SHAREHOLDER_REGISTRY_EXTRACT - выписка из реестра акционеров, APPLICATION - заявление на банковскую гарантию, GUARANTEE_DOCX - проект гарантии в формате .docx, GUARANTEE_PDF - проект гарантии в формате .pdf, GUARANTEE_BANK_SIGNATURE - документ подписи сотрудника к гарантии, GUARANTEE_OFFER_DOCX - оферта в формате .docx, GUARANTEE_OFFER_PDF - оферта в формате .pdf, GUARANTEE_OFFER_BANK_SIGNATURE - документ подписи сотрудника к оферте, QUESTIONNAIRE_COMPANY - вопросник принципала (ЮЛ/ИП), QUESTIONNAIRE_PERSON - вопросник бенефициарного владельца (ФЛ), OTHER - прочий документ, ACCESSION_CONVENTION - заявление о присоединении – заполняется только один раз при первичном обращении, ORDER_APPOINTMENT_POSITION - копия решения и приказа о назначении на должность исполнительного органа, DEAL_SIZE_APPROVEMENT - документ одобрения крупной сделки, CONTRACT_CONCLUDED - заключённый договор, PROCUREMENT_DOCUMENTATION - документация по закупке, GUARANTEE_PROJECT_PDF - проект гарантии в формате .pdfPROCUREMENT_DOCUMENTATION - документация по закупке</value>
        [DataMember(Name = "fileUploadType", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Текущий статус документа
        /// </summary>
        /// <value>Текущий статус документа</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum DECLINE for value: DECLINE
            /// </summary>
            [EnumMember(Value = "DECLINE")]
            DECLINE = 1,

            /// <summary>
            /// Enum DOCUMENTSREQUESTED for value: DOCUMENTS_REQUESTED
            /// </summary>
            [EnumMember(Value = "DOCUMENTS_REQUESTED")]
            DOCUMENTSREQUESTED = 2,

            /// <summary>
            /// Enum LOADED for value: LOADED
            /// </summary>
            [EnumMember(Value = "LOADED")]
            LOADED = 3,

            /// <summary>
            /// Enum VALIDATIONINPROGRESS for value: VALIDATION_IN_PROGRESS
            /// </summary>
            [EnumMember(Value = "VALIDATION_IN_PROGRESS")]
            VALIDATIONINPROGRESS = 4

        }


        /// <summary>
        /// Текущий статус документа
        /// </summary>
        /// <value>Текущий статус документа</value>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDownload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FileDownload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FileDownload" /> class.
        /// </summary>
        /// <param name="documentId">Идентификатор выгружаемого документа СХК..</param>
        /// <param name="fileName">Имя передаваемого документа (required).</param>
        /// <param name="group">Группа документа (required).</param>
        /// <param name="type">Тип документа. PASSPORT - паспорт, CORPORATE_CHARTER - устав, QUARTERLY_FINANCIAL_REPORT - квартальная отчетность, ANNUAL_FINANCIAL_REPORT - годовая отчетность, SHAREHOLDER_REGISTRY_EXTRACT - выписка из реестра акционеров, APPLICATION - заявление на банковскую гарантию, GUARANTEE_DOCX - проект гарантии в формате .docx, GUARANTEE_PDF - проект гарантии в формате .pdf, GUARANTEE_BANK_SIGNATURE - документ подписи сотрудника к гарантии, GUARANTEE_OFFER_DOCX - оферта в формате .docx, GUARANTEE_OFFER_PDF - оферта в формате .pdf, GUARANTEE_OFFER_BANK_SIGNATURE - документ подписи сотрудника к оферте, QUESTIONNAIRE_COMPANY - вопросник принципала (ЮЛ/ИП), QUESTIONNAIRE_PERSON - вопросник бенефициарного владельца (ФЛ), OTHER - прочий документ, ACCESSION_CONVENTION - заявление о присоединении – заполняется только один раз при первичном обращении, ORDER_APPOINTMENT_POSITION - копия решения и приказа о назначении на должность исполнительного органа, DEAL_SIZE_APPROVEMENT - документ одобрения крупной сделки, CONTRACT_CONCLUDED - заключённый договор, PROCUREMENT_DOCUMENTATION - документация по закупке, GUARANTEE_PROJECT_PDF - проект гарантии в формате .pdfPROCUREMENT_DOCUMENTATION - документация по закупке (required).</param>
        /// <param name="status">Текущий статус документа (required).</param>
        public FileDownload(string documentId = default(string), string fileName = default(string), GroupEnum group = default(GroupEnum), TypeEnum type = default(TypeEnum), StatusEnum status = default(StatusEnum))
        {
            // to ensure "fileName" is required (not null)
            if (fileName == null)
            {
                throw new ArgumentNullException("fileName is a required property for FileDownload and cannot be null");
            }
            this.FileName = fileName;
            this.Group = group;
            this.Type = type;
            this.Status = status;
            this.DocumentId = documentId;
        }

        /// <summary>
        /// Идентификатор выгружаемого документа СХК.
        /// </summary>
        /// <value>Идентификатор выгружаемого документа СХК.</value>
        [DataMember(Name = "documentId", EmitDefaultValue = false)]
        public string DocumentId { get; set; }

        /// <summary>
        /// Имя передаваемого документа
        /// </summary>
        /// <value>Имя передаваемого документа</value>
        [DataMember(Name = "fileName", IsRequired = true, EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class FileDownload {\n");
            sb.Append("  DocumentId: ").Append(DocumentId).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  FileUploadType: ").Append(Type).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as FileDownload);
        }

        /// <summary>
        /// Returns true if FileDownload instances are equal
        /// </summary>
        /// <param name="input">Instance of FileDownload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FileDownload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.DocumentId == input.DocumentId ||
                    (this.DocumentId != null &&
                    this.DocumentId.Equals(input.DocumentId))
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.Group == input.Group ||
                    this.Group.Equals(input.Group)
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.DocumentId != null)
                {
                    hashCode = (hashCode * 59) + this.DocumentId.GetHashCode();
                }
                if (this.FileName != null)
                {
                    hashCode = (hashCode * 59) + this.FileName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Group.GetHashCode();
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            // DocumentId (string) maxLength
            if (this.DocumentId != null && this.DocumentId.Length > 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentId, length must be less than 36.", new [] { "DocumentId" });
            }

            // DocumentId (string) minLength
            if (this.DocumentId != null && this.DocumentId.Length < 36)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentId, length must be greater than 36.", new [] { "DocumentId" });
            }

            // DocumentId (string) pattern
            Regex regexDocumentId = new Regex(@"^[0-9a-f]{8}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{4}-[0-9a-f]{12}$", RegexOptions.CultureInvariant);
            if (false == regexDocumentId.Match(this.DocumentId).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for DocumentId, must match a pattern of " + regexDocumentId, new [] { "DocumentId" });
            }

            // FileName (string) maxLength
            if (this.FileName != null && this.FileName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileName, length must be less than 255.", new [] { "FileName" });
            }

            // FileName (string) minLength
            if (this.FileName != null && this.FileName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileName, length must be greater than 1.", new [] { "FileName" });
            }

            yield break;
        }
    }

}

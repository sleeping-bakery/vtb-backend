/*
 * Поисковые сервисы каталога поставщиков услуг
 *
 * Поисковые сервисы каталога поставщиков услуг
 *
 * The version of the OpenAPI document: 1.0.0
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
using OpenAPIDateConverter = Multibanking.ServiceClient.Client.OpenAPIDateConverter;

namespace Multibanking.ServiceClient.Model
{
    /// <summary>
    /// Услуга поставщика услуг
    /// </summary>
    [DataContract(Name = "ServiceProviderSearchDtoRs")]
    public partial class ServiceProviderSearchDtoRs : IEquatable<ServiceProviderSearchDtoRs>, IValidatableObject
    {
        /// <summary>
        /// Тип услуги
        /// </summary>
        /// <value>Тип услуги</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ServiceTypeEnum
        {
            /// <summary>
            /// Enum CONTRACT for value: CONTRACT
            /// </summary>
            [EnumMember(Value = "CONTRACT")]
            CONTRACT = 1,

            /// <summary>
            /// Enum GISHCS for value: GIS_HCS
            /// </summary>
            [EnumMember(Value = "GIS_HCS")]
            GISHCS = 2

        }


        /// <summary>
        /// Тип услуги
        /// </summary>
        /// <value>Тип услуги</value>
        [DataMember(Name = "serviceType", IsRequired = true, EmitDefaultValue = true)]
        public ServiceTypeEnum ServiceType { get; set; }
        /// <summary>
        /// Подтип услуги (deprecated, см. subTypes)
        /// </summary>
        /// <value>Подтип услуги (deprecated, см. subTypes)</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubTypeEnum
        {
            /// <summary>
            /// Enum MOBILEBYPHONE for value: MOBILE_BY_PHONE
            /// </summary>
            [EnumMember(Value = "MOBILE_BY_PHONE")]
            MOBILEBYPHONE = 1,

            /// <summary>
            /// Enum FEDERAL for value: FEDERAL
            /// </summary>
            [EnumMember(Value = "FEDERAL")]
            FEDERAL = 2,

            /// <summary>
            /// Enum BYACCOUNTTOANOTHERBANK for value: BY_ACCOUNT_TO_ANOTHER_BANK
            /// </summary>
            [EnumMember(Value = "BY_ACCOUNT_TO_ANOTHER_BANK")]
            BYACCOUNTTOANOTHERBANK = 3,

            /// <summary>
            /// Enum BYACCOUNTTOINTERNAL for value: BY_ACCOUNT_TO_INTERNAL
            /// </summary>
            [EnumMember(Value = "BY_ACCOUNT_TO_INTERNAL")]
            BYACCOUNTTOINTERNAL = 4,

            /// <summary>
            /// Enum TOANOTHERBANK for value: TO_ANOTHER_BANK
            /// </summary>
            [EnumMember(Value = "TO_ANOTHER_BANK")]
            TOANOTHERBANK = 5,

            /// <summary>
            /// Enum TOINTERNAL for value: TO_INTERNAL
            /// </summary>
            [EnumMember(Value = "TO_INTERNAL")]
            TOINTERNAL = 6

        }


        /// <summary>
        /// Подтип услуги (deprecated, см. subTypes)
        /// </summary>
        /// <value>Подтип услуги (deprecated, см. subTypes)</value>
        [DataMember(Name = "subType", EmitDefaultValue = false)]
        [Obsolete]
        public SubTypeEnum? SubType { get; set; }
        /// <summary>
        /// Подтипы услуги
        /// </summary>
        /// <value>Подтипы услуги</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubTypesEnum
        {
            /// <summary>
            /// Enum MOBILEBYPHONE for value: MOBILE_BY_PHONE
            /// </summary>
            [EnumMember(Value = "MOBILE_BY_PHONE")]
            MOBILEBYPHONE = 1,

            /// <summary>
            /// Enum FEDERAL for value: FEDERAL
            /// </summary>
            [EnumMember(Value = "FEDERAL")]
            FEDERAL = 2,

            /// <summary>
            /// Enum BYACCOUNTTOANOTHERBANK for value: BY_ACCOUNT_TO_ANOTHER_BANK
            /// </summary>
            [EnumMember(Value = "BY_ACCOUNT_TO_ANOTHER_BANK")]
            BYACCOUNTTOANOTHERBANK = 3,

            /// <summary>
            /// Enum BYACCOUNTTOINTERNAL for value: BY_ACCOUNT_TO_INTERNAL
            /// </summary>
            [EnumMember(Value = "BY_ACCOUNT_TO_INTERNAL")]
            BYACCOUNTTOINTERNAL = 4,

            /// <summary>
            /// Enum TOANOTHERBANK for value: TO_ANOTHER_BANK
            /// </summary>
            [EnumMember(Value = "TO_ANOTHER_BANK")]
            TOANOTHERBANK = 5,

            /// <summary>
            /// Enum TOINTERNAL for value: TO_INTERNAL
            /// </summary>
            [EnumMember(Value = "TO_INTERNAL")]
            TOINTERNAL = 6

        }



        /// <summary>
        /// Подтипы услуги
        /// </summary>
        /// <value>Подтипы услуги</value>
        [DataMember(Name = "subTypes", EmitDefaultValue = false)]
        public List<SubTypesEnum> SubTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderSearchDtoRs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ServiceProviderSearchDtoRs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceProviderSearchDtoRs" /> class.
        /// </summary>
        /// <param name="id">Идентификатор услуги (required).</param>
        /// <param name="operationCode">Код операции (услуги) (required).</param>
        /// <param name="productId">Идентификатор продукта.</param>
        /// <param name="serviceType">Тип услуги (required).</param>
        /// <param name="subType">Подтип услуги (deprecated, см. subTypes).</param>
        /// <param name="subTypes">Подтипы услуги.</param>
        /// <param name="name">Наименование услуги (required).</param>
        /// <param name="shortName">Короткое наименование услуги.</param>
        /// <param name="description">Описание услуги.</param>
        /// <param name="receiver">receiver.</param>
        /// <param name="actions">Список возможных действий над услугой.</param>
        /// <param name="categoryIds">Список идентификаторов категорий, в которых доступна услуга.</param>
        /// <param name="regionIds">Список кодов регионов, в которых доступна услуга.</param>
        /// <param name="pmntSettings">pmntSettings.</param>
        public ServiceProviderSearchDtoRs(string id = default(string), string operationCode = default(string), string productId = default(string), ServiceTypeEnum serviceType = default(ServiceTypeEnum), SubTypeEnum? subType = default(SubTypeEnum?), List<SubTypesEnum> subTypes = default(List<SubTypesEnum>), string name = default(string), string shortName = default(string), string description = default(string), PaymentReceiverDtoRs receiver = default(PaymentReceiverDtoRs), List<OperationActionDtoRs> actions = default(List<OperationActionDtoRs>), List<string> categoryIds = default(List<string>), List<string> regionIds = default(List<string>), PaymentSettingsSearchDtoRs pmntSettings = default(PaymentSettingsSearchDtoRs))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for ServiceProviderSearchDtoRs and cannot be null");
            }
            this.Id = id;
            // to ensure "operationCode" is required (not null)
            if (operationCode == null)
            {
                throw new ArgumentNullException("operationCode is a required property for ServiceProviderSearchDtoRs and cannot be null");
            }
            this.OperationCode = operationCode;
            this.ServiceType = serviceType;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ServiceProviderSearchDtoRs and cannot be null");
            }
            this.Name = name;
            this.ProductId = productId;
            this.SubType = subType;
            this.SubTypes = subTypes;
            this.ShortName = shortName;
            this.Description = description;
            this.Receiver = receiver;
            this.Actions = actions;
            this.CategoryIds = categoryIds;
            this.RegionIds = regionIds;
            this.PmntSettings = pmntSettings;
        }

        /// <summary>
        /// Идентификатор услуги
        /// </summary>
        /// <value>Идентификатор услуги</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Код операции (услуги)
        /// </summary>
        /// <value>Код операции (услуги)</value>
        [DataMember(Name = "operationCode", IsRequired = true, EmitDefaultValue = true)]
        public string OperationCode { get; set; }

        /// <summary>
        /// Идентификатор продукта
        /// </summary>
        /// <value>Идентификатор продукта</value>
        [DataMember(Name = "productId", EmitDefaultValue = false)]
        public string ProductId { get; set; }

        /// <summary>
        /// Наименование услуги
        /// </summary>
        /// <value>Наименование услуги</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Короткое наименование услуги
        /// </summary>
        /// <value>Короткое наименование услуги</value>
        [DataMember(Name = "shortName", EmitDefaultValue = false)]
        public string ShortName { get; set; }

        /// <summary>
        /// Описание услуги
        /// </summary>
        /// <value>Описание услуги</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Receiver
        /// </summary>
        [DataMember(Name = "receiver", EmitDefaultValue = false)]
        public PaymentReceiverDtoRs Receiver { get; set; }

        /// <summary>
        /// Список возможных действий над услугой
        /// </summary>
        /// <value>Список возможных действий над услугой</value>
        [DataMember(Name = "actions", EmitDefaultValue = false)]
        public List<OperationActionDtoRs> Actions { get; set; }

        /// <summary>
        /// Список идентификаторов категорий, в которых доступна услуга
        /// </summary>
        /// <value>Список идентификаторов категорий, в которых доступна услуга</value>
        [DataMember(Name = "categoryIds", EmitDefaultValue = false)]
        public List<string> CategoryIds { get; set; }

        /// <summary>
        /// Список кодов регионов, в которых доступна услуга
        /// </summary>
        /// <value>Список кодов регионов, в которых доступна услуга</value>
        [DataMember(Name = "regionIds", EmitDefaultValue = false)]
        public List<string> RegionIds { get; set; }

        /// <summary>
        /// Gets or Sets PmntSettings
        /// </summary>
        [DataMember(Name = "pmntSettings", EmitDefaultValue = false)]
        public PaymentSettingsSearchDtoRs PmntSettings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ServiceProviderSearchDtoRs {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  OperationCode: ").Append(OperationCode).Append("\n");
            sb.Append("  ProductId: ").Append(ProductId).Append("\n");
            sb.Append("  ServiceType: ").Append(ServiceType).Append("\n");
            sb.Append("  SubType: ").Append(SubType).Append("\n");
            sb.Append("  SubTypes: ").Append(SubTypes).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ShortName: ").Append(ShortName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Receiver: ").Append(Receiver).Append("\n");
            sb.Append("  Actions: ").Append(Actions).Append("\n");
            sb.Append("  CategoryIds: ").Append(CategoryIds).Append("\n");
            sb.Append("  RegionIds: ").Append(RegionIds).Append("\n");
            sb.Append("  PmntSettings: ").Append(PmntSettings).Append("\n");
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
            return this.Equals(input as ServiceProviderSearchDtoRs);
        }

        /// <summary>
        /// Returns true if ServiceProviderSearchDtoRs instances are equal
        /// </summary>
        /// <param name="input">Instance of ServiceProviderSearchDtoRs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ServiceProviderSearchDtoRs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.OperationCode == input.OperationCode ||
                    (this.OperationCode != null &&
                    this.OperationCode.Equals(input.OperationCode))
                ) && 
                (
                    this.ProductId == input.ProductId ||
                    (this.ProductId != null &&
                    this.ProductId.Equals(input.ProductId))
                ) && 
                (
                    this.ServiceType == input.ServiceType ||
                    this.ServiceType.Equals(input.ServiceType)
                ) && 
                (
                    this.SubType == input.SubType ||
                    this.SubType.Equals(input.SubType)
                ) && 
                (
                    this.SubTypes == input.SubTypes ||
                    this.SubTypes.SequenceEqual(input.SubTypes)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ShortName == input.ShortName ||
                    (this.ShortName != null &&
                    this.ShortName.Equals(input.ShortName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Receiver == input.Receiver ||
                    (this.Receiver != null &&
                    this.Receiver.Equals(input.Receiver))
                ) && 
                (
                    this.Actions == input.Actions ||
                    this.Actions != null &&
                    input.Actions != null &&
                    this.Actions.SequenceEqual(input.Actions)
                ) && 
                (
                    this.CategoryIds == input.CategoryIds ||
                    this.CategoryIds != null &&
                    input.CategoryIds != null &&
                    this.CategoryIds.SequenceEqual(input.CategoryIds)
                ) && 
                (
                    this.RegionIds == input.RegionIds ||
                    this.RegionIds != null &&
                    input.RegionIds != null &&
                    this.RegionIds.SequenceEqual(input.RegionIds)
                ) && 
                (
                    this.PmntSettings == input.PmntSettings ||
                    (this.PmntSettings != null &&
                    this.PmntSettings.Equals(input.PmntSettings))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.OperationCode != null)
                {
                    hashCode = (hashCode * 59) + this.OperationCode.GetHashCode();
                }
                if (this.ProductId != null)
                {
                    hashCode = (hashCode * 59) + this.ProductId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ServiceType.GetHashCode();
                hashCode = (hashCode * 59) + this.SubType.GetHashCode();
                hashCode = (hashCode * 59) + this.SubTypes.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ShortName != null)
                {
                    hashCode = (hashCode * 59) + this.ShortName.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.Receiver != null)
                {
                    hashCode = (hashCode * 59) + this.Receiver.GetHashCode();
                }
                if (this.Actions != null)
                {
                    hashCode = (hashCode * 59) + this.Actions.GetHashCode();
                }
                if (this.CategoryIds != null)
                {
                    hashCode = (hashCode * 59) + this.CategoryIds.GetHashCode();
                }
                if (this.RegionIds != null)
                {
                    hashCode = (hashCode * 59) + this.RegionIds.GetHashCode();
                }
                if (this.PmntSettings != null)
                {
                    hashCode = (hashCode * 59) + this.PmntSettings.GetHashCode();
                }
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
            // Id (string) maxLength
            if (this.Id != null && this.Id.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Id, length must be less than 64.", new [] { "Id" });
            }

            // OperationCode (string) maxLength
            if (this.OperationCode != null && this.OperationCode.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for OperationCode, length must be less than 64.", new [] { "OperationCode" });
            }

            // ProductId (string) maxLength
            if (this.ProductId != null && this.ProductId.Length > 64)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ProductId, length must be less than 64.", new [] { "ProductId" });
            }

            // Name (string) maxLength
            if (this.Name != null && this.Name.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be less than 255.", new [] { "Name" });
            }

            // ShortName (string) maxLength
            if (this.ShortName != null && this.ShortName.Length > 255)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ShortName, length must be less than 255.", new [] { "ShortName" });
            }

            // Description (string) maxLength
            if (this.Description != null && this.Description.Length > 2000)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Description, length must be less than 2000.", new [] { "Description" });
            }

            yield break;
        }
    }

}

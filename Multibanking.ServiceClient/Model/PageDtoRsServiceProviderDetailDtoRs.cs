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
    /// Страница ресурса
    /// </summary>
    [DataContract(Name = "PageDtoRsServiceProviderDetailDtoRs")]
    public partial class PageDtoRsServiceProviderDetailDtoRs : IEquatable<PageDtoRsServiceProviderDetailDtoRs>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageDtoRsServiceProviderDetailDtoRs" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PageDtoRsServiceProviderDetailDtoRs() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PageDtoRsServiceProviderDetailDtoRs" /> class.
        /// </summary>
        /// <param name="items">Список объектов страницы (required).</param>
        /// <param name="pageNumber">Номер страницы (required).</param>
        /// <param name="pageSize">Размер страницы (required).</param>
        /// <param name="total">Общее число результатов (required).</param>
        /// <param name="hasMore">Признак наличия следующей страницы с результатами (required).</param>
        public PageDtoRsServiceProviderDetailDtoRs(List<ServiceProviderDetailDtoRs> items = default(List<ServiceProviderDetailDtoRs>), int pageNumber = default(int), int pageSize = default(int), long total = default(long), bool hasMore = default(bool))
        {
            // to ensure "items" is required (not null)
            if (items == null)
            {
                throw new ArgumentNullException("items is a required property for PageDtoRsServiceProviderDetailDtoRs and cannot be null");
            }
            this.Items = items;
            this.PageNumber = pageNumber;
            this.PageSize = pageSize;
            this.Total = total;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Список объектов страницы
        /// </summary>
        /// <value>Список объектов страницы</value>
        [DataMember(Name = "items", IsRequired = true, EmitDefaultValue = true)]
        public List<ServiceProviderDetailDtoRs> Items { get; set; }

        /// <summary>
        /// Номер страницы
        /// </summary>
        /// <value>Номер страницы</value>
        [DataMember(Name = "pageNumber", IsRequired = true, EmitDefaultValue = true)]
        public int PageNumber { get; set; }

        /// <summary>
        /// Размер страницы
        /// </summary>
        /// <value>Размер страницы</value>
        [DataMember(Name = "pageSize", IsRequired = true, EmitDefaultValue = true)]
        public int PageSize { get; set; }

        /// <summary>
        /// Общее число результатов
        /// </summary>
        /// <value>Общее число результатов</value>
        [DataMember(Name = "total", IsRequired = true, EmitDefaultValue = true)]
        public long Total { get; set; }

        /// <summary>
        /// Признак наличия следующей страницы с результатами
        /// </summary>
        /// <value>Признак наличия следующей страницы с результатами</value>
        [DataMember(Name = "hasMore", IsRequired = true, EmitDefaultValue = true)]
        public bool HasMore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageDtoRsServiceProviderDetailDtoRs {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  PageNumber: ").Append(PageNumber).Append("\n");
            sb.Append("  PageSize: ").Append(PageSize).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  HasMore: ").Append(HasMore).Append("\n");
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
            return this.Equals(input as PageDtoRsServiceProviderDetailDtoRs);
        }

        /// <summary>
        /// Returns true if PageDtoRsServiceProviderDetailDtoRs instances are equal
        /// </summary>
        /// <param name="input">Instance of PageDtoRsServiceProviderDetailDtoRs to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageDtoRsServiceProviderDetailDtoRs input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    input.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.PageNumber == input.PageNumber ||
                    this.PageNumber.Equals(input.PageNumber)
                ) && 
                (
                    this.PageSize == input.PageSize ||
                    this.PageSize.Equals(input.PageSize)
                ) && 
                (
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
                ) && 
                (
                    this.HasMore == input.HasMore ||
                    this.HasMore.Equals(input.HasMore)
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
                if (this.Items != null)
                {
                    hashCode = (hashCode * 59) + this.Items.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PageNumber.GetHashCode();
                hashCode = (hashCode * 59) + this.PageSize.GetHashCode();
                hashCode = (hashCode * 59) + this.Total.GetHashCode();
                hashCode = (hashCode * 59) + this.HasMore.GetHashCode();
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
            // PageNumber (int) maximum
            if (this.PageNumber > (int)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageNumber, must be a value less than or equal to 2147483647.", new [] { "PageNumber" });
            }

            // PageNumber (int) minimum
            if (this.PageNumber < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageNumber, must be a value greater than or equal to 0.", new [] { "PageNumber" });
            }

            // PageSize (int) maximum
            if (this.PageSize > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageSize, must be a value less than or equal to 100.", new [] { "PageSize" });
            }

            // PageSize (int) minimum
            if (this.PageSize < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for PageSize, must be a value greater than or equal to 0.", new [] { "PageSize" });
            }

            // Total (long) maximum
            if (this.Total > (long)2147483647)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Total, must be a value less than or equal to 2147483647.", new [] { "Total" });
            }

            // Total (long) minimum
            if (this.Total < (long)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Total, must be a value greater than or equal to 0.", new [] { "Total" });
            }

            yield break;
        }
    }

}
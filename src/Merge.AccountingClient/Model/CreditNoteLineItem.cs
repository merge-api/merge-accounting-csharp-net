/*
 * Merge Accounting API
 *
 * The unified API for building rich integrations with multiple Accounting & Finance platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
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
using OpenAPIDateConverter = Merge.AccountingClient.Client.OpenAPIDateConverter;

namespace Merge.AccountingClient.Model
{
    /// <summary>
    /// CreditNoteLineItem
    /// </summary>
    [DataContract(Name = "CreditNoteLineItem")]
    public partial class CreditNoteLineItem : IEquatable<CreditNoteLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteLineItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreditNoteLineItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNoteLineItem" /> class.
        /// </summary>
        /// <param name="item">item.</param>
        /// <param name="name">The credit note line item&#39;s name..</param>
        /// <param name="description">The description of the item that is owed..</param>
        /// <param name="quantity">The credit note line item&#39;s quantity..</param>
        /// <param name="memo">The credit note line item&#39;s memo..</param>
        /// <param name="unitPrice">The credit note line item&#39;s unit price..</param>
        /// <param name="taxRate">The credit note line item&#39;s tax rate..</param>
        /// <param name="totalLineAmount">The credit note line item&#39;s total..</param>
        /// <param name="trackingCategory">The credit note line item&#39;s associated tracking category..</param>
        /// <param name="trackingCategories">The credit note line item&#39;s associated tracking categories. (required).</param>
        /// <param name="account">The credit note line item&#39;s account..</param>
        /// <param name="company">The company the credit note belongs to..</param>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        public CreditNoteLineItem(Guid? item = default(Guid?), string name = default(string), string description = default(string), decimal? quantity = default(decimal?), string memo = default(string), decimal? unitPrice = default(decimal?), Guid? taxRate = default(Guid?), decimal? totalLineAmount = default(decimal?), Guid? trackingCategory = default(Guid?), List<Guid> trackingCategories = default(List<Guid>), Guid? account = default(Guid?), Guid? company = default(Guid?), string remoteId = default(string))
        {
            // to ensure "trackingCategories" is required (not null)
            this.TrackingCategories = trackingCategories ?? throw new ArgumentNullException("trackingCategories is a required property for CreditNoteLineItem and cannot be null");
            this.Item = item;
            this.Name = name;
            this.Description = description;
            this.Quantity = quantity;
            this.Memo = memo;
            this.UnitPrice = unitPrice;
            this.TaxRate = taxRate;
            this.TotalLineAmount = totalLineAmount;
            this.TrackingCategory = trackingCategory;
            this.Account = account;
            this.Company = company;
            this.RemoteId = remoteId;
        }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = true)]
        public Guid? Item { get; set; }

        /// <summary>
        /// The credit note line item&#39;s name.
        /// </summary>
        /// <value>The credit note line item&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The description of the item that is owed.
        /// </summary>
        /// <value>The description of the item that is owed.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The credit note line item&#39;s quantity.
        /// </summary>
        /// <value>The credit note line item&#39;s quantity.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = true)]
        public decimal? Quantity { get; set; }

        /// <summary>
        /// The credit note line item&#39;s memo.
        /// </summary>
        /// <value>The credit note line item&#39;s memo.</value>
        [DataMember(Name = "memo", EmitDefaultValue = true)]
        public string Memo { get; set; }

        /// <summary>
        /// The credit note line item&#39;s unit price.
        /// </summary>
        /// <value>The credit note line item&#39;s unit price.</value>
        [DataMember(Name = "unit_price", EmitDefaultValue = true)]
        public decimal? UnitPrice { get; set; }

        /// <summary>
        /// The credit note line item&#39;s tax rate.
        /// </summary>
        /// <value>The credit note line item&#39;s tax rate.</value>
        [DataMember(Name = "tax_rate", EmitDefaultValue = true)]
        public Guid? TaxRate { get; set; }

        /// <summary>
        /// The credit note line item&#39;s total.
        /// </summary>
        /// <value>The credit note line item&#39;s total.</value>
        [DataMember(Name = "total_line_amount", EmitDefaultValue = true)]
        public decimal? TotalLineAmount { get; set; }

        /// <summary>
        /// The credit note line item&#39;s associated tracking category.
        /// </summary>
        /// <value>The credit note line item&#39;s associated tracking category.</value>
        [DataMember(Name = "tracking_category", EmitDefaultValue = true)]
        public Guid? TrackingCategory { get; set; }

        /// <summary>
        /// The credit note line item&#39;s associated tracking categories.
        /// </summary>
        /// <value>The credit note line item&#39;s associated tracking categories.</value>
        [DataMember(Name = "tracking_categories", IsRequired = true, EmitDefaultValue = false)]
        public List<Guid> TrackingCategories { get; set; }

        /// <summary>
        /// The credit note line item&#39;s account.
        /// </summary>
        /// <value>The credit note line item&#39;s account.</value>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// The company the credit note belongs to.
        /// </summary>
        /// <value>The company the credit note belongs to.</value>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public Guid? Company { get; set; }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// This is the datetime that this object was last updated by Merge
        /// </summary>
        /// <value>This is the datetime that this object was last updated by Merge</value>
        [DataMember(Name = "modified_at", EmitDefaultValue = false)]
        public DateTime ModifiedAt { get; private set; }

        /// <summary>
        /// Returns false as ModifiedAt should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeModifiedAt()
        {
            return false;
        }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditNoteLineItem {\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  TaxRate: ").Append(TaxRate).Append("\n");
            sb.Append("  TotalLineAmount: ").Append(TotalLineAmount).Append("\n");
            sb.Append("  TrackingCategory: ").Append(TrackingCategory).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
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
            return this.Equals(input as CreditNoteLineItem);
        }

        /// <summary>
        /// Returns true if CreditNoteLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNoteLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNoteLineItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.TaxRate == input.TaxRate ||
                    (this.TaxRate != null &&
                    this.TaxRate.Equals(input.TaxRate))
                ) && 
                (
                    this.TotalLineAmount == input.TotalLineAmount ||
                    (this.TotalLineAmount != null &&
                    this.TotalLineAmount.Equals(input.TotalLineAmount))
                ) && 
                (
                    this.TrackingCategory == input.TrackingCategory ||
                    (this.TrackingCategory != null &&
                    this.TrackingCategory.Equals(input.TrackingCategory))
                ) && 
                (
                    this.TrackingCategories == input.TrackingCategories ||
                    this.TrackingCategories != null &&
                    input.TrackingCategories != null &&
                    this.TrackingCategories.SequenceEqual(input.TrackingCategories)
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
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
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.TaxRate != null)
                    hashCode = hashCode * 59 + this.TaxRate.GetHashCode();
                if (this.TotalLineAmount != null)
                    hashCode = hashCode * 59 + this.TotalLineAmount.GetHashCode();
                if (this.TrackingCategory != null)
                    hashCode = hashCode * 59 + this.TrackingCategory.GetHashCode();
                if (this.TrackingCategories != null)
                    hashCode = hashCode * 59 + this.TrackingCategories.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // Quantity (decimal?) pattern
            Regex regexQuantity = new Regex(@"^-?\\d{0,24}(?:\\.\\d{0,8})?$", RegexOptions.CultureInvariant);
            if (false == regexQuantity.Match(this.Quantity.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Quantity, must match a pattern of " + regexQuantity, new [] { "Quantity" });
            }

            // UnitPrice (decimal?) pattern
            Regex regexUnitPrice = new Regex(@"^-?\\d{0,32}(?:\\.\\d{0,16})?$", RegexOptions.CultureInvariant);
            if (false == regexUnitPrice.Match(this.UnitPrice.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for UnitPrice, must match a pattern of " + regexUnitPrice, new [] { "UnitPrice" });
            }

            // TotalLineAmount (decimal?) pattern
            Regex regexTotalLineAmount = new Regex(@"^-?\\d{0,32}(?:\\.\\d{0,16})?$", RegexOptions.CultureInvariant);
            if (false == regexTotalLineAmount.Match(this.TotalLineAmount.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalLineAmount, must match a pattern of " + regexTotalLineAmount, new [] { "TotalLineAmount" });
            }

            yield break;
        }
    }

}

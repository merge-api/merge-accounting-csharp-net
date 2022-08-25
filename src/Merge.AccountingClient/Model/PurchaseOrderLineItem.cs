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
    /// # The PurchaseOrderLineItem Object ### Description The &#x60;PurchaseOrderLineItem&#x60; object is used to represent a purchase order&#39;s line item.  ### Usage Example Fetch from the &#x60;GET PurchaseOrder&#x60; endpoint and view a company&#39;s purchase orders.
    /// </summary>
    [DataContract(Name = "PurchaseOrderLineItem")]
    public partial class PurchaseOrderLineItem : IEquatable<PurchaseOrderLineItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderLineItem" /> class.
        /// </summary>
        /// <param name="description">The line item&#39;s description..</param>
        /// <param name="unitPrice">The line item&#39;s unit price..</param>
        /// <param name="quantity">The line item&#39;s quantity..</param>
        /// <param name="item">item.</param>
        /// <param name="account">The purchase order line item&#39;s account..</param>
        /// <param name="trackingCategory">The purchase order line item&#39;s associated tracking category..</param>
        /// <param name="taxAmount">The purchase order line item&#39;s tax amount..</param>
        /// <param name="totalLineAmount">The purchase order line item&#39;s total amount..</param>
        public PurchaseOrderLineItem(string description = default(string), float? unitPrice = default(float?), float? quantity = default(float?), Guid? item = default(Guid?), Guid? account = default(Guid?), Guid? trackingCategory = default(Guid?), decimal? taxAmount = default(decimal?), decimal? totalLineAmount = default(decimal?))
        {
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.Item = item;
            this.Account = account;
            this.TrackingCategory = trackingCategory;
            this.TaxAmount = taxAmount;
            this.TotalLineAmount = totalLineAmount;
        }

        /// <summary>
        /// The line item&#39;s description.
        /// </summary>
        /// <value>The line item&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The line item&#39;s unit price.
        /// </summary>
        /// <value>The line item&#39;s unit price.</value>
        [DataMember(Name = "unit_price", EmitDefaultValue = true)]
        public float? UnitPrice { get; set; }

        /// <summary>
        /// The line item&#39;s quantity.
        /// </summary>
        /// <value>The line item&#39;s quantity.</value>
        [DataMember(Name = "quantity", EmitDefaultValue = true)]
        public float? Quantity { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = true)]
        public Guid? Item { get; set; }

        /// <summary>
        /// The purchase order line item&#39;s account.
        /// </summary>
        /// <value>The purchase order line item&#39;s account.</value>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// The purchase order line item&#39;s associated tracking category.
        /// </summary>
        /// <value>The purchase order line item&#39;s associated tracking category.</value>
        [DataMember(Name = "tracking_category", EmitDefaultValue = true)]
        public Guid? TrackingCategory { get; set; }

        /// <summary>
        /// The purchase order line item&#39;s tax amount.
        /// </summary>
        /// <value>The purchase order line item&#39;s tax amount.</value>
        [DataMember(Name = "tax_amount", EmitDefaultValue = true)]
        public decimal? TaxAmount { get; set; }

        /// <summary>
        /// The purchase order line item&#39;s total amount.
        /// </summary>
        /// <value>The purchase order line item&#39;s total amount.</value>
        [DataMember(Name = "total_line_amount", EmitDefaultValue = true)]
        public decimal? TotalLineAmount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseOrderLineItem {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  TrackingCategory: ").Append(TrackingCategory).Append("\n");
            sb.Append("  TaxAmount: ").Append(TaxAmount).Append("\n");
            sb.Append("  TotalLineAmount: ").Append(TotalLineAmount).Append("\n");
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
            return this.Equals(input as PurchaseOrderLineItem);
        }

        /// <summary>
        /// Returns true if PurchaseOrderLineItem instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrderLineItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrderLineItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.Quantity == input.Quantity ||
                    (this.Quantity != null &&
                    this.Quantity.Equals(input.Quantity))
                ) && 
                (
                    this.Item == input.Item ||
                    (this.Item != null &&
                    this.Item.Equals(input.Item))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.TrackingCategory == input.TrackingCategory ||
                    (this.TrackingCategory != null &&
                    this.TrackingCategory.Equals(input.TrackingCategory))
                ) && 
                (
                    this.TaxAmount == input.TaxAmount ||
                    (this.TaxAmount != null &&
                    this.TaxAmount.Equals(input.TaxAmount))
                ) && 
                (
                    this.TotalLineAmount == input.TotalLineAmount ||
                    (this.TotalLineAmount != null &&
                    this.TotalLineAmount.Equals(input.TotalLineAmount))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.TrackingCategory != null)
                    hashCode = hashCode * 59 + this.TrackingCategory.GetHashCode();
                if (this.TaxAmount != null)
                    hashCode = hashCode * 59 + this.TaxAmount.GetHashCode();
                if (this.TotalLineAmount != null)
                    hashCode = hashCode * 59 + this.TotalLineAmount.GetHashCode();
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
            // TaxAmount (decimal?) pattern
            Regex regexTaxAmount = new Regex(@"^\\d{0,32}(?:\\.\\d{0,16})?$", RegexOptions.CultureInvariant);
            if (false == regexTaxAmount.Match(this.TaxAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaxAmount, must match a pattern of " + regexTaxAmount, new [] { "TaxAmount" });
            }

            // TotalLineAmount (decimal?) pattern
            Regex regexTotalLineAmount = new Regex(@"^\\d{0,32}(?:\\.\\d{0,16})?$", RegexOptions.CultureInvariant);
            if (false == regexTotalLineAmount.Match(this.TotalLineAmount).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TotalLineAmount, must match a pattern of " + regexTotalLineAmount, new [] { "TotalLineAmount" });
            }

            yield break;
        }
    }

}

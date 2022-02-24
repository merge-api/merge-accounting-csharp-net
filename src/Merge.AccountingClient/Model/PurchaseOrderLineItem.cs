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
        public PurchaseOrderLineItem(string description = default(string), float? unitPrice = default(float?), float? quantity = default(float?), Guid? item = default(Guid?))
        {
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.Item = item;
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
            yield break;
        }
    }

}

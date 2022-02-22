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
    /// # The Item Object ### Description The &#x60;Item&#x60; object is used to represent an item that a company buys, sells, or resells, such as products and services.  ### Usage Example Fetch from the &#x60;LIST Items&#x60; endpoint and view a company&#39;s items.
    /// </summary>
    [DataContract(Name = "Item")]
    public partial class Item : IEquatable<Item>, IValidatableObject
    {

        /// <summary>
        /// The item&#39;s status.
        /// </summary>
        /// <value>The item&#39;s status.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public Status7d1Enum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Item" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="name">The item&#39;s name..</param>
        /// <param name="status">The item&#39;s status..</param>
        /// <param name="unitPrice">The item&#39;s unit price..</param>
        /// <param name="purchasePrice">The item&#39;s purchase price..</param>
        /// <param name="purchaseAccount">purchaseAccount.</param>
        /// <param name="salesAccount">salesAccount.</param>
        /// <param name="remoteUpdatedAt">When the third party&#39;s item note was updated..</param>
        public Item(string remoteId = default(string), string name = default(string), Status7d1Enum? status = default(Status7d1Enum?), float? unitPrice = default(float?), float? purchasePrice = default(float?), Guid? purchaseAccount = default(Guid?), Guid? salesAccount = default(Guid?), DateTime? remoteUpdatedAt = default(DateTime?))
        {
            this.RemoteId = remoteId;
            this.Name = name;
            this.Status = status;
            this.UnitPrice = unitPrice;
            this.PurchasePrice = purchasePrice;
            this.PurchaseAccount = purchaseAccount;
            this.SalesAccount = salesAccount;
            this.RemoteUpdatedAt = remoteUpdatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; private set; }

        /// <summary>
        /// Returns false as Id should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeId()
        {
            return false;
        }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// Gets or Sets RemoteData
        /// </summary>
        [DataMember(Name = "remote_data", EmitDefaultValue = true)]
        public List<RemoteData> RemoteData { get; private set; }

        /// <summary>
        /// Returns false as RemoteData should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteData()
        {
            return false;
        }

        /// <summary>
        /// The item&#39;s name.
        /// </summary>
        /// <value>The item&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The item&#39;s unit price.
        /// </summary>
        /// <value>The item&#39;s unit price.</value>
        [DataMember(Name = "unit_price", EmitDefaultValue = true)]
        public float? UnitPrice { get; set; }

        /// <summary>
        /// The item&#39;s purchase price.
        /// </summary>
        /// <value>The item&#39;s purchase price.</value>
        [DataMember(Name = "purchase_price", EmitDefaultValue = true)]
        public float? PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets PurchaseAccount
        /// </summary>
        [DataMember(Name = "purchase_account", EmitDefaultValue = true)]
        public Guid? PurchaseAccount { get; set; }

        /// <summary>
        /// Gets or Sets SalesAccount
        /// </summary>
        [DataMember(Name = "sales_account", EmitDefaultValue = true)]
        public Guid? SalesAccount { get; set; }

        /// <summary>
        /// When the third party&#39;s item note was updated.
        /// </summary>
        /// <value>When the third party&#39;s item note was updated.</value>
        [DataMember(Name = "remote_updated_at", EmitDefaultValue = true)]
        public DateTime? RemoteUpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Item {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  RemoteData: ").Append(RemoteData).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  PurchaseAccount: ").Append(PurchaseAccount).Append("\n");
            sb.Append("  SalesAccount: ").Append(SalesAccount).Append("\n");
            sb.Append("  RemoteUpdatedAt: ").Append(RemoteUpdatedAt).Append("\n");
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
            return this.Equals(input as Item);
        }

        /// <summary>
        /// Returns true if Item instances are equal
        /// </summary>
        /// <param name="input">Instance of Item to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Item input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.RemoteData == input.RemoteData ||
                    this.RemoteData != null &&
                    input.RemoteData != null &&
                    this.RemoteData.SequenceEqual(input.RemoteData)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.UnitPrice == input.UnitPrice ||
                    (this.UnitPrice != null &&
                    this.UnitPrice.Equals(input.UnitPrice))
                ) && 
                (
                    this.PurchasePrice == input.PurchasePrice ||
                    (this.PurchasePrice != null &&
                    this.PurchasePrice.Equals(input.PurchasePrice))
                ) && 
                (
                    this.PurchaseAccount == input.PurchaseAccount ||
                    (this.PurchaseAccount != null &&
                    this.PurchaseAccount.Equals(input.PurchaseAccount))
                ) && 
                (
                    this.SalesAccount == input.SalesAccount ||
                    (this.SalesAccount != null &&
                    this.SalesAccount.Equals(input.SalesAccount))
                ) && 
                (
                    this.RemoteUpdatedAt == input.RemoteUpdatedAt ||
                    (this.RemoteUpdatedAt != null &&
                    this.RemoteUpdatedAt.Equals(input.RemoteUpdatedAt))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.RemoteData != null)
                    hashCode = hashCode * 59 + this.RemoteData.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.PurchasePrice != null)
                    hashCode = hashCode * 59 + this.PurchasePrice.GetHashCode();
                if (this.PurchaseAccount != null)
                    hashCode = hashCode * 59 + this.PurchaseAccount.GetHashCode();
                if (this.SalesAccount != null)
                    hashCode = hashCode * 59 + this.SalesAccount.GetHashCode();
                if (this.RemoteUpdatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteUpdatedAt.GetHashCode();
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

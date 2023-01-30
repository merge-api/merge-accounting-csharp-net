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
    /// # The ExpenseLine Object ### Description The &#x60;ExpenseLine&#x60; object is used to represent an expense&#39;s line items.  ### Usage Example Fetch from the &#x60;GET Expense&#x60; endpoint and view the expense&#39;s line items.
    /// </summary>
    [DataContract(Name = "ExpenseLineRequest")]
    public partial class ExpenseLineRequest : IEquatable<ExpenseLineRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ExpenseLineRequest" /> class.
        /// </summary>
        /// <param name="item">The line&#39;s item..</param>
        /// <param name="netAmount">The line&#39;s net amount..</param>
        /// <param name="trackingCategory">trackingCategory.</param>
        /// <param name="trackingCategories">trackingCategories.</param>
        /// <param name="company">The company the line belongs to..</param>
        /// <param name="account">The expense&#39;s payment account..</param>
        /// <param name="description">The description of the item that was purchased by the company..</param>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="integrationParams">integrationParams.</param>
        /// <param name="linkedAccountParams">linkedAccountParams.</param>
        public ExpenseLineRequest(Guid? item = default(Guid?), float? netAmount = default(float?), Guid? trackingCategory = default(Guid?), List<Guid?> trackingCategories = default(List<Guid?>), Guid? company = default(Guid?), Guid? account = default(Guid?), string description = default(string), string remoteId = default(string), Dictionary<string, Object> integrationParams = default(Dictionary<string, Object>), Dictionary<string, Object> linkedAccountParams = default(Dictionary<string, Object>))
        {
            this.Item = item;
            this.NetAmount = netAmount;
            this.TrackingCategory = trackingCategory;
            this.TrackingCategories = trackingCategories;
            this.Company = company;
            this.Account = account;
            this.Description = description;
            this.RemoteId = remoteId;
            this.IntegrationParams = integrationParams;
            this.LinkedAccountParams = linkedAccountParams;
        }

        /// <summary>
        /// The line&#39;s item.
        /// </summary>
        /// <value>The line&#39;s item.</value>
        [DataMember(Name = "item", EmitDefaultValue = true)]
        public Guid? Item { get; set; }

        /// <summary>
        /// The line&#39;s net amount.
        /// </summary>
        /// <value>The line&#39;s net amount.</value>
        [DataMember(Name = "net_amount", EmitDefaultValue = true)]
        public float? NetAmount { get; set; }

        /// <summary>
        /// Gets or Sets TrackingCategory
        /// </summary>
        [DataMember(Name = "tracking_category", EmitDefaultValue = true)]
        public Guid? TrackingCategory { get; set; }

        /// <summary>
        /// Gets or Sets TrackingCategories
        /// </summary>
        [DataMember(Name = "tracking_categories", EmitDefaultValue = false)]
        public List<Guid?> TrackingCategories { get; set; }

        /// <summary>
        /// The company the line belongs to.
        /// </summary>
        /// <value>The company the line belongs to.</value>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public Guid? Company { get; set; }

        /// <summary>
        /// The expense&#39;s payment account.
        /// </summary>
        /// <value>The expense&#39;s payment account.</value>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// The description of the item that was purchased by the company.
        /// </summary>
        /// <value>The description of the item that was purchased by the company.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// Gets or Sets IntegrationParams
        /// </summary>
        [DataMember(Name = "integration_params", EmitDefaultValue = true)]
        public Dictionary<string, Object> IntegrationParams { get; set; }

        /// <summary>
        /// Gets or Sets LinkedAccountParams
        /// </summary>
        [DataMember(Name = "linked_account_params", EmitDefaultValue = true)]
        public Dictionary<string, Object> LinkedAccountParams { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ExpenseLineRequest {\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
            sb.Append("  TrackingCategory: ").Append(TrackingCategory).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  IntegrationParams: ").Append(IntegrationParams).Append("\n");
            sb.Append("  LinkedAccountParams: ").Append(LinkedAccountParams).Append("\n");
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
            return this.Equals(input as ExpenseLineRequest);
        }

        /// <summary>
        /// Returns true if ExpenseLineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of ExpenseLineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ExpenseLineRequest input)
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
                    this.NetAmount == input.NetAmount ||
                    (this.NetAmount != null &&
                    this.NetAmount.Equals(input.NetAmount))
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
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.IntegrationParams == input.IntegrationParams ||
                    this.IntegrationParams != null &&
                    input.IntegrationParams != null &&
                    this.IntegrationParams.SequenceEqual(input.IntegrationParams)
                ) && 
                (
                    this.LinkedAccountParams == input.LinkedAccountParams ||
                    this.LinkedAccountParams != null &&
                    input.LinkedAccountParams != null &&
                    this.LinkedAccountParams.SequenceEqual(input.LinkedAccountParams)
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
                if (this.NetAmount != null)
                    hashCode = hashCode * 59 + this.NetAmount.GetHashCode();
                if (this.TrackingCategory != null)
                    hashCode = hashCode * 59 + this.TrackingCategory.GetHashCode();
                if (this.TrackingCategories != null)
                    hashCode = hashCode * 59 + this.TrackingCategories.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.IntegrationParams != null)
                    hashCode = hashCode * 59 + this.IntegrationParams.GetHashCode();
                if (this.LinkedAccountParams != null)
                    hashCode = hashCode * 59 + this.LinkedAccountParams.GetHashCode();
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
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
    /// # The InvoiceLineItem Object ### Description The &#x60;InvoiceLineItem&#x60; object represents an itemized record of goods and/or services sold to a customer. If type &#x3D; accounts_payable, invoice is a bill, if type &#x3D; accounts_receivable it&#39;s an invoice.  ### Usage Example Fetch from the &#x60;GET Invoice&#x60; endpoint and view the invoice&#39;s line items.
    /// </summary>
    [DataContract(Name = "InvoiceLineItemRequest")]
    public partial class InvoiceLineItemRequest : IEquatable<InvoiceLineItemRequest>, IValidatableObject
    {

        /// <summary>
        /// The line item&#39;s currency.
        /// </summary>
        /// <value>The line item&#39;s currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InvoiceLineItemRequest" /> class.
        /// </summary>
        /// <param name="description">The line item&#39;s description..</param>
        /// <param name="unitPrice">The line item&#39;s unit price..</param>
        /// <param name="quantity">The line item&#39;s quantity..</param>
        /// <param name="totalAmount">The line item&#39;s total amount..</param>
        /// <param name="currency">The line item&#39;s currency..</param>
        /// <param name="exchangeRate">The line item&#39;s exchange rate..</param>
        /// <param name="item">item.</param>
        /// <param name="account">account.</param>
        /// <param name="trackingCategory">trackingCategory.</param>
        /// <param name="trackingCategories">trackingCategories.</param>
        /// <param name="company">The company the line item belongs to..</param>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="integrationParams">integrationParams.</param>
        /// <param name="linkedAccountParams">linkedAccountParams.</param>
        public InvoiceLineItemRequest(string description = default(string), float? unitPrice = default(float?), float? quantity = default(float?), float? totalAmount = default(float?), CurrencyEnum? currency = default(CurrencyEnum?), decimal? exchangeRate = default(decimal?), Guid? item = default(Guid?), Guid? account = default(Guid?), Guid? trackingCategory = default(Guid?), List<Guid?> trackingCategories = default(List<Guid?>), Guid? company = default(Guid?), string remoteId = default(string), Dictionary<string, Object> integrationParams = default(Dictionary<string, Object>), Dictionary<string, Object> linkedAccountParams = default(Dictionary<string, Object>))
        {
            this.Description = description;
            this.UnitPrice = unitPrice;
            this.Quantity = quantity;
            this.TotalAmount = totalAmount;
            this.Currency = currency;
            this.ExchangeRate = exchangeRate;
            this.Item = item;
            this.Account = account;
            this.TrackingCategory = trackingCategory;
            this.TrackingCategories = trackingCategories;
            this.Company = company;
            this.RemoteId = remoteId;
            this.IntegrationParams = integrationParams;
            this.LinkedAccountParams = linkedAccountParams;
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
        /// The line item&#39;s total amount.
        /// </summary>
        /// <value>The line item&#39;s total amount.</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public float? TotalAmount { get; set; }

        /// <summary>
        /// The line item&#39;s exchange rate.
        /// </summary>
        /// <value>The line item&#39;s exchange rate.</value>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = true)]
        public decimal? ExchangeRate { get; set; }

        /// <summary>
        /// Gets or Sets Item
        /// </summary>
        [DataMember(Name = "item", EmitDefaultValue = true)]
        public Guid? Item { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

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
        /// The company the line item belongs to.
        /// </summary>
        /// <value>The company the line item belongs to.</value>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public Guid? Company { get; set; }

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
            sb.Append("class InvoiceLineItemRequest {\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  UnitPrice: ").Append(UnitPrice).Append("\n");
            sb.Append("  Quantity: ").Append(Quantity).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
            sb.Append("  Item: ").Append(Item).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  TrackingCategory: ").Append(TrackingCategory).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
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
            return this.Equals(input as InvoiceLineItemRequest);
        }

        /// <summary>
        /// Returns true if InvoiceLineItemRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of InvoiceLineItemRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InvoiceLineItemRequest input)
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
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.UnitPrice != null)
                    hashCode = hashCode * 59 + this.UnitPrice.GetHashCode();
                if (this.Quantity != null)
                    hashCode = hashCode * 59 + this.Quantity.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
                if (this.Item != null)
                    hashCode = hashCode * 59 + this.Item.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.TrackingCategory != null)
                    hashCode = hashCode * 59 + this.TrackingCategory.GetHashCode();
                if (this.TrackingCategories != null)
                    hashCode = hashCode * 59 + this.TrackingCategories.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
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
            // ExchangeRate (decimal?) pattern
            Regex regexExchangeRate = new Regex(@"^\\d{0,32}(?:\\.\\d{0,16})?$", RegexOptions.CultureInvariant);
            if (false == regexExchangeRate.Match(this.ExchangeRate.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExchangeRate, must match a pattern of " + regexExchangeRate, new [] { "ExchangeRate" });
            }

            yield break;
        }
    }

}

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
    /// # The JournalLine Object ### Description The &#x60;JournalLine&#x60; object is used to represent a journal entry&#39;s line items.  ### Usage Example Fetch from the &#x60;GET JournalEntry&#x60; endpoint and view the journal entry&#39;s line items.
    /// </summary>
    [DataContract(Name = "JournalLineRequest")]
    public partial class JournalLineRequest : IEquatable<JournalLineRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalLineRequest" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="account">account.</param>
        /// <param name="netAmount">The value of the line item including taxes and other fees..</param>
        /// <param name="trackingCategory">trackingCategory.</param>
        /// <param name="trackingCategories">trackingCategories.</param>
        /// <param name="contact">contact.</param>
        /// <param name="description">The line&#39;s description..</param>
        /// <param name="exchangeRate">The journal line item&#39;s exchange rate..</param>
        /// <param name="integrationParams">integrationParams.</param>
        /// <param name="linkedAccountParams">linkedAccountParams.</param>
        public JournalLineRequest(string remoteId = default(string), Guid? account = default(Guid?), double? netAmount = default(double?), Guid? trackingCategory = default(Guid?), List<Guid?> trackingCategories = default(List<Guid?>), Guid? contact = default(Guid?), string description = default(string), decimal? exchangeRate = default(decimal?), Dictionary<string, Object> integrationParams = default(Dictionary<string, Object>), Dictionary<string, Object> linkedAccountParams = default(Dictionary<string, Object>))
        {
            this.RemoteId = remoteId;
            this.Account = account;
            this.NetAmount = netAmount;
            this.TrackingCategory = trackingCategory;
            this.TrackingCategories = trackingCategories;
            this.Contact = contact;
            this.Description = description;
            this.ExchangeRate = exchangeRate;
            this.IntegrationParams = integrationParams;
            this.LinkedAccountParams = linkedAccountParams;
        }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// Gets or Sets Account
        /// </summary>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// The value of the line item including taxes and other fees.
        /// </summary>
        /// <value>The value of the line item including taxes and other fees.</value>
        [DataMember(Name = "net_amount", EmitDefaultValue = true)]
        public double? NetAmount { get; set; }

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
        /// Gets or Sets Contact
        /// </summary>
        [DataMember(Name = "contact", EmitDefaultValue = true)]
        public Guid? Contact { get; set; }

        /// <summary>
        /// The line&#39;s description.
        /// </summary>
        /// <value>The line&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The journal line item&#39;s exchange rate.
        /// </summary>
        /// <value>The journal line item&#39;s exchange rate.</value>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = true)]
        public decimal? ExchangeRate { get; set; }

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
            sb.Append("class JournalLineRequest {\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
            sb.Append("  TrackingCategory: ").Append(TrackingCategory).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  Contact: ").Append(Contact).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
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
            return this.Equals(input as JournalLineRequest);
        }

        /// <summary>
        /// Returns true if JournalLineRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalLineRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalLineRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RemoteId == input.RemoteId ||
                    (this.RemoteId != null &&
                    this.RemoteId.Equals(input.RemoteId))
                ) && 
                (
                    this.Account == input.Account ||
                    (this.Account != null &&
                    this.Account.Equals(input.Account))
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
                    this.Contact == input.Contact ||
                    (this.Contact != null &&
                    this.Contact.Equals(input.Contact))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
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
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.NetAmount != null)
                    hashCode = hashCode * 59 + this.NetAmount.GetHashCode();
                if (this.TrackingCategory != null)
                    hashCode = hashCode * 59 + this.TrackingCategory.GetHashCode();
                if (this.TrackingCategories != null)
                    hashCode = hashCode * 59 + this.TrackingCategories.GetHashCode();
                if (this.Contact != null)
                    hashCode = hashCode * 59 + this.Contact.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
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
            Regex regexExchangeRate = new Regex(@"^-?\\d{0,32}(?:\\.\\d{0,16})?$", RegexOptions.CultureInvariant);
            if (false == regexExchangeRate.Match(this.ExchangeRate).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ExchangeRate, must match a pattern of " + regexExchangeRate, new [] { "ExchangeRate" });
            }

            yield break;
        }
    }

}

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
    /// # The VendorCreditLine Object ### Description The &#x60;VendorCreditLine&#x60; object is used to represent a vendor credit&#39;s line items.  ### Usage Example Fetch from the &#x60;GET VendorCredit&#x60; endpoint and view the vendor credit&#39;s line items.
    /// </summary>
    [DataContract(Name = "VendorCreditLine")]
    public partial class VendorCreditLine : IEquatable<VendorCreditLine>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorCreditLine" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VendorCreditLine() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VendorCreditLine" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="netAmount">The full value of the credit..</param>
        /// <param name="trackingCategory">The line&#39;s associated tracking category..</param>
        /// <param name="trackingCategories">The line&#39;s associated tracking categories. (required).</param>
        /// <param name="description">The line&#39;s description..</param>
        /// <param name="account">The line&#39;s account..</param>
        /// <param name="company">The company the line belongs to..</param>
        /// <param name="exchangeRate">The vendor credit line item&#39;s exchange rate..</param>
        public VendorCreditLine(string remoteId = default(string), double? netAmount = default(double?), Guid? trackingCategory = default(Guid?), List<Guid> trackingCategories = default(List<Guid>), string description = default(string), Guid? account = default(Guid?), Guid? company = default(Guid?), decimal? exchangeRate = default(decimal?))
        {
            // to ensure "trackingCategories" is required (not null)
            this.TrackingCategories = trackingCategories ?? throw new ArgumentNullException("trackingCategories is a required property for VendorCreditLine and cannot be null");
            this.RemoteId = remoteId;
            this.NetAmount = netAmount;
            this.TrackingCategory = trackingCategory;
            this.Description = description;
            this.Account = account;
            this.Company = company;
            this.ExchangeRate = exchangeRate;
        }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// The full value of the credit.
        /// </summary>
        /// <value>The full value of the credit.</value>
        [DataMember(Name = "net_amount", EmitDefaultValue = true)]
        public double? NetAmount { get; set; }

        /// <summary>
        /// The line&#39;s associated tracking category.
        /// </summary>
        /// <value>The line&#39;s associated tracking category.</value>
        [DataMember(Name = "tracking_category", EmitDefaultValue = true)]
        public Guid? TrackingCategory { get; set; }

        /// <summary>
        /// The line&#39;s associated tracking categories.
        /// </summary>
        /// <value>The line&#39;s associated tracking categories.</value>
        [DataMember(Name = "tracking_categories", IsRequired = true, EmitDefaultValue = false)]
        public List<Guid> TrackingCategories { get; set; }

        /// <summary>
        /// The line&#39;s description.
        /// </summary>
        /// <value>The line&#39;s description.</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The line&#39;s account.
        /// </summary>
        /// <value>The line&#39;s account.</value>
        [DataMember(Name = "account", EmitDefaultValue = true)]
        public Guid? Account { get; set; }

        /// <summary>
        /// The company the line belongs to.
        /// </summary>
        /// <value>The company the line belongs to.</value>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public Guid? Company { get; set; }

        /// <summary>
        /// The vendor credit line item&#39;s exchange rate.
        /// </summary>
        /// <value>The vendor credit line item&#39;s exchange rate.</value>
        [DataMember(Name = "exchange_rate", EmitDefaultValue = true)]
        public decimal? ExchangeRate { get; set; }

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
            sb.Append("class VendorCreditLine {\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  NetAmount: ").Append(NetAmount).Append("\n");
            sb.Append("  TrackingCategory: ").Append(TrackingCategory).Append("\n");
            sb.Append("  TrackingCategories: ").Append(TrackingCategories).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Account: ").Append(Account).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  ExchangeRate: ").Append(ExchangeRate).Append("\n");
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
            return this.Equals(input as VendorCreditLine);
        }

        /// <summary>
        /// Returns true if VendorCreditLine instances are equal
        /// </summary>
        /// <param name="input">Instance of VendorCreditLine to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VendorCreditLine input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
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
                    this.ExchangeRate == input.ExchangeRate ||
                    (this.ExchangeRate != null &&
                    this.ExchangeRate.Equals(input.ExchangeRate))
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
                if (this.RemoteId != null)
                    hashCode = hashCode * 59 + this.RemoteId.GetHashCode();
                if (this.NetAmount != null)
                    hashCode = hashCode * 59 + this.NetAmount.GetHashCode();
                if (this.TrackingCategory != null)
                    hashCode = hashCode * 59 + this.TrackingCategory.GetHashCode();
                if (this.TrackingCategories != null)
                    hashCode = hashCode * 59 + this.TrackingCategories.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Account != null)
                    hashCode = hashCode * 59 + this.Account.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.ExchangeRate != null)
                    hashCode = hashCode * 59 + this.ExchangeRate.GetHashCode();
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

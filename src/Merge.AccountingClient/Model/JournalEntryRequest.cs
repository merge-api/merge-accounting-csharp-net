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
    /// # The JournalEntry Object ### Description The &#x60;JournalEntry&#x60; object is used to represent a company&#39;s journey entries.  ### Usage Example Fetch from the &#x60;GET JournalEntry&#x60; endpoint and view a company&#39;s journey entry.
    /// </summary>
    [DataContract(Name = "JournalEntryRequest")]
    public partial class JournalEntryRequest : IEquatable<JournalEntryRequest>, IValidatableObject
    {

        /// <summary>
        /// The journal&#39;s currency.
        /// </summary>
        /// <value>The journal&#39;s currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JournalEntryRequest" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="transactionDate">The journal entry&#39;s transaction date..</param>
        /// <param name="remoteCreatedAt">When the third party&#39;s journal entry was created..</param>
        /// <param name="payments">Array of &#x60;Payment&#x60; object IDs..</param>
        /// <param name="memo">The journal entry&#39;s private note..</param>
        /// <param name="currency">The journal&#39;s currency..</param>
        public JournalEntryRequest(string remoteId = default(string), DateTime? transactionDate = default(DateTime?), DateTime? remoteCreatedAt = default(DateTime?), List<Guid?> payments = default(List<Guid?>), string memo = default(string), string currency = default(string))
        {
            this.RemoteId = remoteId;
            this.TransactionDate = transactionDate;
            this.RemoteCreatedAt = remoteCreatedAt;
            this.Payments = payments;
            this.Memo = memo;
            this.Currency = currency;
        }

        /// <summary>
        /// The third-party API ID of the matching object.
        /// </summary>
        /// <value>The third-party API ID of the matching object.</value>
        [DataMember(Name = "remote_id", EmitDefaultValue = true)]
        public string RemoteId { get; set; }

        /// <summary>
        /// The journal entry&#39;s transaction date.
        /// </summary>
        /// <value>The journal entry&#39;s transaction date.</value>
        [DataMember(Name = "transaction_date", EmitDefaultValue = true)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// When the third party&#39;s journal entry was created.
        /// </summary>
        /// <value>When the third party&#39;s journal entry was created.</value>
        [DataMember(Name = "remote_created_at", EmitDefaultValue = true)]
        public DateTime? RemoteCreatedAt { get; set; }

        /// <summary>
        /// Array of &#x60;Payment&#x60; object IDs.
        /// </summary>
        /// <value>Array of &#x60;Payment&#x60; object IDs.</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public List<Guid?> Payments { get; set; }

        /// <summary>
        /// The journal entry&#39;s private note.
        /// </summary>
        /// <value>The journal entry&#39;s private note.</value>
        [DataMember(Name = "memo", EmitDefaultValue = true)]
        public string Memo { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JournalEntryRequest {\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  RemoteCreatedAt: ").Append(RemoteCreatedAt).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
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
            return this.Equals(input as JournalEntryRequest);
        }

        /// <summary>
        /// Returns true if JournalEntryRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of JournalEntryRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JournalEntryRequest input)
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
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.RemoteCreatedAt == input.RemoteCreatedAt ||
                    (this.RemoteCreatedAt != null &&
                    this.RemoteCreatedAt.Equals(input.RemoteCreatedAt))
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
                ) && 
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
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
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                if (this.RemoteCreatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteCreatedAt.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                hashCode = hashCode * 59 + this.Currency.GetHashCode();
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

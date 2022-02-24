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
    /// # The CreditNote Object ### Description The &#x60;CreditNote&#x60; object is used to represent a refund or credit of payment.  ### Usage Example Fetch from the &#x60;LIST CreditNotes&#x60; endpoint and view a company&#39;s credit notes.
    /// </summary>
    [DataContract(Name = "CreditNote")]
    public partial class CreditNote : IEquatable<CreditNote>, IValidatableObject
    {

        /// <summary>
        /// The credit note&#39;s status.
        /// </summary>
        /// <value>The credit note&#39;s status.</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public CreditNoteStatusEnum? Status { get; set; }

        /// <summary>
        /// The credit note&#39;s currency.
        /// </summary>
        /// <value>The credit note&#39;s currency.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public CurrencyEnum? Currency { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreditNote" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="transactionDate">The credit note&#39;s transaction date..</param>
        /// <param name="status">The credit note&#39;s status..</param>
        /// <param name="totalAmount">The credit note&#39;s total amount..</param>
        /// <param name="remainingCredit">The credit note&#39;s remaining credit..</param>
        /// <param name="currency">The credit note&#39;s currency..</param>
        /// <param name="remoteCreatedAt">When the third party&#39;s credit note was created..</param>
        /// <param name="remoteUpdatedAt">When the third party&#39;s credit note was updated..</param>
        /// <param name="payments">Array of &#x60;Payment&#x60; object IDs.</param>
        public CreditNote(string remoteId = default(string), DateTime? transactionDate = default(DateTime?), CreditNoteStatusEnum? status = default(CreditNoteStatusEnum?), float? totalAmount = default(float?), float? remainingCredit = default(float?), CurrencyEnum? currency = default(CurrencyEnum?), DateTime? remoteCreatedAt = default(DateTime?), DateTime? remoteUpdatedAt = default(DateTime?), List<Guid?> payments = default(List<Guid?>))
        {
            this.RemoteId = remoteId;
            this.TransactionDate = transactionDate;
            this.Status = status;
            this.TotalAmount = totalAmount;
            this.RemainingCredit = remainingCredit;
            this.Currency = currency;
            this.RemoteCreatedAt = remoteCreatedAt;
            this.RemoteUpdatedAt = remoteUpdatedAt;
            this.Payments = payments;
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
        /// The credit note&#39;s transaction date.
        /// </summary>
        /// <value>The credit note&#39;s transaction date.</value>
        [DataMember(Name = "transaction_date", EmitDefaultValue = true)]
        public DateTime? TransactionDate { get; set; }

        /// <summary>
        /// The credit note&#39;s total amount.
        /// </summary>
        /// <value>The credit note&#39;s total amount.</value>
        [DataMember(Name = "total_amount", EmitDefaultValue = true)]
        public float? TotalAmount { get; set; }

        /// <summary>
        /// The credit note&#39;s remaining credit.
        /// </summary>
        /// <value>The credit note&#39;s remaining credit.</value>
        [DataMember(Name = "remaining_credit", EmitDefaultValue = true)]
        public float? RemainingCredit { get; set; }

        /// <summary>
        /// When the third party&#39;s credit note was created.
        /// </summary>
        /// <value>When the third party&#39;s credit note was created.</value>
        [DataMember(Name = "remote_created_at", EmitDefaultValue = true)]
        public DateTime? RemoteCreatedAt { get; set; }

        /// <summary>
        /// When the third party&#39;s credit note was updated.
        /// </summary>
        /// <value>When the third party&#39;s credit note was updated.</value>
        [DataMember(Name = "remote_updated_at", EmitDefaultValue = true)]
        public DateTime? RemoteUpdatedAt { get; set; }

        /// <summary>
        /// Array of &#x60;Payment&#x60; object IDs
        /// </summary>
        /// <value>Array of &#x60;Payment&#x60; object IDs</value>
        [DataMember(Name = "payments", EmitDefaultValue = false)]
        public List<Guid?> Payments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreditNote {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  RemoteData: ").Append(RemoteData).Append("\n");
            sb.Append("  TransactionDate: ").Append(TransactionDate).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  TotalAmount: ").Append(TotalAmount).Append("\n");
            sb.Append("  RemainingCredit: ").Append(RemainingCredit).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RemoteCreatedAt: ").Append(RemoteCreatedAt).Append("\n");
            sb.Append("  RemoteUpdatedAt: ").Append(RemoteUpdatedAt).Append("\n");
            sb.Append("  Payments: ").Append(Payments).Append("\n");
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
            return this.Equals(input as CreditNote);
        }

        /// <summary>
        /// Returns true if CreditNote instances are equal
        /// </summary>
        /// <param name="input">Instance of CreditNote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreditNote input)
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
                    this.TransactionDate == input.TransactionDate ||
                    (this.TransactionDate != null &&
                    this.TransactionDate.Equals(input.TransactionDate))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.TotalAmount == input.TotalAmount ||
                    (this.TotalAmount != null &&
                    this.TotalAmount.Equals(input.TotalAmount))
                ) && 
                (
                    this.RemainingCredit == input.RemainingCredit ||
                    (this.RemainingCredit != null &&
                    this.RemainingCredit.Equals(input.RemainingCredit))
                ) && 
                (
                    this.Currency == input.Currency ||
                    this.Currency.Equals(input.Currency)
                ) && 
                (
                    this.RemoteCreatedAt == input.RemoteCreatedAt ||
                    (this.RemoteCreatedAt != null &&
                    this.RemoteCreatedAt.Equals(input.RemoteCreatedAt))
                ) && 
                (
                    this.RemoteUpdatedAt == input.RemoteUpdatedAt ||
                    (this.RemoteUpdatedAt != null &&
                    this.RemoteUpdatedAt.Equals(input.RemoteUpdatedAt))
                ) && 
                (
                    this.Payments == input.Payments ||
                    this.Payments != null &&
                    input.Payments != null &&
                    this.Payments.SequenceEqual(input.Payments)
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
                if (this.TransactionDate != null)
                    hashCode = hashCode * 59 + this.TransactionDate.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.TotalAmount != null)
                    hashCode = hashCode * 59 + this.TotalAmount.GetHashCode();
                if (this.RemainingCredit != null)
                    hashCode = hashCode * 59 + this.RemainingCredit.GetHashCode();
                hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.RemoteCreatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteCreatedAt.GetHashCode();
                if (this.RemoteUpdatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteUpdatedAt.GetHashCode();
                if (this.Payments != null)
                    hashCode = hashCode * 59 + this.Payments.GetHashCode();
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

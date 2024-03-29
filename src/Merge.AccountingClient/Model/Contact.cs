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
    /// # The Contact Object ### Description The &#x60;Contact&#x60; object refers to either a supplier or a customer.  ### Usage Example Fetch from the &#x60;LIST Contacts&#x60; endpoint and view a company&#39;s contacts.
    /// </summary>
    [DataContract(Name = "Contact")]
    public partial class Contact : IEquatable<Contact>, IValidatableObject
    {

        /// <summary>
        /// The contact&#39;s status  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;ARCHIVED&#x60; - ARCHIVED
        /// </summary>
        /// <value>The contact&#39;s status  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;ARCHIVED&#x60; - ARCHIVED</value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public Status7d1Enum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Contact" /> class.
        /// </summary>
        /// <param name="remoteId">The third-party API ID of the matching object..</param>
        /// <param name="name">The contact&#39;s name..</param>
        /// <param name="isSupplier">Whether the contact is a supplier..</param>
        /// <param name="isCustomer">Whether the contact is a customer..</param>
        /// <param name="emailAddress">The contact&#39;s email address..</param>
        /// <param name="taxNumber">The contact&#39;s tax number..</param>
        /// <param name="status">The contact&#39;s status  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;ARCHIVED&#x60; - ARCHIVED.</param>
        /// <param name="currency">The currency the contact&#39;s transactions are in..</param>
        /// <param name="remoteUpdatedAt">When the third party&#39;s contact was updated..</param>
        /// <param name="company">The company the contact belongs to..</param>
        /// <param name="addresses">&#x60;Address&#x60; object IDs for the given &#x60;Contacts&#x60; object..</param>
        /// <param name="phoneNumbers">&#x60;AccountingPhoneNumber&#x60; object for the given &#x60;Contacts&#x60; object..</param>
        public Contact(string remoteId = default(string), string name = default(string), bool? isSupplier = default(bool?), bool? isCustomer = default(bool?), string emailAddress = default(string), string taxNumber = default(string), Status7d1Enum? status = default(Status7d1Enum?), string currency = default(string), DateTime? remoteUpdatedAt = default(DateTime?), Guid? company = default(Guid?), List<Guid?> addresses = default(List<Guid?>), List<AccountingPhoneNumber> phoneNumbers = default(List<AccountingPhoneNumber>))
        {
            this.RemoteId = remoteId;
            this.Name = name;
            this.IsSupplier = isSupplier;
            this.IsCustomer = isCustomer;
            this.EmailAddress = emailAddress;
            this.TaxNumber = taxNumber;
            this.Status = status;
            this.Currency = currency;
            this.RemoteUpdatedAt = remoteUpdatedAt;
            this.Company = company;
            this.Addresses = addresses;
            this.PhoneNumbers = phoneNumbers;
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
        /// The contact&#39;s name.
        /// </summary>
        /// <value>The contact&#39;s name.</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Whether the contact is a supplier.
        /// </summary>
        /// <value>Whether the contact is a supplier.</value>
        [DataMember(Name = "is_supplier", EmitDefaultValue = true)]
        public bool? IsSupplier { get; set; }

        /// <summary>
        /// Whether the contact is a customer.
        /// </summary>
        /// <value>Whether the contact is a customer.</value>
        [DataMember(Name = "is_customer", EmitDefaultValue = true)]
        public bool? IsCustomer { get; set; }

        /// <summary>
        /// The contact&#39;s email address.
        /// </summary>
        /// <value>The contact&#39;s email address.</value>
        [DataMember(Name = "email_address", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The contact&#39;s tax number.
        /// </summary>
        /// <value>The contact&#39;s tax number.</value>
        [DataMember(Name = "tax_number", EmitDefaultValue = true)]
        public string TaxNumber { get; set; }

        /// <summary>
        /// The currency the contact&#39;s transactions are in.
        /// </summary>
        /// <value>The currency the contact&#39;s transactions are in.</value>
        [DataMember(Name = "currency", EmitDefaultValue = true)]
        public string Currency { get; set; }

        /// <summary>
        /// When the third party&#39;s contact was updated.
        /// </summary>
        /// <value>When the third party&#39;s contact was updated.</value>
        [DataMember(Name = "remote_updated_at", EmitDefaultValue = true)]
        public DateTime? RemoteUpdatedAt { get; set; }

        /// <summary>
        /// The company the contact belongs to.
        /// </summary>
        /// <value>The company the contact belongs to.</value>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public Guid? Company { get; set; }

        /// <summary>
        /// &#x60;Address&#x60; object IDs for the given &#x60;Contacts&#x60; object.
        /// </summary>
        /// <value>&#x60;Address&#x60; object IDs for the given &#x60;Contacts&#x60; object.</value>
        [DataMember(Name = "addresses", EmitDefaultValue = false)]
        public List<Guid?> Addresses { get; set; }

        /// <summary>
        /// &#x60;AccountingPhoneNumber&#x60; object for the given &#x60;Contacts&#x60; object.
        /// </summary>
        /// <value>&#x60;AccountingPhoneNumber&#x60; object for the given &#x60;Contacts&#x60; object.</value>
        [DataMember(Name = "phone_numbers", EmitDefaultValue = false)]
        public List<AccountingPhoneNumber> PhoneNumbers { get; set; }

        /// <summary>
        /// Indicates whether or not this object has been deleted by third party webhooks.
        /// </summary>
        /// <value>Indicates whether or not this object has been deleted by third party webhooks.</value>
        [DataMember(Name = "remote_was_deleted", EmitDefaultValue = true)]
        public bool RemoteWasDeleted { get; private set; }

        /// <summary>
        /// Returns false as RemoteWasDeleted should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeRemoteWasDeleted()
        {
            return false;
        }

        /// <summary>
        /// Gets or Sets FieldMappings
        /// </summary>
        [DataMember(Name = "field_mappings", EmitDefaultValue = true)]
        public Dictionary<string, Object> FieldMappings { get; private set; }

        /// <summary>
        /// Returns false as FieldMappings should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeFieldMappings()
        {
            return false;
        }

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
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Contact {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  RemoteId: ").Append(RemoteId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  IsSupplier: ").Append(IsSupplier).Append("\n");
            sb.Append("  IsCustomer: ").Append(IsCustomer).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  TaxNumber: ").Append(TaxNumber).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  RemoteUpdatedAt: ").Append(RemoteUpdatedAt).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  Addresses: ").Append(Addresses).Append("\n");
            sb.Append("  PhoneNumbers: ").Append(PhoneNumbers).Append("\n");
            sb.Append("  RemoteWasDeleted: ").Append(RemoteWasDeleted).Append("\n");
            sb.Append("  FieldMappings: ").Append(FieldMappings).Append("\n");
            sb.Append("  ModifiedAt: ").Append(ModifiedAt).Append("\n");
            sb.Append("  RemoteData: ").Append(RemoteData).Append("\n");
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
            return this.Equals(input as Contact);
        }

        /// <summary>
        /// Returns true if Contact instances are equal
        /// </summary>
        /// <param name="input">Instance of Contact to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Contact input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.IsSupplier == input.IsSupplier ||
                    (this.IsSupplier != null &&
                    this.IsSupplier.Equals(input.IsSupplier))
                ) && 
                (
                    this.IsCustomer == input.IsCustomer ||
                    (this.IsCustomer != null &&
                    this.IsCustomer.Equals(input.IsCustomer))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.TaxNumber == input.TaxNumber ||
                    (this.TaxNumber != null &&
                    this.TaxNumber.Equals(input.TaxNumber))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.RemoteUpdatedAt == input.RemoteUpdatedAt ||
                    (this.RemoteUpdatedAt != null &&
                    this.RemoteUpdatedAt.Equals(input.RemoteUpdatedAt))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.Addresses == input.Addresses ||
                    this.Addresses != null &&
                    input.Addresses != null &&
                    this.Addresses.SequenceEqual(input.Addresses)
                ) && 
                (
                    this.PhoneNumbers == input.PhoneNumbers ||
                    this.PhoneNumbers != null &&
                    input.PhoneNumbers != null &&
                    this.PhoneNumbers.SequenceEqual(input.PhoneNumbers)
                ) && 
                (
                    this.RemoteWasDeleted == input.RemoteWasDeleted ||
                    this.RemoteWasDeleted.Equals(input.RemoteWasDeleted)
                ) && 
                (
                    this.FieldMappings == input.FieldMappings ||
                    this.FieldMappings != null &&
                    input.FieldMappings != null &&
                    this.FieldMappings.SequenceEqual(input.FieldMappings)
                ) && 
                (
                    this.ModifiedAt == input.ModifiedAt ||
                    (this.ModifiedAt != null &&
                    this.ModifiedAt.Equals(input.ModifiedAt))
                ) && 
                (
                    this.RemoteData == input.RemoteData ||
                    this.RemoteData != null &&
                    input.RemoteData != null &&
                    this.RemoteData.SequenceEqual(input.RemoteData)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.IsSupplier != null)
                    hashCode = hashCode * 59 + this.IsSupplier.GetHashCode();
                if (this.IsCustomer != null)
                    hashCode = hashCode * 59 + this.IsCustomer.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.TaxNumber != null)
                    hashCode = hashCode * 59 + this.TaxNumber.GetHashCode();
                hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.RemoteUpdatedAt != null)
                    hashCode = hashCode * 59 + this.RemoteUpdatedAt.GetHashCode();
                if (this.Company != null)
                    hashCode = hashCode * 59 + this.Company.GetHashCode();
                if (this.Addresses != null)
                    hashCode = hashCode * 59 + this.Addresses.GetHashCode();
                if (this.PhoneNumbers != null)
                    hashCode = hashCode * 59 + this.PhoneNumbers.GetHashCode();
                hashCode = hashCode * 59 + this.RemoteWasDeleted.GetHashCode();
                if (this.FieldMappings != null)
                    hashCode = hashCode * 59 + this.FieldMappings.GetHashCode();
                if (this.ModifiedAt != null)
                    hashCode = hashCode * 59 + this.ModifiedAt.GetHashCode();
                if (this.RemoteData != null)
                    hashCode = hashCode * 59 + this.RemoteData.GetHashCode();
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

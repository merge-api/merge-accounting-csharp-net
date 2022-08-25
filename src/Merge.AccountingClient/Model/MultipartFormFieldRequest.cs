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
    /// # The MultipartFormField Object ### Description The &#x60;MultipartFormField&#x60; object is used to represent fields in an HTTP request using &#x60;multipart/form-data&#x60;.  ### Usage Example Create a &#x60;MultipartFormField&#x60; to define a multipart form entry.
    /// </summary>
    [DataContract(Name = "MultipartFormFieldRequest")]
    public partial class MultipartFormFieldRequest : IEquatable<MultipartFormFieldRequest>, IValidatableObject
    {

        /// <summary>
        /// The encoding of the value of &#x60;data&#x60;. Defaults to &#x60;RAW&#x60; if not defined.
        /// </summary>
        /// <value>The encoding of the value of &#x60;data&#x60;. Defaults to &#x60;RAW&#x60; if not defined.</value>
        [DataMember(Name = "encoding", EmitDefaultValue = true)]
        public string Encoding { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartFormFieldRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultipartFormFieldRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultipartFormFieldRequest" /> class.
        /// </summary>
        /// <param name="name">The name of the form field (required).</param>
        /// <param name="data">The data for the form field. (required).</param>
        /// <param name="encoding">The encoding of the value of &#x60;data&#x60;. Defaults to &#x60;RAW&#x60; if not defined..</param>
        /// <param name="fileName">The file name of the form field, if the field is for a file..</param>
        /// <param name="contentType">The MIME type of the file, if the field is for a file..</param>
        public MultipartFormFieldRequest(string name = default(string), string data = default(string), string encoding = default(string), string fileName = default(string), string contentType = default(string))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for MultipartFormFieldRequest and cannot be null");
            // to ensure "data" is required (not null)
            this.Data = data ?? throw new ArgumentNullException("data is a required property for MultipartFormFieldRequest and cannot be null");
            this.Encoding = encoding;
            this.FileName = fileName;
            this.ContentType = contentType;
        }

        /// <summary>
        /// The name of the form field
        /// </summary>
        /// <value>The name of the form field</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// The data for the form field.
        /// </summary>
        /// <value>The data for the form field.</value>
        [DataMember(Name = "data", IsRequired = true, EmitDefaultValue = false)]
        public string Data { get; set; }

        /// <summary>
        /// The file name of the form field, if the field is for a file.
        /// </summary>
        /// <value>The file name of the form field, if the field is for a file.</value>
        [DataMember(Name = "file_name", EmitDefaultValue = true)]
        public string FileName { get; set; }

        /// <summary>
        /// The MIME type of the file, if the field is for a file.
        /// </summary>
        /// <value>The MIME type of the file, if the field is for a file.</value>
        [DataMember(Name = "content_type", EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultipartFormFieldRequest {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Encoding: ").Append(Encoding).Append("\n");
            sb.Append("  FileName: ").Append(FileName).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
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
            return this.Equals(input as MultipartFormFieldRequest);
        }

        /// <summary>
        /// Returns true if MultipartFormFieldRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of MultipartFormFieldRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultipartFormFieldRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Data == input.Data ||
                    (this.Data != null &&
                    this.Data.Equals(input.Data))
                ) && 
                (
                    this.Encoding == input.Encoding ||
                    this.Encoding.Equals(input.Encoding)
                ) && 
                (
                    this.FileName == input.FileName ||
                    (this.FileName != null &&
                    this.FileName.Equals(input.FileName))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                hashCode = hashCode * 59 + this.Encoding.GetHashCode();
                if (this.FileName != null)
                    hashCode = hashCode * 59 + this.FileName.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
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
            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }

            // Data (string) minLength
            if(this.Data != null && this.Data.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Data, length must be greater than 1.", new [] { "Data" });
            }

            // FileName (string) minLength
            if(this.FileName != null && this.FileName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for FileName, length must be greater than 1.", new [] { "FileName" });
            }

            // ContentType (string) minLength
            if(this.ContentType != null && this.ContentType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ContentType, length must be greater than 1.", new [] { "ContentType" });
            }

            yield break;
        }
    }

}

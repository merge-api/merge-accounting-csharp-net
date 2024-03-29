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
    /// PurchaseOrderResponse
    /// </summary>
    [DataContract(Name = "PurchaseOrderResponse")]
    public partial class PurchaseOrderResponse : IEquatable<PurchaseOrderResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PurchaseOrderResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PurchaseOrderResponse" /> class.
        /// </summary>
        /// <param name="model">model (required).</param>
        /// <param name="warnings">warnings (required).</param>
        /// <param name="errors">errors (required).</param>
        /// <param name="logs">logs.</param>
        public PurchaseOrderResponse(PurchaseOrder model = default(PurchaseOrder), List<WarningValidationProblem> warnings = default(List<WarningValidationProblem>), List<ErrorValidationProblem> errors = default(List<ErrorValidationProblem>), List<DebugModeLog> logs = default(List<DebugModeLog>))
        {
            // to ensure "model" is required (not null)
            this.Model = model ?? throw new ArgumentNullException("model is a required property for PurchaseOrderResponse and cannot be null");
            // to ensure "warnings" is required (not null)
            this.Warnings = warnings ?? throw new ArgumentNullException("warnings is a required property for PurchaseOrderResponse and cannot be null");
            // to ensure "errors" is required (not null)
            this.Errors = errors ?? throw new ArgumentNullException("errors is a required property for PurchaseOrderResponse and cannot be null");
            this.Logs = logs;
        }

        /// <summary>
        /// Gets or Sets Model
        /// </summary>
        [DataMember(Name = "model", IsRequired = true, EmitDefaultValue = false)]
        public PurchaseOrder Model { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", IsRequired = true, EmitDefaultValue = false)]
        public List<WarningValidationProblem> Warnings { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = false)]
        public List<ErrorValidationProblem> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Logs
        /// </summary>
        [DataMember(Name = "logs", EmitDefaultValue = false)]
        public List<DebugModeLog> Logs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PurchaseOrderResponse {\n");
            sb.Append("  Model: ").Append(Model).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Logs: ").Append(Logs).Append("\n");
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
            return this.Equals(input as PurchaseOrderResponse);
        }

        /// <summary>
        /// Returns true if PurchaseOrderResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of PurchaseOrderResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PurchaseOrderResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Model == input.Model ||
                    (this.Model != null &&
                    this.Model.Equals(input.Model))
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Logs == input.Logs ||
                    this.Logs != null &&
                    input.Logs != null &&
                    this.Logs.SequenceEqual(input.Logs)
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
                if (this.Model != null)
                    hashCode = hashCode * 59 + this.Model.GetHashCode();
                if (this.Warnings != null)
                    hashCode = hashCode * 59 + this.Warnings.GetHashCode();
                if (this.Errors != null)
                    hashCode = hashCode * 59 + this.Errors.GetHashCode();
                if (this.Logs != null)
                    hashCode = hashCode * 59 + this.Logs.GetHashCode();
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

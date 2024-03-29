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
    /// AccountIntegration
    /// </summary>
    [DataContract(Name = "AccountIntegration")]
    public partial class AccountIntegration : IEquatable<AccountIntegration>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIntegration" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountIntegration() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountIntegration" /> class.
        /// </summary>
        /// <param name="name">Company name. (required).</param>
        /// <param name="categories">Category or categories this integration belongs to. Multiple categories should be comma separated, i.e. [ats, hris]..</param>
        /// <param name="image">Company logo in rectangular shape. &lt;b&gt;Upload an image with a clear background.&lt;/b&gt;.</param>
        /// <param name="squareImage">Company logo in square shape. &lt;b&gt;Upload an image with a white background.&lt;/b&gt;.</param>
        /// <param name="color">The color of this integration used for buttons and text throughout the app and landing pages. &lt;b&gt;Choose a darker, saturated color.&lt;/b&gt;.</param>
        /// <param name="isInBeta">If checked, this integration will not appear in the linking flow, and will appear elsewhere with a Beta tag..</param>
        /// <param name="apiEndpointsToDocumentationUrls">Mapping of API endpoints to documentation urls for support. Example: {&#39;GET&#39;: [[&#39;/common-model-scopes&#39;, &#39;https://docs.merge.dev/accounting/common-model-scopes/#common_model_scopes_retrieve&#39;],[&#39;/common-model-actions&#39;, &#39;https://docs.merge.dev/accounting/common-model-actions/#common_model_actions_retrieve&#39;]], &#39;POST&#39;: []}.</param>
        public AccountIntegration(string name = default(string), List<CategoriesEnum> categories = default(List<CategoriesEnum>), string image = default(string), string squareImage = default(string), string color = default(string), bool isInBeta = default(bool), Dictionary<string, Object> apiEndpointsToDocumentationUrls = default(Dictionary<string, Object>))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for AccountIntegration and cannot be null");
            this.Categories = categories;
            this.Image = image;
            this.SquareImage = squareImage;
            this.Color = color;
            this.IsInBeta = isInBeta;
            this.ApiEndpointsToDocumentationUrls = apiEndpointsToDocumentationUrls;
        }

        /// <summary>
        /// Company name.
        /// </summary>
        /// <value>Company name.</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Category or categories this integration belongs to. Multiple categories should be comma separated, i.e. [ats, hris].
        /// </summary>
        /// <value>Category or categories this integration belongs to. Multiple categories should be comma separated, i.e. [ats, hris].</value>
        [DataMember(Name = "categories", EmitDefaultValue = false)]
        public List<CategoriesEnum> Categories { get; set; }

        /// <summary>
        /// Company logo in rectangular shape. &lt;b&gt;Upload an image with a clear background.&lt;/b&gt;
        /// </summary>
        /// <value>Company logo in rectangular shape. &lt;b&gt;Upload an image with a clear background.&lt;/b&gt;</value>
        [DataMember(Name = "image", EmitDefaultValue = true)]
        public string Image { get; set; }

        /// <summary>
        /// Company logo in square shape. &lt;b&gt;Upload an image with a white background.&lt;/b&gt;
        /// </summary>
        /// <value>Company logo in square shape. &lt;b&gt;Upload an image with a white background.&lt;/b&gt;</value>
        [DataMember(Name = "square_image", EmitDefaultValue = true)]
        public string SquareImage { get; set; }

        /// <summary>
        /// The color of this integration used for buttons and text throughout the app and landing pages. &lt;b&gt;Choose a darker, saturated color.&lt;/b&gt;
        /// </summary>
        /// <value>The color of this integration used for buttons and text throughout the app and landing pages. &lt;b&gt;Choose a darker, saturated color.&lt;/b&gt;</value>
        [DataMember(Name = "color", EmitDefaultValue = false)]
        public string Color { get; set; }

        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", EmitDefaultValue = false)]
        public string Slug { get; private set; }

        /// <summary>
        /// Returns false as Slug should not be serialized given that it's read-only.
        /// </summary>
        /// <returns>false (boolean)</returns>
        public bool ShouldSerializeSlug()
        {
            return false;
        }

        /// <summary>
        /// If checked, this integration will not appear in the linking flow, and will appear elsewhere with a Beta tag.
        /// </summary>
        /// <value>If checked, this integration will not appear in the linking flow, and will appear elsewhere with a Beta tag.</value>
        [DataMember(Name = "is_in_beta", EmitDefaultValue = true)]
        public bool IsInBeta { get; set; }

        /// <summary>
        /// Mapping of API endpoints to documentation urls for support. Example: {&#39;GET&#39;: [[&#39;/common-model-scopes&#39;, &#39;https://docs.merge.dev/accounting/common-model-scopes/#common_model_scopes_retrieve&#39;],[&#39;/common-model-actions&#39;, &#39;https://docs.merge.dev/accounting/common-model-actions/#common_model_actions_retrieve&#39;]], &#39;POST&#39;: []}
        /// </summary>
        /// <value>Mapping of API endpoints to documentation urls for support. Example: {&#39;GET&#39;: [[&#39;/common-model-scopes&#39;, &#39;https://docs.merge.dev/accounting/common-model-scopes/#common_model_scopes_retrieve&#39;],[&#39;/common-model-actions&#39;, &#39;https://docs.merge.dev/accounting/common-model-actions/#common_model_actions_retrieve&#39;]], &#39;POST&#39;: []}</value>
        [DataMember(Name = "api_endpoints_to_documentation_urls", EmitDefaultValue = false)]
        public Dictionary<string, Object> ApiEndpointsToDocumentationUrls { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountIntegration {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Categories: ").Append(Categories).Append("\n");
            sb.Append("  Image: ").Append(Image).Append("\n");
            sb.Append("  SquareImage: ").Append(SquareImage).Append("\n");
            sb.Append("  Color: ").Append(Color).Append("\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  IsInBeta: ").Append(IsInBeta).Append("\n");
            sb.Append("  ApiEndpointsToDocumentationUrls: ").Append(ApiEndpointsToDocumentationUrls).Append("\n");
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
            return this.Equals(input as AccountIntegration);
        }

        /// <summary>
        /// Returns true if AccountIntegration instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountIntegration to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountIntegration input)
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
                    this.Categories == input.Categories ||
                    this.Categories != null &&
                    input.Categories != null &&
                    this.Categories.SequenceEqual(input.Categories)
                ) && 
                (
                    this.Image == input.Image ||
                    (this.Image != null &&
                    this.Image.Equals(input.Image))
                ) && 
                (
                    this.SquareImage == input.SquareImage ||
                    (this.SquareImage != null &&
                    this.SquareImage.Equals(input.SquareImage))
                ) && 
                (
                    this.Color == input.Color ||
                    (this.Color != null &&
                    this.Color.Equals(input.Color))
                ) && 
                (
                    this.Slug == input.Slug ||
                    (this.Slug != null &&
                    this.Slug.Equals(input.Slug))
                ) && 
                (
                    this.IsInBeta == input.IsInBeta ||
                    this.IsInBeta.Equals(input.IsInBeta)
                ) && 
                (
                    this.ApiEndpointsToDocumentationUrls == input.ApiEndpointsToDocumentationUrls ||
                    this.ApiEndpointsToDocumentationUrls != null &&
                    input.ApiEndpointsToDocumentationUrls != null &&
                    this.ApiEndpointsToDocumentationUrls.SequenceEqual(input.ApiEndpointsToDocumentationUrls)
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
                if (this.Categories != null)
                    hashCode = hashCode * 59 + this.Categories.GetHashCode();
                if (this.Image != null)
                    hashCode = hashCode * 59 + this.Image.GetHashCode();
                if (this.SquareImage != null)
                    hashCode = hashCode * 59 + this.SquareImage.GetHashCode();
                if (this.Color != null)
                    hashCode = hashCode * 59 + this.Color.GetHashCode();
                if (this.Slug != null)
                    hashCode = hashCode * 59 + this.Slug.GetHashCode();
                hashCode = hashCode * 59 + this.IsInBeta.GetHashCode();
                if (this.ApiEndpointsToDocumentationUrls != null)
                    hashCode = hashCode * 59 + this.ApiEndpointsToDocumentationUrls.GetHashCode();
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
            // Color (string) maxLength
            if(this.Color != null && this.Color.Length > 18)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, length must be less than 18.", new [] { "Color" });
            }

            // Color (string) pattern
            Regex regexColor = new Regex(@"^#([A-Fa-f0-9]{6}|[A-Fa-f0-9]{3})$", RegexOptions.CultureInvariant);
            if (false == regexColor.Match(this.Color.ToString()).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Color, must match a pattern of " + regexColor, new [] { "Color" });
            }

            yield break;
        }
    }

}

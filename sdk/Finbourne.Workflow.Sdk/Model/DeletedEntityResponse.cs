/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.209
 * Contact: info@finbourne.com
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
using OpenAPIDateConverter = Finbourne.Workflow.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Workflow.Sdk.Model
{
    /// <summary>
    /// DeletedEntityResponse
    /// </summary>
    [DataContract(Name = "DeletedEntityResponse")]
    public partial class DeletedEntityResponse : IEquatable<DeletedEntityResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedEntityResponse" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DeletedEntityResponse() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedEntityResponse" /> class.
        /// </summary>
        /// <param name="href">The Uri related to this Entity.</param>
        /// <param name="effectiveFrom">The EffectiveFrom for this response.</param>
        /// <param name="asAt">The AsAt for this response (required).</param>
        /// <param name="links">links.</param>
        public DeletedEntityResponse(string href = default(string), DateTimeOffset? effectiveFrom = default(DateTimeOffset?), DateTimeOffset asAt = default(DateTimeOffset), List<Link> links = default(List<Link>))
        {
            this.AsAt = asAt;
            this.Href = href;
            this.EffectiveFrom = effectiveFrom;
            this.Links = links;
        }

        /// <summary>
        /// The Uri related to this Entity
        /// </summary>
        /// <value>The Uri related to this Entity</value>
        [DataMember(Name = "href", EmitDefaultValue = true)]
        public string Href { get; set; }

        /// <summary>
        /// The EffectiveFrom for this response
        /// </summary>
        /// <value>The EffectiveFrom for this response</value>
        [DataMember(Name = "effectiveFrom", EmitDefaultValue = true)]
        public DateTimeOffset? EffectiveFrom { get; set; }

        /// <summary>
        /// The AsAt for this response
        /// </summary>
        /// <value>The AsAt for this response</value>
        [DataMember(Name = "asAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTimeOffset AsAt { get; set; }

        /// <summary>
        /// Gets or Sets Links
        /// </summary>
        [DataMember(Name = "links", EmitDefaultValue = true)]
        public List<Link> Links { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DeletedEntityResponse {\n");
            sb.Append("  Href: ").Append(Href).Append("\n");
            sb.Append("  EffectiveFrom: ").Append(EffectiveFrom).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  Links: ").Append(Links).Append("\n");
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
            return this.Equals(input as DeletedEntityResponse);
        }

        /// <summary>
        /// Returns true if DeletedEntityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of DeletedEntityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DeletedEntityResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Href == input.Href ||
                    (this.Href != null &&
                    this.Href.Equals(input.Href))
                ) && 
                (
                    this.EffectiveFrom == input.EffectiveFrom ||
                    (this.EffectiveFrom != null &&
                    this.EffectiveFrom.Equals(input.EffectiveFrom))
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.Links == input.Links ||
                    this.Links != null &&
                    input.Links != null &&
                    this.Links.SequenceEqual(input.Links)
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
                if (this.Href != null)
                    hashCode = hashCode * 59 + this.Href.GetHashCode();
                if (this.EffectiveFrom != null)
                    hashCode = hashCode * 59 + this.EffectiveFrom.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}
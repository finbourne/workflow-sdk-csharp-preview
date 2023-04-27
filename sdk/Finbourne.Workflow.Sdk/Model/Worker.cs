/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.233
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
    /// Information about the Worker
    /// </summary>
    [DataContract(Name = "Worker")]
    public partial class Worker : IEquatable<Worker>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Worker" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Worker() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Worker" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="displayName">Human readable name (required).</param>
        /// <param name="description">Human readable description.</param>
        /// <param name="workerConfiguration">workerConfiguration (required).</param>
        /// <param name="version">version.</param>
        /// <param name="links">links.</param>
        public Worker(ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), WorkerConfiguration workerConfiguration = default(WorkerConfiguration), Version version = default(Version), List<Link> links = default(List<Link>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for Worker and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for Worker and cannot be null");
            // to ensure "workerConfiguration" is required (not null)
            this.WorkerConfiguration = workerConfiguration ?? throw new ArgumentNullException("workerConfiguration is a required property for Worker and cannot be null");
            this.Description = description;
            this.Version = version;
            this.Links = links;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Human readable name
        /// </summary>
        /// <value>Human readable name</value>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Human readable description
        /// </summary>
        /// <value>Human readable description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets WorkerConfiguration
        /// </summary>
        [DataMember(Name = "workerConfiguration", IsRequired = true, EmitDefaultValue = false)]
        public WorkerConfiguration WorkerConfiguration { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

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
            sb.Append("class Worker {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  WorkerConfiguration: ").Append(WorkerConfiguration).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as Worker);
        }

        /// <summary>
        /// Returns true if Worker instances are equal
        /// </summary>
        /// <param name="input">Instance of Worker to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Worker input)
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
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.WorkerConfiguration == input.WorkerConfiguration ||
                    (this.WorkerConfiguration != null &&
                    this.WorkerConfiguration.Equals(input.WorkerConfiguration))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.WorkerConfiguration != null)
                    hashCode = hashCode * 59 + this.WorkerConfiguration.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.Links != null)
                    hashCode = hashCode * 59 + this.Links.GetHashCode();
                return hashCode;
            }
        }

    }
}

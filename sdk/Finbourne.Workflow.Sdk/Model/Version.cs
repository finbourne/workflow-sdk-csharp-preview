/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.252
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
    /// The version metadata.
    /// </summary>
    [DataContract(Name = "Version")]
    public partial class Version : IEquatable<Version>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Version" /> class.
        /// </summary>
        /// <param name="asAtCreated">The asAt datetime at which this entity was first created..</param>
        /// <param name="userIdCreated">The unique id of the user who created this entity..</param>
        /// <param name="asAtModified">The asAt datetime at which this entity was last updated..</param>
        /// <param name="userIdModified">The unique id of the user who last updated this entity..</param>
        /// <param name="asAtVersionNumber">The integer version number for this entity (the entity was created at version 1)..</param>
        public Version(DateTimeOffset? asAtCreated = default(DateTimeOffset?), string userIdCreated = default(string), DateTimeOffset? asAtModified = default(DateTimeOffset?), string userIdModified = default(string), int? asAtVersionNumber = default(int?))
        {
            this.AsAtCreated = asAtCreated;
            this.UserIdCreated = userIdCreated;
            this.AsAtModified = asAtModified;
            this.UserIdModified = userIdModified;
            this.AsAtVersionNumber = asAtVersionNumber;
        }

        /// <summary>
        /// The asAt datetime at which this entity was first created.
        /// </summary>
        /// <value>The asAt datetime at which this entity was first created.</value>
        [DataMember(Name = "asAtCreated", EmitDefaultValue = true)]
        public DateTimeOffset? AsAtCreated { get; set; }

        /// <summary>
        /// The unique id of the user who created this entity.
        /// </summary>
        /// <value>The unique id of the user who created this entity.</value>
        [DataMember(Name = "userIdCreated", EmitDefaultValue = true)]
        public string UserIdCreated { get; set; }

        /// <summary>
        /// The asAt datetime at which this entity was last updated.
        /// </summary>
        /// <value>The asAt datetime at which this entity was last updated.</value>
        [DataMember(Name = "asAtModified", EmitDefaultValue = true)]
        public DateTimeOffset? AsAtModified { get; set; }

        /// <summary>
        /// The unique id of the user who last updated this entity.
        /// </summary>
        /// <value>The unique id of the user who last updated this entity.</value>
        [DataMember(Name = "userIdModified", EmitDefaultValue = true)]
        public string UserIdModified { get; set; }

        /// <summary>
        /// The integer version number for this entity (the entity was created at version 1).
        /// </summary>
        /// <value>The integer version number for this entity (the entity was created at version 1).</value>
        [DataMember(Name = "asAtVersionNumber", EmitDefaultValue = true)]
        public int? AsAtVersionNumber { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Version {\n");
            sb.Append("  AsAtCreated: ").Append(AsAtCreated).Append("\n");
            sb.Append("  UserIdCreated: ").Append(UserIdCreated).Append("\n");
            sb.Append("  AsAtModified: ").Append(AsAtModified).Append("\n");
            sb.Append("  UserIdModified: ").Append(UserIdModified).Append("\n");
            sb.Append("  AsAtVersionNumber: ").Append(AsAtVersionNumber).Append("\n");
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
            return this.Equals(input as Version);
        }

        /// <summary>
        /// Returns true if Version instances are equal
        /// </summary>
        /// <param name="input">Instance of Version to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Version input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsAtCreated == input.AsAtCreated ||
                    (this.AsAtCreated != null &&
                    this.AsAtCreated.Equals(input.AsAtCreated))
                ) && 
                (
                    this.UserIdCreated == input.UserIdCreated ||
                    (this.UserIdCreated != null &&
                    this.UserIdCreated.Equals(input.UserIdCreated))
                ) && 
                (
                    this.AsAtModified == input.AsAtModified ||
                    (this.AsAtModified != null &&
                    this.AsAtModified.Equals(input.AsAtModified))
                ) && 
                (
                    this.UserIdModified == input.UserIdModified ||
                    (this.UserIdModified != null &&
                    this.UserIdModified.Equals(input.UserIdModified))
                ) && 
                (
                    this.AsAtVersionNumber == input.AsAtVersionNumber ||
                    (this.AsAtVersionNumber != null &&
                    this.AsAtVersionNumber.Equals(input.AsAtVersionNumber))
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
                if (this.AsAtCreated != null)
                    hashCode = hashCode * 59 + this.AsAtCreated.GetHashCode();
                if (this.UserIdCreated != null)
                    hashCode = hashCode * 59 + this.UserIdCreated.GetHashCode();
                if (this.AsAtModified != null)
                    hashCode = hashCode * 59 + this.AsAtModified.GetHashCode();
                if (this.UserIdModified != null)
                    hashCode = hashCode * 59 + this.UserIdModified.GetHashCode();
                if (this.AsAtVersionNumber != null)
                    hashCode = hashCode * 59 + this.AsAtVersionNumber.GetHashCode();
                return hashCode;
            }
        }

    }
}

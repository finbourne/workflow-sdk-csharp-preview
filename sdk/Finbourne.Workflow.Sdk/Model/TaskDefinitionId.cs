/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.160
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
    /// Identification for a Task Definition
    /// </summary>
    [DataContract(Name = "TaskDefinitionId")]
    public partial class TaskDefinitionId : IEquatable<TaskDefinitionId>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDefinitionId" /> class.
        /// </summary>
        /// <param name="scope">Identifer.</param>
        /// <param name="code">Human readable Key.</param>
        /// <param name="version">Numeric versioning support.</param>
        public TaskDefinitionId(string scope = default(string), string code = default(string), long version = default(long))
        {
            this.Scope = scope;
            this.Code = code;
            this.Version = version;
        }

        /// <summary>
        /// Identifer
        /// </summary>
        /// <value>Identifer</value>
        [DataMember(Name = "scope", EmitDefaultValue = true)]
        public string Scope { get; set; }

        /// <summary>
        /// Human readable Key
        /// </summary>
        /// <value>Human readable Key</value>
        [DataMember(Name = "code", EmitDefaultValue = true)]
        public string Code { get; set; }

        /// <summary>
        /// Numeric versioning support
        /// </summary>
        /// <value>Numeric versioning support</value>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public long Version { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskDefinitionId {\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
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
            return this.Equals(input as TaskDefinitionId);
        }

        /// <summary>
        /// Returns true if TaskDefinitionId instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskDefinitionId to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskDefinitionId input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Scope == input.Scope ||
                    (this.Scope != null &&
                    this.Scope.Equals(input.Scope))
                ) && 
                (
                    this.Code == input.Code ||
                    (this.Code != null &&
                    this.Code.Equals(input.Code))
                ) && 
                (
                    this.Version == input.Version ||
                    this.Version.Equals(input.Version)
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
                if (this.Scope != null)
                    hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Code != null)
                    hashCode = hashCode * 59 + this.Code.GetHashCode();
                hashCode = hashCode * 59 + this.Version.GetHashCode();
                return hashCode;
            }
        }

    }
}

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
    /// The version of the Task Definition used by this Task
    /// </summary>
    [DataContract(Name = "TaskDefinitionVersion")]
    public partial class TaskDefinitionVersion : IEquatable<TaskDefinitionVersion>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDefinitionVersion" /> class.
        /// </summary>
        /// <param name="asAtModified">The asAt datetime of the Task Definition used by this Task.</param>
        public TaskDefinitionVersion(DateTimeOffset asAtModified = default(DateTimeOffset))
        {
            this.AsAtModified = asAtModified;
        }

        /// <summary>
        /// The asAt datetime of the Task Definition used by this Task
        /// </summary>
        /// <value>The asAt datetime of the Task Definition used by this Task</value>
        [DataMember(Name = "asAtModified", EmitDefaultValue = false)]
        public DateTimeOffset AsAtModified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskDefinitionVersion {\n");
            sb.Append("  AsAtModified: ").Append(AsAtModified).Append("\n");
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
            return this.Equals(input as TaskDefinitionVersion);
        }

        /// <summary>
        /// Returns true if TaskDefinitionVersion instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskDefinitionVersion to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskDefinitionVersion input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AsAtModified == input.AsAtModified ||
                    (this.AsAtModified != null &&
                    this.AsAtModified.Equals(input.AsAtModified))
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
                if (this.AsAtModified != null)
                    hashCode = hashCode * 59 + this.AsAtModified.GetHashCode();
                return hashCode;
            }
        }

    }
}
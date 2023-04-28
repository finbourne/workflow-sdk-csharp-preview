/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.243
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
    /// A request to update a Task
    /// </summary>
    [DataContract(Name = "UpdateTaskRequest")]
    public partial class UpdateTaskRequest : IEquatable<UpdateTaskRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTaskRequest" /> class.
        /// </summary>
        /// <param name="correlationIds">A set of guid identifiers that allow correlation across the application tier.</param>
        /// <param name="fields">Defines the fields associated with the update.</param>
        public UpdateTaskRequest(List<string> correlationIds = default(List<string>), List<TaskInstanceField> fields = default(List<TaskInstanceField>))
        {
            this.CorrelationIds = correlationIds;
            this.Fields = fields;
        }

        /// <summary>
        /// A set of guid identifiers that allow correlation across the application tier
        /// </summary>
        /// <value>A set of guid identifiers that allow correlation across the application tier</value>
        [DataMember(Name = "correlationIds", EmitDefaultValue = true)]
        public List<string> CorrelationIds { get; set; }

        /// <summary>
        /// Defines the fields associated with the update
        /// </summary>
        /// <value>Defines the fields associated with the update</value>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<TaskInstanceField> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTaskRequest {\n");
            sb.Append("  CorrelationIds: ").Append(CorrelationIds).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
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
            return this.Equals(input as UpdateTaskRequest);
        }

        /// <summary>
        /// Returns true if UpdateTaskRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of UpdateTaskRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UpdateTaskRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CorrelationIds == input.CorrelationIds ||
                    this.CorrelationIds != null &&
                    input.CorrelationIds != null &&
                    this.CorrelationIds.SequenceEqual(input.CorrelationIds)
                ) && 
                (
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
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
                if (this.CorrelationIds != null)
                    hashCode = hashCode * 59 + this.CorrelationIds.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }

    }
}

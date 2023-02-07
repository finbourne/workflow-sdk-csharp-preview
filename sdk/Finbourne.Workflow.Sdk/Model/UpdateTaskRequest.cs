/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.131
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
    /// Contains required info to update a set of affected Task Instances
    /// </summary>
    [DataContract(Name = "UpdateTaskRequest")]
    public partial class UpdateTaskRequest : IEquatable<UpdateTaskRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateTaskRequest" /> class.
        /// </summary>
        /// <param name="field">The Field this Update is reporting; this is synonymous with FieldSchema.Name.</param>
        /// <param name="value">String representation of the data itself.</param>
        public UpdateTaskRequest(string field = default(string), string value = default(string))
        {
            this.Field = field;
            this.Value = value;
        }

        /// <summary>
        /// The Field this Update is reporting; this is synonymous with FieldSchema.Name
        /// </summary>
        /// <value>The Field this Update is reporting; this is synonymous with FieldSchema.Name</value>
        [DataMember(Name = "field", EmitDefaultValue = true)]
        public string Field { get; set; }

        /// <summary>
        /// String representation of the data itself
        /// </summary>
        /// <value>String representation of the data itself</value>
        [DataMember(Name = "value", EmitDefaultValue = true)]
        public string Value { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UpdateTaskRequest {\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
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
                    this.Field == input.Field ||
                    (this.Field != null &&
                    this.Field.Equals(input.Field))
                ) && 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
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
                if (this.Field != null)
                    hashCode = hashCode * 59 + this.Field.GetHashCode();
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                return hashCode;
            }
        }

    }
}

/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.253
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
    /// Defines the Initial State of the Task
    /// </summary>
    [DataContract(Name = "InitialState")]
    public partial class InitialState : IEquatable<InitialState>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialState" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InitialState() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InitialState" /> class.
        /// </summary>
        /// <param name="name">The Initial State of the Task (required).</param>
        /// <param name="requiredFields">Required input Fields for the Initial State.</param>
        public InitialState(string name = default(string), List<string> requiredFields = default(List<string>))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for InitialState and cannot be null");
            this.RequiredFields = requiredFields;
        }

        /// <summary>
        /// The Initial State of the Task
        /// </summary>
        /// <value>The Initial State of the Task</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Required input Fields for the Initial State
        /// </summary>
        /// <value>Required input Fields for the Initial State</value>
        [DataMember(Name = "requiredFields", EmitDefaultValue = true)]
        public List<string> RequiredFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InitialState {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RequiredFields: ").Append(RequiredFields).Append("\n");
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
            return this.Equals(input as InitialState);
        }

        /// <summary>
        /// Returns true if InitialState instances are equal
        /// </summary>
        /// <param name="input">Instance of InitialState to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InitialState input)
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
                    this.RequiredFields == input.RequiredFields ||
                    this.RequiredFields != null &&
                    input.RequiredFields != null &&
                    this.RequiredFields.SequenceEqual(input.RequiredFields)
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
                if (this.RequiredFields != null)
                    hashCode = hashCode * 59 + this.RequiredFields.GetHashCode();
                return hashCode;
            }
        }

    }
}

/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.231
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
    /// State changes happen in response to Triggers
    /// </summary>
    [DataContract(Name = "TransitionTriggerDefinition")]
    public partial class TransitionTriggerDefinition : IEquatable<TransitionTriggerDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TransitionTriggerDefinition" /> class.
        /// </summary>
        /// <param name="name">The key/Name of this Trigger.</param>
        /// <param name="trigger">trigger.</param>
        public TransitionTriggerDefinition(string name = default(string), TriggerSchema trigger = default(TriggerSchema))
        {
            this.Name = name;
            this.Trigger = trigger;
        }

        /// <summary>
        /// The key/Name of this Trigger
        /// </summary>
        /// <value>The key/Name of this Trigger</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Trigger
        /// </summary>
        [DataMember(Name = "trigger", EmitDefaultValue = false)]
        public TriggerSchema Trigger { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransitionTriggerDefinition {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
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
            return this.Equals(input as TransitionTriggerDefinition);
        }

        /// <summary>
        /// Returns true if TransitionTriggerDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of TransitionTriggerDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransitionTriggerDefinition input)
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
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
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
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                return hashCode;
            }
        }

    }
}

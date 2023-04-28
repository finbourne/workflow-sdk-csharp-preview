/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.241
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
    /// Defines a State change
    /// </summary>
    [DataContract(Name = "TaskTransitionDefinition")]
    public partial class TaskTransitionDefinition : IEquatable<TaskTransitionDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskTransitionDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskTransitionDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskTransitionDefinition" /> class.
        /// </summary>
        /// <param name="fromState">The State this Transition if coming From (required).</param>
        /// <param name="toState">The State this Transition is going To (required).</param>
        /// <param name="trigger">The Trigger for this Transition (required).</param>
        /// <param name="guard">The Guard for this Transition, if any.</param>
        public TaskTransitionDefinition(string fromState = default(string), string toState = default(string), string trigger = default(string), string guard = default(string))
        {
            // to ensure "fromState" is required (not null)
            this.FromState = fromState ?? throw new ArgumentNullException("fromState is a required property for TaskTransitionDefinition and cannot be null");
            // to ensure "toState" is required (not null)
            this.ToState = toState ?? throw new ArgumentNullException("toState is a required property for TaskTransitionDefinition and cannot be null");
            // to ensure "trigger" is required (not null)
            this.Trigger = trigger ?? throw new ArgumentNullException("trigger is a required property for TaskTransitionDefinition and cannot be null");
            this.Guard = guard;
        }

        /// <summary>
        /// The State this Transition if coming From
        /// </summary>
        /// <value>The State this Transition if coming From</value>
        [DataMember(Name = "fromState", IsRequired = true, EmitDefaultValue = false)]
        public string FromState { get; set; }

        /// <summary>
        /// The State this Transition is going To
        /// </summary>
        /// <value>The State this Transition is going To</value>
        [DataMember(Name = "toState", IsRequired = true, EmitDefaultValue = false)]
        public string ToState { get; set; }

        /// <summary>
        /// The Trigger for this Transition
        /// </summary>
        /// <value>The Trigger for this Transition</value>
        [DataMember(Name = "trigger", IsRequired = true, EmitDefaultValue = false)]
        public string Trigger { get; set; }

        /// <summary>
        /// The Guard for this Transition, if any
        /// </summary>
        /// <value>The Guard for this Transition, if any</value>
        [DataMember(Name = "guard", EmitDefaultValue = true)]
        public string Guard { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskTransitionDefinition {\n");
            sb.Append("  FromState: ").Append(FromState).Append("\n");
            sb.Append("  ToState: ").Append(ToState).Append("\n");
            sb.Append("  Trigger: ").Append(Trigger).Append("\n");
            sb.Append("  Guard: ").Append(Guard).Append("\n");
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
            return this.Equals(input as TaskTransitionDefinition);
        }

        /// <summary>
        /// Returns true if TaskTransitionDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskTransitionDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskTransitionDefinition input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FromState == input.FromState ||
                    (this.FromState != null &&
                    this.FromState.Equals(input.FromState))
                ) && 
                (
                    this.ToState == input.ToState ||
                    (this.ToState != null &&
                    this.ToState.Equals(input.ToState))
                ) && 
                (
                    this.Trigger == input.Trigger ||
                    (this.Trigger != null &&
                    this.Trigger.Equals(input.Trigger))
                ) && 
                (
                    this.Guard == input.Guard ||
                    (this.Guard != null &&
                    this.Guard.Equals(input.Guard))
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
                if (this.FromState != null)
                    hashCode = hashCode * 59 + this.FromState.GetHashCode();
                if (this.ToState != null)
                    hashCode = hashCode * 59 + this.ToState.GetHashCode();
                if (this.Trigger != null)
                    hashCode = hashCode * 59 + this.Trigger.GetHashCode();
                if (this.Guard != null)
                    hashCode = hashCode * 59 + this.Guard.GetHashCode();
                return hashCode;
            }
        }

    }
}

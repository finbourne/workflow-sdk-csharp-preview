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
    /// TaskDefinition
    /// </summary>
    [DataContract(Name = "TaskDefinition")]
    public partial class TaskDefinition : IEquatable<TaskDefinition>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDefinition" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskDefinition() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskDefinition" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="version">version.</param>
        /// <param name="displayName">Human readable name (required).</param>
        /// <param name="description">Human readable description.</param>
        /// <param name="states">The states this Task Definition operates over (required).</param>
        /// <param name="fieldSchema">The Fields that this Task Definition operates on.</param>
        /// <param name="initialState">initialState (required).</param>
        /// <param name="triggers">The Triggers for State transition.</param>
        /// <param name="transitions">The Transitions between States.</param>
        public TaskDefinition(ResourceId id = default(ResourceId), Version version = default(Version), string displayName = default(string), string description = default(string), List<TaskStateDefinition> states = default(List<TaskStateDefinition>), List<TaskFieldDefinition> fieldSchema = default(List<TaskFieldDefinition>), InitialState initialState = default(InitialState), List<TransitionTriggerDefinition> triggers = default(List<TransitionTriggerDefinition>), List<TaskTransitionDefinition> transitions = default(List<TaskTransitionDefinition>))
        {
            // to ensure "id" is required (not null)
            this.Id = id ?? throw new ArgumentNullException("id is a required property for TaskDefinition and cannot be null");
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for TaskDefinition and cannot be null");
            // to ensure "states" is required (not null)
            this.States = states ?? throw new ArgumentNullException("states is a required property for TaskDefinition and cannot be null");
            // to ensure "initialState" is required (not null)
            this.InitialState = initialState ?? throw new ArgumentNullException("initialState is a required property for TaskDefinition and cannot be null");
            this.Version = version;
            this.Description = description;
            this.FieldSchema = fieldSchema;
            this.Triggers = triggers;
            this.Transitions = transitions;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

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
        /// The states this Task Definition operates over
        /// </summary>
        /// <value>The states this Task Definition operates over</value>
        [DataMember(Name = "states", IsRequired = true, EmitDefaultValue = false)]
        public List<TaskStateDefinition> States { get; set; }

        /// <summary>
        /// The Fields that this Task Definition operates on
        /// </summary>
        /// <value>The Fields that this Task Definition operates on</value>
        [DataMember(Name = "fieldSchema", EmitDefaultValue = true)]
        public List<TaskFieldDefinition> FieldSchema { get; set; }

        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [DataMember(Name = "initialState", IsRequired = true, EmitDefaultValue = false)]
        public InitialState InitialState { get; set; }

        /// <summary>
        /// The Triggers for State transition
        /// </summary>
        /// <value>The Triggers for State transition</value>
        [DataMember(Name = "triggers", EmitDefaultValue = true)]
        public List<TransitionTriggerDefinition> Triggers { get; set; }

        /// <summary>
        /// The Transitions between States
        /// </summary>
        /// <value>The Transitions between States</value>
        [DataMember(Name = "transitions", EmitDefaultValue = true)]
        public List<TaskTransitionDefinition> Transitions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TaskDefinition {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  FieldSchema: ").Append(FieldSchema).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  Transitions: ").Append(Transitions).Append("\n");
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
            return this.Equals(input as TaskDefinition);
        }

        /// <summary>
        /// Returns true if TaskDefinition instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskDefinition to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskDefinition input)
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
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
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
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.FieldSchema == input.FieldSchema ||
                    this.FieldSchema != null &&
                    input.FieldSchema != null &&
                    this.FieldSchema.SequenceEqual(input.FieldSchema)
                ) && 
                (
                    this.InitialState == input.InitialState ||
                    (this.InitialState != null &&
                    this.InitialState.Equals(input.InitialState))
                ) && 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.Transitions == input.Transitions ||
                    this.Transitions != null &&
                    input.Transitions != null &&
                    this.Transitions.SequenceEqual(input.Transitions)
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
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.FieldSchema != null)
                    hashCode = hashCode * 59 + this.FieldSchema.GetHashCode();
                if (this.InitialState != null)
                    hashCode = hashCode * 59 + this.InitialState.GetHashCode();
                if (this.Triggers != null)
                    hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                if (this.Transitions != null)
                    hashCode = hashCode * 59 + this.Transitions.GetHashCode();
                return hashCode;
            }
        }

    }
}

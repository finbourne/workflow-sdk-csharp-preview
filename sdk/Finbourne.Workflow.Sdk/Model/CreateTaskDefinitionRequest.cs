/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.154
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
    /// Contains required info to create a new Task Definition
    /// </summary>
    [DataContract(Name = "CreateTaskDefinitionRequest")]
    public partial class CreateTaskDefinitionRequest : IEquatable<CreateTaskDefinitionRequest>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateTaskDefinitionRequest" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="displayName">Human readable name.</param>
        /// <param name="description">Human readable description.</param>
        /// <param name="fields">Defines the fields associated with this Task.</param>
        /// <param name="states">The states this Task Definition operates over.</param>
        /// <param name="transitions">Transitions.</param>
        /// <param name="triggers">Triggers.</param>
        /// <param name="initialState">initialState.</param>
        /// <param name="outputs">The Outputs of this Task.</param>
        public CreateTaskDefinitionRequest(ResourceId id = default(ResourceId), string displayName = default(string), string description = default(string), List<FieldSchema> fields = default(List<FieldSchema>), List<State> states = default(List<State>), List<Transition> transitions = default(List<Transition>), List<Trigger> triggers = default(List<Trigger>), InitialState initialState = default(InitialState), List<Output> outputs = default(List<Output>))
        {
            this.Id = id;
            this.DisplayName = displayName;
            this.Description = description;
            this.Fields = fields;
            this.States = states;
            this.Transitions = transitions;
            this.Triggers = triggers;
            this.InitialState = initialState;
            this.Outputs = outputs;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public ResourceId Id { get; set; }

        /// <summary>
        /// Human readable name
        /// </summary>
        /// <value>Human readable name</value>
        [DataMember(Name = "displayName", EmitDefaultValue = true)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Human readable description
        /// </summary>
        /// <value>Human readable description</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Defines the fields associated with this Task
        /// </summary>
        /// <value>Defines the fields associated with this Task</value>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<FieldSchema> Fields { get; set; }

        /// <summary>
        /// The states this Task Definition operates over
        /// </summary>
        /// <value>The states this Task Definition operates over</value>
        [DataMember(Name = "states", EmitDefaultValue = true)]
        public List<State> States { get; set; }

        /// <summary>
        /// Transitions
        /// </summary>
        /// <value>Transitions</value>
        [DataMember(Name = "transitions", EmitDefaultValue = true)]
        public List<Transition> Transitions { get; set; }

        /// <summary>
        /// Triggers
        /// </summary>
        /// <value>Triggers</value>
        [DataMember(Name = "triggers", EmitDefaultValue = true)]
        public List<Trigger> Triggers { get; set; }

        /// <summary>
        /// Gets or Sets InitialState
        /// </summary>
        [DataMember(Name = "initialState", EmitDefaultValue = false)]
        public InitialState InitialState { get; set; }

        /// <summary>
        /// The Outputs of this Task
        /// </summary>
        /// <value>The Outputs of this Task</value>
        [DataMember(Name = "outputs", EmitDefaultValue = true)]
        public List<Output> Outputs { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateTaskDefinitionRequest {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Fields: ").Append(Fields).Append("\n");
            sb.Append("  States: ").Append(States).Append("\n");
            sb.Append("  Transitions: ").Append(Transitions).Append("\n");
            sb.Append("  Triggers: ").Append(Triggers).Append("\n");
            sb.Append("  InitialState: ").Append(InitialState).Append("\n");
            sb.Append("  Outputs: ").Append(Outputs).Append("\n");
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
            return this.Equals(input as CreateTaskDefinitionRequest);
        }

        /// <summary>
        /// Returns true if CreateTaskDefinitionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateTaskDefinitionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateTaskDefinitionRequest input)
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
                    this.Fields == input.Fields ||
                    this.Fields != null &&
                    input.Fields != null &&
                    this.Fields.SequenceEqual(input.Fields)
                ) && 
                (
                    this.States == input.States ||
                    this.States != null &&
                    input.States != null &&
                    this.States.SequenceEqual(input.States)
                ) && 
                (
                    this.Transitions == input.Transitions ||
                    this.Transitions != null &&
                    input.Transitions != null &&
                    this.Transitions.SequenceEqual(input.Transitions)
                ) && 
                (
                    this.Triggers == input.Triggers ||
                    this.Triggers != null &&
                    input.Triggers != null &&
                    this.Triggers.SequenceEqual(input.Triggers)
                ) && 
                (
                    this.InitialState == input.InitialState ||
                    (this.InitialState != null &&
                    this.InitialState.Equals(input.InitialState))
                ) && 
                (
                    this.Outputs == input.Outputs ||
                    this.Outputs != null &&
                    input.Outputs != null &&
                    this.Outputs.SequenceEqual(input.Outputs)
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
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                if (this.States != null)
                    hashCode = hashCode * 59 + this.States.GetHashCode();
                if (this.Transitions != null)
                    hashCode = hashCode * 59 + this.Transitions.GetHashCode();
                if (this.Triggers != null)
                    hashCode = hashCode * 59 + this.Triggers.GetHashCode();
                if (this.InitialState != null)
                    hashCode = hashCode * 59 + this.InitialState.GetHashCode();
                if (this.Outputs != null)
                    hashCode = hashCode * 59 + this.Outputs.GetHashCode();
                return hashCode;
            }
        }

    }
}

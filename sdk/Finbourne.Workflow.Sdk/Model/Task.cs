/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.254
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
    /// Defines a Task created based on a Task Definition
    /// </summary>
    [DataContract(Name = "Task")]
    public partial class Task : IEquatable<Task>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Task() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Task" /> class.
        /// </summary>
        /// <param name="id">The unique id for this Task (required).</param>
        /// <param name="correlationIds">User-provided ID used to link entities and tasks.</param>
        /// <param name="taskDefinitionId">taskDefinitionId (required).</param>
        /// <param name="taskDefinitionVersion">taskDefinitionVersion (required).</param>
        /// <param name="version">version.</param>
        /// <param name="state">Current State (required).</param>
        /// <param name="terminalState">True if no onward transitions are possible (required).</param>
        /// <param name="asAtLastTransition">Last Transition timestamp.</param>
        /// <param name="fields">Fields and their latest values - should correspond with the Task Definition field schema.</param>
        public Task(Guid id = default(Guid), List<string> correlationIds = default(List<string>), ResourceId taskDefinitionId = default(ResourceId), TaskDefinitionVersion taskDefinitionVersion = default(TaskDefinitionVersion), Version version = default(Version), string state = default(string), bool terminalState = default(bool), DateTimeOffset? asAtLastTransition = default(DateTimeOffset?), List<TaskInstanceField> fields = default(List<TaskInstanceField>))
        {
            this.Id = id;
            // to ensure "taskDefinitionId" is required (not null)
            this.TaskDefinitionId = taskDefinitionId ?? throw new ArgumentNullException("taskDefinitionId is a required property for Task and cannot be null");
            // to ensure "taskDefinitionVersion" is required (not null)
            this.TaskDefinitionVersion = taskDefinitionVersion ?? throw new ArgumentNullException("taskDefinitionVersion is a required property for Task and cannot be null");
            // to ensure "state" is required (not null)
            this.State = state ?? throw new ArgumentNullException("state is a required property for Task and cannot be null");
            this.TerminalState = terminalState;
            this.CorrelationIds = correlationIds;
            this.Version = version;
            this.AsAtLastTransition = asAtLastTransition;
            this.Fields = fields;
        }

        /// <summary>
        /// The unique id for this Task
        /// </summary>
        /// <value>The unique id for this Task</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// User-provided ID used to link entities and tasks
        /// </summary>
        /// <value>User-provided ID used to link entities and tasks</value>
        [DataMember(Name = "correlationIds", EmitDefaultValue = true)]
        public List<string> CorrelationIds { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionId
        /// </summary>
        [DataMember(Name = "taskDefinitionId", IsRequired = true, EmitDefaultValue = false)]
        public ResourceId TaskDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionVersion
        /// </summary>
        [DataMember(Name = "taskDefinitionVersion", IsRequired = true, EmitDefaultValue = false)]
        public TaskDefinitionVersion TaskDefinitionVersion { get; set; }

        /// <summary>
        /// Gets or Sets Version
        /// </summary>
        [DataMember(Name = "version", EmitDefaultValue = false)]
        public Version Version { get; set; }

        /// <summary>
        /// Current State
        /// </summary>
        /// <value>Current State</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = false)]
        public string State { get; set; }

        /// <summary>
        /// True if no onward transitions are possible
        /// </summary>
        /// <value>True if no onward transitions are possible</value>
        [DataMember(Name = "terminalState", IsRequired = true, EmitDefaultValue = true)]
        public bool TerminalState { get; set; }

        /// <summary>
        /// Last Transition timestamp
        /// </summary>
        /// <value>Last Transition timestamp</value>
        [DataMember(Name = "asAtLastTransition", EmitDefaultValue = true)]
        public DateTimeOffset? AsAtLastTransition { get; set; }

        /// <summary>
        /// Fields and their latest values - should correspond with the Task Definition field schema
        /// </summary>
        /// <value>Fields and their latest values - should correspond with the Task Definition field schema</value>
        [DataMember(Name = "fields", EmitDefaultValue = true)]
        public List<TaskInstanceField> Fields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Task {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  CorrelationIds: ").Append(CorrelationIds).Append("\n");
            sb.Append("  TaskDefinitionId: ").Append(TaskDefinitionId).Append("\n");
            sb.Append("  TaskDefinitionVersion: ").Append(TaskDefinitionVersion).Append("\n");
            sb.Append("  Version: ").Append(Version).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  TerminalState: ").Append(TerminalState).Append("\n");
            sb.Append("  AsAtLastTransition: ").Append(AsAtLastTransition).Append("\n");
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
            return this.Equals(input as Task);
        }

        /// <summary>
        /// Returns true if Task instances are equal
        /// </summary>
        /// <param name="input">Instance of Task to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Task input)
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
                    this.CorrelationIds == input.CorrelationIds ||
                    this.CorrelationIds != null &&
                    input.CorrelationIds != null &&
                    this.CorrelationIds.SequenceEqual(input.CorrelationIds)
                ) && 
                (
                    this.TaskDefinitionId == input.TaskDefinitionId ||
                    (this.TaskDefinitionId != null &&
                    this.TaskDefinitionId.Equals(input.TaskDefinitionId))
                ) && 
                (
                    this.TaskDefinitionVersion == input.TaskDefinitionVersion ||
                    (this.TaskDefinitionVersion != null &&
                    this.TaskDefinitionVersion.Equals(input.TaskDefinitionVersion))
                ) && 
                (
                    this.Version == input.Version ||
                    (this.Version != null &&
                    this.Version.Equals(input.Version))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
                ) && 
                (
                    this.TerminalState == input.TerminalState ||
                    this.TerminalState.Equals(input.TerminalState)
                ) && 
                (
                    this.AsAtLastTransition == input.AsAtLastTransition ||
                    (this.AsAtLastTransition != null &&
                    this.AsAtLastTransition.Equals(input.AsAtLastTransition))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.CorrelationIds != null)
                    hashCode = hashCode * 59 + this.CorrelationIds.GetHashCode();
                if (this.TaskDefinitionId != null)
                    hashCode = hashCode * 59 + this.TaskDefinitionId.GetHashCode();
                if (this.TaskDefinitionVersion != null)
                    hashCode = hashCode * 59 + this.TaskDefinitionVersion.GetHashCode();
                if (this.Version != null)
                    hashCode = hashCode * 59 + this.Version.GetHashCode();
                if (this.State != null)
                    hashCode = hashCode * 59 + this.State.GetHashCode();
                hashCode = hashCode * 59 + this.TerminalState.GetHashCode();
                if (this.AsAtLastTransition != null)
                    hashCode = hashCode * 59 + this.AsAtLastTransition.GetHashCode();
                if (this.Fields != null)
                    hashCode = hashCode * 59 + this.Fields.GetHashCode();
                return hashCode;
            }
        }

    }
}

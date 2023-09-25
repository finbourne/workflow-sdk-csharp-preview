/*
 * FINBOURNE Workflow API
 *
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
using FileParameter = Finbourne.Workflow.Sdk.Client.FileParameter;
using OpenAPIDateConverter = Finbourne.Workflow.Sdk.Client.OpenAPIDateConverter;

namespace Finbourne.Workflow.Sdk.Model
{
    /// <summary>
    /// Summary of a Task created based on a Task Definition
    /// </summary>
    [DataContract(Name = "TaskSummary")]
    public partial class TaskSummary : IEquatable<TaskSummary>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSummary" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TaskSummary() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TaskSummary" /> class.
        /// </summary>
        /// <param name="id">The unique id for this Task (required).</param>
        /// <param name="taskDefinitionId">taskDefinitionId (required).</param>
        /// <param name="taskDefinitionVersion">taskDefinitionVersion (required).</param>
        /// <param name="taskDefinitionDisplayName">The display name of the Task Definition used by this Task (required).</param>
        /// <param name="state">Current State (required).</param>
        public TaskSummary(Guid id = default(Guid), ResourceId taskDefinitionId = default(ResourceId), TaskDefinitionVersion taskDefinitionVersion = default(TaskDefinitionVersion), string taskDefinitionDisplayName = default(string), string state = default(string))
        {
            this.Id = id;
            // to ensure "taskDefinitionId" is required (not null)
            if (taskDefinitionId == null)
            {
                throw new ArgumentNullException("taskDefinitionId is a required property for TaskSummary and cannot be null");
            }
            this.TaskDefinitionId = taskDefinitionId;
            // to ensure "taskDefinitionVersion" is required (not null)
            if (taskDefinitionVersion == null)
            {
                throw new ArgumentNullException("taskDefinitionVersion is a required property for TaskSummary and cannot be null");
            }
            this.TaskDefinitionVersion = taskDefinitionVersion;
            // to ensure "taskDefinitionDisplayName" is required (not null)
            if (taskDefinitionDisplayName == null)
            {
                throw new ArgumentNullException("taskDefinitionDisplayName is a required property for TaskSummary and cannot be null");
            }
            this.TaskDefinitionDisplayName = taskDefinitionDisplayName;
            // to ensure "state" is required (not null)
            if (state == null)
            {
                throw new ArgumentNullException("state is a required property for TaskSummary and cannot be null");
            }
            this.State = state;
        }

        /// <summary>
        /// The unique id for this Task
        /// </summary>
        /// <value>The unique id for this Task</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionId
        /// </summary>
        [DataMember(Name = "taskDefinitionId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId TaskDefinitionId { get; set; }

        /// <summary>
        /// Gets or Sets TaskDefinitionVersion
        /// </summary>
        [DataMember(Name = "taskDefinitionVersion", IsRequired = true, EmitDefaultValue = true)]
        public TaskDefinitionVersion TaskDefinitionVersion { get; set; }

        /// <summary>
        /// The display name of the Task Definition used by this Task
        /// </summary>
        /// <value>The display name of the Task Definition used by this Task</value>
        [DataMember(Name = "taskDefinitionDisplayName", IsRequired = true, EmitDefaultValue = true)]
        public string TaskDefinitionDisplayName { get; set; }

        /// <summary>
        /// Current State
        /// </summary>
        /// <value>Current State</value>
        [DataMember(Name = "state", IsRequired = true, EmitDefaultValue = true)]
        public string State { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TaskSummary {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TaskDefinitionId: ").Append(TaskDefinitionId).Append("\n");
            sb.Append("  TaskDefinitionVersion: ").Append(TaskDefinitionVersion).Append("\n");
            sb.Append("  TaskDefinitionDisplayName: ").Append(TaskDefinitionDisplayName).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
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
            return this.Equals(input as TaskSummary);
        }

        /// <summary>
        /// Returns true if TaskSummary instances are equal
        /// </summary>
        /// <param name="input">Instance of TaskSummary to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TaskSummary input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                    this.TaskDefinitionDisplayName == input.TaskDefinitionDisplayName ||
                    (this.TaskDefinitionDisplayName != null &&
                    this.TaskDefinitionDisplayName.Equals(input.TaskDefinitionDisplayName))
                ) && 
                (
                    this.State == input.State ||
                    (this.State != null &&
                    this.State.Equals(input.State))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.TaskDefinitionId != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionId.GetHashCode();
                }
                if (this.TaskDefinitionVersion != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionVersion.GetHashCode();
                }
                if (this.TaskDefinitionDisplayName != null)
                {
                    hashCode = (hashCode * 59) + this.TaskDefinitionDisplayName.GetHashCode();
                }
                if (this.State != null)
                {
                    hashCode = (hashCode * 59) + this.State.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            // TaskDefinitionDisplayName (string) minLength
            if (this.TaskDefinitionDisplayName != null && this.TaskDefinitionDisplayName.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for TaskDefinitionDisplayName, length must be greater than 1.", new [] { "TaskDefinitionDisplayName" });
            }

            // State (string) minLength
            if (this.State != null && this.State.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for State, length must be greater than 1.", new [] { "State" });
            }

            yield break;
        }
    }
}

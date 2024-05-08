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
    /// Read only Create new task response
    /// </summary>
    [DataContract(Name = "CreateNewTaskActivityResponse")]
    public partial class CreateNewTaskActivityResponse : IEquatable<CreateNewTaskActivityResponse>, IValidatableObject
    {
        /// <summary>
        /// Type of task activity
        /// </summary>
        /// <value>Type of task activity</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CreateNewTask for value: CreateNewTask
            /// </summary>
            [EnumMember(Value = "CreateNewTask")]
            CreateNewTask = 1

        }


        /// <summary>
        /// Type of task activity
        /// </summary>
        /// <value>Type of task activity</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateNewTaskActivityResponse" /> class.
        /// </summary>
        /// <param name="type">Type of task activity.</param>
        /// <param name="initialTrigger">Trigger to supply to all tasks to be made.</param>
        /// <param name="correlationIds">The event to correlation ID mappings.</param>
        /// <param name="taskFields">The event to task field mappings.</param>
        public CreateNewTaskActivityResponse(TypeEnum? type = default(TypeEnum?), string initialTrigger = default(string), List<EventHandlerMapping> correlationIds = default(List<EventHandlerMapping>), Dictionary<string, FieldMapping> taskFields = default(Dictionary<string, FieldMapping>))
        {
            this.Type = type;
            this.InitialTrigger = initialTrigger;
            this.CorrelationIds = correlationIds;
            this.TaskFields = taskFields;
        }

        /// <summary>
        /// Trigger to supply to all tasks to be made
        /// </summary>
        /// <value>Trigger to supply to all tasks to be made</value>
        [DataMember(Name = "initialTrigger", EmitDefaultValue = true)]
        public string InitialTrigger { get; set; }

        /// <summary>
        /// The event to correlation ID mappings
        /// </summary>
        /// <value>The event to correlation ID mappings</value>
        [DataMember(Name = "correlationIds", EmitDefaultValue = true)]
        public List<EventHandlerMapping> CorrelationIds { get; set; }

        /// <summary>
        /// The event to task field mappings
        /// </summary>
        /// <value>The event to task field mappings</value>
        [DataMember(Name = "taskFields", EmitDefaultValue = true)]
        public Dictionary<string, FieldMapping> TaskFields { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateNewTaskActivityResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  InitialTrigger: ").Append(InitialTrigger).Append("\n");
            sb.Append("  CorrelationIds: ").Append(CorrelationIds).Append("\n");
            sb.Append("  TaskFields: ").Append(TaskFields).Append("\n");
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
            return this.Equals(input as CreateNewTaskActivityResponse);
        }

        /// <summary>
        /// Returns true if CreateNewTaskActivityResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateNewTaskActivityResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateNewTaskActivityResponse input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.InitialTrigger == input.InitialTrigger ||
                    (this.InitialTrigger != null &&
                    this.InitialTrigger.Equals(input.InitialTrigger))
                ) && 
                (
                    this.CorrelationIds == input.CorrelationIds ||
                    this.CorrelationIds != null &&
                    input.CorrelationIds != null &&
                    this.CorrelationIds.SequenceEqual(input.CorrelationIds)
                ) && 
                (
                    this.TaskFields == input.TaskFields ||
                    this.TaskFields != null &&
                    input.TaskFields != null &&
                    this.TaskFields.SequenceEqual(input.TaskFields)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.InitialTrigger != null)
                {
                    hashCode = (hashCode * 59) + this.InitialTrigger.GetHashCode();
                }
                if (this.CorrelationIds != null)
                {
                    hashCode = (hashCode * 59) + this.CorrelationIds.GetHashCode();
                }
                if (this.TaskFields != null)
                {
                    hashCode = (hashCode * 59) + this.TaskFields.GetHashCode();
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
            yield break;
        }
    }
}

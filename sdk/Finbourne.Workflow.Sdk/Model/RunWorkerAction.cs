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
    /// Defines a Run Worker Action
    /// </summary>
    [DataContract(Name = "RunWorkerAction")]
    public partial class RunWorkerAction : IEquatable<RunWorkerAction>, IValidatableObject
    {
        /// <summary>
        /// Type name for this Action
        /// </summary>
        /// <value>Type name for this Action</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum RunWorker for value: RunWorker
            /// </summary>
            [EnumMember(Value = "RunWorker")]
            RunWorker = 1

        }


        /// <summary>
        /// Type name for this Action
        /// </summary>
        /// <value>Type name for this Action</value>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunWorkerAction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected RunWorkerAction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="RunWorkerAction" /> class.
        /// </summary>
        /// <param name="type">Type name for this Action (required).</param>
        /// <param name="workerId">workerId (required).</param>
        /// <param name="workerAsAt">Worker AsAt.</param>
        /// <param name="workerParameters">Parameters for this Worker.</param>
        /// <param name="workerStatusTriggers">workerStatusTriggers.</param>
        /// <param name="childTaskConfigurations">Tasks can be generated from run worker results; this is the configuration.</param>
        public RunWorkerAction(TypeEnum type = default(TypeEnum), ResourceId workerId = default(ResourceId), DateTimeOffset? workerAsAt = default(DateTimeOffset?), Dictionary<string, FieldMapping> workerParameters = default(Dictionary<string, FieldMapping>), WorkerStatusTriggers workerStatusTriggers = default(WorkerStatusTriggers), List<ResultantChildTaskConfiguration> childTaskConfigurations = default(List<ResultantChildTaskConfiguration>))
        {
            this.Type = type;
            // to ensure "workerId" is required (not null)
            if (workerId == null)
            {
                throw new ArgumentNullException("workerId is a required property for RunWorkerAction and cannot be null");
            }
            this.WorkerId = workerId;
            this.WorkerAsAt = workerAsAt;
            this.WorkerParameters = workerParameters;
            this.WorkerStatusTriggers = workerStatusTriggers;
            this.ChildTaskConfigurations = childTaskConfigurations;
        }

        /// <summary>
        /// Gets or Sets WorkerId
        /// </summary>
        [DataMember(Name = "workerId", IsRequired = true, EmitDefaultValue = true)]
        public ResourceId WorkerId { get; set; }

        /// <summary>
        /// Worker AsAt
        /// </summary>
        /// <value>Worker AsAt</value>
        [DataMember(Name = "workerAsAt", EmitDefaultValue = true)]
        public DateTimeOffset? WorkerAsAt { get; set; }

        /// <summary>
        /// Parameters for this Worker
        /// </summary>
        /// <value>Parameters for this Worker</value>
        [DataMember(Name = "workerParameters", EmitDefaultValue = true)]
        public Dictionary<string, FieldMapping> WorkerParameters { get; set; }

        /// <summary>
        /// Gets or Sets WorkerStatusTriggers
        /// </summary>
        [DataMember(Name = "workerStatusTriggers", EmitDefaultValue = false)]
        public WorkerStatusTriggers WorkerStatusTriggers { get; set; }

        /// <summary>
        /// Tasks can be generated from run worker results; this is the configuration
        /// </summary>
        /// <value>Tasks can be generated from run worker results; this is the configuration</value>
        [DataMember(Name = "childTaskConfigurations", EmitDefaultValue = true)]
        public List<ResultantChildTaskConfiguration> ChildTaskConfigurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class RunWorkerAction {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  WorkerId: ").Append(WorkerId).Append("\n");
            sb.Append("  WorkerAsAt: ").Append(WorkerAsAt).Append("\n");
            sb.Append("  WorkerParameters: ").Append(WorkerParameters).Append("\n");
            sb.Append("  WorkerStatusTriggers: ").Append(WorkerStatusTriggers).Append("\n");
            sb.Append("  ChildTaskConfigurations: ").Append(ChildTaskConfigurations).Append("\n");
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
            return this.Equals(input as RunWorkerAction);
        }

        /// <summary>
        /// Returns true if RunWorkerAction instances are equal
        /// </summary>
        /// <param name="input">Instance of RunWorkerAction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(RunWorkerAction input)
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
                    this.WorkerId == input.WorkerId ||
                    (this.WorkerId != null &&
                    this.WorkerId.Equals(input.WorkerId))
                ) && 
                (
                    this.WorkerAsAt == input.WorkerAsAt ||
                    (this.WorkerAsAt != null &&
                    this.WorkerAsAt.Equals(input.WorkerAsAt))
                ) && 
                (
                    this.WorkerParameters == input.WorkerParameters ||
                    this.WorkerParameters != null &&
                    input.WorkerParameters != null &&
                    this.WorkerParameters.SequenceEqual(input.WorkerParameters)
                ) && 
                (
                    this.WorkerStatusTriggers == input.WorkerStatusTriggers ||
                    (this.WorkerStatusTriggers != null &&
                    this.WorkerStatusTriggers.Equals(input.WorkerStatusTriggers))
                ) && 
                (
                    this.ChildTaskConfigurations == input.ChildTaskConfigurations ||
                    this.ChildTaskConfigurations != null &&
                    input.ChildTaskConfigurations != null &&
                    this.ChildTaskConfigurations.SequenceEqual(input.ChildTaskConfigurations)
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
                if (this.WorkerId != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerId.GetHashCode();
                }
                if (this.WorkerAsAt != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerAsAt.GetHashCode();
                }
                if (this.WorkerParameters != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerParameters.GetHashCode();
                }
                if (this.WorkerStatusTriggers != null)
                {
                    hashCode = (hashCode * 59) + this.WorkerStatusTriggers.GetHashCode();
                }
                if (this.ChildTaskConfigurations != null)
                {
                    hashCode = (hashCode * 59) + this.ChildTaskConfigurations.GetHashCode();
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

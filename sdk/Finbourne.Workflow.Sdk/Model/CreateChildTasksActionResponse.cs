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
    /// Defines a read-only Create Child Tasks Action
    /// </summary>
    [DataContract(Name = "CreateChildTasksActionResponse")]
    public partial class CreateChildTasksActionResponse : IEquatable<CreateChildTasksActionResponse>, IValidatableObject
    {
        /// <summary>
        /// Type name for this Action
        /// </summary>
        /// <value>Type name for this Action</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CreateChildTasks for value: CreateChildTasks
            /// </summary>
            [EnumMember(Value = "CreateChildTasks")]
            CreateChildTasks = 1

        }


        /// <summary>
        /// Type name for this Action
        /// </summary>
        /// <value>Type name for this Action</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public TypeEnum? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateChildTasksActionResponse" /> class.
        /// </summary>
        /// <param name="type">Type name for this Action.</param>
        /// <param name="childTaskConfigurations">The Child Task Configurations.</param>
        public CreateChildTasksActionResponse(TypeEnum? type = default(TypeEnum?), List<CreateChildTaskConfiguration> childTaskConfigurations = default(List<CreateChildTaskConfiguration>))
        {
            this.Type = type;
            this.ChildTaskConfigurations = childTaskConfigurations;
        }

        /// <summary>
        /// The Child Task Configurations
        /// </summary>
        /// <value>The Child Task Configurations</value>
        [DataMember(Name = "childTaskConfigurations", EmitDefaultValue = true)]
        public List<CreateChildTaskConfiguration> ChildTaskConfigurations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateChildTasksActionResponse {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
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
            return this.Equals(input as CreateChildTasksActionResponse);
        }

        /// <summary>
        /// Returns true if CreateChildTasksActionResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateChildTasksActionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateChildTasksActionResponse input)
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

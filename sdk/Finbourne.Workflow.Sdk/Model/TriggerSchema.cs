/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.161
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
    /// Triggers can operate in response to different stimuli
    /// </summary>
    [DataContract(Name = "TriggerSchema")]
    public partial class TriggerSchema : IEquatable<TriggerSchema>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerSchema" /> class.
        /// </summary>
        /// <param name="type">The type of Trigger: External, Timeout or WebHook.</param>
        /// <param name="timeInState">The amount of time to wait in seconds (Timeout only).</param>
        /// <param name="responseCodes">Defines a set of HTTP response codes that correspond to an outcome. eg: &#39;OK &#x3D;&gt;  [&#39;200&#39;, &#39;204&#39;] (WebHook only).</param>
        public TriggerSchema(string type = default(string), int timeInState = default(int), Dictionary<string, List<int>> responseCodes = default(Dictionary<string, List<int>>))
        {
            this.Type = type;
            this.TimeInState = timeInState;
            this.ResponseCodes = responseCodes;
        }

        /// <summary>
        /// The type of Trigger: External, Timeout or WebHook
        /// </summary>
        /// <value>The type of Trigger: External, Timeout or WebHook</value>
        [DataMember(Name = "type", EmitDefaultValue = true)]
        public string Type { get; set; }

        /// <summary>
        /// The amount of time to wait in seconds (Timeout only)
        /// </summary>
        /// <value>The amount of time to wait in seconds (Timeout only)</value>
        [DataMember(Name = "timeInState", EmitDefaultValue = true)]
        public int TimeInState { get; set; }

        /// <summary>
        /// Defines a set of HTTP response codes that correspond to an outcome. eg: &#39;OK &#x3D;&gt;  [&#39;200&#39;, &#39;204&#39;] (WebHook only)
        /// </summary>
        /// <value>Defines a set of HTTP response codes that correspond to an outcome. eg: &#39;OK &#x3D;&gt;  [&#39;200&#39;, &#39;204&#39;] (WebHook only)</value>
        [DataMember(Name = "responseCodes", EmitDefaultValue = true)]
        public Dictionary<string, List<int>> ResponseCodes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerSchema {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  TimeInState: ").Append(TimeInState).Append("\n");
            sb.Append("  ResponseCodes: ").Append(ResponseCodes).Append("\n");
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
            return this.Equals(input as TriggerSchema);
        }

        /// <summary>
        /// Returns true if TriggerSchema instances are equal
        /// </summary>
        /// <param name="input">Instance of TriggerSchema to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggerSchema input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.TimeInState == input.TimeInState ||
                    this.TimeInState.Equals(input.TimeInState)
                ) && 
                (
                    this.ResponseCodes == input.ResponseCodes ||
                    this.ResponseCodes != null &&
                    input.ResponseCodes != null &&
                    this.ResponseCodes.SequenceEqual(input.ResponseCodes)
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                hashCode = hashCode * 59 + this.TimeInState.GetHashCode();
                if (this.ResponseCodes != null)
                    hashCode = hashCode * 59 + this.ResponseCodes.GetHashCode();
                return hashCode;
            }
        }

    }
}

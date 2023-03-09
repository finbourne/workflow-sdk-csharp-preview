/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.159
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
    /// Encapsulates what happened
    /// </summary>
    [DataContract(Name = "TriggerInvocationResponse")]
    public partial class TriggerInvocationResponse : IEquatable<TriggerInvocationResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TriggerInvocationResponse" /> class.
        /// </summary>
        /// <param name="wasSuccessful">A flag indicating success.</param>
        /// <param name="asAt">If successful, the AsAt time.</param>
        /// <param name="message">Any messaging.</param>
        public TriggerInvocationResponse(bool wasSuccessful = default(bool), DateTimeOffset? asAt = default(DateTimeOffset?), string message = default(string))
        {
            this.WasSuccessful = wasSuccessful;
            this.AsAt = asAt;
            this.Message = message;
        }

        /// <summary>
        /// A flag indicating success
        /// </summary>
        /// <value>A flag indicating success</value>
        [DataMember(Name = "wasSuccessful", EmitDefaultValue = true)]
        public bool WasSuccessful { get; set; }

        /// <summary>
        /// If successful, the AsAt time
        /// </summary>
        /// <value>If successful, the AsAt time</value>
        [DataMember(Name = "asAt", EmitDefaultValue = true)]
        public DateTimeOffset? AsAt { get; set; }

        /// <summary>
        /// Any messaging
        /// </summary>
        /// <value>Any messaging</value>
        [DataMember(Name = "message", EmitDefaultValue = true)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TriggerInvocationResponse {\n");
            sb.Append("  WasSuccessful: ").Append(WasSuccessful).Append("\n");
            sb.Append("  AsAt: ").Append(AsAt).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as TriggerInvocationResponse);
        }

        /// <summary>
        /// Returns true if TriggerInvocationResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of TriggerInvocationResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TriggerInvocationResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WasSuccessful == input.WasSuccessful ||
                    this.WasSuccessful.Equals(input.WasSuccessful)
                ) && 
                (
                    this.AsAt == input.AsAt ||
                    (this.AsAt != null &&
                    this.AsAt.Equals(input.AsAt))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                hashCode = hashCode * 59 + this.WasSuccessful.GetHashCode();
                if (this.AsAt != null)
                    hashCode = hashCode * 59 + this.AsAt.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                return hashCode;
            }
        }

    }
}

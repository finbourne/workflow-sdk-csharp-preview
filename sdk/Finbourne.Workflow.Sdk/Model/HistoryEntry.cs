/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.162
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
    /// A single audit entry
    /// </summary>
    [DataContract(Name = "HistoryEntry")]
    public partial class HistoryEntry : IEquatable<HistoryEntry>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="HistoryEntry" /> class.
        /// </summary>
        /// <param name="timeStamp">The timestamp for the entry.</param>
        /// <param name="entry">The information itself.</param>
        public HistoryEntry(DateTimeOffset timeStamp = default(DateTimeOffset), string entry = default(string))
        {
            this.TimeStamp = timeStamp;
            this.Entry = entry;
        }

        /// <summary>
        /// The timestamp for the entry
        /// </summary>
        /// <value>The timestamp for the entry</value>
        [DataMember(Name = "timeStamp", EmitDefaultValue = false)]
        public DateTimeOffset TimeStamp { get; set; }

        /// <summary>
        /// The information itself
        /// </summary>
        /// <value>The information itself</value>
        [DataMember(Name = "entry", EmitDefaultValue = true)]
        public string Entry { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HistoryEntry {\n");
            sb.Append("  TimeStamp: ").Append(TimeStamp).Append("\n");
            sb.Append("  Entry: ").Append(Entry).Append("\n");
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
            return this.Equals(input as HistoryEntry);
        }

        /// <summary>
        /// Returns true if HistoryEntry instances are equal
        /// </summary>
        /// <param name="input">Instance of HistoryEntry to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HistoryEntry input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TimeStamp == input.TimeStamp ||
                    (this.TimeStamp != null &&
                    this.TimeStamp.Equals(input.TimeStamp))
                ) && 
                (
                    this.Entry == input.Entry ||
                    (this.Entry != null &&
                    this.Entry.Equals(input.Entry))
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
                if (this.TimeStamp != null)
                    hashCode = hashCode * 59 + this.TimeStamp.GetHashCode();
                if (this.Entry != null)
                    hashCode = hashCode * 59 + this.Entry.GetHashCode();
                return hashCode;
            }
        }

    }
}

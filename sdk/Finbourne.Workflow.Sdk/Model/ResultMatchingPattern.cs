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
    /// Standard Finbourne filter to match against Run Worker results
    /// </summary>
    [DataContract(Name = "ResultMatchingPattern")]
    public partial class ResultMatchingPattern : IEquatable<ResultMatchingPattern>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultMatchingPattern" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ResultMatchingPattern() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ResultMatchingPattern" /> class.
        /// </summary>
        /// <param name="filter">Filter string (required).</param>
        public ResultMatchingPattern(string filter = default(string))
        {
            // to ensure "filter" is required (not null)
            if (filter == null)
            {
                throw new ArgumentNullException("filter is a required property for ResultMatchingPattern and cannot be null");
            }
            this.Filter = filter;
        }

        /// <summary>
        /// Filter string
        /// </summary>
        /// <value>Filter string</value>
        [DataMember(Name = "filter", IsRequired = true, EmitDefaultValue = true)]
        public string Filter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ResultMatchingPattern {\n");
            sb.Append("  Filter: ").Append(Filter).Append("\n");
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
            return this.Equals(input as ResultMatchingPattern);
        }

        /// <summary>
        /// Returns true if ResultMatchingPattern instances are equal
        /// </summary>
        /// <param name="input">Instance of ResultMatchingPattern to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ResultMatchingPattern input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Filter == input.Filter ||
                    (this.Filter != null &&
                    this.Filter.Equals(input.Filter))
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
                if (this.Filter != null)
                {
                    hashCode = (hashCode * 59) + this.Filter.GetHashCode();
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
            // Filter (string) maxLength
            if (this.Filter != null && this.Filter.Length > 1024)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Filter, length must be less than 1024.", new [] { "Filter" });
            }

            // Filter (string) minLength
            if (this.Filter != null && this.Filter.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Filter, length must be greater than 1.", new [] { "Filter" });
            }

            // Filter (string) pattern
            Regex regexFilter = new Regex(@"^[\s\S]*$", RegexOptions.CultureInvariant);
            if (false == regexFilter.Match(this.Filter).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Filter, must match a pattern of " + regexFilter, new [] { "Filter" });
            }

            yield break;
        }
    }
}

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
    /// Constraints that should be applied to a Tasks fields
    /// </summary>
    [DataContract(Name = "ValueConstraints")]
    public partial class ValueConstraints : IEquatable<ValueConstraints>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueConstraints" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValueConstraints() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValueConstraints" /> class.
        /// </summary>
        /// <param name="constraintType">Whether the constraint is a suggestion or should be enforced via validation (required).</param>
        /// <param name="valueSourceType">The source of the acceptable values (required).</param>
        /// <param name="acceptableValues">The acceptable values for the field (required).</param>
        public ValueConstraints(string constraintType = default(string), string valueSourceType = default(string), List<Object> acceptableValues = default(List<Object>))
        {
            // to ensure "constraintType" is required (not null)
            if (constraintType == null)
            {
                throw new ArgumentNullException("constraintType is a required property for ValueConstraints and cannot be null");
            }
            this.ConstraintType = constraintType;
            // to ensure "valueSourceType" is required (not null)
            if (valueSourceType == null)
            {
                throw new ArgumentNullException("valueSourceType is a required property for ValueConstraints and cannot be null");
            }
            this.ValueSourceType = valueSourceType;
            // to ensure "acceptableValues" is required (not null)
            if (acceptableValues == null)
            {
                throw new ArgumentNullException("acceptableValues is a required property for ValueConstraints and cannot be null");
            }
            this.AcceptableValues = acceptableValues;
        }

        /// <summary>
        /// Whether the constraint is a suggestion or should be enforced via validation
        /// </summary>
        /// <value>Whether the constraint is a suggestion or should be enforced via validation</value>
        [DataMember(Name = "constraintType", IsRequired = true, EmitDefaultValue = true)]
        public string ConstraintType { get; set; }

        /// <summary>
        /// The source of the acceptable values
        /// </summary>
        /// <value>The source of the acceptable values</value>
        [DataMember(Name = "valueSourceType", IsRequired = true, EmitDefaultValue = true)]
        public string ValueSourceType { get; set; }

        /// <summary>
        /// The acceptable values for the field
        /// </summary>
        /// <value>The acceptable values for the field</value>
        [DataMember(Name = "acceptableValues", IsRequired = true, EmitDefaultValue = true)]
        public List<Object> AcceptableValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValueConstraints {\n");
            sb.Append("  ConstraintType: ").Append(ConstraintType).Append("\n");
            sb.Append("  ValueSourceType: ").Append(ValueSourceType).Append("\n");
            sb.Append("  AcceptableValues: ").Append(AcceptableValues).Append("\n");
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
            return this.Equals(input as ValueConstraints);
        }

        /// <summary>
        /// Returns true if ValueConstraints instances are equal
        /// </summary>
        /// <param name="input">Instance of ValueConstraints to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValueConstraints input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ConstraintType == input.ConstraintType ||
                    (this.ConstraintType != null &&
                    this.ConstraintType.Equals(input.ConstraintType))
                ) && 
                (
                    this.ValueSourceType == input.ValueSourceType ||
                    (this.ValueSourceType != null &&
                    this.ValueSourceType.Equals(input.ValueSourceType))
                ) && 
                (
                    this.AcceptableValues == input.AcceptableValues ||
                    this.AcceptableValues != null &&
                    input.AcceptableValues != null &&
                    this.AcceptableValues.SequenceEqual(input.AcceptableValues)
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
                if (this.ConstraintType != null)
                {
                    hashCode = (hashCode * 59) + this.ConstraintType.GetHashCode();
                }
                if (this.ValueSourceType != null)
                {
                    hashCode = (hashCode * 59) + this.ValueSourceType.GetHashCode();
                }
                if (this.AcceptableValues != null)
                {
                    hashCode = (hashCode * 59) + this.AcceptableValues.GetHashCode();
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
            // ConstraintType (string) minLength
            if (this.ConstraintType != null && this.ConstraintType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ConstraintType, length must be greater than 1.", new [] { "ConstraintType" });
            }

            // ValueSourceType (string) minLength
            if (this.ValueSourceType != null && this.ValueSourceType.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for ValueSourceType, length must be greater than 1.", new [] { "ValueSourceType" });
            }

            yield break;
        }
    }
}

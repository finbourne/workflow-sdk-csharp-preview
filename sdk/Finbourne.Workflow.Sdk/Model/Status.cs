/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.128
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
    /// Denotes the status of the entire Task Instance
    /// </summary>
    /// <value>Denotes the status of the entire Task Instance</value>
    
    [JsonConverter(typeof(StringEnumConverter))]
    
    public enum Status
    {
        /// <summary>
        /// Enum Undefined for value: Undefined
        /// </summary>
        [EnumMember(Value = "Undefined")]
        Undefined = 1,

        /// <summary>
        /// Enum NotStarted for value: NotStarted
        /// </summary>
        [EnumMember(Value = "NotStarted")]
        NotStarted = 2,

        /// <summary>
        /// Enum InProgress for value: InProgress
        /// </summary>
        [EnumMember(Value = "InProgress")]
        InProgress = 3,

        /// <summary>
        /// Enum Failed for value: Failed
        /// </summary>
        [EnumMember(Value = "Failed")]
        Failed = 4,

        /// <summary>
        /// Enum Complete for value: Complete
        /// </summary>
        [EnumMember(Value = "Complete")]
        Complete = 5,

        /// <summary>
        /// Enum Blocked for value: Blocked
        /// </summary>
        [EnumMember(Value = "Blocked")]
        Blocked = 6

    }

}

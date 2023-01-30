/*
 * Merge Accounting API
 *
 * The unified API for building rich integrations with multiple Accounting & Finance platforms.
 *
 * The version of the OpenAPI document: 1.0
 * Contact: hello@merge.dev
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
using OpenAPIDateConverter = Merge.AccountingClient.Client.OpenAPIDateConverter;

namespace Merge.AccountingClient.Model
{
    /// <summary>
    /// Defines CategoryTypeEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoryTypeEnum
    {
        /// <summary>
        /// Enum CLASS for value: CLASS
        /// </summary>
        [EnumMember(Value = "CLASS")]
        CLASS = 1,

        /// <summary>
        /// Enum DEPARTMENT for value: DEPARTMENT
        /// </summary>
        [EnumMember(Value = "DEPARTMENT")]
        DEPARTMENT = 2

    }

}
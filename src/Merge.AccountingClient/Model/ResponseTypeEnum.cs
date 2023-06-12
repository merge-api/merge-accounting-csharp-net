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
    /// * &#x60;JSON&#x60; - JSON * &#x60;BASE64_GZIP&#x60; - BASE64_GZIP
    /// </summary>
    /// <value>* &#x60;JSON&#x60; - JSON * &#x60;BASE64_GZIP&#x60; - BASE64_GZIP</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ResponseTypeEnum
    {
        /// <summary>
        /// Enum JSON for value: JSON
        /// </summary>
        [EnumMember(Value = "JSON")]
        JSON = 1,

        /// <summary>
        /// Enum BASE64GZIP for value: BASE64_GZIP
        /// </summary>
        [EnumMember(Value = "BASE64_GZIP")]
        BASE64GZIP = 2

    }

}

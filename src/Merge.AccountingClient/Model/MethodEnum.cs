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
    /// * &#x60;GET&#x60; - GET * &#x60;OPTIONS&#x60; - OPTIONS * &#x60;HEAD&#x60; - HEAD * &#x60;POST&#x60; - POST * &#x60;PUT&#x60; - PUT * &#x60;PATCH&#x60; - PATCH * &#x60;DELETE&#x60; - DELETE
    /// </summary>
    /// <value>* &#x60;GET&#x60; - GET * &#x60;OPTIONS&#x60; - OPTIONS * &#x60;HEAD&#x60; - HEAD * &#x60;POST&#x60; - POST * &#x60;PUT&#x60; - PUT * &#x60;PATCH&#x60; - PATCH * &#x60;DELETE&#x60; - DELETE</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MethodEnum
    {
        /// <summary>
        /// Enum GET for value: GET
        /// </summary>
        [EnumMember(Value = "GET")]
        GET = 1,

        /// <summary>
        /// Enum OPTIONS for value: OPTIONS
        /// </summary>
        [EnumMember(Value = "OPTIONS")]
        OPTIONS = 2,

        /// <summary>
        /// Enum HEAD for value: HEAD
        /// </summary>
        [EnumMember(Value = "HEAD")]
        HEAD = 3,

        /// <summary>
        /// Enum POST for value: POST
        /// </summary>
        [EnumMember(Value = "POST")]
        POST = 4,

        /// <summary>
        /// Enum PUT for value: PUT
        /// </summary>
        [EnumMember(Value = "PUT")]
        PUT = 5,

        /// <summary>
        /// Enum PATCH for value: PATCH
        /// </summary>
        [EnumMember(Value = "PATCH")]
        PATCH = 6,

        /// <summary>
        /// Enum DELETE for value: DELETE
        /// </summary>
        [EnumMember(Value = "DELETE")]
        DELETE = 7

    }

}

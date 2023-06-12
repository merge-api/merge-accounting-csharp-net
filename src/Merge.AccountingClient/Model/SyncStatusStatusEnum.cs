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
    /// * &#x60;SYNCING&#x60; - SYNCING * &#x60;DONE&#x60; - DONE * &#x60;FAILED&#x60; - FAILED * &#x60;DISABLED&#x60; - DISABLED * &#x60;PAUSED&#x60; - PAUSED * &#x60;PARTIALLY_SYNCED&#x60; - PARTIALLY_SYNCED
    /// </summary>
    /// <value>* &#x60;SYNCING&#x60; - SYNCING * &#x60;DONE&#x60; - DONE * &#x60;FAILED&#x60; - FAILED * &#x60;DISABLED&#x60; - DISABLED * &#x60;PAUSED&#x60; - PAUSED * &#x60;PARTIALLY_SYNCED&#x60; - PARTIALLY_SYNCED</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SyncStatusStatusEnum
    {
        /// <summary>
        /// Enum SYNCING for value: SYNCING
        /// </summary>
        [EnumMember(Value = "SYNCING")]
        SYNCING = 1,

        /// <summary>
        /// Enum DONE for value: DONE
        /// </summary>
        [EnumMember(Value = "DONE")]
        DONE = 2,

        /// <summary>
        /// Enum FAILED for value: FAILED
        /// </summary>
        [EnumMember(Value = "FAILED")]
        FAILED = 3,

        /// <summary>
        /// Enum DISABLED for value: DISABLED
        /// </summary>
        [EnumMember(Value = "DISABLED")]
        DISABLED = 4,

        /// <summary>
        /// Enum PAUSED for value: PAUSED
        /// </summary>
        [EnumMember(Value = "PAUSED")]
        PAUSED = 5,

        /// <summary>
        /// Enum PARTIALLYSYNCED for value: PARTIALLY_SYNCED
        /// </summary>
        [EnumMember(Value = "PARTIALLY_SYNCED")]
        PARTIALLYSYNCED = 6

    }

}

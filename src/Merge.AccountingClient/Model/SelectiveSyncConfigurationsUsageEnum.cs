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
    /// Defines SelectiveSyncConfigurationsUsageEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SelectiveSyncConfigurationsUsageEnum
    {
        /// <summary>
        /// Enum NEXTSYNC for value: IN_NEXT_SYNC
        /// </summary>
        [EnumMember(Value = "IN_NEXT_SYNC")]
        NEXTSYNC = 1,

        /// <summary>
        /// Enum LASTSYNC for value: IN_LAST_SYNC
        /// </summary>
        [EnumMember(Value = "IN_LAST_SYNC")]
        LASTSYNC = 2

    }

}

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
    /// Defines CategoriesEnum
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CategoriesEnum
    {
        /// <summary>
        /// Enum Hris for value: hris
        /// </summary>
        [EnumMember(Value = "hris")]
        Hris = 1,

        /// <summary>
        /// Enum Ats for value: ats
        /// </summary>
        [EnumMember(Value = "ats")]
        Ats = 2,

        /// <summary>
        /// Enum Accounting for value: accounting
        /// </summary>
        [EnumMember(Value = "accounting")]
        Accounting = 3,

        /// <summary>
        /// Enum Ticketing for value: ticketing
        /// </summary>
        [EnumMember(Value = "ticketing")]
        Ticketing = 4,

        /// <summary>
        /// Enum Crm for value: crm
        /// </summary>
        [EnumMember(Value = "crm")]
        Crm = 5

    }

}

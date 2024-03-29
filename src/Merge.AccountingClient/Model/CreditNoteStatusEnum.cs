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
    /// * &#x60;SUBMITTED&#x60; - SUBMITTED * &#x60;AUTHORIZED&#x60; - AUTHORIZED * &#x60;PAID&#x60; - PAID
    /// </summary>
    /// <value>* &#x60;SUBMITTED&#x60; - SUBMITTED * &#x60;AUTHORIZED&#x60; - AUTHORIZED * &#x60;PAID&#x60; - PAID</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum CreditNoteStatusEnum
    {
        /// <summary>
        /// Enum SUBMITTED for value: SUBMITTED
        /// </summary>
        [EnumMember(Value = "SUBMITTED")]
        SUBMITTED = 1,

        /// <summary>
        /// Enum AUTHORIZED for value: AUTHORIZED
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED = 2,

        /// <summary>
        /// Enum PAID for value: PAID
        /// </summary>
        [EnumMember(Value = "PAID")]
        PAID = 3

    }

}

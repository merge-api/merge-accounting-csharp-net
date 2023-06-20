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
    /// * &#x60;DRAFT&#x60; - DRAFT * &#x60;SUBMITTED&#x60; - SUBMITTED * &#x60;AUTHORIZED&#x60; - AUTHORIZED * &#x60;BILLED&#x60; - BILLED * &#x60;DELETED&#x60; - DELETED
    /// </summary>
    /// <value>* &#x60;DRAFT&#x60; - DRAFT * &#x60;SUBMITTED&#x60; - SUBMITTED * &#x60;AUTHORIZED&#x60; - AUTHORIZED * &#x60;BILLED&#x60; - BILLED * &#x60;DELETED&#x60; - DELETED</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PurchaseOrderStatusEnum
    {
        /// <summary>
        /// Enum DRAFT for value: DRAFT
        /// </summary>
        [EnumMember(Value = "DRAFT")]
        DRAFT = 1,

        /// <summary>
        /// Enum SUBMITTED for value: SUBMITTED
        /// </summary>
        [EnumMember(Value = "SUBMITTED")]
        SUBMITTED = 2,

        /// <summary>
        /// Enum AUTHORIZED for value: AUTHORIZED
        /// </summary>
        [EnumMember(Value = "AUTHORIZED")]
        AUTHORIZED = 3,

        /// <summary>
        /// Enum BILLED for value: BILLED
        /// </summary>
        [EnumMember(Value = "BILLED")]
        BILLED = 4,

        /// <summary>
        /// Enum DELETED for value: DELETED
        /// </summary>
        [EnumMember(Value = "DELETED")]
        DELETED = 5

    }

}

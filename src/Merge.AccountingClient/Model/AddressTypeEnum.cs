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
    /// * &#x60;BILLING&#x60; - BILLING * &#x60;SHIPPING&#x60; - SHIPPING
    /// </summary>
    /// <value>* &#x60;BILLING&#x60; - BILLING * &#x60;SHIPPING&#x60; - SHIPPING</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AddressTypeEnum
    {
        /// <summary>
        /// Enum BILLING for value: BILLING
        /// </summary>
        [EnumMember(Value = "BILLING")]
        BILLING = 1,

        /// <summary>
        /// Enum SHIPPING for value: SHIPPING
        /// </summary>
        [EnumMember(Value = "SHIPPING")]
        SHIPPING = 2

    }

}

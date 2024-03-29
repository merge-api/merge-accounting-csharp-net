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
using System.IO;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using RestSharp;
using Xunit;

using Merge.AccountingClient.Client;
using Merge.AccountingClient.Api;
// uncomment below to import models
//using Merge.AccountingClient.Model;

namespace Merge.AccountingClient.Test.Api
{
    /// <summary>
    ///  Class for testing LinkedAccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class LinkedAccountsApiTests : IDisposable
    {
        private LinkedAccountsApi instance;

        public LinkedAccountsApiTests()
        {
            instance = new LinkedAccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of LinkedAccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' LinkedAccountsApi
            //Assert.IsType<LinkedAccountsApi>(instance);
        }

        /// <summary>
        /// Test LinkedAccountsList
        /// </summary>
        [Fact]
        public void LinkedAccountsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string category = null;
            //string cursor = null;
            //string endUserEmailAddress = null;
            //string endUserOrganizationName = null;
            //string endUserOriginId = null;
            //string endUserOriginIds = null;
            //Guid? id = null;
            //string ids = null;
            //bool? includeDuplicates = null;
            //string integrationName = null;
            //string isTestAccount = null;
            //int? pageSize = null;
            //string status = null;
            //var response = instance.LinkedAccountsList(category, cursor, endUserEmailAddress, endUserOrganizationName, endUserOriginId, endUserOriginIds, id, ids, includeDuplicates, integrationName, isTestAccount, pageSize, status);
            //Assert.IsType<PaginatedAccountDetailsAndActionsList>(response);
        }
    }
}

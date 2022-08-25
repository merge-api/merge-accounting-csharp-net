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
    ///  Class for testing AccountsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class AccountsApiTests : IDisposable
    {
        private AccountsApi instance;

        public AccountsApiTests()
        {
            instance = new AccountsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of AccountsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' AccountsApi
            //Assert.IsType<AccountsApi>(instance);
        }

        /// <summary>
        /// Test AccountsList
        /// </summary>
        [Fact]
        public void AccountsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteFields = null;
            //string remoteId = null;
            //var response = instance.AccountsList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId);
            //Assert.IsType<PaginatedAccountList>(response);
        }

        /// <summary>
        /// Test AccountsRetrieve
        /// </summary>
        [Fact]
        public void AccountsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //string remoteFields = null;
            //var response = instance.AccountsRetrieve(xAccountToken, id, includeRemoteData, remoteFields);
            //Assert.IsType<Account>(response);
        }
    }
}

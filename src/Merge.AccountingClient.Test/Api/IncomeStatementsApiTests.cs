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
    ///  Class for testing IncomeStatementsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class IncomeStatementsApiTests : IDisposable
    {
        private IncomeStatementsApi instance;

        public IncomeStatementsApiTests()
        {
            instance = new IncomeStatementsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of IncomeStatementsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' IncomeStatementsApi
            //Assert.IsType<IncomeStatementsApi>(instance);
        }

        /// <summary>
        /// Test IncomeStatementsList
        /// </summary>
        [Fact]
        public void IncomeStatementsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string companyId = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //var response = instance.IncomeStatementsList(xAccountToken, companyId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedIncomeStatementList>(response);
        }

        /// <summary>
        /// Test IncomeStatementsRetrieve
        /// </summary>
        [Fact]
        public void IncomeStatementsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //var response = instance.IncomeStatementsRetrieve(xAccountToken, id, includeRemoteData);
            //Assert.IsType<IncomeStatement>(response);
        }
    }
}

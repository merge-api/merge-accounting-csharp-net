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
    ///  Class for testing CreditNotesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class CreditNotesApiTests : IDisposable
    {
        private CreditNotesApi instance;

        public CreditNotesApiTests()
        {
            instance = new CreditNotesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of CreditNotesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' CreditNotesApi
            //Assert.IsType<CreditNotesApi>(instance);
        }

        /// <summary>
        /// Test CreditNotesList
        /// </summary>
        [Fact]
        public void CreditNotesListTest()
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
            //string remoteFields = null;
            //string remoteId = null;
            //string showEnumOrigins = null;
            //DateTime? transactionDateAfter = null;
            //DateTime? transactionDateBefore = null;
            //var response = instance.CreditNotesList(xAccountToken, companyId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId, showEnumOrigins, transactionDateAfter, transactionDateBefore);
            //Assert.IsType<PaginatedCreditNoteList>(response);
        }

        /// <summary>
        /// Test CreditNotesRetrieve
        /// </summary>
        [Fact]
        public void CreditNotesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //string remoteFields = null;
            //string showEnumOrigins = null;
            //var response = instance.CreditNotesRetrieve(xAccountToken, id, includeRemoteData, remoteFields, showEnumOrigins);
            //Assert.IsType<CreditNote>(response);
        }
    }
}

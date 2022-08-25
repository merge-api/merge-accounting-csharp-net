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
    ///  Class for testing InvoicesApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class InvoicesApiTests : IDisposable
    {
        private InvoicesApi instance;

        public InvoicesApiTests()
        {
            instance = new InvoicesApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of InvoicesApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' InvoicesApi
            //Assert.IsType<InvoicesApi>(instance);
        }

        /// <summary>
        /// Test InvoicesCreate
        /// </summary>
        [Fact]
        public void InvoicesCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //InvoiceEndpointRequest invoiceEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.InvoicesCreate(xAccountToken, invoiceEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<InvoiceResponse>(response);
        }

        /// <summary>
        /// Test InvoicesList
        /// </summary>
        [Fact]
        public void InvoicesListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string contactId = null;
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
            //string type = null;
            //var response = instance.InvoicesList(xAccountToken, contactId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId, type);
            //Assert.IsType<PaginatedInvoiceList>(response);
        }

        /// <summary>
        /// Test InvoicesMetaPostRetrieve
        /// </summary>
        [Fact]
        public void InvoicesMetaPostRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.InvoicesMetaPostRetrieve(xAccountToken);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test InvoicesRetrieve
        /// </summary>
        [Fact]
        public void InvoicesRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //string remoteFields = null;
            //var response = instance.InvoicesRetrieve(xAccountToken, id, includeRemoteData, remoteFields);
            //Assert.IsType<Invoice>(response);
        }
    }
}

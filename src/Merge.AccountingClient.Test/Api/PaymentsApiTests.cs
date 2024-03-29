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
    ///  Class for testing PaymentsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class PaymentsApiTests : IDisposable
    {
        private PaymentsApi instance;

        public PaymentsApiTests()
        {
            instance = new PaymentsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of PaymentsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' PaymentsApi
            //Assert.IsType<PaymentsApi>(instance);
        }

        /// <summary>
        /// Test PaymentsCreate
        /// </summary>
        [Fact]
        public void PaymentsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //PaymentEndpointRequest paymentEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.PaymentsCreate(xAccountToken, paymentEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<PaymentResponse>(response);
        }

        /// <summary>
        /// Test PaymentsList
        /// </summary>
        [Fact]
        public void PaymentsListTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //string accountId = null;
            //string companyId = null;
            //string contactId = null;
            //DateTime? createdAfter = null;
            //DateTime? createdBefore = null;
            //string cursor = null;
            //bool? includeDeletedData = null;
            //bool? includeRemoteData = null;
            //DateTime? modifiedAfter = null;
            //DateTime? modifiedBefore = null;
            //int? pageSize = null;
            //string remoteId = null;
            //DateTime? transactionDateAfter = null;
            //DateTime? transactionDateBefore = null;
            //var response = instance.PaymentsList(xAccountToken, accountId, companyId, contactId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId, transactionDateAfter, transactionDateBefore);
            //Assert.IsType<PaginatedPaymentList>(response);
        }

        /// <summary>
        /// Test PaymentsMetaPostRetrieve
        /// </summary>
        [Fact]
        public void PaymentsMetaPostRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.PaymentsMetaPostRetrieve(xAccountToken);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test PaymentsRetrieve
        /// </summary>
        [Fact]
        public void PaymentsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //var response = instance.PaymentsRetrieve(xAccountToken, id, includeRemoteData);
            //Assert.IsType<Payment>(response);
        }
    }
}

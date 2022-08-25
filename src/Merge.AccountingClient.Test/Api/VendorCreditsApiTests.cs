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
    ///  Class for testing VendorCreditsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class VendorCreditsApiTests : IDisposable
    {
        private VendorCreditsApi instance;

        public VendorCreditsApiTests()
        {
            instance = new VendorCreditsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of VendorCreditsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' VendorCreditsApi
            //Assert.IsType<VendorCreditsApi>(instance);
        }

        /// <summary>
        /// Test VendorCreditsList
        /// </summary>
        [Fact]
        public void VendorCreditsListTest()
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
            //string remoteId = null;
            //var response = instance.VendorCreditsList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
            //Assert.IsType<PaginatedVendorCreditList>(response);
        }

        /// <summary>
        /// Test VendorCreditsRetrieve
        /// </summary>
        [Fact]
        public void VendorCreditsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //var response = instance.VendorCreditsRetrieve(xAccountToken, id, includeRemoteData);
            //Assert.IsType<VendorCredit>(response);
        }
    }
}
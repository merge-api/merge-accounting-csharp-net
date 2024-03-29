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
    ///  Class for testing ContactsApi
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by OpenAPI Generator (https://openapi-generator.tech).
    /// Please update the test case below to test the API endpoint.
    /// </remarks>
    public class ContactsApiTests : IDisposable
    {
        private ContactsApi instance;

        public ContactsApiTests()
        {
            instance = new ContactsApi();
        }

        public void Dispose()
        {
            // Cleanup when everything is done.
        }

        /// <summary>
        /// Test an instance of ContactsApi
        /// </summary>
        [Fact]
        public void InstanceTest()
        {
            // TODO uncomment below to test 'IsType' ContactsApi
            //Assert.IsType<ContactsApi>(instance);
        }

        /// <summary>
        /// Test ContactsCreate
        /// </summary>
        [Fact]
        public void ContactsCreateTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //ContactEndpointRequest contactEndpointRequest = null;
            //bool? isDebugMode = null;
            //bool? runAsync = null;
            //var response = instance.ContactsCreate(xAccountToken, contactEndpointRequest, isDebugMode, runAsync);
            //Assert.IsType<ContactResponse>(response);
        }

        /// <summary>
        /// Test ContactsList
        /// </summary>
        [Fact]
        public void ContactsListTest()
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
            //var response = instance.ContactsList(xAccountToken, companyId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId, showEnumOrigins);
            //Assert.IsType<PaginatedContactList>(response);
        }

        /// <summary>
        /// Test ContactsMetaPostRetrieve
        /// </summary>
        [Fact]
        public void ContactsMetaPostRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //var response = instance.ContactsMetaPostRetrieve(xAccountToken);
            //Assert.IsType<MetaResponse>(response);
        }

        /// <summary>
        /// Test ContactsRetrieve
        /// </summary>
        [Fact]
        public void ContactsRetrieveTest()
        {
            // TODO uncomment below to test the method and replace null with proper value
            //string xAccountToken = null;
            //Guid id = null;
            //bool? includeRemoteData = null;
            //string remoteFields = null;
            //string showEnumOrigins = null;
            //var response = instance.ContactsRetrieve(xAccountToken, id, includeRemoteData, remoteFields, showEnumOrigins);
            //Assert.IsType<Contact>(response);
        }
    }
}

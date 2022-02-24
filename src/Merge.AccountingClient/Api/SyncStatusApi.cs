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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Merge.AccountingClient.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISyncStatusApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <returns>PaginatedSyncStatusList</returns>
        PaginatedSyncStatusList SyncStatusList(string xAccountToken, string cursor = default(string), int? pageSize = default(int?));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <returns>ApiResponse of PaginatedSyncStatusList</returns>
        ApiResponse<PaginatedSyncStatusList> SyncStatusListWithHttpInfo(string xAccountToken, string cursor = default(string), int? pageSize = default(int?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISyncStatusApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedSyncStatusList</returns>
        System.Threading.Tasks.Task<PaginatedSyncStatusList> SyncStatusListAsync(string xAccountToken, string cursor = default(string), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedSyncStatusList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedSyncStatusList>> SyncStatusListWithHttpInfoAsync(string xAccountToken, string cursor = default(string), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ISyncStatusApi : ISyncStatusApiSync, ISyncStatusApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class SyncStatusApi : ISyncStatusApi
    {
        private Merge.AccountingClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SyncStatusApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncStatusApi"/> class.
        /// </summary>
        /// <returns></returns>
        public SyncStatusApi(String basePath)
        {
            this.Configuration = Merge.AccountingClient.Client.Configuration.MergeConfigurations(
                Merge.AccountingClient.Client.GlobalConfiguration.Instance,
                new Merge.AccountingClient.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Merge.AccountingClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Merge.AccountingClient.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Merge.AccountingClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncStatusApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public SyncStatusApi(Merge.AccountingClient.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = Merge.AccountingClient.Client.Configuration.MergeConfigurations(
                Merge.AccountingClient.Client.GlobalConfiguration.Instance,
                configuration
            );
            this.Client = new Merge.AccountingClient.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Merge.AccountingClient.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Merge.AccountingClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SyncStatusApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public SyncStatusApi(Merge.AccountingClient.Client.ISynchronousClient client, Merge.AccountingClient.Client.IAsynchronousClient asyncClient, Merge.AccountingClient.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Merge.AccountingClient.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Merge.AccountingClient.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Merge.AccountingClient.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Merge.AccountingClient.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Merge.AccountingClient.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        ///  Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <returns>PaginatedSyncStatusList</returns>
        public PaginatedSyncStatusList SyncStatusList(string xAccountToken, string cursor = default(string), int? pageSize = default(int?))
        {
            Merge.AccountingClient.Client.ApiResponse<PaginatedSyncStatusList> localVarResponse = SyncStatusListWithHttpInfo(xAccountToken, cursor, pageSize);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <returns>ApiResponse of PaginatedSyncStatusList</returns>
        public Merge.AccountingClient.Client.ApiResponse<PaginatedSyncStatusList> SyncStatusListWithHttpInfo(string xAccountToken, string cursor = default(string), int? pageSize = default(int?))
        {
            // verify the required parameter 'xAccountToken' is set
            if (xAccountToken == null)
                throw new Merge.AccountingClient.Client.ApiException(400, "Missing required parameter 'xAccountToken' when calling SyncStatusApi->SyncStatusList");

            Merge.AccountingClient.Client.RequestOptions localVarRequestOptions = new Merge.AccountingClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Merge.AccountingClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Merge.AccountingClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            localVarRequestOptions.HeaderParameters.Add("X-Account-Token", Merge.AccountingClient.Client.ClientUtils.ParameterToString(xAccountToken)); // header parameter

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PaginatedSyncStatusList>("/sync-status", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SyncStatusList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedSyncStatusList</returns>
        public async System.Threading.Tasks.Task<PaginatedSyncStatusList> SyncStatusListAsync(string xAccountToken, string cursor = default(string), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Merge.AccountingClient.Client.ApiResponse<PaginatedSyncStatusList> localVarResponse = await SyncStatusListWithHttpInfoAsync(xAccountToken, cursor, pageSize, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  Get syncing status. Possible values: &#x60;DISABLED&#x60;, &#x60;DONE&#x60;, &#x60;FAILED&#x60;, &#x60;SYNCING&#x60;
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="xAccountToken">Token identifying the end user.</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedSyncStatusList)</returns>
        public async System.Threading.Tasks.Task<Merge.AccountingClient.Client.ApiResponse<PaginatedSyncStatusList>> SyncStatusListWithHttpInfoAsync(string xAccountToken, string cursor = default(string), int? pageSize = default(int?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'xAccountToken' is set
            if (xAccountToken == null)
                throw new Merge.AccountingClient.Client.ApiException(400, "Missing required parameter 'xAccountToken' when calling SyncStatusApi->SyncStatusList");


            Merge.AccountingClient.Client.RequestOptions localVarRequestOptions = new Merge.AccountingClient.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Merge.AccountingClient.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Merge.AccountingClient.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            localVarRequestOptions.HeaderParameters.Add("X-Account-Token", Merge.AccountingClient.Client.ClientUtils.ParameterToString(xAccountToken)); // header parameter

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PaginatedSyncStatusList>("/sync-status", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("SyncStatusList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

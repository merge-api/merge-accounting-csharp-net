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
    public interface ILinkedAccountsApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List linked accounts for your organization.
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <returns>PaginatedAccountDetailsAndActionsList</returns>
        PaginatedAccountDetailsAndActionsList LinkedAccountsList(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List linked accounts for your organization.
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <returns>ApiResponse of PaginatedAccountDetailsAndActionsList</returns>
        ApiResponse<PaginatedAccountDetailsAndActionsList> LinkedAccountsListWithHttpInfo(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILinkedAccountsApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List linked accounts for your organization.
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedAccountDetailsAndActionsList</returns>
        System.Threading.Tasks.Task<PaginatedAccountDetailsAndActionsList> LinkedAccountsListAsync(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// 
        /// </summary>
        /// <remarks>
        /// List linked accounts for your organization.
        /// </remarks>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedAccountDetailsAndActionsList)</returns>
        System.Threading.Tasks.Task<ApiResponse<PaginatedAccountDetailsAndActionsList>> LinkedAccountsListWithHttpInfoAsync(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ILinkedAccountsApi : ILinkedAccountsApiSync, ILinkedAccountsApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class LinkedAccountsApi : ILinkedAccountsApi
    {
        private Merge.AccountingClient.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinkedAccountsApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LinkedAccountsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public LinkedAccountsApi(String basePath)
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
        /// Initializes a new instance of the <see cref="LinkedAccountsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public LinkedAccountsApi(Merge.AccountingClient.Client.Configuration configuration)
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
        /// Initializes a new instance of the <see cref="LinkedAccountsApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public LinkedAccountsApi(Merge.AccountingClient.Client.ISynchronousClient client, Merge.AccountingClient.Client.IAsynchronousClient asyncClient, Merge.AccountingClient.Client.IReadableConfiguration configuration)
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
        ///  List linked accounts for your organization.
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <returns>PaginatedAccountDetailsAndActionsList</returns>
        public PaginatedAccountDetailsAndActionsList LinkedAccountsList(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string))
        {
            Merge.AccountingClient.Client.ApiResponse<PaginatedAccountDetailsAndActionsList> localVarResponse = LinkedAccountsListWithHttpInfo(category, cursor, endUserEmailAddress, endUserOrganizationName, endUserOriginId, endUserOriginIds, id, ids, integrationName, isTestAccount, pageSize, status);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  List linked accounts for your organization.
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <returns>ApiResponse of PaginatedAccountDetailsAndActionsList</returns>
        public Merge.AccountingClient.Client.ApiResponse<PaginatedAccountDetailsAndActionsList> LinkedAccountsListWithHttpInfo(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string))
        {
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

            if (category != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "category", category));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (endUserEmailAddress != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_email_address", endUserEmailAddress));
            }
            if (endUserOrganizationName != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_organization_name", endUserOrganizationName));
            }
            if (endUserOriginId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_origin_id", endUserOriginId));
            }
            if (endUserOriginIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_origin_ids", endUserOriginIds));
            }
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (ids != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "ids", ids));
            }
            if (integrationName != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "integration_name", integrationName));
            }
            if (isTestAccount != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "is_test_account", isTestAccount));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request
            var localVarResponse = this.Client.Get<PaginatedAccountDetailsAndActionsList>("/linked-accounts", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LinkedAccountsList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        ///  List linked accounts for your organization.
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of PaginatedAccountDetailsAndActionsList</returns>
        public async System.Threading.Tasks.Task<PaginatedAccountDetailsAndActionsList> LinkedAccountsListAsync(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Merge.AccountingClient.Client.ApiResponse<PaginatedAccountDetailsAndActionsList> localVarResponse = await LinkedAccountsListWithHttpInfoAsync(category, cursor, endUserEmailAddress, endUserOrganizationName, endUserOriginId, endUserOriginIds, id, ids, integrationName, isTestAccount, pageSize, status, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        ///  List linked accounts for your organization.
        /// </summary>
        /// <exception cref="Merge.AccountingClient.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="category"> (optional)</param>
        /// <param name="cursor">The pagination cursor value. (optional)</param>
        /// <param name="endUserEmailAddress"> (optional)</param>
        /// <param name="endUserOrganizationName"> (optional)</param>
        /// <param name="endUserOriginId"> (optional)</param>
        /// <param name="endUserOriginIds">Comma-separated list of EndUser origin IDs, making it possible to specify multiple EndUsers at once (optional)</param>
        /// <param name="id"> (optional)</param>
        /// <param name="ids">Comma-separated list of LinkedAccount IDs, making it possible to specify multiple LinkedAccounts at once (optional)</param>
        /// <param name="integrationName"> (optional)</param>
        /// <param name="isTestAccount">If included, will only include test linked accounts. If not included, will only include non-test linked accounts (optional)</param>
        /// <param name="pageSize">Number of results to return per page. (optional)</param>
        /// <param name="status">Filter by status. Options: &#x60;COMPLETE&#x60;, &#x60;INCOMPLETE&#x60;, &#x60;RELINK_NEEDED&#x60; (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (PaginatedAccountDetailsAndActionsList)</returns>
        public async System.Threading.Tasks.Task<Merge.AccountingClient.Client.ApiResponse<PaginatedAccountDetailsAndActionsList>> LinkedAccountsListWithHttpInfoAsync(string category = default(string), int? cursor = default(int?), string endUserEmailAddress = default(string), string endUserOrganizationName = default(string), string endUserOriginId = default(string), string endUserOriginIds = default(string), Guid? id = default(Guid?), string ids = default(string), string integrationName = default(string), string isTestAccount = default(string), int? pageSize = default(int?), string status = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {

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

            if (category != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "category", category));
            }
            if (cursor != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "cursor", cursor));
            }
            if (endUserEmailAddress != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_email_address", endUserEmailAddress));
            }
            if (endUserOrganizationName != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_organization_name", endUserOrganizationName));
            }
            if (endUserOriginId != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_origin_id", endUserOriginId));
            }
            if (endUserOriginIds != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "end_user_origin_ids", endUserOriginIds));
            }
            if (id != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "id", id));
            }
            if (ids != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "ids", ids));
            }
            if (integrationName != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "integration_name", integrationName));
            }
            if (isTestAccount != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "is_test_account", isTestAccount));
            }
            if (pageSize != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "page_size", pageSize));
            }
            if (status != null)
            {
                localVarRequestOptions.QueryParameters.Add(Merge.AccountingClient.Client.ClientUtils.ParameterToMultiMap("", "status", status));
            }

            // authentication (tokenAuth) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", this.Configuration.GetApiKeyWithPrefix("Authorization"));
            }

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<PaginatedAccountDetailsAndActionsList>("/linked-accounts", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("LinkedAccountsList", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}

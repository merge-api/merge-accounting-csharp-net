# Merge.AccountingClient.Api.AccountsApi

All URIs are relative to *https://api.merge.dev/api/accounting/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountsList**](AccountsApi.md#accountslist) | **GET** /accounts | 
[**AccountsRetrieve**](AccountsApi.md#accountsretrieve) | **GET** /accounts/{id} | 


<a name="accountslist"></a>
# **AccountsList**
> PaginatedAccountList AccountsList (string xAccountToken, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteId = null)



Returns a list of `Account` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class AccountsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was deleted in the third-party service. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified after this datetime. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified before this datetime. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 

            try
            {
                PaginatedAccountList result = apiInstance.AccountsList(xAccountToken, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteId);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsList: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAccountToken** | **string**| Token identifying the end user. | 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was deleted in the third-party service. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, will only return objects modified after this datetime. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, will only return objects modified before this datetime. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 

### Return type

[**PaginatedAccountList**](PaginatedAccountList.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="accountsretrieve"></a>
# **AccountsRetrieve**
> Account AccountsRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null)



Returns an `Account` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class AccountsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 

            try
            {
                Account result = apiInstance.AccountsRetrieve(xAccountToken, id, includeRemoteData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountsApi.AccountsRetrieve: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **xAccountToken** | **string**| Token identifying the end user. | 
 **id** | [**Guid**](Guid.md)|  | 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 

### Return type

[**Account**](Account.md)

### Authorization

[tokenAuth](../README.md#tokenAuth)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** |  |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


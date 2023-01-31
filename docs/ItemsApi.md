# Merge.AccountingClient.Api.ItemsApi

All URIs are relative to *https://api.merge.dev/api/accounting/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**ItemsList**](ItemsApi.md#itemslist) | **GET** /items | 
[**ItemsRetrieve**](ItemsApi.md#itemsretrieve) | **GET** /items/{id} | 


<a name="itemslist"></a>
# **ItemsList**
> PaginatedItemList ItemsList (string xAccountToken, string companyId = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteFields = null, string remoteId = null, string showEnumOrigins = null)



Returns a list of `Item` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class ItemsListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ItemsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var companyId = companyId_example;  // string | If provided, will only return items for this company. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified after this datetime. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects modified before this datetime. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var remoteFields = status;  // string | Deprecated. Use show_enum_origins. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 
            var showEnumOrigins = status;  // string | Which fields should be returned in non-normalized form. (optional) 

            try
            {
                PaginatedItemList result = apiInstance.ItemsList(xAccountToken, companyId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId, showEnumOrigins);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsList: " + e.Message );
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
 **companyId** | **string**| If provided, will only return items for this company. | [optional] 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, will only return objects modified after this datetime. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, will only return objects modified before this datetime. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteFields** | **string**| Deprecated. Use show_enum_origins. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 
 **showEnumOrigins** | **string**| Which fields should be returned in non-normalized form. | [optional] 

### Return type

[**PaginatedItemList**](PaginatedItemList.md)

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

<a name="itemsretrieve"></a>
# **ItemsRetrieve**
> Item ItemsRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null, string remoteFields = null, string showEnumOrigins = null)



Returns an `Item` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class ItemsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new ItemsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var remoteFields = status;  // string | Deprecated. Use show_enum_origins. (optional) 
            var showEnumOrigins = status;  // string | Which fields should be returned in non-normalized form. (optional) 

            try
            {
                Item result = apiInstance.ItemsRetrieve(xAccountToken, id, includeRemoteData, remoteFields, showEnumOrigins);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ItemsApi.ItemsRetrieve: " + e.Message );
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
 **remoteFields** | **string**| Deprecated. Use show_enum_origins. | [optional] 
 **showEnumOrigins** | **string**| Which fields should be returned in non-normalized form. | [optional] 

### Return type

[**Item**](Item.md)

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


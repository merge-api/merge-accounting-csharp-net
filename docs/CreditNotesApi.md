# Merge.AccountingClient.Api.CreditNotesApi

All URIs are relative to *https://api.merge.dev/api/accounting/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreditNotesList**](CreditNotesApi.md#creditnoteslist) | **GET** /credit-notes | 
[**CreditNotesRetrieve**](CreditNotesApi.md#creditnotesretrieve) | **GET** /credit-notes/{id} | 


<a name="creditnoteslist"></a>
# **CreditNotesList**
> PaginatedCreditNoteList CreditNotesList (string xAccountToken, string companyId = null, DateTime? createdAfter = null, DateTime? createdBefore = null, string cursor = null, bool? includeDeletedData = null, bool? includeRemoteData = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null, int? pageSize = null, string remoteFields = null, string remoteId = null, string showEnumOrigins = null, DateTime? transactionDateAfter = null, DateTime? transactionDateBefore = null)



Returns a list of `CreditNote` objects.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class CreditNotesListExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CreditNotesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var companyId = companyId_example;  // string | If provided, will only return credit notes for this company. (optional) 
            var createdAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var createdBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 
            var cursor = cD0yMDIxLTAxLTA2KzAzJTNBMjQlM0E1My40MzQzMjYlMkIwMCUzQTAw;  // string | The pagination cursor value. (optional) 
            var includeDeletedData = true;  // bool? | Whether to include data that was marked as deleted by third party webhooks. (optional) 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var modifiedAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge after this date time will be returned. (optional) 
            var modifiedBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, only objects synced by Merge before this date time will be returned. (optional) 
            var pageSize = 56;  // int? | Number of results to return per page. (optional) 
            var remoteFields = status,type;  // string | Deprecated. Use show_enum_origins. (optional) 
            var remoteId = remoteId_example;  // string | The API provider's ID for the given object. (optional) 
            var showEnumOrigins = status,type;  // string | Which fields should be returned in non-normalized form. (optional) 
            var transactionDateAfter = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created after this datetime. (optional) 
            var transactionDateBefore = 2013-10-20T19:20:30+01:00;  // DateTime? | If provided, will only return objects created before this datetime. (optional) 

            try
            {
                PaginatedCreditNoteList result = apiInstance.CreditNotesList(xAccountToken, companyId, createdAfter, createdBefore, cursor, includeDeletedData, includeRemoteData, modifiedAfter, modifiedBefore, pageSize, remoteFields, remoteId, showEnumOrigins, transactionDateAfter, transactionDateBefore);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreditNotesList: " + e.Message );
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
 **companyId** | **string**| If provided, will only return credit notes for this company. | [optional] 
 **createdAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **createdBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 
 **cursor** | **string**| The pagination cursor value. | [optional] 
 **includeDeletedData** | **bool?**| Whether to include data that was marked as deleted by third party webhooks. | [optional] 
 **includeRemoteData** | **bool?**| Whether to include the original data Merge fetched from the third-party to produce these models. | [optional] 
 **modifiedAfter** | **DateTime?**| If provided, only objects synced by Merge after this date time will be returned. | [optional] 
 **modifiedBefore** | **DateTime?**| If provided, only objects synced by Merge before this date time will be returned. | [optional] 
 **pageSize** | **int?**| Number of results to return per page. | [optional] 
 **remoteFields** | **string**| Deprecated. Use show_enum_origins. | [optional] 
 **remoteId** | **string**| The API provider&#39;s ID for the given object. | [optional] 
 **showEnumOrigins** | **string**| Which fields should be returned in non-normalized form. | [optional] 
 **transactionDateAfter** | **DateTime?**| If provided, will only return objects created after this datetime. | [optional] 
 **transactionDateBefore** | **DateTime?**| If provided, will only return objects created before this datetime. | [optional] 

### Return type

[**PaginatedCreditNoteList**](PaginatedCreditNoteList.md)

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

<a name="creditnotesretrieve"></a>
# **CreditNotesRetrieve**
> CreditNote CreditNotesRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null, string remoteFields = null, string showEnumOrigins = null)



Returns a `CreditNote` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class CreditNotesRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new CreditNotesApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 
            var remoteFields = status,type;  // string | Deprecated. Use show_enum_origins. (optional) 
            var showEnumOrigins = status,type;  // string | Which fields should be returned in non-normalized form. (optional) 

            try
            {
                CreditNote result = apiInstance.CreditNotesRetrieve(xAccountToken, id, includeRemoteData, remoteFields, showEnumOrigins);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling CreditNotesApi.CreditNotesRetrieve: " + e.Message );
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

[**CreditNote**](CreditNote.md)

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


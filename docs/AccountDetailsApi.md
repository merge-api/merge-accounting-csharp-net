# Merge.AccountingClient.Api.AccountDetailsApi

All URIs are relative to *https://api.merge.dev/api/accounting/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AccountDetailsRetrieve**](AccountDetailsApi.md#accountdetailsretrieve) | **GET** /account-details | 


<a name="accountdetailsretrieve"></a>
# **AccountDetailsRetrieve**
> AccountDetails AccountDetailsRetrieve (string xAccountToken)



Get details for a linked account.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class AccountDetailsRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new AccountDetailsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.

            try
            {
                AccountDetails result = apiInstance.AccountDetailsRetrieve(xAccountToken);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling AccountDetailsApi.AccountDetailsRetrieve: " + e.Message );
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

### Return type

[**AccountDetails**](AccountDetails.md)

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


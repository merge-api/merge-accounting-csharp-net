# Merge.AccountingClient.Api.PhoneNumbersApi

All URIs are relative to *https://api.merge.dev/api/accounting/v1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**PhoneNumbersRetrieve**](PhoneNumbersApi.md#phonenumbersretrieve) | **GET** /phone-numbers/{id} | 


<a name="phonenumbersretrieve"></a>
# **PhoneNumbersRetrieve**
> AccountingPhoneNumber PhoneNumbersRetrieve (string xAccountToken, Guid id, bool? includeRemoteData = null)



Returns an `AccountingPhoneNumber` object with the given `id`.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class PhoneNumbersRetrieveExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.AddApiKey("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.AddApiKeyPrefix("Authorization", "Bearer");

            var apiInstance = new PhoneNumbersApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.
            var id = new Guid(); // Guid | 
            var includeRemoteData = true;  // bool? | Whether to include the original data Merge fetched from the third-party to produce these models. (optional) 

            try
            {
                AccountingPhoneNumber result = apiInstance.PhoneNumbersRetrieve(xAccountToken, id, includeRemoteData);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling PhoneNumbersApi.PhoneNumbersRetrieve: " + e.Message );
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

[**AccountingPhoneNumber**](AccountingPhoneNumber.md)

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


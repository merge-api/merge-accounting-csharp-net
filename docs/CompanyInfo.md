# Merge.AccountingClient.Model.CompanyInfo
# The CompanyInfo Object ### Description The `CompanyInfo` object is used to represent a company's information.  ### Usage Example Fetch from the `GET CompanyInfo` endpoint and view a company's information.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The company&#39;s name. | [optional] 
**LegalName** | **string** | The company&#39;s legal name. | [optional] 
**TaxNumber** | **string** | The company&#39;s tax number. | [optional] 
**FiscalYearEndMonth** | **int?** | The company&#39;s fiscal year end month. | [optional] 
**FiscalYearEndDay** | **int?** | The company&#39;s fiscal year end day. | [optional] 
**Currency** | **string** | The currency set in the company&#39;s accounting platform. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s company was created. | [optional] 
**Urls** | **List&lt;string&gt;** | The company&#39;s urls. | [optional] 
**Addresses** | [**List&lt;Address&gt;**](Address.md) |  | [optional] 
**PhoneNumbers** | [**List&lt;AccountingPhoneNumber&gt;**](AccountingPhoneNumber.md) |  | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


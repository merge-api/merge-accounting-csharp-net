# Merge.AccountingClient.Model.VendorCredit
# The VendorCredit Object ### Description The `VendorCredit` object is used to represent a company's vendor credits.  ### Usage Example Fetch from the `GET VendorCredit` endpoint and view a company's vendor credits.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Number** | **string** | The vendor credit&#39;s number. | [optional] 
**TransactionDate** | **DateTime?** | The vendor credit&#39;s transaction date. | [optional] 
**Vendor** | **Guid?** |  | [optional] 
**TotalAmount** | **float?** | The vendor credit&#39;s total amount. | [optional] 
**Currency** | **string** | The vendor credit&#39;s currency. | [optional] 
**Lines** | [**List&lt;VendorCreditLine&gt;**](VendorCreditLine.md) |  | [optional] [readonly] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


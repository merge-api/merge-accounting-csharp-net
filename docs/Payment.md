# Merge.AccountingClient.Model.Payment
# The Payment Object ### Description The `Payment` object is used to represent a invoice's payment.  ### Usage Example Fetch from the `GET Payment` endpoint and view an invoice's payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**TransactionDate** | **DateTime?** | The payment&#39;s transaction date. | [optional] 
**Contact** | **Guid?** | The payment&#39;s contact. | [optional] 
**Account** | **Guid?** | The payment&#39;s account. | [optional] 
**TotalAmount** | **float?** | The payment&#39;s total amount. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s payment entry was updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


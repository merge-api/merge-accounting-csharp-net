# Merge.AccountingClient.Model.Transaction

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**TransactionType** | **string** | The type of general transaction. | [optional] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Number** | **string** | The transaction number. | [optional] 
**TransactionDate** | **DateTime?** | The transaction date. | [optional] 
**Account** | **Guid?** | The transaction&#39;s account. | [optional] 
**Contact** | **Guid?** | The transaction&#39;s contact. | [optional] 
**TotalAmount** | **decimal?** | The transaction&#39;s total amount. | [optional] 
**Currency** | **string** | The transaction&#39;s currency. | [optional] 
**LineItems** | [**List&lt;TransactionLineItem&gt;**](TransactionLineItem.md) |  | [optional] [readonly] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


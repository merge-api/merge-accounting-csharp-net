# Merge.AccountingClient.Model.Expense
# The Expense Object ### Description The `Expense` object is used to represent a company's expenses  ### Usage Example Fetch from the `GET Expense` endpoint and view a company's expense.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**TransactionDate** | **DateTime?** | When the transaction occurred. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the expense was created. | [optional] 
**Account** | **Guid?** |  | [optional] 
**Contact** | **Guid?** |  | [optional] 
**TotalAmount** | **float?** | The expense&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The expense&#39;s currency. | [optional] 
**Lines** | [**List&lt;ExpenseLine&gt;**](ExpenseLine.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


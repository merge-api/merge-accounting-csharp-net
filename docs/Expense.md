# Merge.AccountingClient.Model.Expense
# The Expense Object ### Description The `Expense` object is used to represent a purchase made from a business which can be made with a check, credit card, or cash. Each expense object is dedicated to a grouping of expenses, with each expense recorded in the lines object.  ### Usage Example Fetch from the `GET Expense` endpoint and view a company's expense.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**TransactionDate** | **DateTime?** | When the transaction occurred. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the expense was created. | [optional] 
**Account** | **Guid?** | The expense&#39;s payment account. | [optional] 
**Contact** | **Guid?** | The expense&#39;s contact. | [optional] 
**TotalAmount** | **float?** | The expense&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The expense&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The expense&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the expense belongs to. | [optional] 
**Memo** | **string** | The expense&#39;s private note. | [optional] 
**Lines** | [**List&lt;ExpenseLine&gt;**](ExpenseLine.md) |  | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.Transaction
# The Transaction Object ### Description The `Transaction` includes different types of transactions. The Transactions object does not cover expenses, credit notes, vendor credit, invoices, purchase orders, and journal entries. See the “transaction_type” field for more information.  ### Usage Example Fetch from the `GET Transaction` endpoint and view a company's transactions.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionType** | **string** | The type of transaction, which can by any transaction object not already included in Merge’s common model. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Number** | **string** | The transaction&#39;s number used for identifying purposes. | [optional] 
**TransactionDate** | **DateTime?** | The date upon which the transaction occurred. | [optional] 
**Account** | **Guid?** | The transaction&#39;s account. | [optional] 
**Contact** | **Guid?** | The contact to whom the transaction relates to. | [optional] 
**TotalAmount** | **decimal?** | The total amount being paid after taxes. | [optional] 
**Currency** | **CurrencyEnum** | The transaction&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The transaction&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the transaction belongs to. | [optional] 
**LineItems** | [**List&lt;TransactionLineItem&gt;**](TransactionLineItem.md) |  | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


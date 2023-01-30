# Merge.AccountingClient.Model.ExpenseRequest
# The Expense Object ### Description The `Expense` object is used to represent a purchase made from a business which can be made with a check, credit card, or cash. Each expense object is dedicated to a grouping of expenses, with each expense recorded in the lines object.  ### Usage Example Fetch from the `GET Expense` endpoint and view a company's expense.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDate** | **DateTime?** | When the transaction occurred. | [optional] 
**Account** | **Guid?** | The expense&#39;s payment account. | [optional] 
**Contact** | **Guid?** | The expense&#39;s contact. | [optional] 
**TotalAmount** | **float?** | The expense&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The expense&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The expense&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the expense belongs to. | [optional] 
**Memo** | **string** | The expense&#39;s private note. | [optional] 
**Lines** | [**List&lt;ExpenseLineRequest&gt;**](ExpenseLineRequest.md) |  | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


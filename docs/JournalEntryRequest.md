# Merge.AccountingClient.Model.JournalEntryRequest
# The JournalEntry Object ### Description The `JournalEntry` object is used to get a record of all manually created entries made in a company’s general ledger. The journal line items for each journal entry should sum to zero.  ### Usage Example Fetch from the `GET JournalEntry` endpoint and view a company's journey entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDate** | **DateTime?** | The journal entry&#39;s transaction date. | [optional] 
**Payments** | **List&lt;Guid?&gt;** | Array of &#x60;Payment&#x60; object IDs. | [optional] 
**Memo** | **string** | The journal entry&#39;s private note. | [optional] 
**Currency** | **CurrencyEnum** | The journal&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The journal entry&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the journal entry belongs to. | [optional] 
**Lines** | [**List&lt;JournalLineRequest&gt;**](JournalLineRequest.md) |  | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


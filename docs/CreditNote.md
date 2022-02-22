# Merge.AccountingClient.Model.CreditNote
# The CreditNote Object ### Description The `CreditNote` object is used to represent a refund or credit of payment.  ### Usage Example Fetch from the `LIST CreditNotes` endpoint and view a company's credit notes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**TransactionDate** | **DateTime?** | The credit note&#39;s transaction date. | [optional] 
**Status** | **CreditNoteStatusEnum** | The credit note&#39;s status. | [optional] 
**TotalAmount** | **float?** | The credit note&#39;s total amount. | [optional] 
**RemainingCredit** | **float?** | The credit note&#39;s remaining credit. | [optional] 
**Currency** | **CurrencyEnum** | The credit note&#39;s currency. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s credit note was created. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s credit note was updated. | [optional] 
**Payments** | **List&lt;Guid?&gt;** | Array of &#x60;Payment&#x60; object IDs | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


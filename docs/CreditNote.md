# Merge.AccountingClient.Model.CreditNote
# The CreditNote Object ### Description The `CreditNote` object are an accounts payable transaction used when to represent a gift or refund to a customer. A credit note will contain information on the amount of credit owed, the customer, and the account.  ### Usage Example Fetch from the `LIST CreditNotes` endpoint and view a company's credit notes.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**TransactionDate** | **DateTime?** | The credit note&#39;s transaction date. | [optional] 
**Status** | **CreditNoteStatusEnum** | The credit note&#39;s status. | [optional] 
**Number** | **string** | The credit note&#39;s number. | [optional] 
**Contact** | **Guid?** | The credit note&#39;s contact. | [optional] 
**Company** | **Guid?** | The company the credit note belongs to. | [optional] 
**TotalAmount** | **float?** | The credit note&#39;s total amount. | [optional] 
**RemainingCredit** | **float?** | The amount of value remaining in the credit note that the customer can use. | [optional] 
**LineItems** | [**List&lt;CreditNoteLineItem&gt;**](CreditNoteLineItem.md) |  | [optional] 
**Currency** | **CurrencyEnum** | The credit note&#39;s currency. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s credit note was created. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s credit note was updated. | [optional] 
**Payments** | **List&lt;Guid?&gt;** | Array of &#x60;Payment&#x60; object IDs | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


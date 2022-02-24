# Merge.AccountingClient.Model.JournalEntryRequest
# The JournalEntry Object ### Description The `JournalEntry` object is used to represent a company's journey entries  ### Usage Example Fetch from the `GET JournalEntry` endpoint and view a company's journey entry.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**TransactionDate** | **DateTime?** | The journal entry&#39;s transaction date. | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s journal entry was created. | [optional] 
**Payments** | **List&lt;Guid?&gt;** | Array of &#x60;Payment&#x60; object IDs. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.JournalLineRequest
# The JournalLine Object ### Description The `JournalLine` object is used to represent a journal entry's line items.  ### Usage Example Fetch from the `GET JournalEntry` endpoint and view the journal entry's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Account** | **Guid?** |  | [optional] 
**NetAmount** | **float?** | The line&#39;s net amount. | [optional] 
**TrackingCategory** | **Guid?** |  | [optional] 
**Contact** | **Guid?** |  | [optional] 
**Description** | **string** | The line&#39;s description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


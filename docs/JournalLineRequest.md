# Merge.AccountingClient.Model.JournalLineRequest
# The JournalLine Object ### Description The `JournalLine` object is used to represent a journal entry's line items.  ### Usage Example Fetch from the `GET JournalEntry` endpoint and view the journal entry's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Account** | **Guid?** |  | [optional] 
**NetAmount** | **float?** | The value of the line item including taxes and other fees. | [optional] 
**TrackingCategory** | **Guid?** |  | [optional] 
**TrackingCategories** | **List&lt;Guid?&gt;** |  | [optional] 
**Contact** | **Guid?** |  | [optional] 
**Description** | **string** | The line&#39;s description. | [optional] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


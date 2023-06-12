# Merge.AccountingClient.Model.JournalLine
# The JournalLine Object ### Description The `JournalLine` object is used to represent a journal entry's line items.  ### Usage Example Fetch from the `GET JournalEntry` endpoint and view the journal entry's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Account** | **Guid?** |  | [optional] 
**NetAmount** | **double?** | The value of the line item including taxes and other fees. | [optional] 
**TrackingCategory** | **Guid?** |  | [optional] 
**TrackingCategories** | **List&lt;Guid?&gt;** |  | [optional] 
**Contact** | **Guid?** |  | [optional] 
**Description** | **string** | The line&#39;s description. | [optional] 
**ExchangeRate** | **decimal?** | The journal line item&#39;s exchange rate. | [optional] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.TrackingCategory
# The TrackingCategory Object ### Description The `TrackingCategory` object is used to represent a company's tracking categories.  ### Usage Example Fetch from the `GET TrackingCategory` endpoint and view a company's tracking category.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The tracking category&#39;s name. | [optional] 
**Status** | **string** | The tracking category&#39;s status. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


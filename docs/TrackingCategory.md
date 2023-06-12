# Merge.AccountingClient.Model.TrackingCategory
# The TrackingCategory Object ### Description The `TrackingCategory` object is used to represent a company's tracking categories.  ### Usage Example Fetch from the `GET TrackingCategory` endpoint and view a company's tracking category.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The tracking category&#39;s name. | [optional] 
**Status** | **Status7d1Enum** | The tracking category&#39;s status.  * &#x60;ACTIVE&#x60; - ACTIVE * &#x60;ARCHIVED&#x60; - ARCHIVED | [optional] 
**CategoryType** | **CategoryTypeEnum** | The tracking category’s type.  * &#x60;CLASS&#x60; - CLASS * &#x60;DEPARTMENT&#x60; - DEPARTMENT | [optional] 
**ParentCategory** | **Guid?** | ID of the parent tracking category. | [optional] 
**Company** | **Guid?** | The company the tracking category belongs to. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


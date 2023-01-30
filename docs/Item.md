# Merge.AccountingClient.Model.Item
# The Item Object ### Description The `Item` object refers to the goods involved in a transaction.  ### Usage Example Fetch from the `LIST Items` endpoint and view a company's items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The item&#39;s name. | [optional] 
**Status** | **Status7d1Enum** | The item&#39;s status. | [optional] 
**UnitPrice** | **float?** | The item&#39;s unit price. | [optional] 
**PurchasePrice** | **float?** | The price at which the item is purchased from a vendor. | [optional] 
**PurchaseAccount** | **Guid?** | References the default account used to record a purchase of the item. | [optional] 
**SalesAccount** | **Guid?** | References the default account used to record a sale. | [optional] 
**Company** | **Guid?** | The company the item belongs to. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s item note was updated. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


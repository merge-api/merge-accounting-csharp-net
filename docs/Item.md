# Merge.AccountingClient.Model.Item
# The Item Object ### Description The `Item` object is used to represent an item that a company buys, sells, or resells, such as products and services.  ### Usage Example Fetch from the `LIST Items` endpoint and view a company's items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The item&#39;s name. | [optional] 
**Status** | **Status7d1Enum** | The item&#39;s status. | [optional] 
**UnitPrice** | **float?** | The item&#39;s unit price. | [optional] 
**PurchasePrice** | **float?** | The item&#39;s purchase price. | [optional] 
**PurchaseAccount** | **Guid?** |  | [optional] 
**SalesAccount** | **Guid?** |  | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s item note was updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


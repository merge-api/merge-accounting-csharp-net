# Merge.AccountingClient.Model.PurchaseOrder
# The PurchaseOrder Object ### Description The `PurchaseOrder` object is used to represent a company's purchase orders.  ### Usage Example Fetch from the `LIST PurchaseOrders` endpoint and view a company's purchase orders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Status** | **PurchaseOrderStatusEnum** | The purchase order&#39;s status. | [optional] 
**IssueDate** | **DateTime?** | The purchase order&#39;s issue date. | [optional] 
**DeliveryDate** | **DateTime?** | The purchase order&#39;s delivery date. | [optional] 
**DeliveryAddress** | **Guid?** | The purchase order&#39;s delivery address. | [optional] 
**TotalAmount** | **float?** | The purchase order&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The purchase order&#39;s currency. | [optional] 
**LineItems** | [**List&lt;PurchaseOrderLineItem&gt;**](PurchaseOrderLineItem.md) |  | [optional] [readonly] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s purchase order note was created. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s purchase order note was updated. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


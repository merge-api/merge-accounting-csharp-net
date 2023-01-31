# Merge.AccountingClient.Model.PurchaseOrder
# The PurchaseOrder Object ### Description The `PurchaseOrder` object is a record of request for a product or service between a buyer and seller.  ### Usage Example Fetch from the `LIST PurchaseOrders` endpoint and view a company's purchase orders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Status** | **PurchaseOrderStatusEnum** | The purchase order&#39;s status. | [optional] 
**IssueDate** | **DateTime?** | The purchase order&#39;s issue date. | [optional] 
**DeliveryDate** | **DateTime?** | The purchase order&#39;s delivery date. | [optional] 
**DeliveryAddress** | **Guid?** | The purchase order&#39;s delivery address. | [optional] 
**Customer** | **Guid?** | The contact making the purchase order. | [optional] 
**Vendor** | **Guid?** | The party fulfilling the purchase order. | [optional] 
**Memo** | **string** | A memo attached to the purchase order. | [optional] 
**TotalAmount** | **float?** | The purchase order&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The purchase order&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The purchase order&#39;s exchange rate. | [optional] 
**LineItems** | [**List&lt;PurchaseOrderLineItem&gt;**](PurchaseOrderLineItem.md) |  | [optional] 
**RemoteCreatedAt** | **DateTime?** | When the third party&#39;s purchase order note was created. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s purchase order note was updated. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


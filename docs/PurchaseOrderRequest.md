# Merge.AccountingClient.Model.PurchaseOrderRequest
# The PurchaseOrder Object ### Description The `PurchaseOrder` object is a record of request for a product or service between a buyer and seller.  ### Usage Example Fetch from the `LIST PurchaseOrders` endpoint and view a company's purchase orders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
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
**LineItems** | [**List&lt;PurchaseOrderLineItemRequest&gt;**](PurchaseOrderLineItemRequest.md) |  | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


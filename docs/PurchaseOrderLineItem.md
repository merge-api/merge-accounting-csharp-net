# Merge.AccountingClient.Model.PurchaseOrderLineItem
# The PurchaseOrderLineItem Object ### Description The `PurchaseOrderLineItem` object is used to represent a purchase order's line item.  ### Usage Example Fetch from the `GET PurchaseOrder` endpoint and view a company's purchase orders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The line item&#39;s description. | [optional] 
**UnitPrice** | **float?** | The line item&#39;s unit price. | [optional] 
**Quantity** | **float?** | The line item&#39;s quantity. | [optional] 
**Item** | **Guid?** |  | [optional] 
**Account** | **Guid?** | The purchase order line item&#39;s account. | [optional] 
**TrackingCategory** | **Guid?** | The purchase order line item&#39;s associated tracking category. | [optional] 
**TaxAmount** | **decimal?** | The purchase order line item&#39;s tax amount. | [optional] 
**TotalLineAmount** | **decimal?** | The purchase order line item&#39;s total amount. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


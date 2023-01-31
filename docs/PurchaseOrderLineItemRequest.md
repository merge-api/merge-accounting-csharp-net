# Merge.AccountingClient.Model.PurchaseOrderLineItemRequest
# The PurchaseOrderLineItem Object ### Description The `PurchaseOrderLineItem` object is used to represent a purchase order's line item.  ### Usage Example Fetch from the `GET PurchaseOrder` endpoint and view a company's purchase orders.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | A description of the good being purchased. | [optional] 
**UnitPrice** | **float?** | The line item&#39;s unit price. | [optional] 
**Quantity** | **float?** | The line item&#39;s quantity. | [optional] 
**Item** | **Guid?** |  | [optional] 
**Account** | **Guid?** | The purchase order line item&#39;s account. | [optional] 
**TrackingCategory** | **Guid?** | The purchase order line item&#39;s associated tracking category. | [optional] 
**TrackingCategories** | **List&lt;Guid&gt;** | The purchase order line item&#39;s associated tracking categories. | 
**TaxAmount** | **decimal?** | The purchase order line item&#39;s tax amount. | [optional] 
**TotalLineAmount** | **decimal?** | The purchase order line item&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The purchase order line item&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The purchase order line item&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the purchase order line item belongs to. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


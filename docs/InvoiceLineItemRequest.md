# Merge.AccountingClient.Model.InvoiceLineItemRequest
# The InvoiceLineItem Object ### Description The `InvoiceLineItem` object is used to represent an invoice's line items.  ### Usage Example Fetch from the `GET Invoice` endpoint and view the invoice's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Description** | **string** | The line item&#39;s description. | [optional] 
**UnitPrice** | **float?** | The line item&#39;s unit price. | [optional] 
**Quantity** | **float?** | The line item&#39;s quantity. | [optional] 
**TotalAmount** | **float?** | The line item&#39;s total amount. | [optional] 
**Item** | **Guid?** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


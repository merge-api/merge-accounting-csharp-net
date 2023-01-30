# Merge.AccountingClient.Model.InvoiceLineItem
# The InvoiceLineItem Object ### Description The `InvoiceLineItem` object represents an itemized record of goods and/or services sold to a customer. If type = accounts_payable, invoice is a bill, if type = accounts_receivable it's an invoice.  ### Usage Example Fetch from the `GET Invoice` endpoint and view the invoice's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Description** | **string** | The line item&#39;s description. | [optional] 
**UnitPrice** | **float?** | The line item&#39;s unit price. | [optional] 
**Quantity** | **float?** | The line item&#39;s quantity. | [optional] 
**TotalAmount** | **float?** | The line item&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The line item&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The line item&#39;s exchange rate. | [optional] 
**Item** | **Guid?** |  | [optional] 
**Account** | **Guid?** |  | [optional] 
**TrackingCategory** | **Guid?** |  | [optional] 
**TrackingCategories** | **List&lt;Guid?&gt;** |  | [optional] 
**Company** | **Guid?** | The company the line item belongs to. | [optional] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


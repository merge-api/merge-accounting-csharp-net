# Merge.AccountingClient.Model.TransactionLineItem
# The TransactionLineItem Object ### Description The `TransactionLineItem` object is used to represent a transaction's line items.  ### Usage Example Fetch from the `GET TransactionLineItem` endpoint and view the transaction's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Memo** | **string** | An internal note used by the business to clarify purpose of the transaction. | [optional] 
**UnitPrice** | **decimal?** | The line item&#39;s unit price. | [optional] 
**Quantity** | **decimal?** | The line item&#39;s quantity. | [optional] 
**Item** | **Guid?** |  | [optional] 
**Account** | **Guid?** | The line item&#39;s account. | [optional] 
**TrackingCategory** | **Guid?** | The line&#39;s associated tracking category. | [optional] 
**TrackingCategories** | **List&lt;Guid&gt;** | The line&#39;s associated tracking categories. | 
**TotalLineAmount** | **decimal?** | The line item&#39;s total. | [optional] 
**TaxRate** | **Guid?** | The line item&#39;s tax rate. | [optional] 
**Currency** | **CurrencyEnum** | The line item&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The line item&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the line belongs to. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


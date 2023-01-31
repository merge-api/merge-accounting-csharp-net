# Merge.AccountingClient.Model.PaymentRequest
# The Payment Object ### Description The `Payment` object represents general payments made towards a specific transaction.  ### Usage Example Fetch from the `GET Payment` endpoint and view an invoice's payment.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TransactionDate** | **DateTime?** | The payment&#39;s transaction date. | [optional] 
**Contact** | **Guid?** | The supplier, or customer involved in the payment. | [optional] 
**Account** | **Guid?** | The supplier’s or customer’s account in which the payment is made. | [optional] 
**Currency** | **CurrencyEnum** | The payment&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The payment&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the payment belongs to. | [optional] 
**TotalAmount** | **float?** | The total amount of money being paid to the supplier, or customer, after taxes. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.Invoice
# The Invoice Object     ### Description     The `Invoice` object represents an itemized record of goods and/or services sold to a customer. If type = accounts_payable `Invoice` is a bill, if type = accounts_receivable it's an invoice.      ### Usage Example     Fetch from the `LIST Invoices` endpoint and view a company's invoices.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Type** | **InvoiceTypeEnum** | Whether the invoice is an accounts receivable or accounts payable. Accounts payable invoices are commonly referred to as Bills. | [optional] 
**Contact** | **Guid?** | The invoice&#39;s contact. | [optional] 
**Number** | **string** | The invoice&#39;s number. | [optional] 
**IssueDate** | **DateTime?** | The invoice&#39;s issue date. | [optional] 
**DueDate** | **DateTime?** | The invoice&#39;s due date. | [optional] 
**PaidOnDate** | **DateTime?** | The invoice&#39;s paid date. | [optional] 
**Memo** | **string** | The invoice&#39;s private note. | [optional] 
**Company** | **Guid?** | The company the invoice belongs to. | [optional] 
**Currency** | **CurrencyEnum** | The invoice&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The invoice&#39;s exchange rate. | [optional] 
**TotalDiscount** | **float?** | The total discounts applied to the total cost. | [optional] 
**SubTotal** | **float?** | The total amount being paid before taxes. | [optional] 
**TotalTaxAmount** | **float?** | The total amount being paid in taxes. | [optional] 
**TotalAmount** | **float?** | The invoice&#39;s total amount. | [optional] 
**Balance** | **float?** | The invoice&#39;s remaining balance. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s invoice entry was updated. | [optional] 
**Payments** | **List&lt;Guid?&gt;** | Array of &#x60;Payment&#x60; object IDs. | [optional] 
**LineItems** | [**List&lt;InvoiceLineItem&gt;**](InvoiceLineItem.md) |  | [optional] 
**RemoteWasDeleted** | **bool** |  | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.Invoice
# The Invoice Object ### Description The `Invoice` object is used to represent a company's invoices.  ### Usage Example Fetch from the `LIST Invoices` endpoint and view a company's invoices.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Type** | **string** | The invoice&#39;s type. | [optional] 
**Contact** | **Guid?** |  | [optional] 
**Number** | **string** | The invoice&#39;s number. | [optional] 
**IssueDate** | **DateTime?** | The invoice&#39;s issue date. | [optional] 
**DueDate** | **DateTime?** | The invoice&#39;s due date. | [optional] 
**PaidOnDate** | **DateTime?** | The invoice&#39;s paid date. | [optional] 
**Memo** | **string** | The invoice&#39;s private note. | [optional] 
**Currency** | **string** | The invoice&#39;s currency. | [optional] 
**TotalDiscount** | **float?** | The invoice&#39;s total discount. | [optional] 
**SubTotal** | **float?** | The invoice&#39;s sub-total. | [optional] 
**TotalTaxAmount** | **float?** | The invoice&#39;s total tax amount. | [optional] 
**TotalAmount** | **float?** | The invoice&#39;s total amount. | [optional] 
**Balance** | **float?** | The invoice&#39;s remaining balance. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s invoice entry was updated. | [optional] 
**Payments** | **List&lt;Guid?&gt;** | Array of &#x60;Payment&#x60; object IDs. | [optional] 
**LineItems** | [**List&lt;InvoiceLineItem&gt;**](InvoiceLineItem.md) |  | [optional] [readonly] 
**RemoteWasDeleted** | **bool** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


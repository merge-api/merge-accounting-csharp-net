# Merge.AccountingClient.Model.VendorCredit
# The VendorCredit Object ### Description The `VendorCredit` object is an accounts receivable transaction used to show that a customer is owed a gift or refund. A vendor credit will contain information on the amount of credit owed to the customer, the vendor that owes the credit, and the account.  ### Usage Example Fetch from the `GET VendorCredit` endpoint and view a company's vendor credits.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Number** | **string** | The vendor credit&#39;s number. | [optional] 
**TransactionDate** | **DateTime?** | The vendor credit&#39;s transaction date. | [optional] 
**Vendor** | **Guid?** | The vendor that owes the gift or refund. | [optional] 
**TotalAmount** | **float?** | The vendor credit&#39;s total amount. | [optional] 
**Currency** | **CurrencyEnum** | The vendor credit&#39;s currency. | [optional] 
**ExchangeRate** | **decimal?** | The vendor credit&#39;s exchange rate. | [optional] 
**Company** | **Guid?** | The company the vendor credit belongs to. | [optional] 
**Lines** | [**List&lt;VendorCreditLine&gt;**](VendorCreditLine.md) |  | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


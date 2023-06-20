# Merge.AccountingClient.Model.VendorCreditLine
# The VendorCreditLine Object ### Description The `VendorCreditLine` object is used to represent a vendor credit's line items.  ### Usage Example Fetch from the `GET VendorCredit` endpoint and view the vendor credit's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**NetAmount** | **double?** | The full value of the credit. | [optional] 
**TrackingCategory** | **Guid?** | The line&#39;s associated tracking category. | [optional] 
**TrackingCategories** | **List&lt;Guid&gt;** | The line&#39;s associated tracking categories. | 
**Description** | **string** | The line&#39;s description. | [optional] 
**Account** | **Guid?** | The line&#39;s account. | [optional] 
**Company** | **Guid?** | The company the line belongs to. | [optional] 
**ExchangeRate** | **decimal?** | The vendor credit line item&#39;s exchange rate. | [optional] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.VendorCreditLine
# The VendorCreditLine Object ### Description The `VendorCreditLine` object is used to represent a vendor credit's line items.  ### Usage Example Fetch from the `GET VendorCredit` endpoint and view the vendor credit's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**NetAmount** | **float?** | The line&#39;s net amount. | [optional] 
**TrackingCategory** | **Guid?** | The line&#39;s associated tracking category. | [optional] 
**Description** | **string** | The line&#39;s description. | [optional] 
**Account** | **Guid?** | The line&#39;s account. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


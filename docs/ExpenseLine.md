# Merge.AccountingClient.Model.ExpenseLine
# The ExpenseLine Object ### Description The `ExpenseLine` object is used to represent an expense's line items.  ### Usage Example Fetch from the `GET Expense` endpoint and view the expense's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Item** | **Guid?** | The line&#39;s item. | [optional] 
**NetAmount** | **float?** | The line&#39;s net amount. | [optional] 
**TrackingCategory** | **Guid?** |  | [optional] 
**Account** | **Guid?** |  | [optional] 
**Description** | **string** | The line item&#39;s description. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


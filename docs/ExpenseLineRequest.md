# Merge.AccountingClient.Model.ExpenseLineRequest
# The ExpenseLine Object ### Description The `ExpenseLine` object is used to represent an expense's line items.  ### Usage Example Fetch from the `GET Expense` endpoint and view the expense's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Item** | **Guid?** | The line&#39;s item. | [optional] 
**NetAmount** | **float?** | The line&#39;s net amount. | [optional] 
**TrackingCategory** | **Guid?** |  | [optional] 
**TrackingCategories** | **List&lt;Guid?&gt;** |  | [optional] 
**Company** | **Guid?** | The company the line belongs to. | [optional] 
**Account** | **Guid?** | The expense&#39;s payment account. | [optional] 
**Description** | **string** | The description of the item that was purchased by the company. | [optional] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


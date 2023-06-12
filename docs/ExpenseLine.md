# Merge.AccountingClient.Model.ExpenseLine
# The ExpenseLine Object ### Description The `ExpenseLine` object is used to represent an expense's line items.  ### Usage Example Fetch from the `GET Expense` endpoint and view the expense's line items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Item** | **Guid?** | The line&#39;s item. | [optional] 
**NetAmount** | **double?** | The line&#39;s net amount. | [optional] 
**TrackingCategory** | **Guid?** |  | [optional] 
**TrackingCategories** | **List&lt;Guid?&gt;** |  | [optional] 
**Company** | **Guid?** | The company the line belongs to. | [optional] 
**Account** | **Guid?** | The expense&#39;s payment account. | [optional] 
**Contact** | **Guid?** | The expense&#39;s contact. | [optional] 
**Description** | **string** | The description of the item that was purchased by the company. | [optional] 
**ExchangeRate** | **decimal?** | The expense line item&#39;s exchange rate. | [optional] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


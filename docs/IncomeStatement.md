# Merge.AccountingClient.Model.IncomeStatement
# The IncomeStatement Object ### Description The `IncomeStatement` object is used to represent a company's income statements.  ### Usage Example Fetch from the `GET IncomeStatement` endpoint and view a company's income statement for a given period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The income statement&#39;s name. | [optional] 
**StartPeriod** | **DateTime?** | The income statement&#39;s start period. | [optional] 
**EndPeriod** | **DateTime?** | The income statement&#39;s end period. | [optional] 
**Income** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**CostOfSales** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**GrossProfit** | **float?** | The income statement&#39;s gross profit. | [optional] 
**OperatingExpenses** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**NetOperatingIncome** | **float?** | The income statement&#39;s net operating profit. | [optional] 
**NonOperatingExpenses** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**NetIncome** | **float?** | The income statement&#39;s net income. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


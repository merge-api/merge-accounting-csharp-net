# Merge.AccountingClient.Model.IncomeStatement
# The IncomeStatement Object ### Description The `IncomeStatement` object is used to represent a company’s income, the cost of sales, operating expenses, and other non-operating expenses. The object also includes other important values like gross profit, gross operating profit, and net income. This represents a period of time (month, quarter, or year).  ### Usage Example Fetch from the `GET IncomeStatement` endpoint and view a company's income statement for a given period.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The income statement&#39;s name. | [optional] 
**Currency** | **CurrencyEnum** | The income statement&#39;s currency. | [optional] 
**Company** | **Guid?** | The company the income statement belongs to. | [optional] 
**StartPeriod** | **DateTime?** | The income statement&#39;s start period. | [optional] 
**EndPeriod** | **DateTime?** | The income statement&#39;s end period. | [optional] 
**Income** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**CostOfSales** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**GrossProfit** | **float?** | The revenue minus the cost of sale. | [optional] 
**OperatingExpenses** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**NetOperatingIncome** | **float?** | The revenue minus the operating expenses. | [optional] 
**NonOperatingExpenses** | [**List&lt;ReportItem&gt;**](ReportItem.md) |  | [optional] [readonly] 
**NetIncome** | **float?** | The gross profit minus the total expenses. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.ReportItem
# The ReportItem Object ### Description The `ReportItem` object is used to represent a report item for a Balance Sheet, Cash Flow Statement or Profit and Loss Report.  ### Usage Example Fetch from the `GET BalanceSheet` endpoint and view the balance sheet's report items.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**Name** | **string** | The report item&#39;s name. | [optional] 
**Value** | **double?** | The report item&#39;s value. | [optional] 
**SubItems** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 
**Company** | **Guid?** | The company the report item belongs to. | [optional] 
**ModifiedAt** | **DateTime** | This is the datetime that this object was last updated by Merge | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


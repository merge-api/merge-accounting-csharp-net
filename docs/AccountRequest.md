# Merge.AccountingClient.Model.AccountRequest
# The Account Object ### Description The `Account` object is what companies use to track transactions. They can be both bank accounts or a general ledger account (also called a chart of accounts).  ### Usage Example Fetch from the `LIST Accounts` endpoint and view a company's accounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The account&#39;s name. | [optional] 
**Description** | **string** | The account&#39;s description. | [optional] 
**Classification** | **ClassificationEnum** | The account&#39;s broadest grouping. | [optional] 
**Type** | **string** | The account&#39;s type is a narrower and more specific grouping within the account&#39;s classification. | [optional] 
**Status** | **AccountStatusEnum** | The account&#39;s status. | [optional] 
**CurrentBalance** | **float?** | The account&#39;s current balance. | [optional] 
**Currency** | **CurrencyEnum** | The account&#39;s currency. | [optional] 
**AccountNumber** | **string** | The account&#39;s number. | [optional] 
**ParentAccount** | **Guid?** | ID of the parent account. | [optional] 
**Company** | **Guid?** | The company the account belongs to. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


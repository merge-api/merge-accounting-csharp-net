# Merge.AccountingClient.Model.Account
# The Account Object ### Description The `Account` object is what businesses use to track transactions. Accountants often call accounts \"ledgers\".  ### Usage Example Fetch from the `LIST Accounts` endpoint and view a company's accounts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The account&#39;s name. | [optional] 
**Description** | **string** | The account&#39;s description. | [optional] 
**Classification** | **ClassificationEnum** | The account&#39;s classification. | [optional] 
**Type** | **string** | The account&#39;s type. | [optional] 
**Status** | **AccountStatusEnum** | The account&#39;s status. | [optional] 
**CurrentBalance** | **float?** | The account&#39;s current balance. | [optional] 
**Currency** | **CurrencyEnum** | The account&#39;s currency. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


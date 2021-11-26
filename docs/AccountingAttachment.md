# Merge.AccountingClient.Model.AccountingAttachment
# The Accounting Attachment Object ### Description The `AccountingAttachment` object is used to represent a company's attachments.  ### Usage Example Fetch from the `LIST AccountingAttachments` endpoint and view a company's attachments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**FileName** | **string** | The attachment&#39;s name. | [optional] 
**FileUrl** | **string** | The attachment&#39;s url. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


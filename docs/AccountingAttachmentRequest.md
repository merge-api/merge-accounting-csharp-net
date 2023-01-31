# Merge.AccountingClient.Model.AccountingAttachmentRequest
# The Accounting Attachment Object ### Description The `AccountingAttachment` object is used to represent a company's attachments.  ### Usage Example Fetch from the `LIST AccountingAttachments` endpoint and view a company's attachments.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FileName** | **string** | The attachment&#39;s name. | [optional] 
**FileUrl** | **string** | The attachment&#39;s url. | [optional] 
**Company** | **Guid?** | The company the accounting attachment belongs to. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Merge.AccountingClient.Model.TaxRate
# The TaxRate Object ### Description The `TaxRate` object is used to represent a tax rate.  ### Usage Example Fetch from the `LIST TaxRates` endpoint and view tax rates relevant to a company.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Description** | **string** | The tax rate&#39;s description. | [optional] 
**TotalTaxRate** | **float?** | The tax rate&#39;s total tax rate. | [optional] 
**EffectiveTaxRate** | **float?** | The tax rate&#39;s effective tax rate. | [optional] 
**Company** | **Guid?** | The company the tax rate belongs to. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**FieldMappings** | **Dictionary&lt;string, Object&gt;** |  | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


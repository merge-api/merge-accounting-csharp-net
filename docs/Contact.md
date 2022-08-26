# Merge.AccountingClient.Model.Contact
# The Contact Object ### Description The `Contact` object is used to represent a Contact. This can be either a supplier or a customer.  ### Usage Example Fetch from the `LIST Contacts` endpoint and view a company's contacts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** |  | [optional] [readonly] 
**RemoteId** | **string** | The third-party API ID of the matching object. | [optional] 
**RemoteData** | [**List&lt;RemoteData&gt;**](RemoteData.md) |  | [optional] [readonly] 
**Name** | **string** | The contact&#39;s name. | [optional] 
**IsSupplier** | **bool?** | Whether the contact is a supplier. | [optional] 
**IsCustomer** | **bool?** | Whether the contact is a customer. | [optional] 
**EmailAddress** | **string** | The contact&#39;s email address. | [optional] 
**TaxNumber** | **string** | The contact&#39;s tax number. | [optional] 
**Status** | **string** | The contact&#39;s status | [optional] 
**Currency** | **string** | The currency the contact&#39;s transactions are in. | [optional] 
**RemoteUpdatedAt** | **DateTime?** | When the third party&#39;s contact was updated. | [optional] 
**Addresses** | **List&lt;Guid?&gt;** | &#x60;Address&#x60; object IDs for the given &#x60;Contacts&#x60; object. | [optional] 
**PhoneNumbers** | [**List&lt;AccountingPhoneNumber&gt;**](AccountingPhoneNumber.md) | &#x60;AccountingPhoneNumber&#x60; object for the given &#x60;Contacts&#x60; object. | [optional] 
**RemoteWasDeleted** | **bool** | Indicates whether or not this object has been deleted by third party webhooks. | [optional] [readonly] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


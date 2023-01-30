# Merge.AccountingClient.Model.ContactRequest
# The Contact Object ### Description The `Contact` object refers to either a supplier or a customer.  ### Usage Example Fetch from the `LIST Contacts` endpoint and view a company's contacts.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | The contact&#39;s name. | [optional] 
**IsSupplier** | **bool?** | Whether the contact is a supplier. | [optional] 
**IsCustomer** | **bool?** | Whether the contact is a customer. | [optional] 
**EmailAddress** | **string** | The contact&#39;s email address. | [optional] 
**TaxNumber** | **string** | The contact&#39;s tax number. | [optional] 
**Status** | **Status7d1Enum** | The contact&#39;s status | [optional] 
**Currency** | **string** | The currency the contact&#39;s transactions are in. | [optional] 
**Company** | **Guid?** | The company the contact belongs to. | [optional] 
**Addresses** | **List&lt;Guid?&gt;** | &#x60;Address&#x60; object IDs for the given &#x60;Contacts&#x60; object. | [optional] 
**PhoneNumbers** | [**List&lt;AccountingPhoneNumberRequest&gt;**](AccountingPhoneNumberRequest.md) | &#x60;AccountingPhoneNumber&#x60; object for the given &#x60;Contacts&#x60; object. | [optional] 
**IntegrationParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 
**LinkedAccountParams** | **Dictionary&lt;string, Object&gt;** |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


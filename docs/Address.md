# Merge.AccountingClient.Model.Address
# The Address Object ### Description The `Address` object is used to represent a contact's or company's address.  ### Usage Example Fetch from the `GET CompanyInfo` endpoint and view the company's addresses.

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **AddressTypeEnum** | The address type. | [optional] 
**Street1** | **string** | Line 1 of the address&#39;s street. | [optional] 
**Street2** | **string** | Line 2 of the address&#39;s street. | [optional] 
**City** | **string** | The address&#39;s city. | [optional] 
**State** | **Object** | The address&#39;s state or region. | [optional] [readonly] 
**CountrySubdivision** | **string** | The address&#39;s state or region. | [optional] 
**Country** | **CountryEnum** | The address&#39;s country. | [optional] 
**ZipCode** | **string** | The address&#39;s zip code. | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


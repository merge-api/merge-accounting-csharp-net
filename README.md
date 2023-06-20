# Merge.AccountingClient - the C# library for the Merge Accounting API

The unified API for building rich integrations with multiple Accounting & Finance platforms.

This C# SDK is automatically generated by the [OpenAPI Generator](https://openapi-generator.tech) project:

- API version: 1.0
- SDK version: 1.1.1
- Build package: org.openapitools.codegen.languages.CSharpNetCoreClientCodegen
  For more information, please visit [https://www.merge.dev/](https://www.merge.dev/)

<a name="frameworks-supported"></a>

## Frameworks supported

- .NET Core >=1.0
- .NET Framework >=4.6
- Mono/Xamarin >=vNext

<a name="dependencies"></a>

## Dependencies

- [RestSharp](https://www.nuget.org/packages/RestSharp) - 106.11.7 or later
- [Json.NET](https://www.nuget.org/packages/Newtonsoft.Json/) - 12.0.3 or later
- [JsonSubTypes](https://www.nuget.org/packages/JsonSubTypes/) - 1.8.0 or later
- [System.ComponentModel.Annotations](https://www.nuget.org/packages/System.ComponentModel.Annotations) - 5.0.0 or later

The DLLs included in the package may not be the latest version. We recommend using [NuGet](https://docs.nuget.org/consume/installing-nuget) to obtain the latest version of the packages:

```
Install-Package RestSharp
Install-Package Newtonsoft.Json
Install-Package JsonSubTypes
Install-Package System.ComponentModel.Annotations
```

NOTE: RestSharp versions greater than 105.1.0 have a bug which causes file uploads to fail. See [RestSharp#742](https://github.com/restsharp/RestSharp/issues/742).
NOTE: RestSharp for .Net Core creates a new socket for each api call, which can lead to a socket exhaustion problem. See [RestSharp#1406](https://github.com/restsharp/RestSharp/issues/1406).

<a name="installation"></a>

## Installation

Generate the DLL using your preferred tool (e.g. `dotnet build`)

Then include the DLL (under the `bin` folder) in the C# project, and use the namespaces:

```csharp
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;
```

<a name="usage"></a>

## Usage

To use the API client with a HTTP proxy, setup a `System.Net.WebProxy`

```csharp
Configuration c = new Configuration();
System.Net.WebProxy webProxy = new System.Net.WebProxy("http://myProxyUrl:80/");
webProxy.Credentials = System.Net.CredentialCache.DefaultCredentials;
c.Proxy = webProxy;
```

<a name="getting-started"></a>

## Getting Started

```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Merge.AccountingClient.Api;
using Merge.AccountingClient.Client;
using Merge.AccountingClient.Model;

namespace Example
{
    public class Example
    {
        public static void Main()
        {

            Configuration config = new Configuration();
            config.BasePath = "https://api.merge.dev/api/accounting/v1";
            // Configure API key authorization: tokenAuth
            config.ApiKey.Add("Authorization", "YOUR_API_KEY");
            // Uncomment below to setup prefix (e.g. Bearer) for API key, if needed
            // config.ApiKeyPrefix.Add("Authorization", "Bearer");

            var apiInstance = new AccountDetailsApi(config);
            var xAccountToken = xAccountToken_example;  // string | Token identifying the end user.

            try
            {
                AccountDetails result = apiInstance.AccountDetailsRetrieve(xAccountToken);
                Debug.WriteLine(result);
            }
            catch (ApiException e)
            {
                Debug.Print("Exception when calling AccountDetailsApi.AccountDetailsRetrieve: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }

        }
    }
}
```

<a name="documentation-for-api-endpoints"></a>

## Documentation for API Endpoints

All URIs are relative to *https://api.merge.dev/api/accounting/v1*

| Class                   | Method                                                                                              | HTTP request                           | Description |
| ----------------------- | --------------------------------------------------------------------------------------------------- | -------------------------------------- | ----------- |
| _AccountDetailsApi_     | [**AccountDetailsRetrieve**](docs/AccountDetailsApi.md#accountdetailsretrieve)                      | **GET** /account-details               |
| _AccountTokenApi_       | [**AccountTokenRetrieve**](docs/AccountTokenApi.md#accounttokenretrieve)                            | **GET** /account-token/{public_token}  |
| _AccountsApi_           | [**AccountsCreate**](docs/AccountsApi.md#accountscreate)                                            | **POST** /accounts                     |
| _AccountsApi_           | [**AccountsList**](docs/AccountsApi.md#accountslist)                                                | **GET** /accounts                      |
| _AccountsApi_           | [**AccountsMetaPostRetrieve**](docs/AccountsApi.md#accountsmetapostretrieve)                        | **GET** /accounts/meta/post            |
| _AccountsApi_           | [**AccountsRetrieve**](docs/AccountsApi.md#accountsretrieve)                                        | **GET** /accounts/{id}                 |
| _AddressesApi_          | [**AddressesRetrieve**](docs/AddressesApi.md#addressesretrieve)                                     | **GET** /addresses/{id}                |
| _AttachmentsApi_        | [**AttachmentsCreate**](docs/AttachmentsApi.md#attachmentscreate)                                   | **POST** /attachments                  |
| _AttachmentsApi_        | [**AttachmentsList**](docs/AttachmentsApi.md#attachmentslist)                                       | **GET** /attachments                   |
| _AttachmentsApi_        | [**AttachmentsMetaPostRetrieve**](docs/AttachmentsApi.md#attachmentsmetapostretrieve)               | **GET** /attachments/meta/post         |
| _AttachmentsApi_        | [**AttachmentsRetrieve**](docs/AttachmentsApi.md#attachmentsretrieve)                               | **GET** /attachments/{id}              |
| _AvailableActionsApi_   | [**AvailableActionsRetrieve**](docs/AvailableActionsApi.md#availableactionsretrieve)                | **GET** /available-actions             |
| _BalanceSheetsApi_      | [**BalanceSheetsList**](docs/BalanceSheetsApi.md#balancesheetslist)                                 | **GET** /balance-sheets                |
| _BalanceSheetsApi_      | [**BalanceSheetsRetrieve**](docs/BalanceSheetsApi.md#balancesheetsretrieve)                         | **GET** /balance-sheets/{id}           |
| _CashFlowStatementsApi_ | [**CashFlowStatementsList**](docs/CashFlowStatementsApi.md#cashflowstatementslist)                  | **GET** /cash-flow-statements          |
| _CashFlowStatementsApi_ | [**CashFlowStatementsRetrieve**](docs/CashFlowStatementsApi.md#cashflowstatementsretrieve)          | **GET** /cash-flow-statements/{id}     |
| _CompanyInfoApi_        | [**CompanyInfoList**](docs/CompanyInfoApi.md#companyinfolist)                                       | **GET** /company-info                  |
| _CompanyInfoApi_        | [**CompanyInfoRetrieve**](docs/CompanyInfoApi.md#companyinforetrieve)                               | **GET** /company-info/{id}             |
| _ContactsApi_           | [**ContactsCreate**](docs/ContactsApi.md#contactscreate)                                            | **POST** /contacts                     |
| _ContactsApi_           | [**ContactsList**](docs/ContactsApi.md#contactslist)                                                | **GET** /contacts                      |
| _ContactsApi_           | [**ContactsMetaPostRetrieve**](docs/ContactsApi.md#contactsmetapostretrieve)                        | **GET** /contacts/meta/post            |
| _ContactsApi_           | [**ContactsRetrieve**](docs/ContactsApi.md#contactsretrieve)                                        | **GET** /contacts/{id}                 |
| _CreditNotesApi_        | [**CreditNotesList**](docs/CreditNotesApi.md#creditnoteslist)                                       | **GET** /credit-notes                  |
| _CreditNotesApi_        | [**CreditNotesRetrieve**](docs/CreditNotesApi.md#creditnotesretrieve)                               | **GET** /credit-notes/{id}             |
| _DeleteAccountApi_      | [**DeleteAccountCreate**](docs/DeleteAccountApi.md#deleteaccountcreate)                             | **POST** /delete-account               |
| _ExpensesApi_           | [**ExpensesCreate**](docs/ExpensesApi.md#expensescreate)                                            | **POST** /expenses                     |
| _ExpensesApi_           | [**ExpensesList**](docs/ExpensesApi.md#expenseslist)                                                | **GET** /expenses                      |
| _ExpensesApi_           | [**ExpensesMetaPostRetrieve**](docs/ExpensesApi.md#expensesmetapostretrieve)                        | **GET** /expenses/meta/post            |
| _ExpensesApi_           | [**ExpensesRetrieve**](docs/ExpensesApi.md#expensesretrieve)                                        | **GET** /expenses/{id}                 |
| _ForceResyncApi_        | [**SyncStatusResyncCreate**](docs/ForceResyncApi.md#syncstatusresynccreate)                         | **POST** /sync-status/resync           |
| _GenerateKeyApi_        | [**GenerateKeyCreate**](docs/GenerateKeyApi.md#generatekeycreate)                                   | **POST** /generate-key                 |
| _IncomeStatementsApi_   | [**IncomeStatementsList**](docs/IncomeStatementsApi.md#incomestatementslist)                        | **GET** /income-statements             |
| _IncomeStatementsApi_   | [**IncomeStatementsRetrieve**](docs/IncomeStatementsApi.md#incomestatementsretrieve)                | **GET** /income-statements/{id}        |
| _InvoicesApi_           | [**InvoicesCreate**](docs/InvoicesApi.md#invoicescreate)                                            | **POST** /invoices                     |
| _InvoicesApi_           | [**InvoicesList**](docs/InvoicesApi.md#invoiceslist)                                                | **GET** /invoices                      |
| _InvoicesApi_           | [**InvoicesMetaPostRetrieve**](docs/InvoicesApi.md#invoicesmetapostretrieve)                        | **GET** /invoices/meta/post            |
| _InvoicesApi_           | [**InvoicesRetrieve**](docs/InvoicesApi.md#invoicesretrieve)                                        | **GET** /invoices/{id}                 |
| _IssuesApi_             | [**IssuesList**](docs/IssuesApi.md#issueslist)                                                      | **GET** /issues                        |
| _IssuesApi_             | [**IssuesRetrieve**](docs/IssuesApi.md#issuesretrieve)                                              | **GET** /issues/{id}                   |
| _ItemsApi_              | [**ItemsList**](docs/ItemsApi.md#itemslist)                                                         | **GET** /items                         |
| _ItemsApi_              | [**ItemsRetrieve**](docs/ItemsApi.md#itemsretrieve)                                                 | **GET** /items/{id}                    |
| _JournalEntriesApi_     | [**JournalEntriesCreate**](docs/JournalEntriesApi.md#journalentriescreate)                          | **POST** /journal-entries              |
| _JournalEntriesApi_     | [**JournalEntriesList**](docs/JournalEntriesApi.md#journalentrieslist)                              | **GET** /journal-entries               |
| _JournalEntriesApi_     | [**JournalEntriesMetaPostRetrieve**](docs/JournalEntriesApi.md#journalentriesmetapostretrieve)      | **GET** /journal-entries/meta/post     |
| _JournalEntriesApi_     | [**JournalEntriesRetrieve**](docs/JournalEntriesApi.md#journalentriesretrieve)                      | **GET** /journal-entries/{id}          |
| _LinkTokenApi_          | [**LinkTokenCreate**](docs/LinkTokenApi.md#linktokencreate)                                         | **POST** /link-token                   |
| _LinkedAccountsApi_     | [**LinkedAccountsList**](docs/LinkedAccountsApi.md#linkedaccountslist)                              | **GET** /linked-accounts               |
| _PassthroughApi_        | [**PassthroughCreate**](docs/PassthroughApi.md#passthroughcreate)                                   | **POST** /passthrough                  |
| _PaymentsApi_           | [**PaymentsCreate**](docs/PaymentsApi.md#paymentscreate)                                            | **POST** /payments                     |
| _PaymentsApi_           | [**PaymentsList**](docs/PaymentsApi.md#paymentslist)                                                | **GET** /payments                      |
| _PaymentsApi_           | [**PaymentsMetaPostRetrieve**](docs/PaymentsApi.md#paymentsmetapostretrieve)                        | **GET** /payments/meta/post            |
| _PaymentsApi_           | [**PaymentsRetrieve**](docs/PaymentsApi.md#paymentsretrieve)                                        | **GET** /payments/{id}                 |
| _PhoneNumbersApi_       | [**PhoneNumbersRetrieve**](docs/PhoneNumbersApi.md#phonenumbersretrieve)                            | **GET** /phone-numbers/{id}            |
| _PurchaseOrdersApi_     | [**PurchaseOrdersCreate**](docs/PurchaseOrdersApi.md#purchaseorderscreate)                          | **POST** /purchase-orders              |
| _PurchaseOrdersApi_     | [**PurchaseOrdersList**](docs/PurchaseOrdersApi.md#purchaseorderslist)                              | **GET** /purchase-orders               |
| _PurchaseOrdersApi_     | [**PurchaseOrdersMetaPostRetrieve**](docs/PurchaseOrdersApi.md#purchaseordersmetapostretrieve)      | **GET** /purchase-orders/meta/post     |
| _PurchaseOrdersApi_     | [**PurchaseOrdersRetrieve**](docs/PurchaseOrdersApi.md#purchaseordersretrieve)                      | **GET** /purchase-orders/{id}          |
| _RegenerateKeyApi_      | [**RegenerateKeyCreate**](docs/RegenerateKeyApi.md#regeneratekeycreate)                             | **POST** /regenerate-key               |
| _SelectiveSyncApi_      | [**SelectiveSyncConfigurationsList**](docs/SelectiveSyncApi.md#selectivesyncconfigurationslist)     | **GET** /selective-sync/configurations |
| _SelectiveSyncApi_      | [**SelectiveSyncConfigurationsUpdate**](docs/SelectiveSyncApi.md#selectivesyncconfigurationsupdate) | **PUT** /selective-sync/configurations |
| _SelectiveSyncApi_      | [**SelectiveSyncMetaList**](docs/SelectiveSyncApi.md#selectivesyncmetalist)                         | **GET** /selective-sync/meta           |
| _SyncStatusApi_         | [**SyncStatusList**](docs/SyncStatusApi.md#syncstatuslist)                                          | **GET** /sync-status                   |
| _TaxRatesApi_           | [**TaxRatesList**](docs/TaxRatesApi.md#taxrateslist)                                                | **GET** /tax-rates                     |
| _TaxRatesApi_           | [**TaxRatesRetrieve**](docs/TaxRatesApi.md#taxratesretrieve)                                        | **GET** /tax-rates/{id}                |
| _TrackingCategoriesApi_ | [**TrackingCategoriesList**](docs/TrackingCategoriesApi.md#trackingcategorieslist)                  | **GET** /tracking-categories           |
| _TrackingCategoriesApi_ | [**TrackingCategoriesRetrieve**](docs/TrackingCategoriesApi.md#trackingcategoriesretrieve)          | **GET** /tracking-categories/{id}      |
| _TransactionsApi_       | [**TransactionsList**](docs/TransactionsApi.md#transactionslist)                                    | **GET** /transactions                  |
| _TransactionsApi_       | [**TransactionsRetrieve**](docs/TransactionsApi.md#transactionsretrieve)                            | **GET** /transactions/{id}             |
| _VendorCreditsApi_      | [**VendorCreditsList**](docs/VendorCreditsApi.md#vendorcreditslist)                                 | **GET** /vendor-credits                |
| _VendorCreditsApi_      | [**VendorCreditsRetrieve**](docs/VendorCreditsApi.md#vendorcreditsretrieve)                         | **GET** /vendor-credits/{id}           |
| _WebhookReceiversApi_   | [**WebhookReceiversCreate**](docs/WebhookReceiversApi.md#webhookreceiverscreate)                    | **POST** /webhook-receivers            |
| _WebhookReceiversApi_   | [**WebhookReceiversList**](docs/WebhookReceiversApi.md#webhookreceiverslist)                        | **GET** /webhook-receivers             |

<a name="documentation-for-models"></a>

## Documentation for Models

- [Model.Account](docs/Account.md)
- [Model.AccountDetails](docs/AccountDetails.md)
- [Model.AccountDetailsAndActions](docs/AccountDetailsAndActions.md)
- [Model.AccountDetailsAndActionsIntegration](docs/AccountDetailsAndActionsIntegration.md)
- [Model.AccountDetailsAndActionsStatusEnum](docs/AccountDetailsAndActionsStatusEnum.md)
- [Model.AccountEndpointRequest](docs/AccountEndpointRequest.md)
- [Model.AccountIntegration](docs/AccountIntegration.md)
- [Model.AccountRequest](docs/AccountRequest.md)
- [Model.AccountResponse](docs/AccountResponse.md)
- [Model.AccountStatusEnum](docs/AccountStatusEnum.md)
- [Model.AccountToken](docs/AccountToken.md)
- [Model.AccountingAttachment](docs/AccountingAttachment.md)
- [Model.AccountingAttachmentEndpointRequest](docs/AccountingAttachmentEndpointRequest.md)
- [Model.AccountingAttachmentRequest](docs/AccountingAttachmentRequest.md)
- [Model.AccountingAttachmentResponse](docs/AccountingAttachmentResponse.md)
- [Model.AccountingPhoneNumber](docs/AccountingPhoneNumber.md)
- [Model.AccountingPhoneNumberRequest](docs/AccountingPhoneNumberRequest.md)
- [Model.Address](docs/Address.md)
- [Model.AddressTypeEnum](docs/AddressTypeEnum.md)
- [Model.AvailableActions](docs/AvailableActions.md)
- [Model.BalanceSheet](docs/BalanceSheet.md)
- [Model.CashFlowStatement](docs/CashFlowStatement.md)
- [Model.CategoriesEnum](docs/CategoriesEnum.md)
- [Model.CategoryEnum](docs/CategoryEnum.md)
- [Model.CategoryTypeEnum](docs/CategoryTypeEnum.md)
- [Model.ClassificationEnum](docs/ClassificationEnum.md)
- [Model.CommonModelScopesBodyRequest](docs/CommonModelScopesBodyRequest.md)
- [Model.CompanyInfo](docs/CompanyInfo.md)
- [Model.ConditionSchema](docs/ConditionSchema.md)
- [Model.ConditionTypeEnum](docs/ConditionTypeEnum.md)
- [Model.Contact](docs/Contact.md)
- [Model.ContactEndpointRequest](docs/ContactEndpointRequest.md)
- [Model.ContactRequest](docs/ContactRequest.md)
- [Model.ContactResponse](docs/ContactResponse.md)
- [Model.CountryEnum](docs/CountryEnum.md)
- [Model.CreditNote](docs/CreditNote.md)
- [Model.CreditNoteLineItem](docs/CreditNoteLineItem.md)
- [Model.CreditNoteStatusEnum](docs/CreditNoteStatusEnum.md)
- [Model.CurrencyEnum](docs/CurrencyEnum.md)
- [Model.DataPassthroughRequest](docs/DataPassthroughRequest.md)
- [Model.DebugModeLog](docs/DebugModeLog.md)
- [Model.DebugModelLogSummary](docs/DebugModelLogSummary.md)
- [Model.EnabledActionsEnum](docs/EnabledActionsEnum.md)
- [Model.EncodingEnum](docs/EncodingEnum.md)
- [Model.EndUserDetailsRequest](docs/EndUserDetailsRequest.md)
- [Model.ErrorValidationProblem](docs/ErrorValidationProblem.md)
- [Model.Expense](docs/Expense.md)
- [Model.ExpenseEndpointRequest](docs/ExpenseEndpointRequest.md)
- [Model.ExpenseLine](docs/ExpenseLine.md)
- [Model.ExpenseLineRequest](docs/ExpenseLineRequest.md)
- [Model.ExpenseRequest](docs/ExpenseRequest.md)
- [Model.ExpenseResponse](docs/ExpenseResponse.md)
- [Model.GenerateRemoteKeyRequest](docs/GenerateRemoteKeyRequest.md)
- [Model.IncomeStatement](docs/IncomeStatement.md)
- [Model.Invoice](docs/Invoice.md)
- [Model.InvoiceEndpointRequest](docs/InvoiceEndpointRequest.md)
- [Model.InvoiceLineItem](docs/InvoiceLineItem.md)
- [Model.InvoiceLineItemRequest](docs/InvoiceLineItemRequest.md)
- [Model.InvoiceRequest](docs/InvoiceRequest.md)
- [Model.InvoiceResponse](docs/InvoiceResponse.md)
- [Model.InvoiceTypeEnum](docs/InvoiceTypeEnum.md)
- [Model.Issue](docs/Issue.md)
- [Model.IssueStatusEnum](docs/IssueStatusEnum.md)
- [Model.Item](docs/Item.md)
- [Model.JournalEntry](docs/JournalEntry.md)
- [Model.JournalEntryEndpointRequest](docs/JournalEntryEndpointRequest.md)
- [Model.JournalEntryRequest](docs/JournalEntryRequest.md)
- [Model.JournalEntryResponse](docs/JournalEntryResponse.md)
- [Model.JournalLine](docs/JournalLine.md)
- [Model.JournalLineRequest](docs/JournalLineRequest.md)
- [Model.LinkToken](docs/LinkToken.md)
- [Model.LinkedAccountCondition](docs/LinkedAccountCondition.md)
- [Model.LinkedAccountConditionRequest](docs/LinkedAccountConditionRequest.md)
- [Model.LinkedAccountSelectiveSyncConfiguration](docs/LinkedAccountSelectiveSyncConfiguration.md)
- [Model.LinkedAccountSelectiveSyncConfigurationListRequest](docs/LinkedAccountSelectiveSyncConfigurationListRequest.md)
- [Model.LinkedAccountSelectiveSyncConfigurationRequest](docs/LinkedAccountSelectiveSyncConfigurationRequest.md)
- [Model.LinkedAccountStatus](docs/LinkedAccountStatus.md)
- [Model.MetaResponse](docs/MetaResponse.md)
- [Model.MethodEnum](docs/MethodEnum.md)
- [Model.ModelOperation](docs/ModelOperation.md)
- [Model.MultipartFormFieldRequest](docs/MultipartFormFieldRequest.md)
- [Model.OperatorSchema](docs/OperatorSchema.md)
- [Model.PaginatedAccountDetailsAndActionsList](docs/PaginatedAccountDetailsAndActionsList.md)
- [Model.PaginatedAccountList](docs/PaginatedAccountList.md)
- [Model.PaginatedAccountingAttachmentList](docs/PaginatedAccountingAttachmentList.md)
- [Model.PaginatedBalanceSheetList](docs/PaginatedBalanceSheetList.md)
- [Model.PaginatedCashFlowStatementList](docs/PaginatedCashFlowStatementList.md)
- [Model.PaginatedCompanyInfoList](docs/PaginatedCompanyInfoList.md)
- [Model.PaginatedConditionSchemaList](docs/PaginatedConditionSchemaList.md)
- [Model.PaginatedContactList](docs/PaginatedContactList.md)
- [Model.PaginatedCreditNoteList](docs/PaginatedCreditNoteList.md)
- [Model.PaginatedExpenseList](docs/PaginatedExpenseList.md)
- [Model.PaginatedIncomeStatementList](docs/PaginatedIncomeStatementList.md)
- [Model.PaginatedInvoiceList](docs/PaginatedInvoiceList.md)
- [Model.PaginatedIssueList](docs/PaginatedIssueList.md)
- [Model.PaginatedItemList](docs/PaginatedItemList.md)
- [Model.PaginatedJournalEntryList](docs/PaginatedJournalEntryList.md)
- [Model.PaginatedPaymentList](docs/PaginatedPaymentList.md)
- [Model.PaginatedPurchaseOrderList](docs/PaginatedPurchaseOrderList.md)
- [Model.PaginatedSyncStatusList](docs/PaginatedSyncStatusList.md)
- [Model.PaginatedTaxRateList](docs/PaginatedTaxRateList.md)
- [Model.PaginatedTrackingCategoryList](docs/PaginatedTrackingCategoryList.md)
- [Model.PaginatedTransactionList](docs/PaginatedTransactionList.md)
- [Model.PaginatedVendorCreditList](docs/PaginatedVendorCreditList.md)
- [Model.Payment](docs/Payment.md)
- [Model.PaymentEndpointRequest](docs/PaymentEndpointRequest.md)
- [Model.PaymentRequest](docs/PaymentRequest.md)
- [Model.PaymentResponse](docs/PaymentResponse.md)
- [Model.PostingStatusEnum](docs/PostingStatusEnum.md)
- [Model.PurchaseOrder](docs/PurchaseOrder.md)
- [Model.PurchaseOrderEndpointRequest](docs/PurchaseOrderEndpointRequest.md)
- [Model.PurchaseOrderLineItem](docs/PurchaseOrderLineItem.md)
- [Model.PurchaseOrderLineItemRequest](docs/PurchaseOrderLineItemRequest.md)
- [Model.PurchaseOrderRequest](docs/PurchaseOrderRequest.md)
- [Model.PurchaseOrderResponse](docs/PurchaseOrderResponse.md)
- [Model.PurchaseOrderStatusEnum](docs/PurchaseOrderStatusEnum.md)
- [Model.RemoteData](docs/RemoteData.md)
- [Model.RemoteKey](docs/RemoteKey.md)
- [Model.RemoteKeyForRegenerationRequest](docs/RemoteKeyForRegenerationRequest.md)
- [Model.RemoteResponse](docs/RemoteResponse.md)
- [Model.ReportItem](docs/ReportItem.md)
- [Model.RequestFormatEnum](docs/RequestFormatEnum.md)
- [Model.ResponseTypeEnum](docs/ResponseTypeEnum.md)
- [Model.SelectiveSyncConfigurationsUsageEnum](docs/SelectiveSyncConfigurationsUsageEnum.md)
- [Model.Status7d1Enum](docs/Status7d1Enum.md)
- [Model.SyncStatus](docs/SyncStatus.md)
- [Model.SyncStatusStatusEnum](docs/SyncStatusStatusEnum.md)
- [Model.TaxRate](docs/TaxRate.md)
- [Model.TrackingCategory](docs/TrackingCategory.md)
- [Model.Transaction](docs/Transaction.md)
- [Model.TransactionLineItem](docs/TransactionLineItem.md)
- [Model.ValidationProblemSource](docs/ValidationProblemSource.md)
- [Model.VendorCredit](docs/VendorCredit.md)
- [Model.VendorCreditLine](docs/VendorCreditLine.md)
- [Model.WarningValidationProblem](docs/WarningValidationProblem.md)
- [Model.WebhookReceiver](docs/WebhookReceiver.md)
- [Model.WebhookReceiverRequest](docs/WebhookReceiverRequest.md)

<a name="documentation-for-authorization"></a>

## Documentation for Authorization

<a name="tokenAuth"></a>

### tokenAuth

- **Type**: API key
- **API key parameter name**: Authorization
- **Location**: HTTP header

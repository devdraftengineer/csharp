# Devdraft.Model.CreateExternalBankTransferDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceWalletId** | **string** | The ID of the source bridge wallet | 
**SourceCurrency** | **string** | The source currency | 
**DestinationCurrency** | **string** | The destination currency | 
**DestinationPaymentRail** | **BridgeFiatPaymentRail** | The destination payment rail (fiat payment method) | 
**ExternalAccountId** | **string** | The external account ID for the bank transfer | 
**Amount** | **decimal** | The amount to transfer | [optional] 
**WireMessage** | **string** | Wire transfer message (1-256 characters, only for wire transfers) | [optional] 
**SepaReference** | **string** | SEPA reference message (6-140 characters, only for SEPA transfers) | [optional] 
**SwiftReference** | **string** | SWIFT reference message (1-190 characters, only for SWIFT transfers) | [optional] 
**SpeiReference** | **string** | SPEI reference message (1-40 characters, only for SPEI transfers) | [optional] 
**SwiftCharges** | **string** | SWIFT charges bearer (only for SWIFT transfers) | [optional] 
**AchReference** | **string** | ACH reference message (1-10 characters, only for ACH transfers) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


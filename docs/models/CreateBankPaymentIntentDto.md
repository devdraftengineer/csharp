# Devdraft.Model.CreateBankPaymentIntentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourcePaymentRail** | **BridgePaymentRail** | The banking payment method to use for the transfer. Determines processing time and fees. | 
**SourceCurrency** | **FiatCurrency** | The fiat currency to convert FROM. Must match the currency of the source payment rail. | 
**DestinationCurrency** | **StableCoinCurrency** | The stablecoin currency to convert TO. The customer will receive this currency. | 
**DestinationNetwork** | **BridgePaymentRail** | The blockchain network where the stablecoin will be delivered. Must support the destination currency. | 
**DestinationAddress** | **string** | Destination wallet address. Supports Ethereum (0x...) and Solana address formats. | [optional] 
**Amount** | **string** | Payment amount (optional for flexible amount) | [optional] 
**CustomerFirstName** | **string** | Customer first name | [optional] 
**CustomerLastName** | **string** | Customer last name | [optional] 
**CustomerEmail** | **string** | Customer email address | [optional] 
**CustomerAddress** | **string** | Customer address | [optional] 
**CustomerCountry** | **string** | Customer country | [optional] 
**CustomerCountryISO** | **string** | Customer country ISO code | [optional] 
**CustomerProvince** | **string** | Customer province/state | [optional] 
**CustomerProvinceISO** | **string** | Customer province/state ISO code | [optional] 
**PhoneNumber** | **string** | Customer phone number | [optional] 
**WireMessage** | **string** | Wire transfer message (for WIRE transfers) | [optional] 
**SepaReference** | **string** | SEPA reference (for SEPA transfers) | [optional] 
**AchReference** | **string** | ACH reference (for ACH transfers) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# Devdraft.Model.CreateStablePaymentIntentDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**SourceCurrency** | **StableCoinCurrency** | The stablecoin currency to convert FROM. This is the currency the customer will pay with. | 
**SourceNetwork** | **BridgePaymentRail** | The blockchain network where the source currency resides. Determines gas fees and transaction speed. | 
**DestinationNetwork** | **BridgePaymentRail** | The blockchain network where the converted currency will be delivered. Must support the destination currency. | 
**DestinationCurrency** | **StableCoinCurrency** | The stablecoin currency to convert TO. If omitted, defaults to the same as source currency (cross-chain transfer). | [optional] 
**DestinationAddress** | **string** | The wallet address where converted funds will be sent. Supports Ethereum (0x...) and Solana address formats. | [optional] 
**Amount** | **string** | Payment amount in the source currency. Omit for flexible amount payments where users specify the amount during checkout. | [optional] 
**CustomerFirstName** | **string** | Customer&#39;s first name. Used for transaction records and compliance. Required for amounts over $1000. | [optional] 
**CustomerLastName** | **string** | Customer&#39;s last name. Used for transaction records and compliance. Required for amounts over $1000. | [optional] 
**CustomerEmail** | **string** | Customer&#39;s email address. Used for transaction notifications and receipts. Highly recommended for all transactions. | [optional] 
**CustomerAddress** | **string** | Customer&#39;s full address. Required for compliance in certain jurisdictions and high-value transactions. | [optional] 
**CustomerCountry** | **string** | Customer&#39;s country of residence. Used for compliance and tax reporting. | [optional] 
**CustomerCountryISO** | **string** | Customer&#39;s country ISO 3166-1 alpha-2 code. Used for automated compliance checks. | [optional] 
**CustomerProvince** | **string** | Customer&#39;s state or province. Required for US and Canadian customers. | [optional] 
**CustomerProvinceISO** | **string** | Customer&#39;s state or province ISO code. Used for automated tax calculations. | [optional] 
**PhoneNumber** | **string** | Customer&#39;s phone number with country code. Used for SMS notifications and verification. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


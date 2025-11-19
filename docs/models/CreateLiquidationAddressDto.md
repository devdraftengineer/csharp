# Devdraft.Model.CreateLiquidationAddressDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Chain** | **string** | The blockchain chain for the liquidation address | 
**Currency** | **string** | The currency for the liquidation address | 
**Address** | **string** | The liquidation address on the blockchain | 
**ExternalAccountId** | **string** | External bank account to send funds to | [optional] 
**PrefundedAccountId** | **string** | Developer&#39;s prefunded account id | [optional] 
**BridgeWalletId** | **string** | Bridge Wallet to send funds to | [optional] 
**DestinationPaymentRail** | **BridgePaymentRail** | Payment rail for sending funds | [optional] 
**DestinationCurrency** | **DestinationCurrency** | Currency for sending funds | [optional] 
**DestinationWireMessage** | **string** | Message for wire transfers | [optional] 
**DestinationSepaReference** | **string** | Reference for SEPA transactions | [optional] 
**DestinationAchReference** | **string** | Reference for ACH transactions | [optional] 
**DestinationAddress** | **string** | Crypto wallet address for crypto transfers | [optional] 
**DestinationBlockchainMemo** | **string** | Memo for blockchain transactions | [optional] 
**ReturnAddress** | **string** | Address to return funds on failed transactions (Not supported on Stellar) | [optional] 
**CustomDeveloperFeePercent** | **string** | Custom developer fee percentage (Base 100 percentage: 10.2% &#x3D; \&quot;10.2\&quot;) | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


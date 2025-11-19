# Devdraft.Model.CreatePaymentLinkDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Title** | **string** | Display title for the payment link. This appears on the checkout page and in customer communications. | 
**Url** | **string** | Unique URL slug for the payment link. Can be a full URL or just the path segment. Must be unique within your account. | 
**LinkType** | **string** | Type of the payment link | 
**Description** | **string** | Detailed description of what the customer is purchasing. Supports markdown formatting. | [optional] 
**CoverImage** | **string** | Cover image URL | [optional] 
**Amount** | **decimal** | Amount for the payment link | [optional] 
**PaymentForId** | **string** | Payment for ID | [optional] 
**CustomerId** | **string** | Customer ID | [optional] 
**PaymentLinkProducts** | [**List&lt;PaymentLinkProductDto&gt;**](PaymentLinkProductDto.md) | Array of products in the payment link | [optional] 
**IsForAllProduct** | **bool** | Whether the payment link is for all products | [optional] [default to false]
**AllowQuantityAdjustment** | **bool** | Whether to allow quantity adjustment | [default to true]
**CollectTax** | **bool** | Whether to collect tax | [default to false]
**TaxId** | **string** | Tax ID | [optional] 
**CollectAddress** | **bool** | Whether to collect address | [default to false]
**LimitPayments** | **bool** | Whether to limit payments | [optional] [default to false]
**MaxPayments** | **decimal** | Maximum number of payments | [optional] 
**CustomFields** | **Object** | Custom fields | [optional] 
**AllowMobilePayment** | **bool** | Whether to allow mobile payment | [default to false]
**Currency** | **string** | Currency | [default to CurrencyEnum.Usdc]
**ExpirationDate** | **DateTime** | Expiration date | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


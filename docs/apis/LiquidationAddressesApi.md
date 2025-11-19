# Devdraft.Api.LiquidationAddressesApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**LiquidationAddressControllerCreateLiquidationAddress**](LiquidationAddressesApi.md#liquidationaddresscontrollercreateliquidationaddress) | **POST** /api/v0/customers/{customerId}/liquidation_addresses | Create a new liquidation address for a customer |
| [**LiquidationAddressControllerGetLiquidationAddress**](LiquidationAddressesApi.md#liquidationaddresscontrollergetliquidationaddress) | **GET** /api/v0/customers/{customerId}/liquidation_addresses/{liquidationAddressId} | Get a specific liquidation address |
| [**LiquidationAddressControllerGetLiquidationAddresses**](LiquidationAddressesApi.md#liquidationaddresscontrollergetliquidationaddresses) | **GET** /api/v0/customers/{customerId}/liquidation_addresses | Get all liquidation addresses for a customer |

<a id="liquidationaddresscontrollercreateliquidationaddress"></a>
# **LiquidationAddressControllerCreateLiquidationAddress**
> LiquidationAddressResponseDto LiquidationAddressControllerCreateLiquidationAddress (string customerId, CreateLiquidationAddressDto createLiquidationAddressDto)

Create a new liquidation address for a customer

       Create a new liquidation address for a customer. Liquidation addresses allow        customers to automatically liquidate cryptocurrency holdings to fiat or other        stablecoins based on configured parameters.        **Required fields:**       - chain: Blockchain network (ethereum, polygon, arbitrum, base)       - currency: Stablecoin currency (usdc, eurc, dai, pyusd, usdt)       - address: Valid blockchain address        **At least one destination must be specified:**       - external_account_id: External bank account       - prefunded_account_id: Developer's prefunded account       - bridge_wallet_id: Bridge wallet       - destination_address: Crypto wallet address        **Payment Rails:**       Different payment rails have different requirements:       - ACH: Requires external_account_id, supports destination_ach_reference       - SEPA: Requires external_account_id, supports destination_sepa_reference       - Wire: Requires external_account_id, supports destination_wire_message       - Crypto: Requires destination_address, supports destination_blockchain_memo     


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | Unique identifier for the customer |  |
| **createLiquidationAddressDto** | [**CreateLiquidationAddressDto**](CreateLiquidationAddressDto.md) |  |  |

### Return type

[**LiquidationAddressResponseDto**](LiquidationAddressResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Liquidation address created successfully |  -  |
| **400** | Invalid request data |  -  |
| **404** | Customer not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="liquidationaddresscontrollergetliquidationaddress"></a>
# **LiquidationAddressControllerGetLiquidationAddress**
> LiquidationAddressResponseDto LiquidationAddressControllerGetLiquidationAddress (string customerId, string liquidationAddressId)

Get a specific liquidation address

Retrieve a specific liquidation address by its ID for a given customer.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | Unique identifier for the customer |  |
| **liquidationAddressId** | **string** | Unique identifier for the liquidation address |  |

### Return type

[**LiquidationAddressResponseDto**](LiquidationAddressResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Liquidation address details |  -  |
| **404** | Liquidation address not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="liquidationaddresscontrollergetliquidationaddresses"></a>
# **LiquidationAddressControllerGetLiquidationAddresses**
> List&lt;LiquidationAddressResponseDto&gt; LiquidationAddressControllerGetLiquidationAddresses (string customerId)

Get all liquidation addresses for a customer

Retrieve all liquidation addresses associated with a specific customer.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **customerId** | **string** | Unique identifier for the customer |  |

### Return type

[**List&lt;LiquidationAddressResponseDto&gt;**](LiquidationAddressResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of liquidation addresses |  -  |
| **404** | Customer not found |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


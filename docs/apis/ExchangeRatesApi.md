# Devdraft.Api.ExchangeRatesApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ExchangeRateControllerGetEURToUSDRate**](ExchangeRatesApi.md#exchangeratecontrollergeteurtousdrate) | **GET** /api/v0/exchange-rate/eur-to-usd | Get EUR to USD exchange rate |
| [**ExchangeRateControllerGetExchangeRate**](ExchangeRatesApi.md#exchangeratecontrollergetexchangerate) | **GET** /api/v0/exchange-rate | Get exchange rate between specified currencies |
| [**ExchangeRateControllerGetUSDToEURRate**](ExchangeRatesApi.md#exchangeratecontrollergetusdtoeurrate) | **GET** /api/v0/exchange-rate/usd-to-eur | Get USD to EUR exchange rate |

<a id="exchangeratecontrollergeteurtousdrate"></a>
# **ExchangeRateControllerGetEURToUSDRate**
> ExchangeRateResponseDto ExchangeRateControllerGetEURToUSDRate ()

Get EUR to USD exchange rate

Retrieves the current exchange rate for converting EUR to USD (EURC to USDC).      This endpoint provides real-time exchange rate information for stablecoin conversions: - Mid-market rate for reference pricing - Buy rate for actual conversion calculations - Sell rate for reverse conversion scenarios  ## Use Cases - Display current exchange rates in dashboards - Calculate conversion amounts for EURC to USDC transfers - Financial reporting and analytics - Real-time pricing for multi-currency operations  ## Rate Information - **Mid-market rate**: The theoretical middle rate between buy and sell - **Buy rate**: Rate used when converting FROM EUR TO USD (what you get) - **Sell rate**: Rate used when converting FROM USD TO EUR (what you pay)  The rates are updated in real-time and reflect current market conditions.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ExchangeRateResponseDto**](ExchangeRateResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Exchange rate retrieved successfully |  -  |
| **401** | Unauthorized - Invalid or missing API credentials |  -  |
| **404** | App not found or no access permission |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exchangeratecontrollergetexchangerate"></a>
# **ExchangeRateControllerGetExchangeRate**
> ExchangeRateResponseDto ExchangeRateControllerGetExchangeRate (string from, string to)

Get exchange rate between specified currencies

Retrieves the current exchange rate between two specified currencies.      This flexible endpoint allows you to get exchange rates for any supported currency pair: - Supports USD and EUR currency codes - Provides comprehensive rate information - Real-time market data  ## Supported Currency Pairs - USD to EUR (USDC to EURC) - EUR to USD (EURC to USDC)  ## Query Parameters - **from**: Source currency code (usd, eur) - **to**: Target currency code (usd, eur)  ## Use Cases - Flexible exchange rate queries - Multi-currency application support - Dynamic currency conversion calculations - Financial analytics and reporting  ## Rate Information All rates are provided with full market context including mid-market, buy, and sell rates.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **from** | **string** | Source currency code (e.g., usd) |  |
| **to** | **string** | Target currency code (e.g., eur) |  |

### Return type

[**ExchangeRateResponseDto**](ExchangeRateResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Exchange rate retrieved successfully |  -  |
| **400** | Bad Request - Invalid currency codes or unsupported currency pair |  -  |
| **401** | Unauthorized - Invalid or missing API credentials |  -  |
| **404** | App not found or no access permission |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="exchangeratecontrollergetusdtoeurrate"></a>
# **ExchangeRateControllerGetUSDToEURRate**
> ExchangeRateResponseDto ExchangeRateControllerGetUSDToEURRate ()

Get USD to EUR exchange rate

Retrieves the current exchange rate for converting USD to EUR (USDC to EURC).      This endpoint provides real-time exchange rate information for stablecoin conversions: - Mid-market rate for reference pricing - Buy rate for actual conversion calculations - Sell rate for reverse conversion scenarios  ## Use Cases - Display current exchange rates in dashboards - Calculate conversion amounts for USDC to EURC transfers - Financial reporting and analytics - Real-time pricing for multi-currency operations  ## Rate Information - **Mid-market rate**: The theoretical middle rate between buy and sell - **Buy rate**: Rate used when converting FROM USD TO EUR (what you get) - **Sell rate**: Rate used when converting FROM EUR TO USD (what you pay)  The rates are updated in real-time and reflect current market conditions.


### Parameters
This endpoint does not need any parameter.
### Return type

[**ExchangeRateResponseDto**](ExchangeRateResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Exchange rate retrieved successfully |  -  |
| **401** | Unauthorized - Invalid or missing API credentials |  -  |
| **404** | App not found or no access permission |  -  |
| **500** | Internal server error |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


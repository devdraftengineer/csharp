# Devdraft.Api.TransfersApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TransferControllerCreateDirectBankTransfer**](TransfersApi.md#transfercontrollercreatedirectbanktransfer) | **POST** /api/v0/transfers/direct-bank | Create a direct bank transfer |
| [**TransferControllerCreateDirectWalletTransfer**](TransfersApi.md#transfercontrollercreatedirectwallettransfer) | **POST** /api/v0/transfers/direct-wallet | Create a direct wallet transfer |
| [**TransferControllerCreateExternalBankTransfer**](TransfersApi.md#transfercontrollercreateexternalbanktransfer) | **POST** /api/v0/transfers/external-bank-transfer | Create an external bank transfer |
| [**TransferControllerCreateExternalStablecoinTransfer**](TransfersApi.md#transfercontrollercreateexternalstablecointransfer) | **POST** /api/v0/transfers/external-stablecoin-transfer | Create an external stablecoin transfer |
| [**TransferControllerCreateStablecoinConversion**](TransfersApi.md#transfercontrollercreatestablecoinconversion) | **POST** /api/v0/transfers/stablecoin-conversion | Create a stablecoin conversion |

<a id="transfercontrollercreatedirectbanktransfer"></a>
# **TransferControllerCreateDirectBankTransfer**
> void TransferControllerCreateDirectBankTransfer (CreateDirectBankTransferDto createDirectBankTransferDto)

Create a direct bank transfer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDirectBankTransferDto** | [**CreateDirectBankTransferDto**](CreateDirectBankTransferDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The transfer has been successfully created. |  -  |
| **400** | Bad Request - Invalid input |  -  |
| **404** | Not Found - Bridge wallet not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transfercontrollercreatedirectwallettransfer"></a>
# **TransferControllerCreateDirectWalletTransfer**
> void TransferControllerCreateDirectWalletTransfer (CreateDirectWalletTransferDto createDirectWalletTransferDto)

Create a direct wallet transfer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createDirectWalletTransferDto** | [**CreateDirectWalletTransferDto**](CreateDirectWalletTransferDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The transfer has been successfully created. |  -  |
| **400** | Bad Request - Invalid input |  -  |
| **404** | Not Found - Bridge wallet not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transfercontrollercreateexternalbanktransfer"></a>
# **TransferControllerCreateExternalBankTransfer**
> void TransferControllerCreateExternalBankTransfer (CreateExternalBankTransferDto createExternalBankTransferDto)

Create an external bank transfer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createExternalBankTransferDto** | [**CreateExternalBankTransferDto**](CreateExternalBankTransferDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The external bank transfer has been successfully created. |  -  |
| **400** | Bad Request - Invalid input |  -  |
| **404** | Not Found - Bridge wallet not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transfercontrollercreateexternalstablecointransfer"></a>
# **TransferControllerCreateExternalStablecoinTransfer**
> void TransferControllerCreateExternalStablecoinTransfer (CreateExternalStablecoinTransferDto createExternalStablecoinTransferDto)

Create an external stablecoin transfer


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createExternalStablecoinTransferDto** | [**CreateExternalStablecoinTransferDto**](CreateExternalStablecoinTransferDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The external stablecoin transfer has been successfully created. |  -  |
| **400** | Bad Request - Invalid input |  -  |
| **404** | Not Found - Bridge wallet not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="transfercontrollercreatestablecoinconversion"></a>
# **TransferControllerCreateStablecoinConversion**
> void TransferControllerCreateStablecoinConversion (CreateStablecoinConversionDto createStablecoinConversionDto)

Create a stablecoin conversion


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createStablecoinConversionDto** | [**CreateStablecoinConversionDto**](CreateStablecoinConversionDto.md) |  |  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The conversion has been successfully created. |  -  |
| **400** | Bad Request - Invalid input |  -  |
| **404** | Not Found - Bridge wallet not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


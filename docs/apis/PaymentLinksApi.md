# Devdraft.Api.PaymentLinksApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**PaymentLinksControllerCreate**](PaymentLinksApi.md#paymentlinkscontrollercreate) | **POST** /api/v0/payment-links | Create a new payment link |
| [**PaymentLinksControllerFindAll**](PaymentLinksApi.md#paymentlinkscontrollerfindall) | **GET** /api/v0/payment-links | Get all payment links |
| [**PaymentLinksControllerFindOne**](PaymentLinksApi.md#paymentlinkscontrollerfindone) | **GET** /api/v0/payment-links/{id} | Get a payment link by ID |
| [**PaymentLinksControllerUpdate**](PaymentLinksApi.md#paymentlinkscontrollerupdate) | **PUT** /api/v0/payment-links/{id} | Update a payment link |

<a id="paymentlinkscontrollercreate"></a>
# **PaymentLinksControllerCreate**
> void PaymentLinksControllerCreate (CreatePaymentLinkDto createPaymentLinkDto)

Create a new payment link

Creates a new payment link with the provided details. Supports both simple one-time payments and complex product bundles.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createPaymentLinkDto** | [**CreatePaymentLinkDto**](CreatePaymentLinkDto.md) | Payment link creation data |  |

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
| **201** | The payment link has been successfully created. |  -  |
| **400** | Bad Request. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymentlinkscontrollerfindall"></a>
# **PaymentLinksControllerFindAll**
> void PaymentLinksControllerFindAll (string skip = null, string take = null)

Get all payment links


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skip** | **string** | Number of records to skip (must be non-negative) | [optional]  |
| **take** | **string** | Number of records to take (must be positive) | [optional]  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return all payment links. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymentlinkscontrollerfindone"></a>
# **PaymentLinksControllerFindOne**
> void PaymentLinksControllerFindOne (string id)

Get a payment link by ID


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Payment Link ID |  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the payment link. |  -  |
| **404** | Payment link not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="paymentlinkscontrollerupdate"></a>
# **PaymentLinksControllerUpdate**
> void PaymentLinksControllerUpdate (string id, Object body)

Update a payment link


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Payment Link ID |  |
| **body** | **Object** |  |  |

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
| **200** | The payment link has been successfully updated. |  -  |
| **404** | Payment link not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


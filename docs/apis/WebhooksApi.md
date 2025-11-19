# Devdraft.Api.WebhooksApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**WebhookControllerCreate**](WebhooksApi.md#webhookcontrollercreate) | **POST** /api/v0/webhooks | Create a new webhook |
| [**WebhookControllerFindAll**](WebhooksApi.md#webhookcontrollerfindall) | **GET** /api/v0/webhooks | Get all webhooks |
| [**WebhookControllerFindOne**](WebhooksApi.md#webhookcontrollerfindone) | **GET** /api/v0/webhooks/{id} | Get a webhook by id |
| [**WebhookControllerRemove**](WebhooksApi.md#webhookcontrollerremove) | **DELETE** /api/v0/webhooks/{id} | Delete a webhook |
| [**WebhookControllerUpdate**](WebhooksApi.md#webhookcontrollerupdate) | **PATCH** /api/v0/webhooks/{id} | Update a webhook |

<a id="webhookcontrollercreate"></a>
# **WebhookControllerCreate**
> WebhookResponseDto WebhookControllerCreate (CreateWebhookDto createWebhookDto)

Create a new webhook

Creates a new webhook endpoint for receiving event notifications. Requires webhook:create scope.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createWebhookDto** | [**CreateWebhookDto**](CreateWebhookDto.md) | Webhook configuration details |  |

### Return type

[**WebhookResponseDto**](WebhookResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The webhook has been successfully created. |  -  |
| **400** | Invalid input data. |  -  |
| **401** | Unauthorized - Missing or invalid API key. |  -  |
| **403** | Forbidden - Missing required scope or API key not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookcontrollerfindall"></a>
# **WebhookControllerFindAll**
> List&lt;WebhookResponseDto&gt; WebhookControllerFindAll (decimal skip = null, decimal take = null)

Get all webhooks

Retrieves a list of all webhooks for your application. Requires webhook:read scope.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skip** | **decimal** | Number of records to skip (default: 0) | [optional]  |
| **take** | **decimal** | Number of records to return (default: 10) | [optional]  |

### Return type

[**List&lt;WebhookResponseDto&gt;**](WebhookResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return all webhooks. |  -  |
| **401** | Unauthorized - Missing or invalid API key. |  -  |
| **403** | Forbidden - Missing required scope or API key not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookcontrollerfindone"></a>
# **WebhookControllerFindOne**
> WebhookResponseDto WebhookControllerFindOne (Guid id)

Get a webhook by id

Retrieves details for a specific webhook. Requires webhook:read scope.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Webhook unique identifier (UUID) |  |

### Return type

[**WebhookResponseDto**](WebhookResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Return the webhook. |  -  |
| **401** | Unauthorized - Missing or invalid API key. |  -  |
| **403** | Forbidden - Missing required scope or API key not found. |  -  |
| **404** | Webhook not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookcontrollerremove"></a>
# **WebhookControllerRemove**
> WebhookResponseDto WebhookControllerRemove (Guid id)

Delete a webhook

Deletes a webhook configuration. Requires webhook:delete scope.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Webhook unique identifier (UUID) |  |

### Return type

[**WebhookResponseDto**](WebhookResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The webhook has been successfully deleted. |  -  |
| **401** | Unauthorized - Missing or invalid API key. |  -  |
| **403** | Forbidden - Missing required scope or API key not found. |  -  |
| **404** | Webhook not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="webhookcontrollerupdate"></a>
# **WebhookControllerUpdate**
> WebhookResponseDto WebhookControllerUpdate (Guid id, UpdateWebhookDto updateWebhookDto)

Update a webhook

Updates an existing webhook configuration. Requires webhook:update scope.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Webhook unique identifier (UUID) |  |
| **updateWebhookDto** | [**UpdateWebhookDto**](UpdateWebhookDto.md) | Webhook update details |  |

### Return type

[**WebhookResponseDto**](WebhookResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The webhook has been successfully updated. |  -  |
| **400** | Invalid input data. |  -  |
| **401** | Unauthorized - Missing or invalid API key. |  -  |
| **403** | Forbidden - Missing required scope or API key not found. |  -  |
| **404** | Webhook not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# Devdraft.Api.APIHealthApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**HealthControllerCheckV0**](APIHealthApi.md#healthcontrollercheckv0) | **GET** /api/v0/health | Authenticated health check endpoint |
| [**HealthControllerPublicHealthCheckV0**](APIHealthApi.md#healthcontrollerpublichealthcheckv0) | **GET** /api/v0/health/public | Public health check endpoint |

<a id="healthcontrollercheckv0"></a>
# **HealthControllerCheckV0**
> HealthResponseDto HealthControllerCheckV0 ()

Authenticated health check endpoint


### Parameters
This endpoint does not need any parameter.
### Return type

[**HealthResponseDto**](HealthResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Service is up and running |  -  |
| **401** | Unauthorized. Client key or secret is invalid or missing. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="healthcontrollerpublichealthcheckv0"></a>
# **HealthControllerPublicHealthCheckV0**
> PublicHealthResponseDto HealthControllerPublicHealthCheckV0 ()

Public health check endpoint


### Parameters
This endpoint does not need any parameter.
### Return type

[**PublicHealthResponseDto**](PublicHealthResponseDto.md)

### Authorization

No authorization required

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Basic service health check |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


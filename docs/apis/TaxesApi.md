# Devdraft.Api.TaxesApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TaxControllerCreate**](TaxesApi.md#taxcontrollercreate) | **POST** /api/v0/taxes | Create a new tax |
| [**TaxControllerDeleteWithoutId**](TaxesApi.md#taxcontrollerdeletewithoutid) | **DELETE** /api/v0/taxes | Tax ID required for deletion |
| [**TaxControllerFindAll**](TaxesApi.md#taxcontrollerfindall) | **GET** /api/v0/taxes | Get all taxes with filters |
| [**TaxControllerFindOne**](TaxesApi.md#taxcontrollerfindone) | **GET** /api/v0/taxes/{id} | Get a tax by ID |
| [**TaxControllerRemove**](TaxesApi.md#taxcontrollerremove) | **DELETE** /api/v0/taxes/{id} | Delete a tax |
| [**TaxControllerUpdate**](TaxesApi.md#taxcontrollerupdate) | **PUT** /api/v0/taxes/{id} | Update a tax |
| [**TaxControllerUpdateWithoutId**](TaxesApi.md#taxcontrollerupdatewithoutid) | **PUT** /api/v0/taxes | Tax ID required for updates |

<a id="taxcontrollercreate"></a>
# **TaxControllerCreate**
> TaxControllerCreate201Response TaxControllerCreate (CreateTaxDto createTaxDto)

Create a new tax

Creates a new tax rate that can be applied to products, invoices, and payment links.  ## Use Cases - Set up sales tax for different regions - Create VAT rates for international customers - Configure state and local tax rates - Manage tax compliance requirements  ## Example: Create Basic Sales Tax ```json {   \"name\": \"Sales Tax\",   \"description\": \"Standard sales tax for retail transactions\",   \"percentage\": 8.5,   \"active\": true } ```  ## Required Fields - `name`: Tax name for identification (1-100 characters) - `percentage`: Tax rate percentage (0-100)  ## Optional Fields - `description`: Explanation of what this tax covers (max 255 characters) - `active`: Whether this tax is currently active (default: true) - `appIds`: Array of app IDs where this tax should be available


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTaxDto** | [**CreateTaxDto**](CreateTaxDto.md) | Tax creation data |  |

### Return type

[**TaxControllerCreate201Response**](TaxControllerCreate201Response.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Tax created successfully |  -  |
| **400** | Bad Request - Invalid input data |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taxcontrollerdeletewithoutid"></a>
# **TaxControllerDeleteWithoutId**
> void TaxControllerDeleteWithoutId ()

Tax ID required for deletion

This endpoint requires a tax ID in the URL path. Use DELETE /api/v0/taxes/{id} instead.


### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request - Tax ID is required in the URL path |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taxcontrollerfindall"></a>
# **TaxControllerFindAll**
> void TaxControllerFindAll (decimal skip = null, decimal take = null, string name = null, bool active = null)

Get all taxes with filters

Retrieves a list of taxes with optional filtering and pagination.  ## Use Cases - List all available tax rates - Search taxes by name - Filter active/inactive taxes - Export tax configuration  ## Query Parameters - `skip`: Number of records to skip (default: 0, min: 0) - `take`: Number of records to return (default: 10, min: 1, max: 100) - `name`: Filter taxes by name (partial match, case-insensitive) - `active`: Filter by active status (true/false)  ## Example Request `GET /api/v0/taxes?skip=0&take=20&active=true&name=Sales`  ## Example Response ```json [   {     \"id\": \"tax_123456\",     \"name\": \"Sales Tax\",     \"description\": \"Standard sales tax for retail transactions\",     \"percentage\": 8.5,     \"active\": true,     \"created_at\": \"2024-03-20T10:00:00Z\",     \"updated_at\": \"2024-03-20T10:00:00Z\"   } ] ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skip** | **decimal** | Number of records to skip for pagination | [optional] [default to 0M] |
| **take** | **decimal** | Number of records to return (max 100) | [optional] [default to 10M] |
| **name** | **string** | Filter taxes by name (partial match, case-insensitive) | [optional]  |
| **active** | **bool** | Filter by active status | [optional]  |

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
| **200** | Successfully retrieved taxes |  -  |
| **400** | Bad Request - Invalid query parameters |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taxcontrollerfindone"></a>
# **TaxControllerFindOne**
> void TaxControllerFindOne (Guid id)

Get a tax by ID

Retrieves detailed information about a specific tax.  ## Use Cases - View tax details - Verify tax configuration - Check tax status before applying to products  ## Path Parameters - `id`: Tax UUID (required) - Must be a valid UUID format  ## Example Request `GET /api/v0/taxes/123e4567-e89b-12d3-a456-426614174000`  ## Example Response ```json {   \"id\": \"tax_123456\",   \"name\": \"Sales Tax\",   \"description\": \"Standard sales tax for retail transactions\",   \"percentage\": 8.5,   \"active\": true,   \"created_at\": \"2024-03-20T10:00:00Z\",   \"updated_at\": \"2024-03-20T10:00:00Z\" } ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Tax unique identifier (UUID) |  |

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
| **200** | Successfully retrieved tax |  -  |
| **400** | Bad Request - Invalid tax ID format |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Not Found - Tax not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taxcontrollerremove"></a>
# **TaxControllerRemove**
> void TaxControllerRemove (Guid id)

Delete a tax

Deletes an existing tax.  ## Use Cases - Remove obsolete tax rates - Clean up unused taxes - Comply with regulatory changes  ## Path Parameters - `id`: Tax UUID (required) - Must be a valid UUID format  ## Example Request `DELETE /api/v0/taxes/123e4567-e89b-12d3-a456-426614174000`  ## Warning This action cannot be undone. Consider deactivating the tax instead of deleting it if it has been used in transactions.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Tax unique identifier (UUID) |  |

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
| **200** | Successfully deleted tax |  -  |
| **400** | Bad Request - Invalid tax ID format |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Not Found - Tax not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taxcontrollerupdate"></a>
# **TaxControllerUpdate**
> void TaxControllerUpdate (Guid id, UpdateTaxDto updateTaxDto)

Update a tax

Updates an existing tax's information.  ## Use Cases - Modify tax percentage rates - Update tax descriptions - Activate/deactivate taxes - Change tax names  ## Path Parameters - `id`: Tax UUID (required) - Must be a valid UUID format  ## Example Request `PUT /api/v0/taxes/123e4567-e89b-12d3-a456-426614174000`  ## Example Request Body ```json {   \"name\": \"Updated Sales Tax\",   \"description\": \"Updated sales tax rate\",   \"percentage\": 9.0,   \"active\": true } ```  ## Notes - Only include fields that need to be updated - All fields are optional in updates - Percentage changes affect future calculations only


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Tax unique identifier (UUID) |  |
| **updateTaxDto** | [**UpdateTaxDto**](UpdateTaxDto.md) | Tax update data - only include fields you want to update |  |

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
| **200** | Successfully updated tax |  -  |
| **400** | Bad Request - Invalid input data or tax ID format |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Not Found - Tax not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="taxcontrollerupdatewithoutid"></a>
# **TaxControllerUpdateWithoutId**
> void TaxControllerUpdateWithoutId ()

Tax ID required for updates

This endpoint requires a tax ID in the URL path. Use PUT /api/v0/taxes/{id} instead.


### Parameters
This endpoint does not need any parameter.
### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **400** | Bad Request - Tax ID is required in the URL path |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


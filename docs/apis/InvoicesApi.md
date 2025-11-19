# Devdraft.Api.InvoicesApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**InvoiceControllerCreate**](InvoicesApi.md#invoicecontrollercreate) | **POST** /api/v0/invoices | Create a new invoice |
| [**InvoiceControllerFindAll**](InvoicesApi.md#invoicecontrollerfindall) | **GET** /api/v0/invoices | Get all invoices |
| [**InvoiceControllerFindOne**](InvoicesApi.md#invoicecontrollerfindone) | **GET** /api/v0/invoices/{id} | Get an invoice by ID |
| [**InvoiceControllerUpdate**](InvoicesApi.md#invoicecontrollerupdate) | **PUT** /api/v0/invoices/{id} | Update an invoice |

<a id="invoicecontrollercreate"></a>
# **InvoiceControllerCreate**
> void InvoiceControllerCreate (CreateInvoiceDto createInvoiceDto)

Create a new invoice


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createInvoiceDto** | [**CreateInvoiceDto**](CreateInvoiceDto.md) |  |  |

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
| **201** | The invoice has been successfully created. |  -  |
| **400** | Bad Request. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="invoicecontrollerfindall"></a>
# **InvoiceControllerFindAll**
> void InvoiceControllerFindAll (decimal skip = null, decimal take = null)

Get all invoices


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skip** | **decimal** | Number of records to skip | [optional]  |
| **take** | **decimal** | Number of records to take | [optional]  |

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
| **200** | Return all invoices. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="invoicecontrollerfindone"></a>
# **InvoiceControllerFindOne**
> void InvoiceControllerFindOne (string id)

Get an invoice by ID


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Invoice ID |  |

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
| **200** | Return the invoice. |  -  |
| **404** | Invoice not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="invoicecontrollerupdate"></a>
# **InvoiceControllerUpdate**
> void InvoiceControllerUpdate (string id, CreateInvoiceDto createInvoiceDto)

Update an invoice


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Invoice ID |  |
| **createInvoiceDto** | [**CreateInvoiceDto**](CreateInvoiceDto.md) |  |  |

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
| **200** | The invoice has been successfully updated. |  -  |
| **404** | Invoice not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


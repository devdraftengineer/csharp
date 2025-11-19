# Devdraft.Api.ProductsApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**ProductControllerCreate**](ProductsApi.md#productcontrollercreate) | **POST** /api/v0/products | Create a new product |
| [**ProductControllerFindAll**](ProductsApi.md#productcontrollerfindall) | **GET** /api/v0/products | Get all products |
| [**ProductControllerFindOne**](ProductsApi.md#productcontrollerfindone) | **GET** /api/v0/products/{id} | Get a product by ID |
| [**ProductControllerRemove**](ProductsApi.md#productcontrollerremove) | **DELETE** /api/v0/products/{id} | Delete a product |
| [**ProductControllerUpdate**](ProductsApi.md#productcontrollerupdate) | **PUT** /api/v0/products/{id} | Update a product |
| [**ProductControllerUploadImage**](ProductsApi.md#productcontrolleruploadimage) | **POST** /api/v0/products/{id}/images | Upload images for a product |

<a id="productcontrollercreate"></a>
# **ProductControllerCreate**
> void ProductControllerCreate (string name, string description, decimal price, string currency = null, string type = null, decimal weight = null, string unit = null, decimal quantity = null, decimal stockCount = null, string status = null, string productType = null, List<string> images = null)

Create a new product

Creates a new product with optional image uploads.      This endpoint allows you to create products with detailed information and multiple images.  ## Use Cases - Add new products to your catalog - Create products with multiple images - Set up product pricing and descriptions  ## Supported Image Formats - JPEG/JPG - PNG - WebP - Maximum 10 images per product - Maximum file size: 5MB per image  ## Example Request (multipart/form-data) ``` name: \"Premium Widget\" description: \"High-quality widget for all your needs\" price: \"99.99\" images: [file1.jpg, file2.jpg]  // Optional, up to 10 images ```  ## Required Fields - `name`: Product name - `price`: Product price (decimal number)  ## Optional Fields - `description`: Detailed product description - `images`: Product images (up to 10 files)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **name** | **string** | Product name as it will appear to customers. Should be clear and descriptive. |  |
| **description** | **string** | Detailed description of the product. Supports markdown formatting for rich text display. |  |
| **price** | **decimal** | Product price in the specified currency. Must be greater than 0. |  |
| **currency** | **string** | Currency code for the price. Defaults to USD if not specified. | [optional] [default to USD] |
| **type** | **string** | Product type | [optional]  |
| **weight** | **decimal** | Weight of the product | [optional]  |
| **unit** | **string** | Unit of measurement | [optional]  |
| **quantity** | **decimal** | Quantity available | [optional]  |
| **stockCount** | **decimal** | Stock count | [optional]  |
| **status** | **string** | Product status | [optional]  |
| **productType** | **string** | Product type | [optional]  |
| **images** | [**List&lt;string&gt;**](string.md) | Array of image URLs | [optional]  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | The product has been successfully created. |  -  |
| **400** | Bad Request - Invalid input data or image format |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **413** | Payload Too Large - Image files too large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productcontrollerfindall"></a>
# **ProductControllerFindAll**
> void ProductControllerFindAll (decimal skip = null, decimal take = null)

Get all products

Retrieves a list of products with pagination.      This endpoint allows you to fetch products with optional pagination.  ## Use Cases - List all products - Browse product catalog - Implement product search  ## Query Parameters - `skip`: Number of records to skip (default: 0) - `take`: Number of records to take (default: 10)  ## Example Response ```json {   \"data\": [     {       \"id\": \"prod_123456\",       \"name\": \"Premium Widget\",       \"description\": \"High-quality widget for all your needs\",       \"price\": \"99.99\",       \"images\": [         \"https://storage.example.com/images/file1.jpg\",         \"https://storage.example.com/images/file2.jpg\"       ],       \"createdAt\": \"2024-03-20T10:00:00Z\"     }   ],   \"total\": 100,   \"skip\": 0,   \"take\": 10 } ```


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
| **200** | Return all products. |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productcontrollerfindone"></a>
# **ProductControllerFindOne**
> void ProductControllerFindOne (string id)

Get a product by ID

Retrieves detailed information about a specific product.      This endpoint allows you to fetch complete product details including all images.  ## Use Cases - View product details - Display product information - Check product availability  ## Example Response ```json {   \"id\": \"prod_123456\",   \"name\": \"Premium Widget\",   \"description\": \"High-quality widget for all your needs\",   \"price\": \"99.99\",   \"images\": [     \"https://storage.example.com/images/file1.jpg\",     \"https://storage.example.com/images/file2.jpg\"   ],   \"createdAt\": \"2024-03-20T10:00:00Z\",   \"updatedAt\": \"2024-03-20T10:00:00Z\" } ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Product ID |  |

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
| **200** | Return the product. |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Product not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productcontrollerremove"></a>
# **ProductControllerRemove**
> void ProductControllerRemove (string id)

Delete a product

Deletes a product and its associated images.      This endpoint allows you to remove a product and all its associated data.  ## Use Cases - Remove discontinued products - Clean up product catalog - Delete test products  ## Notes - This action cannot be undone - All product images will be deleted - Associated data will be removed


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Product ID |  |

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
| **200** | The product has been successfully deleted. |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Product not found. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productcontrollerupdate"></a>
# **ProductControllerUpdate**
> void ProductControllerUpdate (string id, string name = null, string description = null, decimal price = null, string currency = null, string type = null, decimal weight = null, string unit = null, decimal quantity = null, decimal stockCount = null, string status = null, string productType = null, List<string> images = null)

Update a product

Updates an existing product's information and optionally adds new images.      This endpoint allows you to modify product details and manage product images.  ## Use Cases - Update product information - Change product pricing - Modify product images - Update product description  ## Example Request (multipart/form-data) ``` name: \"Updated Premium Widget\" description: \"Updated description\" price: \"129.99\" images: [file1.jpg, file2.jpg]  // Optional, up to 10 images ```  ## Notes - Only include fields that need to be updated - New images will replace existing images - Maximum 10 images per product - Images are automatically optimized


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Product ID |  |
| **name** | **string** | Product name as it will appear to customers. Should be clear and descriptive. | [optional]  |
| **description** | **string** | Detailed description of the product. Supports markdown formatting for rich text display. | [optional]  |
| **price** | **decimal** | Product price in the specified currency. Must be greater than 0. | [optional]  |
| **currency** | **string** | Currency code for the price. Defaults to USD if not specified. | [optional] [default to USD] |
| **type** | **string** | Product type | [optional]  |
| **weight** | **decimal** | Weight of the product | [optional]  |
| **unit** | **string** | Unit of measurement | [optional]  |
| **quantity** | **decimal** | Quantity available | [optional]  |
| **stockCount** | **decimal** | Stock count | [optional]  |
| **status** | **string** | Product status | [optional]  |
| **productType** | **string** | Product type | [optional]  |
| **images** | [**List&lt;string&gt;**](string.md) | Array of image URLs | [optional]  |

### Return type

void (empty response body)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: multipart/form-data
 - **Accept**: Not defined


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | The product has been successfully updated. |  -  |
| **400** | Bad Request - Invalid input data or image format |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Product not found. |  -  |
| **413** | Payload Too Large - Image files too large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="productcontrolleruploadimage"></a>
# **ProductControllerUploadImage**
> void ProductControllerUploadImage (string id)

Upload images for a product

Adds new images to an existing product.      This endpoint allows you to upload additional images for a product that already exists.  ## Use Cases - Add more product images - Update product gallery - Enhance product presentation  ## Supported Image Formats - JPEG/JPG - PNG - WebP - Maximum 10 images per upload - Maximum file size: 5MB per image  ## Example Request (multipart/form-data) ``` images: [file1.jpg, file2.jpg]  // Up to 10 images ```  ## Notes - Images are appended to existing product images - Total images per product cannot exceed 10 - Images are automatically optimized and resized


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Product ID |  |

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
| **201** | The images have been successfully uploaded. |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Product not found. |  -  |
| **413** | Payload Too Large - Image files too large |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


# Devdraft.Api.CustomersApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CustomerControllerCreate**](CustomersApi.md#customercontrollercreate) | **POST** /api/v0/customers | Create a new customer |
| [**CustomerControllerFindAll**](CustomersApi.md#customercontrollerfindall) | **GET** /api/v0/customers | Get all customers with filters |
| [**CustomerControllerFindOne**](CustomersApi.md#customercontrollerfindone) | **GET** /api/v0/customers/{id} | Get a customer by ID |
| [**CustomerControllerUpdate**](CustomersApi.md#customercontrollerupdate) | **PATCH** /api/v0/customers/{id} | Update a customer |

<a id="customercontrollercreate"></a>
# **CustomerControllerCreate**
> void CustomerControllerCreate (CreateCustomerDto createCustomerDto)

Create a new customer

Creates a new customer in the system with their personal and contact information.      This endpoint allows you to register new customers and store their details for future transactions.  ## Use Cases - Register new customers for payment processing - Store customer information for recurring payments - Maintain customer profiles for transaction history  ## Example: Create New Customer ```json {   \"first_name\": \"John\",   \"last_name\": \"Doe\",   \"email\": \"john.doe@example.com\",   \"phone_number\": \"+1-555-123-4567\",   \"customer_type\": \"Startup\",   \"status\": \"ACTIVE\" } ```  ## Required Fields - `first_name`: Customer's first name (1-100 characters) - `last_name`: Customer's last name (1-100 characters) - `phone_number`: Customer's phone number (max 20 characters)  ## Optional Fields - `email`: Valid email address (max 255 characters) - `customer_type`: Type of customer account (Individual, Startup, Small Business, Medium Business, Enterprise, Non-Profit, Government) - `status`: Customer status (ACTIVE, BLACKLISTED, DEACTIVATED)


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createCustomerDto** | [**CreateCustomerDto**](CreateCustomerDto.md) | Customer creation data |  |

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
| **201** | Customer created successfully |  -  |
| **400** | Bad Request - Invalid input data |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **409** | Conflict - Customer with the same email already exists |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="customercontrollerfindall"></a>
# **CustomerControllerFindAll**
> void CustomerControllerFindAll (decimal skip = null, decimal take = null, CustomerStatus status = null, string name = null, string email = null)

Get all customers with filters

Retrieves a list of customers with optional filtering and pagination.      This endpoint allows you to search and filter customers based on various criteria.  ## Use Cases - List all customers with pagination - Search customers by name or email - Filter customers by status - Export customer data  ## Query Parameters - `skip`: Number of records to skip (default: 0, min: 0) - `take`: Number of records to take (default: 10, min: 1, max: 100) - `status`: Filter by customer status (ACTIVE, BLACKLISTED, DEACTIVATED) - `name`: Filter by customer name (partial match, case-insensitive) - `email`: Filter by customer email (exact match, case-insensitive)  ## Example Request `GET /api/v0/customers?skip=0&take=20&status=ACTIVE&name=John`  ## Example Response ```json {   \"data\": [     {       \"id\": \"cust_123456\",       \"first_name\": \"John\",       \"last_name\": \"Doe\",       \"email\": \"john.doe@example.com\",       \"phone_number\": \"+1-555-123-4567\",       \"customer_type\": \"Startup\",       \"status\": \"ACTIVE\",       \"created_at\": \"2024-03-20T10:00:00Z\",       \"updated_at\": \"2024-03-20T10:00:00Z\"     }   ],   \"total\": 100,   \"skip\": 0,   \"take\": 10 } ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **skip** | **decimal** | Number of records to skip for pagination | [optional] [default to 0M] |
| **take** | **decimal** | Number of records to return (max 100) | [optional] [default to 10M] |
| **status** | **CustomerStatus** | Filter customers by status | [optional]  |
| **name** | **string** | Filter customers by name (partial match, case-insensitive) | [optional]  |
| **email** | **string** | Filter customers by email (exact match, case-insensitive) | [optional]  |

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
| **200** | Successfully retrieved customers |  -  |
| **400** | Bad Request - Invalid query parameters |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="customercontrollerfindone"></a>
# **CustomerControllerFindOne**
> void CustomerControllerFindOne (Guid id)

Get a customer by ID

Retrieves detailed information about a specific customer.      This endpoint allows you to fetch complete customer details including their contact information and status.  ## Use Cases - View customer details - Verify customer information - Check customer status before processing payments  ## Path Parameters - `id`: Customer UUID (required) - Must be a valid UUID format  ## Example Request `GET /api/v0/customers/123e4567-e89b-12d3-a456-426614174000`  ## Example Response ```json {   \"id\": \"cust_123456\",   \"first_name\": \"John\",   \"last_name\": \"Doe\",   \"email\": \"john.doe@example.com\",   \"phone_number\": \"+1-555-123-4567\",   \"customer_type\": \"Enterprise\",   \"status\": \"ACTIVE\",   \"last_spent\": 1250.50,   \"last_purchase_date\": \"2024-03-15T14:30:00Z\",   \"created_at\": \"2024-03-20T10:00:00Z\",   \"updated_at\": \"2024-03-20T10:00:00Z\" } ```


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Customer unique identifier (UUID) |  |

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
| **200** | Successfully retrieved customer |  -  |
| **400** | Bad Request - Invalid customer ID format |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Not Found - Customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="customercontrollerupdate"></a>
# **CustomerControllerUpdate**
> void CustomerControllerUpdate (Guid id, UpdateCustomerDto updateCustomerDto)

Update a customer

Updates an existing customer's information.      This endpoint allows you to modify customer details while preserving their core information.  ## Use Cases - Update customer contact information - Change customer type - Modify customer status  ## Path Parameters - `id`: Customer UUID (required) - Must be a valid UUID format  ## Example Request `PATCH /api/v0/customers/123e4567-e89b-12d3-a456-426614174000`  ## Example Request Body ```json {   \"first_name\": \"John\",   \"last_name\": \"Smith\",   \"phone_number\": \"+1-987-654-3210\",   \"customer_type\": \"Small Business\" } ```  ## Notes - Only include fields that need to be updated - All fields are optional in updates - Status changes may require additional verification


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **Guid** | Customer unique identifier (UUID) |  |
| **updateCustomerDto** | [**UpdateCustomerDto**](UpdateCustomerDto.md) | Customer update data |  |

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
| **200** | Successfully updated customer |  -  |
| **400** | Bad Request - Invalid input data or customer ID format |  -  |
| **401** | Unauthorized - Invalid API credentials |  -  |
| **404** | Not Found - Customer not found |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


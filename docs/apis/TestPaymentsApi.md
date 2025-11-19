# Devdraft.Api.TestPaymentsApi

All URIs are relative to *https://api.devdraft.ai*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**TestPaymentControllerCreatePaymentV0**](TestPaymentsApi.md#testpaymentcontrollercreatepaymentv0) | **POST** /api/v0/test-payment | Process a test payment |
| [**TestPaymentControllerGetPaymentV0**](TestPaymentsApi.md#testpaymentcontrollergetpaymentv0) | **GET** /api/v0/test-payment/{id} | Get payment details by ID |
| [**TestPaymentControllerRefundPaymentV0**](TestPaymentsApi.md#testpaymentcontrollerrefundpaymentv0) | **POST** /api/v0/test-payment/{id}/refund | Refund a payment |

<a id="testpaymentcontrollercreatepaymentv0"></a>
# **TestPaymentControllerCreatePaymentV0**
> PaymentResponseDto TestPaymentControllerCreatePaymentV0 (Guid idempotencyKey, PaymentRequestDto paymentRequestDto)

Process a test payment

Creates a new payment. Requires an idempotency key to prevent duplicate payments on retry.      ## Idempotency Key Best Practices  1. **Generate unique keys**: Use UUIDs or similar unique identifiers, prefixed with a descriptive operation name 2. **Store keys client-side**: Save the key with the original request so you can retry with the same key 3. **Key format**: Between 6-64 alphanumeric characters 4. **Expiration**: Keys expire after 24 hours by default 5. **Use case**: Perfect for ensuring payment operations are never processed twice, even during network failures  ## Example Request (curl)  ```bash curl -X POST \\   https://api.example.com/rest-api/v0/test-payment \\   -H 'Content-Type: application/json' \\   -H 'Client-Key: your-api-key' \\   -H 'Client-Secret: your-api-secret' \\   -H 'Idempotency-Key: payment_123456_unique_key' \\   -d '{     \"amount\": 100.00,     \"currency\": \"USD\",     \"description\": \"Test payment for order #12345\",     \"customerId\": \"cus_12345\"   }' ```  ## Example Response (First Request)  ```json {   \"id\": \"pay_abc123xyz456\",   \"amount\": 100.00,   \"currency\": \"USD\",   \"status\": \"succeeded\",   \"timestamp\": \"2023-07-01T12:00:00.000Z\" } ```  ## Example Response (Duplicate Request)  The exact same response will be returned for any duplicate request with the same idempotency key, without creating a new payment.  ## Retry Scenario Example  Network failure during payment submission: 1. Client creates payment request with idempotency key: \"payment_123456_unique_key\" 2. Request begins processing, but network connection fails before response received 3. Client retries the exact same request with the same idempotency key 4. Server detects duplicate idempotency key and returns the result of the first request 5. No duplicate payment is created  If you retry with same key but different parameters (e.g., different amount), you'll receive a 409 Conflict error.


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **idempotencyKey** | **Guid** | Unique key to ensure the request is idempotent. If a request with the same key is sent multiple times, only the first will be processed, and subsequent requests will return the same response. |  |
| **paymentRequestDto** | [**PaymentRequestDto**](PaymentRequestDto.md) |  |  |

### Return type

[**PaymentResponseDto**](PaymentResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Payment processed successfully |  -  |
| **400** | Bad Request. The idempotency key is missing or invalid.    Sample response: &#x60;&#x60;&#x60;json {   \&quot;statusCode\&quot;: 400,   \&quot;message\&quot;: \&quot;The idempotency-key header is required for POST requests\&quot; } &#x60;&#x60;&#x60; |  -  |
| **401** | Unauthorized. Client key or secret is invalid or missing. |  -  |
| **409** | Idempotency Conflict. The provided idempotency key was already used with different parameters.    Sample response: &#x60;&#x60;&#x60;json {   \&quot;statusCode\&quot;: 409,   \&quot;message\&quot;: \&quot;Conflict: Idempotency key already used with different request data\&quot; } &#x60;&#x60;&#x60; |  -  |
| **429** | Too many requests, rate limit exceeded. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="testpaymentcontrollergetpaymentv0"></a>
# **TestPaymentControllerGetPaymentV0**
> PaymentResponseDto TestPaymentControllerGetPaymentV0 (string id)

Get payment details by ID


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Payment ID |  |

### Return type

[**PaymentResponseDto**](PaymentResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment details retrieved successfully |  -  |
| **400** | Bad Request. The idempotency key is missing or invalid.    Sample response: &#x60;&#x60;&#x60;json {   \&quot;statusCode\&quot;: 400,   \&quot;message\&quot;: \&quot;The idempotency-key header is required for POST requests\&quot; } &#x60;&#x60;&#x60; |  -  |
| **401** | Unauthorized. Client key or secret is invalid or missing. |  -  |
| **409** | Idempotency Conflict. The provided idempotency key was already used with different parameters.    Sample response: &#x60;&#x60;&#x60;json {   \&quot;statusCode\&quot;: 409,   \&quot;message\&quot;: \&quot;Conflict: Idempotency key already used with different request data\&quot; } &#x60;&#x60;&#x60; |  -  |
| **429** | Too many requests, rate limit exceeded. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)

<a id="testpaymentcontrollerrefundpaymentv0"></a>
# **TestPaymentControllerRefundPaymentV0**
> RefundResponseDto TestPaymentControllerRefundPaymentV0 (string id, Guid idempotencyKey)

Refund a payment

Refunds an existing payment. Requires an idempotency key to prevent duplicate refunds on retry.      ## Idempotency Key Benefits for Refunds  Refunds are critical financial operations where duplicates can cause serious issues. Using idempotency keys ensures:  1. **Prevent duplicate refunds**: Even if a request times out or fails, retrying with the same key won't issue multiple refunds 2. **Safe retries**: Network failures or timeouts won't risk creating multiple refunds 3. **Consistent response**: Always get the same response for the same operation  ## Example Request (curl)  ```bash curl -X POST \\   https://api.example.com/rest-api/v0/test-payment/pay_abc123xyz456/refund \\   -H 'Content-Type: application/json' \\   -H 'Client-Key: your-api-key' \\   -H 'Client-Secret: your-api-secret' \\   -H 'Idempotency-Key: refund_123456_unique_key' ```  ## Example Response (First Request)  ```json {   \"id\": \"ref_xyz789\",   \"paymentId\": \"pay_abc123xyz456\",   \"amount\": 100.00,   \"status\": \"succeeded\",   \"timestamp\": \"2023-07-01T14:30:00.000Z\" } ```  ## Example Response (Duplicate Request)  The exact same response will be returned for any duplicate request with the same idempotency key, without creating a new refund.  ## Idempotency Key Guidelines  - Use a unique key for each distinct refund operation - Store keys client-side to ensure you can retry with the same key if needed - Keys expire after 24 hours by default


### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Payment ID to refund |  |
| **idempotencyKey** | **Guid** | Unique key to ensure the refund request is idempotent. If a request with the same key is sent multiple times, only the first will be processed, and subsequent requests will return the same response. |  |

### Return type

[**RefundResponseDto**](RefundResponseDto.md)

### Authorization

[x-client-secret](../README.md#x-client-secret), [x-client-key](../README.md#x-client-key)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Payment refunded successfully |  -  |
| **400** | Bad Request. The idempotency key is missing or invalid.    Sample response: &#x60;&#x60;&#x60;json {   \&quot;statusCode\&quot;: 400,   \&quot;message\&quot;: \&quot;The idempotency-key header is required for POST requests\&quot; } &#x60;&#x60;&#x60; |  -  |
| **401** | Unauthorized. Client key or secret is invalid or missing. |  -  |
| **409** | Idempotency Conflict. The provided idempotency key was already used with different parameters.    Sample response: &#x60;&#x60;&#x60;json {   \&quot;statusCode\&quot;: 409,   \&quot;message\&quot;: \&quot;Conflict: Idempotency key already used with different request data\&quot; } &#x60;&#x60;&#x60; |  -  |
| **429** | Too many requests, rate limit exceeded. |  -  |

[[Back to top]](#) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to Model list]](../../README.md#documentation-for-models) [[Back to README]](../../README.md)


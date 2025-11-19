# Devdraft.Model.CreateInvoiceDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the invoice | 
**Email** | **string** | Email address | 
**CustomerId** | **string** | Customer ID | 
**Currency** | **string** | Currency for the invoice | 
**Items** | **Object** |  | 
**DueDate** | **DateTime** | Due date of the invoice | 
**Delivery** | **string** | Delivery method | 
**PaymentLink** | **bool** | Whether to generate a payment link | 
**PaymentMethods** | **List&lt;CreateInvoiceDto.PaymentMethodsEnum&gt;** | Array of accepted payment methods | 
**Status** | **string** | Invoice status | 
**PartialPayment** | **bool** | Allow partial payments | 
**Address** | **string** | Address | [optional] 
**PhoneNumber** | **string** | Phone number | [optional] 
**SendDate** | **DateTime** | Send date | [optional] 
**Logo** | **string** | Logo URL | [optional] 
**TaxId** | **string** | Tax ID | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


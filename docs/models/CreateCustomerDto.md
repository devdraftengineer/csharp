# Devdraft.Model.CreateCustomerDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**FirstName** | **string** | Customer&#39;s first name. Used for personalization and legal documentation. | 
**LastName** | **string** | Customer&#39;s last name. Used for personalization and legal documentation. | 
**PhoneNumber** | **string** | Customer&#39;s phone number. Used for SMS notifications and verification. Include country code for international numbers. | 
**Email** | **string** | Customer&#39;s email address. Used for notifications, receipts, and account management. Must be a valid email format. | [optional] 
**CustomerType** | **CustomerType** | Type of customer account. Determines available features and compliance requirements. | [optional] 
**Status** | **CustomerStatus** | Current status of the customer account. Controls access to services and features. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


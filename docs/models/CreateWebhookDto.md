# Devdraft.Model.CreateWebhookDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Name of the webhook for identification purposes | 
**Url** | **string** | URL where webhook events will be sent | 
**IsActive** | **bool** | Whether the webhook is active and will receive events | [default to true]
**SigningSecret** | **string** | Secret key used to sign webhook payloads for verification | [optional] 
**Encrypted** | **bool** | Whether webhook payloads should be encrypted | [default to false]

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


# Devdraft.Model.CreateTaxDto

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Name** | **string** | Tax name. Used to identify and reference this tax rate. | 
**Percentage** | **decimal** | Tax percentage rate. Must be between 0 and 100. | 
**Description** | **string** | Optional description explaining what this tax covers. | [optional] 
**Active** | **bool** | Whether this tax is currently active and can be applied. | [optional] [default to true]
**AppIds** | **List&lt;Guid&gt;** | Array of app IDs where this tax should be available. If not provided, tax will be available for the current app. | [optional] 

[[Back to Model list]](../../README.md#documentation-for-models) [[Back to API list]](../../README.md#documentation-for-api-endpoints) [[Back to README]](../../README.md)


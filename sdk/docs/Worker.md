# Finbourne.Workflow.Sdk.Model.Worker
Information about the Worker

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**WorkerConfiguration** | [**CreateWorkerRequestWorkerConfiguration**](CreateWorkerRequestWorkerConfiguration.md) |  | 
**_Version** | [**ModelVersion**](ModelVersion.md) |  | [optional] 
**Parameters** | [**List&lt;Parameter&gt;**](Parameter.md) | The Parameters this Worker accepts or requires. | [optional] 
**ResultFields** | [**List&lt;ResultField&gt;**](ResultField.md) | The Fields that the Worker results will come back with. | [optional] 
**Links** | [**List&lt;Link&gt;**](Link.md) |  | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


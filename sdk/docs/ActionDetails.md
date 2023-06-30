# Finbourne.Workflow.Sdk.Model.ActionDetails
Abstracts the kinds of Actions available

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**ChildTaskConfigurations** | [**List&lt;ResultantChildTaskConfiguration&gt;**](ResultantChildTaskConfiguration.md) | Tasks can be generated from run worker results; this is the configuration | [optional] 
**WorkerId** | [**ResourceId**](ResourceId.md) |  | 
**WorkerAsAt** | **DateTimeOffset?** | Worker AsAt | [optional] 
**WorkerParameters** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Parameters for this Worker | [optional] 
**WorkerStatusTriggers** | [**WorkerStatusTriggers**](WorkerStatusTriggers.md) |  | [optional] 
**Trigger** | **string** | Trigger on parent task to be invoked | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


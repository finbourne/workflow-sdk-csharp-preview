# Finbourne.Workflow.Sdk.Model.RunWorkerAction
Defines an Worker Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | Type name for this Action | 
**WorkerId** | [**ResourceId**](ResourceId.md) |  | 
**WorkerAsAt** | **DateTimeOffset?** | Worker AsAt | [optional] 
**WorkerParameters** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Parameters for this Worker | [optional] 
**WorkerStatusTriggers** | [**WorkerStatusTriggers**](WorkerStatusTriggers.md) |  | [optional] 
**ChildTaskConfigurations** | [**List&lt;ResultantChildTaskConfiguration&gt;**](ResultantChildTaskConfiguration.md) | Tasks can be generated from run worker results; this is the configuration | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


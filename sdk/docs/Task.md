# Finbourne.Workflow.Sdk.Model.Task
Defines a Task created based on a Task Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique id for this Task | 
**CorrelationIds** | **List&lt;string&gt;** | User-provided ID used to link entities and tasks | [optional] 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionVersion** | [**TaskDefinitionVersion**](TaskDefinitionVersion.md) |  | 
**Version** | [**Version**](Version.md) |  | [optional] 
**State** | **string** | Current State | 
**TerminalState** | **bool** | True if no onward transitions are possible | 
**AsAtLastTransition** | **DateTimeOffset?** | Last Transition timestamp | [optional] 
**Fields** | [**List&lt;TaskInstanceField&gt;**](TaskInstanceField.md) | Fields and their latest values - should correspond with the Task Definition field schema | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


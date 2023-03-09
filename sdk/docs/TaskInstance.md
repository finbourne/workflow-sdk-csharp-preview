# Finbourne.Workflow.Sdk.Model.TaskInstance
Defines an Instance of a TaskDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitionId** | [**TaskDefinitionId**](TaskDefinitionId.md) |  | [optional] 
**TaskInstanceId** | **Guid** | The unique id for this Task Instance | [optional] 
**CorrelationId** | **string** | User-provided ID used to link entities and tasks | [optional] 
**States** | [**List&lt;State&gt;**](State.md) | States | [optional] 
**Transitions** | [**List&lt;Transition&gt;**](Transition.md) | Transitions | [optional] 
**Triggers** | [**List&lt;Trigger&gt;**](Trigger.md) | Triggers | [optional] 
**ActiveState** | **string** | Currently Active State | [optional] 
**Status** | **Status** |  | [optional] 
**TerminalState** | **bool** | True if no onward transitions are possible | [optional] 
**Created** | **DateTimeOffset** | Creation timestamp | [optional] 
**Updated** | **string** | Last Update timestamp | [optional] 
**LastTransition** | **string** | Last Transition timestamp | [optional] 
**Fields** | [**List&lt;FieldInstance&gt;**](FieldInstance.md) | Fields and their latest values - should correspond with the Task Definition field schema | [optional] 
**Receivers** | **List&lt;string&gt;** | A list of downstream Tasks to be invoked on completion | [optional] 
**History** | [**List&lt;HistoryEntry&gt;**](HistoryEntry.md) | A list of timestamped messages detailing what has occurred to this Task | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Finbourne.Workflow.Sdk.Model.Task
Defines a Task created based on a Task Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | The unique id for this Task | 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionVersion** | [**TaskDefinitionVersion**](TaskDefinitionVersion.md) |  | 
**State** | **string** | Current State | 
**UltimateParentTask** | [**TaskSummary**](TaskSummary.md) |  | 
**ParentTask** | [**TaskSummary**](TaskSummary.md) |  | [optional] 
**ChildTasks** | [**List&lt;TaskSummary&gt;**](TaskSummary.md) | This Task&#39;s child tasks | [optional] 
**CorrelationIds** | **List&lt;string&gt;** | User-provided ID used to link entities and tasks | [optional] 
**_Version** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**TerminalState** | **bool** | True if no onward transitions are possible | 
**AsAtLastTransition** | **DateTimeOffset?** | Last Transition timestamp | [optional] 
**Fields** | [**List&lt;TaskInstanceField&gt;**](TaskInstanceField.md) | Fields and their latest values - should correspond with the Task Definition field schema | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Finbourne.Workflow.Sdk.Model.TaskActivityResponse
Readonly information about how the worker should be executed

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of task activity | [optional] 
**CorrelationIds** | [**List&lt;EventHandlerMapping&gt;**](EventHandlerMapping.md) | The event to correlation ID mappings | [optional] 
**TaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | The event to task field mappings | [optional] 
**InitialTrigger** | **string** | Trigger to supply to all tasks to be made | [optional] 
**Filter** | **string** | The filter that matches on existing tasks | [optional] 
**Trigger** | **string** | Trigger to supply to all tasks that have been matched | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


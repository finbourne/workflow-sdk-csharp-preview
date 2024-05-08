# Finbourne.Workflow.Sdk.Model.UpdateMatchingTasksActivityResponse
Readonly TaskActivity response

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of task activity | [optional] 
**Filter** | **string** | The filter that matches on existing tasks | [optional] 
**Trigger** | **string** | Trigger to supply to all tasks that have been matched | [optional] 
**CorrelationIds** | [**List&lt;EventHandlerMapping&gt;**](EventHandlerMapping.md) | The event to correlation ID mappings | [optional] 
**TaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | The event to task field mappings | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Finbourne.Workflow.Sdk.Model.UpdateMatchingTasksActivity
Update all matching tasks based on filter matches

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of task activity | 
**Filter** | **string** | The filter that matches on existing tasks | [optional] 
**Trigger** | **string** | Trigger to supply to all tasks that have been matched | 
**CorrelationIds** | [**List&lt;EventHandlerMapping&gt;**](EventHandlerMapping.md) | The event to correlation ID mappings | [optional] 
**TaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | The event to task field mappings | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


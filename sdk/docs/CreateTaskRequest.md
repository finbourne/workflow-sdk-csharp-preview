# Finbourne.Workflow.Sdk.Model.CreateTaskRequest
Contains required info to create a new Task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**CorrelationIds** | **List&lt;string&gt;** | A set of guid identifiers that allow correlation across the application tier | [optional] 
**Fields** | [**List&lt;TaskInstanceField&gt;**](TaskInstanceField.md) | Fields and their initial values - should correspond with the Task Definition field schema | [optional] 
**StackingKey** | **string** | The key for the Stack that this Task should be added to | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


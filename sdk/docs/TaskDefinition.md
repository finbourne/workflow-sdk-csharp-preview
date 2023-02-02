# Finbourne.Workflow.Sdk.Model.TaskDefinition
TaskDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitionId** | [**TaskDefinitionId**](TaskDefinitionId.md) |  | [optional] 
**DisplayName** | **string** | Human readable name | [optional] 
**Description** | **string** | Human readable description | [optional] 
**States** | [**List&lt;State&gt;**](State.md) | The states this Task Definition operates over | [optional] 
**FieldsSchema** | [**List&lt;FieldSchema&gt;**](FieldSchema.md) | The Fields that this Task Definition operates on | [optional] 
**InitialState** | [**InitialState**](InitialState.md) |  | [optional] 
**Triggers** | [**List&lt;Trigger&gt;**](Trigger.md) | The Triggers for State transition | [optional] 
**Outputs** | [**List&lt;Output&gt;**](Output.md) | The Outputs of this Task | [optional] 
**Transitions** | [**List&lt;Transition&gt;**](Transition.md) | The Transitions between States | [optional] 
**Instances** | **List&lt;Guid&gt;** | Each Definition will have a number of instances associated with it | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


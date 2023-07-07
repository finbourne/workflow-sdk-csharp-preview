# Finbourne.Workflow.Sdk.Model.TaskDefinition
TaskDefinition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**_Version** | [**VersionInfo**](VersionInfo.md) |  | [optional] 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**States** | [**List&lt;TaskStateDefinition&gt;**](TaskStateDefinition.md) | The states this Task Definition operates over | 
**FieldSchema** | [**List&lt;TaskFieldDefinition&gt;**](TaskFieldDefinition.md) | The Fields that this Task Definition operates on | [optional] 
**InitialState** | [**InitialState**](InitialState.md) |  | 
**Triggers** | [**List&lt;TransitionTriggerDefinition&gt;**](TransitionTriggerDefinition.md) | The Triggers for State transition | [optional] 
**Actions** | [**List&lt;ActionDefinition&gt;**](ActionDefinition.md) | The Actions of this Task - executed after a Transition completion | [optional] 
**Transitions** | [**List&lt;TaskTransitionDefinition&gt;**](TaskTransitionDefinition.md) | The Transitions between States | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


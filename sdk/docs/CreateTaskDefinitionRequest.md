# Finbourne.Workflow.Sdk.Model.CreateTaskDefinitionRequest
Contains required info to create a new Task Definition

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | [optional] 
**DisplayName** | **string** | Human readable name | [optional] 
**Description** | **string** | Human readable description | [optional] 
**Fields** | [**List&lt;FieldSchema&gt;**](FieldSchema.md) | Defines the fields associated with this Task | [optional] 
**States** | [**List&lt;State&gt;**](State.md) | The states this Task Definition operates over | [optional] 
**Transitions** | [**List&lt;Transition&gt;**](Transition.md) | Transitions | [optional] 
**Triggers** | [**List&lt;Trigger&gt;**](Trigger.md) | Triggers | [optional] 
**InitialState** | [**InitialState**](InitialState.md) |  | [optional] 
**Outputs** | [**List&lt;Output&gt;**](Output.md) | The Outputs of this Task | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


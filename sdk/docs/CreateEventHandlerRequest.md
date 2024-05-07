# Finbourne.Workflow.Sdk.Model.CreateEventHandlerRequest
Contains information for creating an Event Handler

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | [**ResourceId**](ResourceId.md) |  | 
**DisplayName** | **string** | Human readable name | 
**Description** | **string** | Human readable description | [optional] 
**Status** | **string** | The current status of the event handler | 
**EventMatchingPattern** | [**EventMatchingPattern**](EventMatchingPattern.md) |  | 
**RunAsUserId** | [**EventHandlerMapping**](EventHandlerMapping.md) |  | 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionAsAt** | **DateTimeOffset?** | AsAt of the required task definition | [optional] 
**TaskActivity** | **Object** | Defines what the event handler should do after being triggered | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


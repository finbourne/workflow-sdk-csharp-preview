# Finbourne.Workflow.Sdk.Model.ActionLog
An Action Log contains the processing history of an Action

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **Guid** | Unique identifier of the Action | 
**Origin** | [**ActionLogOrigin**](ActionLogOrigin.md) |  | 
**ActionType** | **string** | The type of the Action | 
**RunAsUserId** | **string** | The ID of the user that the Action was performed by.  If not specified, the actions were performed by the \&quot;current user\&quot;. | [optional] 
**LoggedItems** | [**List&lt;ActionLogItem&gt;**](ActionLogItem.md) | The logged items for this Action | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


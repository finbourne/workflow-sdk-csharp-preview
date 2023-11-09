# Finbourne.Workflow.Sdk.Model.Stack
Information pertaining to the Tasks Stack if one is present

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**MemberAddedAsAt** | **DateTimeOffset** | When the Task was added to the Stack | [optional] 
**StackOpenedAsAt** | **DateTimeOffset** | When the Stack was opened | [optional] 
**StackClosedAsAt** | **DateTimeOffset?** | When the Stack was closed | [optional] 
**StackMembershipType** | **string** | Whether the task is the Lead task of the Stack or a Member within the Stack | [optional] 
**StackStatus** | **string** | Status of the Stack (Open/Closed) | [optional] 
**LeadTaskId** | **Guid** | ID of the Lead Task | [optional] 
**LeadTaskState** | **string** | State of the Lead Task | [optional] 
**TasksInStack** | **int** | Number of Tasks in the Stack | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


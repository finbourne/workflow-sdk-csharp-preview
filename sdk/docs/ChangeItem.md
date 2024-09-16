# Finbourne.Workflow.Sdk.Model.ChangeItem
Defines a change that occured to a Task

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**AsAtModified** | **DateTimeOffset** | The AsAt time of the change | 
**UserIdModified** | **string** | The User ID that performed the change | 
**RequestIdModified** | **string** | The Request ID of the request that caused the change | 
**AsAtVersionNumber** | **int** | The AsAt Version number | 
**Action** | **string** | The Action that resulted in the change | 
**AttributeName** | **string** | The name of the attribute that has been change | 
**PreviousValue** | **Object** | The value of the attribute prior to the change | [optional] 
**NewValue** | **Object** | The value of the attribute following the change | 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


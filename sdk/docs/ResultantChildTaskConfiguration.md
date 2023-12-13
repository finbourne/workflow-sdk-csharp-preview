# Finbourne.Workflow.Sdk.Model.ResultantChildTaskConfiguration
Child Task Configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**ResultMatchingPattern** | [**ResultMatchingPattern**](ResultMatchingPattern.md) |  | [optional] 
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionAsAt** | **DateTimeOffset?** | TaskDefinition AsAt timestamp | [optional] 
**InitialTrigger** | **string** | The Initial Trigger for automatic start | [optional] 
**ChildTaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Field Mappings | 
**MapStackingKeyFrom** | **string** | The field to be mapped as the ChildTasks Stacking Key | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


# Finbourne.Workflow.Sdk.Model.CreateChildTaskConfiguration
Create Child Task Configuration

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**TaskDefinitionId** | [**ResourceId**](ResourceId.md) |  | 
**TaskDefinitionAsAt** | **DateTimeOffset?** | TaskDefinition AsAt timestamp | [optional] 
**InitialTrigger** | **string** | The Initial Trigger for automatic start | [optional] 
**ChildTaskFields** | [**Dictionary&lt;string, FieldMapping&gt;**](FieldMapping.md) | Field Mappings | [optional] 
**MapStackingKeyFrom** | **string** | If present, the value of this field on the parent task will be the Stacking Key on any created child tasks | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


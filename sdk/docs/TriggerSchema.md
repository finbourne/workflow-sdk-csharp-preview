# Finbourne.Workflow.Sdk.Model.TriggerSchema
Triggers can operate in response to different stimuli

## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Type** | **string** | The type of Trigger: Manual, Timeout or WebHook | [optional] 
**TimeInState** | **int** | The amount of time to wait in seconds (Timeout only) | [optional] 
**ResponseCodes** | **Dictionary&lt;string, List&lt;int&gt;&gt;** | Defines a set of HTTP response codes that correspond to an outcome. eg: &#39;OK &#x3D;&gt;  [&#39;200&#39;, &#39;204&#39;] (WebHook only) | [optional] 

[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)


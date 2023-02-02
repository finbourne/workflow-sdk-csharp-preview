# Finbourne.Workflow.Sdk.Api.TaskDefinitionsApi

All URIs are relative to *https://www.lusid.com/workflow*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTaskDefinition**](TaskDefinitionsApi.md#createtaskdefinition) | **POST** /api/taskdefinitions | [EXPERIMENTAL] CreateTaskDefinition: Create a new Task Definition.
[**CreateTaskInstance**](TaskDefinitionsApi.md#createtaskinstance) | **POST** /api/taskdefinitions/{scope}/{code} | [EXPERIMENTAL] CreateTaskInstance: Create a new Task Instance.
[**DeleteTaskDefinition**](TaskDefinitionsApi.md#deletetaskdefinition) | **DELETE** /api/taskdefinitions/{scope}/{code} | [EXPERIMENTAL] DeleteTaskDefinition: Delete a Task Definition.
[**GetTaskDefinition**](TaskDefinitionsApi.md#gettaskdefinition) | **GET** /api/taskdefinitions/{scope}/{code} | [EXPERIMENTAL] GetTaskDefinition: Get a Task Definition.
[**GetTaskInstancesForDefinition**](TaskDefinitionsApi.md#gettaskinstancesfordefinition) | **GET** /api/taskdefinitions/{scope}/{code}/instances | [EXPERIMENTAL] GetTaskInstancesForDefinition: Get all Task Instances based on a Task Definition
[**UpdateTaskDefinition**](TaskDefinitionsApi.md#updatetaskdefinition) | **PUT** /api/taskdefinitions/{scope}/{code} | [EXPERIMENTAL] UpdateTaskDefinition: Update an existing Task Definition.


<a name="createtaskdefinition"></a>
# **CreateTaskDefinition**
> TaskDefinition CreateTaskDefinition (CreateTaskDefinitionRequest createTaskDefinitionRequest)

[EXPERIMENTAL] CreateTaskDefinition: Create a new Task Definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class CreateTaskDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskDefinitionsApi(config);
            var createTaskDefinitionRequest = new CreateTaskDefinitionRequest(); // CreateTaskDefinitionRequest | The data to create a Task Definition

            try
            {
                // [EXPERIMENTAL] CreateTaskDefinition: Create a new Task Definition.
                TaskDefinition result = apiInstance.CreateTaskDefinition(createTaskDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskDefinitionsApi.CreateTaskDefinition: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **createTaskDefinitionRequest** | [**CreateTaskDefinitionRequest**](CreateTaskDefinitionRequest.md)| The data to create a Task Definition | 

### Return type

[**TaskDefinition**](TaskDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createtaskinstance"></a>
# **CreateTaskInstance**
> TaskInstance CreateTaskInstance (string scope, string code, CreateTaskInstanceRequest createTaskInstanceRequest, string taskInstanceScope = null)

[EXPERIMENTAL] CreateTaskInstance: Create a new Task Instance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class CreateTaskInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskDefinitionsApi(config);
            var scope = scope_example;  // string | The scope of task definition to create task instance from
            var code = code_example;  // string | The code of task definition to create a task instance from
            var createTaskInstanceRequest = new CreateTaskInstanceRequest(); // CreateTaskInstanceRequest | Request to create task instance
            var taskInstanceScope = taskInstanceScope_example;  // string | The scope of the task instance should be in; set to 'default' if not provided. (optional)  (default to "default")

            try
            {
                // [EXPERIMENTAL] CreateTaskInstance: Create a new Task Instance.
                TaskInstance result = apiInstance.CreateTaskInstance(scope, code, createTaskInstanceRequest, taskInstanceScope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskDefinitionsApi.CreateTaskInstance: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of task definition to create task instance from | 
 **code** | **string**| The code of task definition to create a task instance from | 
 **createTaskInstanceRequest** | [**CreateTaskInstanceRequest**](CreateTaskInstanceRequest.md)| Request to create task instance | 
 **taskInstanceScope** | **string**| The scope of the task instance should be in; set to &#39;default&#39; if not provided. | [optional] [default to &quot;default&quot;]

### Return type

[**TaskInstance**](TaskInstance.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetaskdefinition"></a>
# **DeleteTaskDefinition**
> DeletedEntityResponse DeleteTaskDefinition (string scope, string code)

[EXPERIMENTAL] DeleteTaskDefinition: Delete a Task Definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class DeleteTaskDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskDefinitionsApi(config);
            var scope = scope_example;  // string | The scope that identifies a Task Definition
            var code = code_example;  // string | The code that identifies a Task Definition

            try
            {
                // [EXPERIMENTAL] DeleteTaskDefinition: Delete a Task Definition.
                DeletedEntityResponse result = apiInstance.DeleteTaskDefinition(scope, code);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskDefinitionsApi.DeleteTaskDefinition: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a Task Definition | 
 **code** | **string**| The code that identifies a Task Definition | 

### Return type

[**DeletedEntityResponse**](DeletedEntityResponse.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No task definition exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskdefinition"></a>
# **GetTaskDefinition**
> TaskDefinition GetTaskDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTaskDefinition: Get a Task Definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class GetTaskDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskDefinitionsApi(config);
            var scope = scope_example;  // string | The scope that identifies a Task Definition
            var code = code_example;  // string | The code that identifies a Task Definition
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | AsAt time to retrieve stated Task Definition. Default to current time if not provided. (optional) 

            try
            {
                // [EXPERIMENTAL] GetTaskDefinition: Get a Task Definition.
                TaskDefinition result = apiInstance.GetTaskDefinition(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskDefinitionsApi.GetTaskDefinition: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a Task Definition | 
 **code** | **string**| The code that identifies a Task Definition | 
 **asAt** | **DateTimeOffset?**| AsAt time to retrieve stated Task Definition. Default to current time if not provided. | [optional] 

### Return type

[**TaskDefinition**](TaskDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No task definition exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettaskinstancesfordefinition"></a>
# **GetTaskInstancesForDefinition**
> ResourceListOfTaskInstance GetTaskInstancesForDefinition (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTaskInstancesForDefinition: Get all Task Instances based on a Task Definition

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class GetTaskInstancesForDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskDefinitionsApi(config);
            var scope = scope_example;  // string | The scope of the source Task Definition and the Task Instances so be searched under.
            var code = code_example;  // string | The code that identifies the source Task Definition
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | AsAt time to retrieve stated Task Instances. Default to latest AsAt if not provided. (optional) 

            try
            {
                // [EXPERIMENTAL] GetTaskInstancesForDefinition: Get all Task Instances based on a Task Definition
                ResourceListOfTaskInstance result = apiInstance.GetTaskInstancesForDefinition(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskDefinitionsApi.GetTaskInstancesForDefinition: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope of the source Task Definition and the Task Instances so be searched under. | 
 **code** | **string**| The code that identifies the source Task Definition | 
 **asAt** | **DateTimeOffset?**| AsAt time to retrieve stated Task Instances. Default to latest AsAt if not provided. | [optional] 

### Return type

[**ResourceListOfTaskInstance**](ResourceListOfTaskInstance.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | List of Task Instances which share the requested Definition |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No Task Instances found in current scope for this Definition |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetaskdefinition"></a>
# **UpdateTaskDefinition**
> TaskDefinition UpdateTaskDefinition (string scope, string code, UpdateTaskDefinitionRequest updateTaskDefinitionRequest)

[EXPERIMENTAL] UpdateTaskDefinition: Update an existing Task Definition.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class UpdateTaskDefinitionExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskDefinitionsApi(config);
            var scope = scope_example;  // string | The scope that identifies a Task Definition
            var code = code_example;  // string | The code that identifies a Task Definition
            var updateTaskDefinitionRequest = new UpdateTaskDefinitionRequest(); // UpdateTaskDefinitionRequest | The data to update a Task Definition

            try
            {
                // [EXPERIMENTAL] UpdateTaskDefinition: Update an existing Task Definition.
                TaskDefinition result = apiInstance.UpdateTaskDefinition(scope, code, updateTaskDefinitionRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskDefinitionsApi.UpdateTaskDefinition: " + e.Message );
                Debug.Print("Status Code: "+ e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **scope** | **string**| The scope that identifies a Task Definition | 
 **code** | **string**| The code that identifies a Task Definition | 
 **updateTaskDefinitionRequest** | [**UpdateTaskDefinitionRequest**](UpdateTaskDefinitionRequest.md)| The data to update a Task Definition | 

### Return type

[**TaskDefinition**](TaskDefinition.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | No task definition exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Finbourne.Workflow.Sdk.Api.TasksApi

All URIs are relative to *https://www.lusid.com/workflow*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateTask**](TasksApi.md#createtask) | **POST** /api/tasks | [EXPERIMENTAL] CreateTask: Create a new Task
[**DeleteTask**](TasksApi.md#deletetask) | **DELETE** /api/tasks/{id} | [EXPERIMENTAL] DeleteTask: Delete a Task
[**GetTask**](TasksApi.md#gettask) | **GET** /api/tasks/{id} | [EXPERIMENTAL] GetTask: Get a Task
[**UpdateTask**](TasksApi.md#updatetask) | **POST** /api/tasks/{id} | [EXPERIMENTAL] UpdateTask: Update a Task


<a name="createtask"></a>
# **CreateTask**
> Task CreateTask (CreateTaskRequest createTaskRequest, string trigger = null)

[EXPERIMENTAL] CreateTask: Create a new Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class CreateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var createTaskRequest = new CreateTaskRequest(); // CreateTaskRequest | Request to create Task
            var trigger = trigger_example;  // string | The name of the Trigger to invoke (optional) 

            try
            {
                // [EXPERIMENTAL] CreateTask: Create a new Task
                Task result = apiInstance.CreateTask(createTaskRequest, trigger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message );
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
 **createTaskRequest** | [**CreateTaskRequest**](CreateTaskRequest.md)| Request to create Task | 
 **trigger** | **string**| The name of the Trigger to invoke | [optional] 

### Return type

[**Task**](Task.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletetask"></a>
# **DeleteTask**
> DeletedEntityResponse DeleteTask (string id)

[EXPERIMENTAL] DeleteTask: Delete a Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class DeleteTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var id = id_example;  // string | The identifier for the Task to be deleted.

            try
            {
                // [EXPERIMENTAL] DeleteTask: Delete a Task
                DeletedEntityResponse result = apiInstance.DeleteTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTask: " + e.Message );
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
 **id** | **string**| The identifier for the Task to be deleted. | 

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
| **404** | No Task exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="gettask"></a>
# **GetTask**
> Task GetTask (string id, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTask: Get a Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class GetTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var id = id_example;  // string | Id of the Task to retrieve
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? |  (optional) 

            try
            {
                // [EXPERIMENTAL] GetTask: Get a Task
                Task result = apiInstance.GetTask(id, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTask: " + e.Message );
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
 **id** | **string**| Id of the Task to retrieve | 
 **asAt** | **DateTimeOffset?**|  | [optional] 

### Return type

[**Task**](Task.md)

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
| **404** | No Task exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="updatetask"></a>
# **UpdateTask**
> Task UpdateTask (string id, string trigger = null, UpdateTaskRequest updateTaskRequest = null)

[EXPERIMENTAL] UpdateTask: Update a Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class UpdateTaskExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TasksApi(config);
            var id = id_example;  // string | Id of the Task to act upon
            var trigger = trigger_example;  // string |  (optional) 
            var updateTaskRequest = new UpdateTaskRequest(); // UpdateTaskRequest | The details of the request (optional) 

            try
            {
                // [EXPERIMENTAL] UpdateTask: Update a Task
                Task result = apiInstance.UpdateTask(id, trigger, updateTaskRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTask: " + e.Message );
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
 **id** | **string**| Id of the Task to act upon | 
 **trigger** | **string**|  | [optional] 
 **updateTaskRequest** | [**UpdateTaskRequest**](UpdateTaskRequest.md)| The details of the request | [optional] 

### Return type

[**Task**](Task.md)

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
| **404** | No Task exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


# Finbourne.Workflow.Sdk.Api.TasksApi

All URIs are relative to *https://www.lusid.com/workflow*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**CreateTask**](TasksApi.md#createtask) | **POST** /api/tasks | [EXPERIMENTAL] CreateTask: Create a new Task |
| [**DeleteTask**](TasksApi.md#deletetask) | **DELETE** /api/tasks/{id} | [EXPERIMENTAL] DeleteTask: Delete a Task |
| [**GetTask**](TasksApi.md#gettask) | **GET** /api/tasks/{id} | [EXPERIMENTAL] GetTask: Get a Task |
| [**ListTasks**](TasksApi.md#listtasks) | **GET** /api/tasks | [EXPERIMENTAL] ListTasks: List Tasks |
| [**UpdateTask**](TasksApi.md#updatetask) | **POST** /api/tasks/{id} | [EXPERIMENTAL] UpdateTask: Update a Task |

<a id="createtask"></a>
# **CreateTask**
> Task CreateTask (CreateTaskRequest createTaskRequest, string? trigger = null)

[EXPERIMENTAL] CreateTask: Create a new Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
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

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TasksApi(httpClient, config, httpClientHandler);
            var createTaskRequest = new CreateTaskRequest(); // CreateTaskRequest | Request to create Task
            var trigger = "trigger_example";  // string? | The name of the Trigger to invoke (optional) 

            try
            {
                // [EXPERIMENTAL] CreateTask: Create a new Task
                Task result = apiInstance.CreateTask(createTaskRequest, trigger);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.CreateTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the CreateTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] CreateTask: Create a new Task
    ApiResponse<Task> response = apiInstance.CreateTaskWithHttpInfo(createTaskRequest, trigger);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.CreateTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **createTaskRequest** | [**CreateTaskRequest**](CreateTaskRequest.md) | Request to create Task |  |
| **trigger** | **string?** | The name of the Trigger to invoke | [optional]  |

### Return type

[**Task**](Task.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="deletetask"></a>
# **DeleteTask**
> DeletedEntityResponse DeleteTask (string id)

[EXPERIMENTAL] DeleteTask: Delete a Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
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

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TasksApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The identifier for the Task to be deleted.

            try
            {
                // [EXPERIMENTAL] DeleteTask: Delete a Task
                DeletedEntityResponse result = apiInstance.DeleteTask(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.DeleteTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the DeleteTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] DeleteTask: Delete a Task
    ApiResponse<DeletedEntityResponse> response = apiInstance.DeleteTaskWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.DeleteTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The identifier for the Task to be deleted. |  |

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
| **404** | Task not found. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="gettask"></a>
# **GetTask**
> Task GetTask (string id, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetTask: Get a Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
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

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TasksApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Id of the Task to retrieve
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to retrieve the Task. Defaults to returning the latest version of the Task if not specified. (optional) 

            try
            {
                // [EXPERIMENTAL] GetTask: Get a Task
                Task result = apiInstance.GetTask(id, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.GetTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetTask: Get a Task
    ApiResponse<Task> response = apiInstance.GetTaskWithHttpInfo(id, asAt);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.GetTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Id of the Task to retrieve |  |
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to retrieve the Task. Defaults to returning the latest version of the Task if not specified. | [optional]  |

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
| **404** | Task not found. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="listtasks"></a>
# **ListTasks**
> PagedResourceListOfTask ListTasks (DateTimeOffset? asAt = null, string? filter = null, int? limit = null, string? page = null)

[EXPERIMENTAL] ListTasks: List Tasks

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class ListTasksExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TasksApi(httpClient, config, httpClientHandler);
            var asAt = DateTime.Parse("2013-10-20T19:20:30+01:00");  // DateTimeOffset? | The asAt datetime at which to list the Tasks. Defaults to return the latest version of each Task if not specified. (optional) 
            var filter = "filter_example";  // string? | Expression to filter the result set. Read more about filtering results from LUSID here: https://support.lusid.com/filtering-results-from-lusid. (optional) 
            var limit = 10;  // int? | When paginating, limit the number of returned results to this many. (optional)  (default to 10)
            var page = "page_example";  // string? | The pagination token to use to continue listing tasks from a previous call to list tasks. This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields must not have changed since the original request. (optional) 

            try
            {
                // [EXPERIMENTAL] ListTasks: List Tasks
                PagedResourceListOfTask result = apiInstance.ListTasks(asAt, filter, limit, page);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.ListTasks: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the ListTasksWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] ListTasks: List Tasks
    ApiResponse<PagedResourceListOfTask> response = apiInstance.ListTasksWithHttpInfo(asAt, filter, limit, page);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.ListTasksWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **asAt** | **DateTimeOffset?** | The asAt datetime at which to list the Tasks. Defaults to return the latest version of each Task if not specified. | [optional]  |
| **filter** | **string?** | Expression to filter the result set. Read more about filtering results from LUSID here: https://support.lusid.com/filtering-results-from-lusid. | [optional]  |
| **limit** | **int?** | When paginating, limit the number of returned results to this many. | [optional] [default to 10] |
| **page** | **string?** | The pagination token to use to continue listing tasks from a previous call to list tasks. This value is returned from the previous call. If a pagination token is provided the sortBy, filter, effectiveAt, and asAt fields must not have changed since the original request. | [optional]  |

### Return type

[**PagedResourceListOfTask**](PagedResourceListOfTask.md)

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
| **404** | No Tasks found. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a id="updatetask"></a>
# **UpdateTask**
> Task UpdateTask (string id, string? trigger = null, UpdateTaskRequest? updateTaskRequest = null)

[EXPERIMENTAL] UpdateTask: Update a Task

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
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

            // create instances of HttpClient, HttpClientHandler to be reused later with different Api classes
            HttpClient httpClient = new HttpClient();
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            var apiInstance = new TasksApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | Id of the Task to act upon
            var trigger = "trigger_example";  // string? |  (optional) 
            var updateTaskRequest = new UpdateTaskRequest?(); // UpdateTaskRequest? | The details of the request (optional) 

            try
            {
                // [EXPERIMENTAL] UpdateTask: Update a Task
                Task result = apiInstance.UpdateTask(id, trigger, updateTaskRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TasksApi.UpdateTask: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the UpdateTaskWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] UpdateTask: Update a Task
    ApiResponse<Task> response = apiInstance.UpdateTaskWithHttpInfo(id, trigger, updateTaskRequest);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling TasksApi.UpdateTaskWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | Id of the Task to act upon |  |
| **trigger** | **string?** |  | [optional]  |
| **updateTaskRequest** | [**UpdateTaskRequest?**](UpdateTaskRequest?.md) | The details of the request | [optional]  |

### Return type

[**Task**](Task.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Task not found. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


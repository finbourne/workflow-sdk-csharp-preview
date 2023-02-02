# Finbourne.Workflow.Sdk.Api.TaskInstancesApi

All URIs are relative to *https://www.lusid.com/workflow*

Method | HTTP request | Description
------------- | ------------- | -------------
[**GetTaskInstance**](TaskInstancesApi.md#gettaskinstance) | **GET** /api/taskinstances/{id} | [EXPERIMENTAL] GetTaskInstance: Get a Task Instance.


<a name="gettaskinstance"></a>
# **GetTaskInstance**
> TaskInstance GetTaskInstance (string id, DateTimeOffset? asAt = null, string taskInstanceScope = null)

[EXPERIMENTAL] GetTaskInstance: Get a Task Instance.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class GetTaskInstanceExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new TaskInstancesApi(config);
            var id = id_example;  // string | Id of the task instance to retrieve
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? |  (optional) 
            var taskInstanceScope = taskInstanceScope_example;  // string | The scope of the task instance to retrieve from; 'default' if not provided. (optional)  (default to "default")

            try
            {
                // [EXPERIMENTAL] GetTaskInstance: Get a Task Instance.
                TaskInstance result = apiInstance.GetTaskInstance(id, asAt, taskInstanceScope);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling TaskInstancesApi.GetTaskInstance: " + e.Message );
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
 **id** | **string**| Id of the task instance to retrieve | 
 **asAt** | **DateTimeOffset?**|  | [optional] 
 **taskInstanceScope** | **string**| The scope of the task instance to retrieve from; &#39;default&#39; if not provided. | [optional] [default to &quot;default&quot;]

### Return type

[**TaskInstance**](TaskInstance.md)

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
| **404** | No Task Instance exists in current scope |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


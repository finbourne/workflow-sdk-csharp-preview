# Finbourne.Workflow.Sdk.Api.WorkersApi

All URIs are relative to *https://www.lusid.com/workflow*

Method | HTTP request | Description
------------- | ------------- | -------------
[**CreateWorker**](WorkersApi.md#createworker) | **POST** /api/workers | [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker
[**GetWorker**](WorkersApi.md#getworker) | **GET** /api/workers/{scope}/{code} | [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker


<a name="createworker"></a>
# **CreateWorker**
> Worker CreateWorker (CreateWorkerRequest createWorkerRequest)

[EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker

If the Worker already exists a failure will be returned

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class CreateWorkerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkersApi(config);
            var createWorkerRequest = new CreateWorkerRequest(); // CreateWorkerRequest | Worker to be created

            try
            {
                // [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker
                Worker result = apiInstance.CreateWorker(createWorkerRequest);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkersApi.CreateWorker: " + e.Message );
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
 **createWorkerRequest** | [**CreateWorkerRequest**](CreateWorkerRequest.md)| Worker to be created | 

### Return type

[**Worker**](Worker.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getworker"></a>
# **GetWorker**
> Worker GetWorker (string scope, string code, DateTimeOffset? asAt = null)

[EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker

Will return a NotFound failure if the Worker does not exist

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class GetWorkerExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new WorkersApi(config);
            var scope = scope_example;  // string | Scope of the worker
            var code = code_example;  // string | Code of the worker
            var asAt = 2013-10-20T19:20:30+01:00;  // DateTimeOffset? | AsAt time of the worker (optional) 

            try
            {
                // [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker
                Worker result = apiInstance.GetWorker(scope, code, asAt);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling WorkersApi.GetWorker: " + e.Message );
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
 **scope** | **string**| Scope of the worker | 
 **code** | **string**| Code of the worker | 
 **asAt** | **DateTimeOffset?**| AsAt time of the worker | [optional] 

### Return type

[**Worker**](Worker.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **201** | Created |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


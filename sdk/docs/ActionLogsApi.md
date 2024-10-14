# Finbourne.Workflow.Sdk.Api.ActionLogsApi

All URIs are relative to *https://www.lusid.com/workflow*

| Method | HTTP request | Description |
|--------|--------------|-------------|
| [**GetActionLogs**](ActionLogsApi.md#getactionlogs) | **GET** /api/actionlogs/{id} | [EXPERIMENTAL] GetActionLogs: Get the Action Logs for an Action Id |

<a id="getactionlogs"></a>
# **GetActionLogs**
> ActionLog GetActionLogs (string id)

[EXPERIMENTAL] GetActionLogs: Get the Action Logs for an Action Id

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
    public class GetActionLogsExample
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
            var apiInstance = new ActionLogsApi(httpClient, config, httpClientHandler);
            var id = "id_example";  // string | The Action Id

            try
            {
                // [EXPERIMENTAL] GetActionLogs: Get the Action Logs for an Action Id
                ActionLog result = apiInstance.GetActionLogs(id);
                Debug.WriteLine(result);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling ActionLogsApi.GetActionLogs: " + e.Message);
                Debug.Print("Status Code: " + e.ErrorCode);
                Debug.Print(e.StackTrace);
            }
        }
    }
}
```

#### Using the GetActionLogsWithHttpInfo variant
This returns an ApiResponse object which contains the response data, status code and headers.

```csharp
try
{
    // [EXPERIMENTAL] GetActionLogs: Get the Action Logs for an Action Id
    ApiResponse<ActionLog> response = apiInstance.GetActionLogsWithHttpInfo(id);
    Debug.Write("Status Code: " + response.StatusCode);
    Debug.Write("Response Headers: " + response.Headers);
    Debug.Write("Response Body: " + response.Data);
}
catch (ApiException e)
{
    Debug.Print("Exception when calling ActionLogsApi.GetActionLogsWithHttpInfo: " + e.Message);
    Debug.Print("Status Code: " + e.ErrorCode);
    Debug.Print(e.StackTrace);
}
```

### Parameters

| Name | Type | Description | Notes |
|------|------|-------------|-------|
| **id** | **string** | The Action Id |  |

### Return type

[**ActionLog**](ActionLog.md)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: text/plain, application/json, text/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **200** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **404** | Action Log not found. |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


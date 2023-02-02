# Finbourne.Workflow.Sdk.Api.UpdatesApi

All URIs are relative to *https://www.lusid.com/workflow*

Method | HTTP request | Description
------------- | ------------- | -------------
[**Raise**](UpdatesApi.md#raise) | **POST** /api/updates | [EXPERIMENTAL] Raise: Process an inbound Update.


<a name="raise"></a>
# **Raise**
> void Raise (string scope, UpdateTaskRequest updateTaskRequest)

[EXPERIMENTAL] Raise: Process an inbound Update.

### Example
```csharp
using System.Collections.Generic;
using System.Diagnostics;
using Finbourne.Workflow.Sdk.Api;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Example
{
    public class RaiseExample
    {
        public static void Main()
        {
            Configuration config = new Configuration();
            config.BasePath = "https://www.lusid.com/workflow";
            // Configure OAuth2 access token for authorization: oauth2
            config.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new UpdatesApi(config);
            var scope = scope_example;  // string | 
            var updateTaskRequest = new UpdateTaskRequest(); // UpdateTaskRequest | Update request

            try
            {
                // [EXPERIMENTAL] Raise: Process an inbound Update.
                apiInstance.Raise(scope, updateTaskRequest);
            }
            catch (ApiException  e)
            {
                Debug.Print("Exception when calling UpdatesApi.Raise: " + e.Message );
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
 **scope** | **string**|  | 
 **updateTaskRequest** | [**UpdateTaskRequest**](UpdateTaskRequest.md)| Update request | 

### Return type

void (empty response body)

### Authorization

[oauth2](../README.md#oauth2)

### HTTP request headers

 - **Content-Type**: application/json-patch+json, application/json, text/json, application/_*+json
 - **Accept**: application/json


### HTTP response details
| Status code | Description | Response headers |
|-------------|-------------|------------------|
| **204** | Success |  -  |
| **400** | The details of the input related failure |  -  |
| **0** | Error response |  -  |

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)


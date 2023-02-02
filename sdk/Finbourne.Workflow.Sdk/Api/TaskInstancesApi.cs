/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.128
 * Contact: info@finbourne.com
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Net.Mime;
using Finbourne.Workflow.Sdk.Client;
using Finbourne.Workflow.Sdk.Model;

namespace Finbourne.Workflow.Sdk.Api
{

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskInstancesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance.
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <returns>TaskInstance</returns>
        TaskInstance GetTaskInstance(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string));

        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of TaskInstance</returns>
        ApiResponse<TaskInstance> GetTaskInstanceWithHttpInfo(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskInstancesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TaskInstance</returns>
        System.Threading.Tasks.Task<TaskInstance> GetTaskInstanceAsync(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TaskInstance)</returns>
        System.Threading.Tasks.Task<ApiResponse<TaskInstance>> GetTaskInstanceWithHttpInfoAsync(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface ITaskInstancesApi : ITaskInstancesApiSync, ITaskInstancesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TaskInstancesApi : ITaskInstancesApi
    {
        private Finbourne.Workflow.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskInstancesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstancesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TaskInstancesApi(String basePath)
        {
            this.Configuration = Finbourne.Workflow.Sdk.Client.Configuration.MergeConfigurations(
                Finbourne.Workflow.Sdk.Client.GlobalConfiguration.Instance,
                new Finbourne.Workflow.Sdk.Client.Configuration { BasePath = basePath }
            );
            this.Client = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.ExceptionFactory = Finbourne.Workflow.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstancesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TaskInstancesApi(Finbourne.Workflow.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Workflow.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TaskInstancesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public TaskInstancesApi(Finbourne.Workflow.Sdk.Client.ISynchronousClient client, Finbourne.Workflow.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Workflow.Sdk.Client.IReadableConfiguration configuration)
        {
            if (client == null) throw new ArgumentNullException("client");
            if (asyncClient == null) throw new ArgumentNullException("asyncClient");
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Client = client;
            this.AsynchronousClient = asyncClient;
            this.Configuration = configuration;
            this.ExceptionFactory = Finbourne.Workflow.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// The client for accessing this underlying API asynchronously.
        /// </summary>
        public Finbourne.Workflow.Sdk.Client.IAsynchronousClient AsynchronousClient { get; set; }

        /// <summary>
        /// The client for accessing this underlying API synchronously.
        /// </summary>
        public Finbourne.Workflow.Sdk.Client.ISynchronousClient Client { get; set; }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.BasePath;
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Finbourne.Workflow.Sdk.Client.IReadableConfiguration Configuration { get; set; }

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Finbourne.Workflow.Sdk.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <returns>TaskInstance</returns>
        public TaskInstance GetTaskInstance(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string))
        {
            Finbourne.Workflow.Sdk.Client.ApiResponse<TaskInstance> localVarResponse = GetTaskInstanceWithHttpInfo(id, asAt, taskInstanceScope);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <returns>ApiResponse of TaskInstance</returns>
        public Finbourne.Workflow.Sdk.Client.ApiResponse<TaskInstance> GetTaskInstanceWithHttpInfo(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling TaskInstancesApi->GetTaskInstance");

            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (taskInstanceScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "taskInstanceScope", taskInstanceScope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.128");

            // make the HTTP request
            var localVarResponse = this.Client.Get<TaskInstance>("/api/taskinstances/{id}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTaskInstance", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of TaskInstance</returns>
        public async System.Threading.Tasks.Task<TaskInstance> GetTaskInstanceAsync(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Workflow.Sdk.Client.ApiResponse<TaskInstance> localVarResponse = await GetTaskInstanceWithHttpInfoAsync(id, asAt, taskInstanceScope, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetTaskInstance: Get a Task Instance. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="id">Id of the task instance to retrieve</param>
        /// <param name="asAt"> (optional)</param>
        /// <param name="taskInstanceScope">The scope of the task instance to retrieve from; &#39;default&#39; if not provided. (optional, default to &quot;default&quot;)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (TaskInstance)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Workflow.Sdk.Client.ApiResponse<TaskInstance>> GetTaskInstanceWithHttpInfoAsync(string id, DateTimeOffset? asAt = default(DateTimeOffset?), string taskInstanceScope = default(string), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'id' is set
            if (id == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'id' when calling TaskInstancesApi->GetTaskInstance");


            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("id", Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToString(id)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }
            if (taskInstanceScope != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "taskInstanceScope", taskInstanceScope));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.128");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<TaskInstance>("/api/taskinstances/{id}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetTaskInstance", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
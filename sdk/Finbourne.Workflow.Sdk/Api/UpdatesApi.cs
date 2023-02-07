/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.131
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
    public interface IUpdatesApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Raise: Process an inbound Update.
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <returns></returns>
        void Raise(string scope, UpdateTaskRequest updateTaskRequest);

        /// <summary>
        /// [EXPERIMENTAL] Raise: Process an inbound Update.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> RaiseWithHttpInfo(string scope, UpdateTaskRequest updateTaskRequest);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUpdatesApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] Raise: Process an inbound Update.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task RaiseAsync(string scope, UpdateTaskRequest updateTaskRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] Raise: Process an inbound Update.
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> RaiseWithHttpInfoAsync(string scope, UpdateTaskRequest updateTaskRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IUpdatesApi : IUpdatesApiSync, IUpdatesApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class UpdatesApi : IUpdatesApi
    {
        private Finbourne.Workflow.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UpdatesApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatesApi"/> class.
        /// </summary>
        /// <returns></returns>
        public UpdatesApi(String basePath)
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
        /// Initializes a new instance of the <see cref="UpdatesApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public UpdatesApi(Finbourne.Workflow.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Workflow.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdatesApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public UpdatesApi(Finbourne.Workflow.Sdk.Client.ISynchronousClient client, Finbourne.Workflow.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Workflow.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EXPERIMENTAL] Raise: Process an inbound Update. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <returns></returns>
        public void Raise(string scope, UpdateTaskRequest updateTaskRequest)
        {
            RaiseWithHttpInfo(scope, updateTaskRequest);
        }

        /// <summary>
        /// [EXPERIMENTAL] Raise: Process an inbound Update. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public Finbourne.Workflow.Sdk.Client.ApiResponse<Object> RaiseWithHttpInfo(string scope, UpdateTaskRequest updateTaskRequest)
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling UpdatesApi->Raise");

            // verify the required parameter 'updateTaskRequest' is set
            if (updateTaskRequest == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'updateTaskRequest' when calling UpdatesApi->Raise");

            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };

            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            localVarRequestOptions.Data = updateTaskRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.131");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Object>("/api/updates", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Raise", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] Raise: Process an inbound Update. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task RaiseAsync(string scope, UpdateTaskRequest updateTaskRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            await RaiseWithHttpInfoAsync(scope, updateTaskRequest, cancellationToken).ConfigureAwait(false);
        }

        /// <summary>
        /// [EXPERIMENTAL] Raise: Process an inbound Update. 
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope"></param>
        /// <param name="updateTaskRequest">Update request</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<Finbourne.Workflow.Sdk.Client.ApiResponse<Object>> RaiseWithHttpInfoAsync(string scope, UpdateTaskRequest updateTaskRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling UpdatesApi->Raise");

            // verify the required parameter 'updateTaskRequest' is set
            if (updateTaskRequest == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'updateTaskRequest' when calling UpdatesApi->Raise");


            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "application/json"
            };


            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "scope", scope));
            localVarRequestOptions.Data = updateTaskRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.131");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Object>("/api/updates", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("Raise", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
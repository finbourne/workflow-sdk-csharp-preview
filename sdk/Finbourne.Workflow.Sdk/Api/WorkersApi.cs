/*
 * FINBOURNE Workflow API
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 0.1.244
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
    public interface IWorkersApiSync : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker
        /// </summary>
        /// <remarks>
        /// If the Worker already exists a failure will be returned
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <returns>Worker</returns>
        Worker CreateWorker(CreateWorkerRequest createWorkerRequest);

        /// <summary>
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker
        /// </summary>
        /// <remarks>
        /// If the Worker already exists a failure will be returned
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <returns>ApiResponse of Worker</returns>
        ApiResponse<Worker> CreateWorkerWithHttpInfo(CreateWorkerRequest createWorkerRequest);
        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker
        /// </summary>
        /// <remarks>
        /// Will return a NotFound failure if the Worker does not exist
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <returns>Worker</returns>
        Worker GetWorker(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));

        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker
        /// </summary>
        /// <remarks>
        /// Will return a NotFound failure if the Worker does not exist
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <returns>ApiResponse of Worker</returns>
        ApiResponse<Worker> GetWorkerWithHttpInfo(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?));
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkersApiAsync : IApiAccessor
    {
        #region Asynchronous Operations
        /// <summary>
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker
        /// </summary>
        /// <remarks>
        /// If the Worker already exists a failure will be returned
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Worker</returns>
        System.Threading.Tasks.Task<Worker> CreateWorkerAsync(CreateWorkerRequest createWorkerRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker
        /// </summary>
        /// <remarks>
        /// If the Worker already exists a failure will be returned
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Worker)</returns>
        System.Threading.Tasks.Task<ApiResponse<Worker>> CreateWorkerWithHttpInfoAsync(CreateWorkerRequest createWorkerRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker
        /// </summary>
        /// <remarks>
        /// Will return a NotFound failure if the Worker does not exist
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Worker</returns>
        System.Threading.Tasks.Task<Worker> GetWorkerAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));

        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker
        /// </summary>
        /// <remarks>
        /// Will return a NotFound failure if the Worker does not exist
        /// </remarks>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Worker)</returns>
        System.Threading.Tasks.Task<ApiResponse<Worker>> GetWorkerWithHttpInfoAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IWorkersApi : IWorkersApiSync, IWorkersApiAsync
    {

    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class WorkersApi : IWorkersApi
    {
        private Finbourne.Workflow.Sdk.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkersApi() : this((string)null)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkersApi"/> class.
        /// </summary>
        /// <returns></returns>
        public WorkersApi(String basePath)
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
        /// Initializes a new instance of the <see cref="WorkersApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public WorkersApi(Finbourne.Workflow.Sdk.Client.Configuration configuration)
        {
            if (configuration == null) throw new ArgumentNullException("configuration");

            this.Configuration = configuration;
            this.Client = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            this.AsynchronousClient = new Finbourne.Workflow.Sdk.Client.ApiClient(this.Configuration.BasePath);
            ExceptionFactory = Finbourne.Workflow.Sdk.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkersApi"/> class
        /// using a Configuration object and client instance.
        /// </summary>
        /// <param name="client">The client interface for synchronous API access.</param>
        /// <param name="asyncClient">The client interface for asynchronous API access.</param>
        /// <param name="configuration">The configuration object.</param>
        public WorkersApi(Finbourne.Workflow.Sdk.Client.ISynchronousClient client, Finbourne.Workflow.Sdk.Client.IAsynchronousClient asyncClient, Finbourne.Workflow.Sdk.Client.IReadableConfiguration configuration)
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
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker If the Worker already exists a failure will be returned
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <returns>Worker</returns>
        public Worker CreateWorker(CreateWorkerRequest createWorkerRequest)
        {
            Finbourne.Workflow.Sdk.Client.ApiResponse<Worker> localVarResponse = CreateWorkerWithHttpInfo(createWorkerRequest);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker If the Worker already exists a failure will be returned
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <returns>ApiResponse of Worker</returns>
        public Finbourne.Workflow.Sdk.Client.ApiResponse<Worker> CreateWorkerWithHttpInfo(CreateWorkerRequest createWorkerRequest)
        {
            // verify the required parameter 'createWorkerRequest' is set
            if (createWorkerRequest == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'createWorkerRequest' when calling WorkersApi->CreateWorker");

            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json",
                "application/json",
                "text/json",
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createWorkerRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.244");

            // make the HTTP request
            var localVarResponse = this.Client.Post<Worker>("/api/workers", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateWorker", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker If the Worker already exists a failure will be returned
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Worker</returns>
        public async System.Threading.Tasks.Task<Worker> CreateWorkerAsync(CreateWorkerRequest createWorkerRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Workflow.Sdk.Client.ApiResponse<Worker> localVarResponse = await CreateWorkerWithHttpInfoAsync(createWorkerRequest, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] CreateWorker: Endpoint For Creating a Worker If the Worker already exists a failure will be returned
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="createWorkerRequest">Worker to be created</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Worker)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Workflow.Sdk.Client.ApiResponse<Worker>> CreateWorkerWithHttpInfoAsync(CreateWorkerRequest createWorkerRequest, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'createWorkerRequest' is set
            if (createWorkerRequest == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'createWorkerRequest' when calling WorkersApi->CreateWorker");


            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
                "application/json-patch+json", 
                "application/json", 
                "text/json", 
                "application/_*+json"
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.Data = createWorkerRequest;

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.244");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.PostAsync<Worker>("/api/workers", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("CreateWorker", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker Will return a NotFound failure if the Worker does not exist
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <returns>Worker</returns>
        public Worker GetWorker(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            Finbourne.Workflow.Sdk.Client.ApiResponse<Worker> localVarResponse = GetWorkerWithHttpInfo(scope, code, asAt);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker Will return a NotFound failure if the Worker does not exist
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <returns>ApiResponse of Worker</returns>
        public Finbourne.Workflow.Sdk.Client.ApiResponse<Worker> GetWorkerWithHttpInfo(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling WorkersApi->GetWorker");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling WorkersApi->GetWorker");

            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };

            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.244");

            // make the HTTP request
            var localVarResponse = this.Client.Get<Worker>("/api/workers/{scope}/{code}", localVarRequestOptions, this.Configuration);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWorker", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker Will return a NotFound failure if the Worker does not exist
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of Worker</returns>
        public async System.Threading.Tasks.Task<Worker> GetWorkerAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            Finbourne.Workflow.Sdk.Client.ApiResponse<Worker> localVarResponse = await GetWorkerWithHttpInfoAsync(scope, code, asAt, cancellationToken).ConfigureAwait(false);
            return localVarResponse.Data;
        }

        /// <summary>
        /// [EXPERIMENTAL] GetWorker: Endpoint for Retrieving a Worker Will return a NotFound failure if the Worker does not exist
        /// </summary>
        /// <exception cref="Finbourne.Workflow.Sdk.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="scope">Scope of the worker</param>
        /// <param name="code">Code of the worker</param>
        /// <param name="asAt">AsAt time of the worker (optional)</param>
        /// <param name="cancellationToken">Cancellation Token to cancel the request.</param>
        /// <returns>Task of ApiResponse (Worker)</returns>
        public async System.Threading.Tasks.Task<Finbourne.Workflow.Sdk.Client.ApiResponse<Worker>> GetWorkerWithHttpInfoAsync(string scope, string code, DateTimeOffset? asAt = default(DateTimeOffset?), System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken))
        {
            // verify the required parameter 'scope' is set
            if (scope == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'scope' when calling WorkersApi->GetWorker");

            // verify the required parameter 'code' is set
            if (code == null)
                throw new Finbourne.Workflow.Sdk.Client.ApiException(400, "Missing required parameter 'code' when calling WorkersApi->GetWorker");


            Finbourne.Workflow.Sdk.Client.RequestOptions localVarRequestOptions = new Finbourne.Workflow.Sdk.Client.RequestOptions();

            String[] _contentTypes = new String[] {
            };

            // to determine the Accept header
            String[] _accepts = new String[] {
                "text/plain",
                "application/json",
                "text/json"
            };


            var localVarContentType = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderContentType(_contentTypes);
            if (localVarContentType != null) localVarRequestOptions.HeaderParameters.Add("Content-Type", localVarContentType);

            var localVarAccept = Finbourne.Workflow.Sdk.Client.ClientUtils.SelectHeaderAccept(_accepts);
            if (localVarAccept != null) localVarRequestOptions.HeaderParameters.Add("Accept", localVarAccept);

            localVarRequestOptions.PathParameters.Add("scope", Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToString(scope)); // path parameter
            localVarRequestOptions.PathParameters.Add("code", Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToString(code)); // path parameter
            if (asAt != null)
            {
                localVarRequestOptions.QueryParameters.Add(Finbourne.Workflow.Sdk.Client.ClientUtils.ParameterToMultiMap("", "asAt", asAt));
            }

            // authentication (oauth2) required
            // oauth required
            if (!String.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarRequestOptions.HeaderParameters.Add("Authorization", "Bearer " + this.Configuration.AccessToken);
            }

            //  set the LUSID header
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Language", "C#");
            localVarRequestOptions.HeaderParameters.Add("X-LUSID-Sdk-Version", "0.1.244");

            // make the HTTP request

            var localVarResponse = await this.AsynchronousClient.GetAsync<Worker>("/api/workers/{scope}/{code}", localVarRequestOptions, this.Configuration, cancellationToken).ConfigureAwait(false);

            if (this.ExceptionFactory != null)
            {
                Exception _exception = this.ExceptionFactory("GetWorker", localVarResponse);
                if (_exception != null) throw _exception;
            }

            return localVarResponse;
        }

    }
}
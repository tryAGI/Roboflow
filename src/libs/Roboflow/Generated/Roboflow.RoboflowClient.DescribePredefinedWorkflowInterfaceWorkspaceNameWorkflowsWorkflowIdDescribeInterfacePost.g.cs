
#nullable enable

namespace Roboflow
{
    public partial class RoboflowClient
    {


        private static readonly global::Roboflow.EndPointSecurityRequirement s_DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostSecurityRequirement0 =
            new global::Roboflow.EndPointSecurityRequirement
            {
                Authorizations = new global::Roboflow.EndPointAuthorizationRequirement[]
                {                    new global::Roboflow.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        SchemeId = "ApikeyApiKey",
                        Location = "Query",
                        Name = "api_key",
                        FriendlyName = "ApiKeyInQuery",
                    },
                },
            };
        private static readonly global::Roboflow.EndPointSecurityRequirement[] s_DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostSecurityRequirements =
            new global::Roboflow.EndPointSecurityRequirement[]
            {                s_DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostSecurityRequirement0,
            };
        partial void PrepareDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string workspaceName,
            ref string workflowId,
            global::Roboflow.PredefinedWorkflowDescribeInterfaceRequest request);
        partial void PrepareDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string workspaceName,
            string workflowId,
            global::Roboflow.PredefinedWorkflowDescribeInterfaceRequest request);
        partial void ProcessDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Endpoint to describe interface of predefined workflow<br/>
        /// Checks Roboflow API for workflow definition, once acquired - describes workflow inputs and outputs
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.DescribeInterfaceResponse> DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync(
            string workspaceName,
            string workflowId,

            global::Roboflow.PredefinedWorkflowDescribeInterfaceRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsResponseAsync(
                workspaceName: workspaceName,
                workflowId: workflowId,

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// Endpoint to describe interface of predefined workflow<br/>
        /// Checks Roboflow API for workflow definition, once acquired - describes workflow inputs and outputs
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.DescribeInterfaceResponse>> DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsResponseAsync(
            string workspaceName,
            string workflowId,

            global::Roboflow.PredefinedWorkflowDescribeInterfaceRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostArguments(
                httpClient: HttpClient,
                workspaceName: ref workspaceName,
                workflowId: ref workflowId,
                request: request);


            var __authorizations = global::Roboflow.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostSecurityRequirements,
                operationName: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync");

            using var __timeoutCancellationTokenSource = global::Roboflow.AutoSDKRequestOptionsSupport.CreateTimeoutCancellationTokenSource(
                clientOptions: Options,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken);
            var __effectiveCancellationToken = __timeoutCancellationTokenSource?.Token ?? cancellationToken;
            var __effectiveReadResponseAsString = global::Roboflow.AutoSDKRequestOptionsSupport.GetReadResponseAsString(
                clientOptions: Options,
                requestOptions: requestOptions,
                fallbackValue: ReadResponseAsString);
            var __maxAttempts = global::Roboflow.AutoSDKRequestOptionsSupport.GetMaxAttempts(
                clientOptions: Options,
                requestOptions: requestOptions,
                supportsRetry: true);

            global::System.Net.Http.HttpRequestMessage __CreateHttpRequest()
            {

                            var __pathBuilder = new global::Roboflow.PathBuilder(
                                path: $"/{workspaceName}/workflows/{workflowId}/describe_interface",
                                baseUri: HttpClient.BaseAddress);
                            foreach (var __authorization in __authorizations)
                            {
                                if (__authorization.Type == "ApiKey" &&
                                    __authorization.Location == "Query")
                                {
                                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                                }
                            }
                            var __path = __pathBuilder.ToString();
                __path = global::Roboflow.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Post,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
                            var __httpRequestContentBody = request.ToJson(JsonSerializerContext);
                            var __httpRequestContent = new global::System.Net.Http.StringContent(
                                content: __httpRequestContentBody,
                                encoding: global::System.Text.Encoding.UTF8,
                                mediaType: "application/json");
                            __httpRequest.Content = __httpRequestContent;
                global::Roboflow.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    workspaceName: workspaceName!,
                    workflowId: workflowId!,
                    request: request);

                return __httpRequest;
            }

            global::System.Net.Http.HttpRequestMessage? __httpRequest = null;
            global::System.Net.Http.HttpResponseMessage? __response = null;
            var __attemptNumber = 0;
            try
            {
                for (var __attempt = 1; __attempt <= __maxAttempts; __attempt++)
                {
                    __attemptNumber = __attempt;
                    __httpRequest = __CreateHttpRequest();
                    await global::Roboflow.AutoSDKRequestOptionsSupport.OnBeforeRequestAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePost",
                                methodName: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync",
                                pathTemplate: "$\"/{workspaceName}/workflows/{workflowId}/describe_interface\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                    try
                    {
                        __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                    }
                    catch (global::System.Net.Http.HttpRequestException __exception)
                    {
                        var __retryDelay = global::Roboflow.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: null,
                            attempt: __attempt);
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePost",
                                methodName: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync",
                                pathTemplate: "$\"/{workspaceName}/workflows/{workflowId}/describe_interface\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                retryDelay: __willRetry ? __retryDelay : (global::System.TimeSpan?)null,
                                retryReason: "exception",
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Roboflow.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Roboflow.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        var __retryDelay = global::Roboflow.AutoSDKRequestOptionsSupport.GetRetryDelay(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            response: __response,
                            attempt: __attempt);
                        await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePost",
                                methodName: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync",
                                pathTemplate: "$\"/{workspaceName}/workflows/{workflowId}/describe_interface\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                retryDelay: __retryDelay,
                                retryReason: "status:" + ((int)__response.StatusCode).ToString(global::System.Globalization.CultureInfo.InvariantCulture),
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Roboflow.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            retryDelay: __retryDelay,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    break;
                }

                if (__response == null)
                {
                    throw new global::System.InvalidOperationException("No response received.");
                }

                using (__response)
                {

                ProcessResponse(
                    client: HttpClient,
                    response: __response);
                ProcessDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePost",
                                methodName: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync",
                                pathTemplate: "$\"/{workspaceName}/workflows/{workflowId}/describe_interface\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePost",
                                methodName: "DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync",
                                pathTemplate: "$\"/{workspaceName}/workflows/{workflowId}/describe_interface\"",
                                httpMethod: "POST",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                retryDelay: null,
                                retryReason: global::System.String.Empty,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                            // Validation Error
                            if ((int)__response.StatusCode == 422)
                            {
                                string? __content_422 = null;
                                global::System.Exception? __exception_422 = null;
                                global::Roboflow.HTTPValidationError? __value_422 = null;
                                try
                                {
                                    if (__effectiveReadResponseAsString)
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);
                                        __value_422 = global::Roboflow.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                    else
                                    {
                                        __content_422 = await __response.Content.ReadAsStringAsync(__effectiveCancellationToken).ConfigureAwait(false);

                                        __value_422 = global::Roboflow.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                                    }
                                }
                                catch (global::System.Exception __ex)
                                {
                                    __exception_422 = __ex;
                                }

                                throw new global::Roboflow.ApiException<global::Roboflow.HTTPValidationError>(
                                    message: __content_422 ?? __response.ReasonPhrase ?? string.Empty,
                                    innerException: __exception_422,
                                    statusCode: __response.StatusCode)
                                {
                                    ResponseBody = __content_422,
                                    ResponseObject = __value_422,
                                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                        __response.Headers,
                                        h => h.Key,
                                        h => h.Value),
                                };
                            }

                            if (__effectiveReadResponseAsString)
                            {
                                var __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                    __effectiveCancellationToken
                #endif
                                ).ConfigureAwait(false);

                                ProcessResponseContent(
                                    client: HttpClient,
                                    response: __response,
                                    content: ref __content);
                                ProcessDescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Roboflow.DescribeInterfaceResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Roboflow.AutoSDKHttpResponse<global::Roboflow.DescribeInterfaceResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Roboflow.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    throw new global::Roboflow.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }
                            else
                            {
                                try
                                {
                                    __response.EnsureSuccessStatusCode();
                                    using var __content = await __response.Content.ReadAsStreamAsync(
                #if NET5_0_OR_GREATER
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    var __value = await global::Roboflow.DescribeInterfaceResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Roboflow.AutoSDKHttpResponse<global::Roboflow.DescribeInterfaceResponse>(
                                        statusCode: __response.StatusCode,
                                        headers: global::Roboflow.AutoSDKHttpResponse.CreateHeaders(__response),
                                        requestUri: __response.RequestMessage?.RequestUri,
                                        body: __value);
                                }
                                catch (global::System.Exception __ex)
                                {
                                    string? __content = null;
                                    try
                                    {
                                        __content = await __response.Content.ReadAsStringAsync(
                #if NET5_0_OR_GREATER
                                            __effectiveCancellationToken
                #endif
                                        ).ConfigureAwait(false);
                                    }
                                    catch (global::System.Exception)
                                    {
                                    }

                                    throw new global::Roboflow.ApiException(
                                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                                        innerException: __ex,
                                        statusCode: __response.StatusCode)
                                    {
                                        ResponseBody = __content,
                                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                                            __response.Headers,
                                            h => h.Key,
                                            h => h.Value),
                                    };
                                }
                            }

                }
            }
            finally
            {
                __httpRequest?.Dispose();
            }
        }
        /// <summary>
        /// Endpoint to describe interface of predefined workflow<br/>
        /// Checks Roboflow API for workflow definition, once acquired - describes workflow inputs and outputs
        /// </summary>
        /// <param name="workspaceName"></param>
        /// <param name="workflowId"></param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="useCache">
        /// Controls usage of cache for workflow definitions. Set this to False when you frequently modify definition saved in Roboflow app and want to fetch the newest version for the request. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="workflowVersionId">
        /// Specific version of the workflow to fetch. If not provided, the latest version is used.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.DescribeInterfaceResponse> DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync(
            string workspaceName,
            string workflowId,
            string apiKey,
            bool? useCache = default,
            string? workflowVersionId = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Roboflow.PredefinedWorkflowDescribeInterfaceRequest
            {
                ApiKey = apiKey,
                UseCache = useCache,
                WorkflowVersionId = workflowVersionId,
            };

            return await DescribePredefinedWorkflowInterfaceWorkspaceNameWorkflowsWorkflowIdDescribeInterfacePostAsync(
                workspaceName: workspaceName,
                workflowId: workflowId,
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
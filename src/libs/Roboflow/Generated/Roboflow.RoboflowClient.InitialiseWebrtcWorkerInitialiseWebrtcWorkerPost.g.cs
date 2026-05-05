
#nullable enable

namespace Roboflow
{
    public partial class RoboflowClient
    {


        private static readonly global::Roboflow.EndPointSecurityRequirement s_InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostSecurityRequirement0 =
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
        private static readonly global::Roboflow.EndPointSecurityRequirement[] s_InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostSecurityRequirements =
            new global::Roboflow.EndPointSecurityRequirement[]
            {                s_InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostSecurityRequirement0,
            };
        partial void PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Roboflow.WebRTCWorkerRequest request);
        partial void PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Roboflow.WebRTCWorkerRequest request);
        partial void ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function<br/>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::Roboflow.InitializeWebRTCResponse> InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(

            global::Roboflow.WebRTCWorkerRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __response = await InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsResponseAsync(

                request: request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken
            ).ConfigureAwait(false);

            return __response.Body;
        }
        /// <summary>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function<br/>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.InitializeWebRTCResponse>> InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsResponseAsync(

            global::Roboflow.WebRTCWorkerRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostArguments(
                httpClient: HttpClient,
                request: request);


            var __authorizations = global::Roboflow.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostSecurityRequirements,
                operationName: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync");

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
                                path: "/initialise_webrtc_worker",
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
                PrepareInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
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
                                operationId: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPost",
                                methodName: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync",
                                pathTemplate: "\"/initialise_webrtc_worker\"",
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
                                operationId: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPost",
                                methodName: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync",
                                pathTemplate: "\"/initialise_webrtc_worker\"",
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
                                operationId: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPost",
                                methodName: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync",
                                pathTemplate: "\"/initialise_webrtc_worker\"",
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
                ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPost",
                                methodName: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync",
                                pathTemplate: "\"/initialise_webrtc_worker\"",
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
                                operationId: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPost",
                                methodName: "InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync",
                                pathTemplate: "\"/initialise_webrtc_worker\"",
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
                                ProcessInitialiseWebrtcWorkerInitialiseWebrtcWorkerPostResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    var __value = global::Roboflow.InitializeWebRTCResponse.FromJson(__content, JsonSerializerContext) ??
                                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                                    return new global::Roboflow.AutoSDKHttpResponse<global::Roboflow.InitializeWebRTCResponse>(
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

                                    var __value = await global::Roboflow.InitializeWebRTCResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                                    return new global::Roboflow.AutoSDKHttpResponse<global::Roboflow.InitializeWebRTCResponse>(
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
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function<br/>
        /// [EXPERIMENTAL] Establishes WebRTC peer connection and processes video stream in spawned process or modal function
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="workflowConfiguration"></param>
        /// <param name="isPreview">
        /// Default Value: false
        /// </param>
        /// <param name="webrtcOffer"></param>
        /// <param name="webrtcConfig"></param>
        /// <param name="webrtcTurnConfig"></param>
        /// <param name="webrtcRealtimeProcessing">
        /// Default Value: true
        /// </param>
        /// <param name="streamOutput"></param>
        /// <param name="dataOutput"></param>
        /// <param name="declaredFps"></param>
        /// <param name="rtspUrl"></param>
        /// <param name="mjpegUrl"></param>
        /// <param name="processingTimeout">
        /// Default Value: 3600
        /// </param>
        /// <param name="processingSessionStarted"></param>
        /// <param name="requestedPlan">
        /// Default Value: webrtc-gpu-small
        /// </param>
        /// <param name="requestedGpu"></param>
        /// <param name="requestedRegion"></param>
        /// <param name="workspaceId"></param>
        /// <param name="sessionId"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        public async global::System.Threading.Tasks.Task<global::Roboflow.InitializeWebRTCResponse> InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(
            global::Roboflow.WorkflowConfiguration workflowConfiguration,
            global::Roboflow.WebRTCOffer webrtcOffer,
            string? apiKey = default,
            bool? isPreview = default,
            global::Roboflow.WebRTCConfig? webrtcConfig = default,
            global::Roboflow.WebRTCTURNConfig? webrtcTurnConfig = default,
            bool? webrtcRealtimeProcessing = default,
            global::System.Collections.Generic.IList<string>? streamOutput = default,
            global::System.Collections.Generic.IList<string>? dataOutput = default,
            double? declaredFps = default,
            string? rtspUrl = default,
            string? mjpegUrl = default,
            int? processingTimeout = default,
            global::System.DateTime? processingSessionStarted = default,
            string? requestedPlan = default,
            string? requestedGpu = default,
            string? requestedRegion = default,
            string? workspaceId = default,
            string? sessionId = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Roboflow.WebRTCWorkerRequest
            {
                ApiKey = apiKey,
                WorkflowConfiguration = workflowConfiguration,
                IsPreview = isPreview,
                WebrtcOffer = webrtcOffer,
                WebrtcConfig = webrtcConfig,
                WebrtcTurnConfig = webrtcTurnConfig,
                WebrtcRealtimeProcessing = webrtcRealtimeProcessing,
                StreamOutput = streamOutput,
                DataOutput = dataOutput,
                DeclaredFps = declaredFps,
                RtspUrl = rtspUrl,
                MjpegUrl = mjpegUrl,
                ProcessingTimeout = processingTimeout,
                ProcessingSessionStarted = processingSessionStarted,
                RequestedPlan = requestedPlan,
                RequestedGpu = requestedGpu,
                RequestedRegion = requestedRegion,
                WorkspaceId = workspaceId,
                SessionId = sessionId,
            };

            return await InitialiseWebrtcWorkerInitialiseWebrtcWorkerPostAsync(
                request: __request,
                requestOptions: requestOptions,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
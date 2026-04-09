
#nullable enable

namespace Roboflow
{
    public partial class RoboflowClient
    {


        private static readonly global::Roboflow.EndPointSecurityRequirement s_PeComparePerceptionEncoderComparePostSecurityRequirement0 =
            new global::Roboflow.EndPointSecurityRequirement
            {
                Authorizations = new global::Roboflow.EndPointAuthorizationRequirement[]
                {                    new global::Roboflow.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Query",
                        Name = "api_key",
                        FriendlyName = "ApiKeyInQuery",
                    },
                },
            };
        private static readonly global::Roboflow.EndPointSecurityRequirement[] s_PeComparePerceptionEncoderComparePostSecurityRequirements =
            new global::Roboflow.EndPointSecurityRequirement[]
            {                s_PeComparePerceptionEncoderComparePostSecurityRequirement0,
            };
        partial void PreparePeComparePerceptionEncoderComparePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            bool? countinference,
            ref string? serviceSecret,
            global::Roboflow.PerceptionEncoderCompareRequest request);
        partial void PreparePeComparePerceptionEncoderComparePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? countinference,
            string? serviceSecret,
            global::Roboflow.PerceptionEncoderCompareRequest request);
        partial void ProcessPeComparePerceptionEncoderComparePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessPeComparePerceptionEncoderComparePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Perception Encoder Compare<br/>
        /// Run the Meta Perception Encoder model to compute similarity scores.
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.PerceptionEncoderCompareResponse> PeComparePerceptionEncoderComparePostAsync(

            global::Roboflow.PerceptionEncoderCompareRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PreparePeComparePerceptionEncoderComparePostArguments(
                httpClient: HttpClient,
                countinference: countinference,
                serviceSecret: ref serviceSecret,
                request: request);


            var __authorizations = global::Roboflow.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_PeComparePerceptionEncoderComparePostSecurityRequirements,
                operationName: "PeComparePerceptionEncoderComparePostAsync");

            var __pathBuilder = new global::Roboflow.PathBuilder(
                path: "/perception_encoder/compare",
                baseUri: HttpClient.BaseAddress);
            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query")
                {
                    __pathBuilder = __pathBuilder.AddRequiredParameter(__authorization.Name, __authorization.Value);
                }
            } 
            __pathBuilder
                .AddOptionalParameter("countinference", countinference?.ToString().ToLowerInvariant())
                .AddOptionalParameter("service_secret", serviceSecret) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
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

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PreparePeComparePerceptionEncoderComparePostRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessPeComparePerceptionEncoderComparePostResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Validation Error
            if ((int)__response.StatusCode == 422)
            {
                string? __content_422 = null;
                global::System.Exception? __exception_422 = null;
                global::Roboflow.HTTPValidationError? __value_422 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_422 = global::Roboflow.HTTPValidationError.FromJson(__content_422, JsonSerializerContext);
                    }
                    else
                    {
                        __content_422 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

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

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessPeComparePerceptionEncoderComparePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Roboflow.PerceptionEncoderCompareResponse.FromJson(__content, JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
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
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        await global::Roboflow.PerceptionEncoderCompareResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
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
        /// <summary>
        /// Perception Encoder Compare<br/>
        /// Run the Meta Perception Encoder model to compute similarity scores.
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="id"></param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="usageBillable">
        /// Default Value: true
        /// </param>
        /// <param name="start"></param>
        /// <param name="source"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="perceptionEncoderVersionId">
        /// The version ID of PERCEPTION_ENCODER to be used for this request. Must be one of RN101, RN50, RN50x16, RN50x4, RN50x64, ViT-B-16, ViT-B-32, ViT-L-14-336px, and ViT-L-14.<br/>
        /// Default Value: PE-Core-L14-336
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="subject">
        /// The type of image data provided, one of 'url' or 'base64'
        /// </param>
        /// <param name="subjectType">
        /// The type of subject, one of 'image' or 'text'<br/>
        /// Default Value: image
        /// </param>
        /// <param name="prompt"></param>
        /// <param name="promptType">
        /// The type of prompt, one of 'image' or 'text'<br/>
        /// Default Value: text
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.PerceptionEncoderCompareResponse> PeComparePerceptionEncoderComparePostAsync(
            string id,
            global::Roboflow.AnyOf<global::Roboflow.InferenceRequestImage, string> subject,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object> prompt,
            bool? countinference = default,
            string? serviceSecret = default,
            string? apiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? perceptionEncoderVersionId = default,
            string? modelId = default,
            string? subjectType = default,
            string? promptType = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Roboflow.PerceptionEncoderCompareRequest
            {
                Id = id,
                ApiKey = apiKey,
                UsageBillable = usageBillable,
                Start = start,
                Source = source,
                SourceInfo = sourceInfo,
                DisableModelMonitoring = disableModelMonitoring,
                PerceptionEncoderVersionId = perceptionEncoderVersionId,
                ModelId = modelId,
                Subject = subject,
                SubjectType = subjectType,
                Prompt = prompt,
                PromptType = promptType,
            };

            return await PeComparePerceptionEncoderComparePostAsync(
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
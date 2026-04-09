
#nullable enable

namespace Roboflow
{
    public partial class RoboflowClient
    {


        private static readonly global::Roboflow.EndPointSecurityRequirement s_Sam3EmbedImageSam3EmbedImagePostSecurityRequirement0 =
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
        private static readonly global::Roboflow.EndPointSecurityRequirement[] s_Sam3EmbedImageSam3EmbedImagePostSecurityRequirements =
            new global::Roboflow.EndPointSecurityRequirement[]
            {                s_Sam3EmbedImageSam3EmbedImagePostSecurityRequirement0,
            };
        partial void PrepareSam3EmbedImageSam3EmbedImagePostArguments(
            global::System.Net.Http.HttpClient httpClient,
            bool? countinference,
            ref string? serviceSecret,
            global::Roboflow.Sam2EmbeddingRequest request);
        partial void PrepareSam3EmbedImageSam3EmbedImagePostRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            bool? countinference,
            string? serviceSecret,
            global::Roboflow.Sam2EmbeddingRequest request);
        partial void ProcessSam3EmbedImageSam3EmbedImagePostResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessSam3EmbedImageSam3EmbedImagePostResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Seg preview Image Embeddings<br/>
        /// Run the  Model to embed image data.
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.Sam3EmbeddingResponse> Sam3EmbedImageSam3EmbedImagePostAsync(

            global::Roboflow.Sam2EmbeddingRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareSam3EmbedImageSam3EmbedImagePostArguments(
                httpClient: HttpClient,
                countinference: countinference,
                serviceSecret: ref serviceSecret,
                request: request);


            var __authorizations = global::Roboflow.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_Sam3EmbedImageSam3EmbedImagePostSecurityRequirements,
                operationName: "Sam3EmbedImageSam3EmbedImagePostAsync");

            var __pathBuilder = new global::Roboflow.PathBuilder(
                path: "/sam3/embed_image",
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
            PrepareSam3EmbedImageSam3EmbedImagePostRequest(
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
            ProcessSam3EmbedImageSam3EmbedImagePostResponse(
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
                ProcessSam3EmbedImageSam3EmbedImagePostResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Roboflow.Sam3EmbeddingResponse.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Roboflow.Sam3EmbeddingResponse.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// Seg preview Image Embeddings<br/>
        /// Run the  Model to embed image data.
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
        /// <param name="sam2VersionId">
        /// The version ID of SAM to be used for this request. Must be one of hiera_tiny, hiera_small, hiera_large, hiera_b_plus<br/>
        /// Default Value: hiera_large
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="image">
        /// The image to be embedded
        /// </param>
        /// <param name="imageId">
        /// The ID of the image to be embedded used to cache the embedding.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.Sam3EmbeddingResponse> Sam3EmbedImageSam3EmbedImagePostAsync(
            string id,
            bool? countinference = default,
            string? serviceSecret = default,
            string? apiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? sam2VersionId = default,
            string? modelId = default,
            global::Roboflow.InferenceRequestImage? image = default,
            string? imageId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Roboflow.Sam2EmbeddingRequest
            {
                Id = id,
                ApiKey = apiKey,
                UsageBillable = usageBillable,
                Start = start,
                Source = source,
                SourceInfo = sourceInfo,
                DisableModelMonitoring = disableModelMonitoring,
                Sam2VersionId = sam2VersionId,
                ModelId = modelId,
                Image = image,
                ImageId = imageId,
            };

            return await Sam3EmbedImageSam3EmbedImagePostAsync(
                countinference: countinference,
                serviceSecret: serviceSecret,
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}
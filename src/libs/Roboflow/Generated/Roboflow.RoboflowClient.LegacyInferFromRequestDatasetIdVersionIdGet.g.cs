
#nullable enable

namespace Roboflow
{
    public partial class RoboflowClient
    {


        private static readonly global::Roboflow.EndPointSecurityRequirement s_LegacyInferFromRequestDatasetIdVersionIdGetSecurityRequirement0 =
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
        private static readonly global::Roboflow.EndPointSecurityRequirement[] s_LegacyInferFromRequestDatasetIdVersionIdGetSecurityRequirements =
            new global::Roboflow.EndPointSecurityRequirement[]
            {                s_LegacyInferFromRequestDatasetIdVersionIdGetSecurityRequirement0,
            };
        partial void PrepareLegacyInferFromRequestDatasetIdVersionIdGetArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref string datasetId,
            ref string versionId,
            ref global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>? confidence,
            ref double? keypointConfidence,
            ref string? format,
            ref string? image,
            ref string? imageType,
            bool? labels,
            ref string? maskDecodeMode,
            double? tradeoffFactor,
            ref int? maxDetections,
            ref double? overlap,
            ref int? stroke,
            bool? disablePreprocAutoOrient,
            bool? disablePreprocContrast,
            bool? disablePreprocGrayscale,
            bool? disablePreprocStaticCrop,
            bool? disableActiveLearning,
            ref string? activeLearningTargetDataset,
            ref string? source,
            ref string? sourceInfo,
            global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2? responseMaskFormat);
        partial void PrepareLegacyInferFromRequestDatasetIdVersionIdGetRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            string datasetId,
            string versionId,
            global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>? confidence,
            double? keypointConfidence,
            string? format,
            string? image,
            string? imageType,
            bool? labels,
            string? maskDecodeMode,
            double? tradeoffFactor,
            int? maxDetections,
            double? overlap,
            int? stroke,
            bool? disablePreprocAutoOrient,
            bool? disablePreprocContrast,
            bool? disablePreprocGrayscale,
            bool? disablePreprocStaticCrop,
            bool? disableActiveLearning,
            string? activeLearningTargetDataset,
            string? source,
            string? sourceInfo,
            global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2? responseMaskFormat);
        partial void ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Legacy Infer From Request<br/>
        /// Legacy inference endpoint for object detection, instance segmentation, and classification.<br/>
        /// Args:<br/>
        ///     background_tasks: (BackgroundTasks) pool of fastapi background tasks<br/>
        ///     dataset_id (str): ID of a Roboflow dataset corresponding to the model to use for inference OR workspace ID<br/>
        ///     version_id (str): ID of a Roboflow dataset version corresponding to the model to use for inference OR model ID<br/>
        ///     api_key (Optional[str], default None): Roboflow API Key passed to the model during initialization for artifact retrieval.<br/>
        ///     # Other parameters described in the function signature...<br/>
        /// Returns:<br/>
        ///     Union[InstanceSegmentationInferenceResponse, KeypointsDetectionInferenceRequest, ObjectDetectionInferenceResponse, ClassificationInferenceResponse, MultiLabelClassificationInferenceResponse, SemanticSegmentationInferenceResponse, Any]: The response containing the inference results.
        /// </summary>
        /// <param name="datasetId">
        /// ID of a Roboflow dataset corresponding to the model to use for inference OR workspace ID
        /// </param>
        /// <param name="versionId">
        /// ID of a Roboflow dataset version corresponding to the model to use for inference OR model ID
        /// </param>
        /// <param name="confidence">
        /// The confidence threshold used to filter out predictions. Pass a float in [0, 1], or "best" to use F1-optimal thresholds from model evaluation, or "default" to use the model's built-in default.<br/>
        /// Default Value: 0.4F
        /// </param>
        /// <param name="keypointConfidence">
        /// The confidence threshold used to filter out keypoints that are not visible based on model confidence<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="format">
        /// One of 'json' or 'image'. If 'json' prediction data is return as a JSON string. If 'image' prediction data is visualized and overlayed on the original input image.<br/>
        /// Default Value: json
        /// </param>
        /// <param name="image">
        /// The publically accessible URL of an image to use for inference.
        /// </param>
        /// <param name="imageType">
        /// One of base64 or numpy. Note, numpy input is not supported for Roboflow Hosted Inference.<br/>
        /// Default Value: base64
        /// </param>
        /// <param name="labels">
        /// If true, labels will be include in any inference visualization.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="maskDecodeMode">
        /// One of 'accurate' or 'fast'. If 'accurate' the mask will be decoded using the original image size. If 'fast' the mask will be decoded using the original mask size. 'accurate' is slower but more accurate.<br/>
        /// Default Value: accurate
        /// </param>
        /// <param name="tradeoffFactor">
        /// The amount to tradeoff between 0='fast' and 1='accurate'<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="maxDetections">
        /// The maximum number of detections to return. This is used to limit the number of predictions returned by the model. The model may return more predictions than this number, but only the top `max_detections` predictions will be returned.<br/>
        /// Default Value: 300
        /// </param>
        /// <param name="overlap">
        /// The IoU threhsold that must be met for a box pair to be considered duplicate during NMS<br/>
        /// Default Value: 0.3F
        /// </param>
        /// <param name="stroke">
        /// The stroke width used when visualizing predictions<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="disablePreprocAutoOrient">
        /// If true, disables automatic image orientation<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocContrast">
        /// If true, disables automatic contrast adjustment<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocGrayscale">
        /// If true, disables automatic grayscale conversion<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disablePreprocStaticCrop">
        /// If true, disables automatic static crop<br/>
        /// Default Value: false
        /// </param>
        /// <param name="disableActiveLearning">
        /// If true, the predictions will be prevented from registration by Active Learning (if the functionality is enabled)<br/>
        /// Default Value: false
        /// </param>
        /// <param name="activeLearningTargetDataset">
        /// Parameter to be used when Active Learning data registration should happen against different dataset than the one pointed by model_id
        /// </param>
        /// <param name="source">
        /// The source of the inference request<br/>
        /// Default Value: external
        /// </param>
        /// <param name="sourceInfo">
        /// The detailed source information of the inference request<br/>
        /// Default Value: external
        /// </param>
        /// <param name="responseMaskFormat">
        /// The format of the prediction mask - polygon (default) or rle - applicable for instance segmentation models.<br/>
        /// Default Value: polygon
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>> LegacyInferFromRequestDatasetIdVersionIdGetAsync(
            string datasetId,
            string versionId,
            global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>? confidence = default,
            double? keypointConfidence = default,
            string? format = default,
            string? image = default,
            string? imageType = default,
            bool? labels = default,
            string? maskDecodeMode = default,
            double? tradeoffFactor = default,
            int? maxDetections = default,
            double? overlap = default,
            int? stroke = default,
            bool? disablePreprocAutoOrient = default,
            bool? disablePreprocContrast = default,
            bool? disablePreprocGrayscale = default,
            bool? disablePreprocStaticCrop = default,
            bool? disableActiveLearning = default,
            string? activeLearningTargetDataset = default,
            string? source = default,
            string? sourceInfo = default,
            global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2? responseMaskFormat = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareLegacyInferFromRequestDatasetIdVersionIdGetArguments(
                httpClient: HttpClient,
                datasetId: ref datasetId,
                versionId: ref versionId,
                confidence: ref confidence,
                keypointConfidence: ref keypointConfidence,
                format: ref format,
                image: ref image,
                imageType: ref imageType,
                labels: labels,
                maskDecodeMode: ref maskDecodeMode,
                tradeoffFactor: tradeoffFactor,
                maxDetections: ref maxDetections,
                overlap: ref overlap,
                stroke: ref stroke,
                disablePreprocAutoOrient: disablePreprocAutoOrient,
                disablePreprocContrast: disablePreprocContrast,
                disablePreprocGrayscale: disablePreprocGrayscale,
                disablePreprocStaticCrop: disablePreprocStaticCrop,
                disableActiveLearning: disableActiveLearning,
                activeLearningTargetDataset: ref activeLearningTargetDataset,
                source: ref source,
                sourceInfo: ref sourceInfo,
                responseMaskFormat: responseMaskFormat);


            var __authorizations = global::Roboflow.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_LegacyInferFromRequestDatasetIdVersionIdGetSecurityRequirements,
                operationName: "LegacyInferFromRequestDatasetIdVersionIdGetAsync");

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
                                path: $"/{datasetId}/{versionId}",
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
                                .AddOptionalParameter("confidence", confidence?.ToString())
                                .AddOptionalParameter("keypoint_confidence", keypointConfidence?.ToString())
                                .AddOptionalParameter("format", format)
                                .AddOptionalParameter("image", image)
                                .AddOptionalParameter("image_type", imageType)
                                .AddOptionalParameter("labels", labels?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("mask_decode_mode", maskDecodeMode)
                                .AddOptionalParameter("tradeoff_factor", tradeoffFactor?.ToString())
                                .AddOptionalParameter("max_detections", maxDetections?.ToString())
                                .AddOptionalParameter("overlap", overlap?.ToString())
                                .AddOptionalParameter("stroke", stroke?.ToString())
                                .AddOptionalParameter("disable_preproc_auto_orient", disablePreprocAutoOrient?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("disable_preproc_contrast", disablePreprocContrast?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("disable_preproc_grayscale", disablePreprocGrayscale?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("disable_preproc_static_crop", disablePreprocStaticCrop?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("disable_active_learning", disableActiveLearning?.ToString().ToLowerInvariant())
                                .AddOptionalParameter("active_learning_target_dataset", activeLearningTargetDataset)
                                .AddOptionalParameter("source", source)
                                .AddOptionalParameter("source_info", sourceInfo)
                                .AddOptionalParameter("response_mask_format", responseMaskFormat?.ToString()) 
                                ;
                            var __path = __pathBuilder.ToString();
                __path = global::Roboflow.AutoSDKRequestOptionsSupport.AppendQueryParameters(
                    path: __path,
                    clientParameters: Options.QueryParameters,
                    requestParameters: requestOptions?.QueryParameters);
                var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                    method: global::System.Net.Http.HttpMethod.Get,
                    requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
                __httpRequest.Version = global::System.Net.HttpVersion.Version11;
                __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif
                global::Roboflow.AutoSDKRequestOptionsSupport.ApplyHeaders(
                    request: __httpRequest,
                    clientHeaders: Options.Headers,
                    requestHeaders: requestOptions?.Headers);

                PrepareRequest(
                    client: HttpClient,
                    request: __httpRequest);
                PrepareLegacyInferFromRequestDatasetIdVersionIdGetRequest(
                    httpClient: HttpClient,
                    httpRequestMessage: __httpRequest,
                    datasetId: datasetId,
                    versionId: versionId,
                    confidence: confidence,
                    keypointConfidence: keypointConfidence,
                    format: format,
                    image: image,
                    imageType: imageType,
                    labels: labels,
                    maskDecodeMode: maskDecodeMode,
                    tradeoffFactor: tradeoffFactor,
                    maxDetections: maxDetections,
                    overlap: overlap,
                    stroke: stroke,
                    disablePreprocAutoOrient: disablePreprocAutoOrient,
                    disablePreprocContrast: disablePreprocContrast,
                    disablePreprocGrayscale: disablePreprocGrayscale,
                    disablePreprocStaticCrop: disablePreprocStaticCrop,
                    disableActiveLearning: disableActiveLearning,
                    activeLearningTargetDataset: activeLearningTargetDataset,
                    source: source,
                    sourceInfo: sourceInfo,
                    responseMaskFormat: responseMaskFormat);

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
                                operationId: "LegacyInferFromRequestDatasetIdVersionIdGet",
                                methodName: "LegacyInferFromRequestDatasetIdVersionIdGetAsync",
                                pathTemplate: "$\"/{datasetId}/{versionId}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                        var __willRetry = __attempt < __maxAttempts && !__effectiveCancellationToken.IsCancellationRequested;
                        await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LegacyInferFromRequestDatasetIdVersionIdGet",
                                methodName: "LegacyInferFromRequestDatasetIdVersionIdGetAsync",
                                pathTemplate: "$\"/{datasetId}/{versionId}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: null,
                                exception: __exception,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: __willRetry,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        if (!__willRetry)
                        {
                            throw;
                        }

                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Roboflow.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
                            cancellationToken: __effectiveCancellationToken).ConfigureAwait(false);
                        continue;
                    }

                    if (__response != null &&
                        __attempt < __maxAttempts &&
                        global::Roboflow.AutoSDKRequestOptionsSupport.ShouldRetryStatusCode(__response.StatusCode))
                    {
                        await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LegacyInferFromRequestDatasetIdVersionIdGet",
                                methodName: "LegacyInferFromRequestDatasetIdVersionIdGetAsync",
                                pathTemplate: "$\"/{datasetId}/{versionId}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attempt,
                                maxAttempts: __maxAttempts,
                                willRetry: true,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                        __response.Dispose();
                        __response = null;
                        __httpRequest.Dispose();
                        __httpRequest = null;
                        await global::Roboflow.AutoSDKRequestOptionsSupport.DelayBeforeRetryAsync(
                            clientOptions: Options,
                            requestOptions: requestOptions,
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
                ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponse(
                    httpClient: HttpClient,
                    httpResponseMessage: __response);
                if (__response.IsSuccessStatusCode)
                {
                    await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterSuccessAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LegacyInferFromRequestDatasetIdVersionIdGet",
                                methodName: "LegacyInferFromRequestDatasetIdVersionIdGetAsync",
                                pathTemplate: "$\"/{datasetId}/{versionId}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
                                cancellationToken: __effectiveCancellationToken)).ConfigureAwait(false);
                }
                else
                {
                    await global::Roboflow.AutoSDKRequestOptionsSupport.OnAfterErrorAsync(
                            clientOptions: Options,
                            context: global::Roboflow.AutoSDKRequestOptionsSupport.CreateHookContext(
                                operationId: "LegacyInferFromRequestDatasetIdVersionIdGet",
                                methodName: "LegacyInferFromRequestDatasetIdVersionIdGetAsync",
                                pathTemplate: "$\"/{datasetId}/{versionId}\"",
                                httpMethod: "GET",
                                baseUri: BaseUri,
                                request: __httpRequest!,
                                response: __response,
                                exception: null,
                                clientOptions: Options,
                                requestOptions: requestOptions,
                                attempt: __attemptNumber,
                                maxAttempts: __maxAttempts,
                                willRetry: false,
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
                                ProcessLegacyInferFromRequestDatasetIdVersionIdGetResponseContent(
                                    httpClient: HttpClient,
                                    httpResponseMessage: __response,
                                    content: ref __content);

                                try
                                {
                                    __response.EnsureSuccessStatusCode();

                                    return
                                        global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>.FromJson(__content, JsonSerializerContext) ??
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
                                        __effectiveCancellationToken
                #endif
                                    ).ConfigureAwait(false);

                                    return
                                        await global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
                                        throw new global::System.InvalidOperationException("Response deserialization failed.");
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
    }
}
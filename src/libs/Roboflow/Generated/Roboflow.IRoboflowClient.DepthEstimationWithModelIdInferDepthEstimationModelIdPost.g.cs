#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Depth Estimation with model ID in path<br/>
        /// Run depth estimation. Model ID is specified in the URL path and can contain slashes.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.DepthEstimationResponse> DepthEstimationWithModelIdInferDepthEstimationModelIdPostAsync(
            string modelId,

            global::Roboflow.DepthEstimationRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Depth Estimation with model ID in path<br/>
        /// Run depth estimation. Model ID is specified in the URL path and can contain slashes.
        /// </summary>
        /// <param name="modelId"></param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.DepthEstimationResponse>> DepthEstimationWithModelIdInferDepthEstimationModelIdPostAsResponseAsync(
            string modelId,

            global::Roboflow.DepthEstimationRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Depth Estimation with model ID in path<br/>
        /// Run depth estimation. Model ID is specified in the URL path and can contain slashes.
        /// </summary>
        /// <param name="modelId"></param>
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
        /// <param name="requestModelId"></param>
        /// <param name="modelType">
        /// The type of the model, usually referring to what task the model performs
        /// </param>
        /// <param name="image"></param>
        /// <param name="depthVersionId">
        /// The version ID of the depth estimation model<br/>
        /// Default Value: small
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.DepthEstimationResponse> DepthEstimationWithModelIdInferDepthEstimationModelIdPostAsync(
            string modelId,
            string id,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage> image,
            bool? countinference = default,
            string? serviceSecret = default,
            string? apiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? requestModelId = default,
            string? modelType = default,
            string? depthVersionId = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
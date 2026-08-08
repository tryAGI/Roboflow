#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Owlv2 image prompting<br/>
        /// Run the google owlv2 model to few-shot object detect
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ObjectDetectionInferenceResponse> Owlv2InferOwlv2InferPostAsync(

            global::Roboflow.OwlV2InferenceRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Owlv2 image prompting<br/>
        /// Run the google owlv2 model to few-shot object detect
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.ObjectDetectionInferenceResponse>> Owlv2InferOwlv2InferPostAsResponseAsync(

            global::Roboflow.OwlV2InferenceRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Owlv2 image prompting<br/>
        /// Run the google owlv2 model to few-shot object detect
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
        /// <param name="streamPipelineContextId">
        /// Internal stream-pipeline frame pairing id. Not part of the public API.
        /// </param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="owlv2VersionId">
        /// The version ID of owlv2 to be used for this request.<br/>
        /// Default Value: owlv2-large-patch14-ensemble
        /// </param>
        /// <param name="modelId">
        /// Model id to be used in the request.
        /// </param>
        /// <param name="image">
        /// Images to run the model on
        /// </param>
        /// <param name="trainingData">
        /// Training images for the owlvit model to learn form
        /// </param>
        /// <param name="confidence">
        /// Default confidence threshold for owlvit predictions. Needs to be much higher than you're used to, probably 0.99 - 0.9999<br/>
        /// Default Value: 0.99F
        /// </param>
        /// <param name="visualizePredictions">
        /// If true, the predictions will be drawn on the original image and returned as a base64 string<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visualizationLabels">
        /// If true, labels will be rendered on prediction visualizations<br/>
        /// Default Value: false
        /// </param>
        /// <param name="visualizationStrokeWidth">
        /// The stroke width used when visualizing predictions<br/>
        /// Default Value: 1
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ObjectDetectionInferenceResponse> Owlv2InferOwlv2InferPostAsync(
            string id,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage> image,
            global::System.Collections.Generic.IList<global::Roboflow.TrainingImage> trainingData,
            bool? countinference = default,
            string? serviceSecret = default,
            string? apiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            string? streamPipelineContextId = default,
            bool? disableModelMonitoring = default,
            string? owlv2VersionId = default,
            string? modelId = default,
            double? confidence = default,
            bool? visualizePredictions = default,
            bool? visualizationLabels = default,
            int? visualizationStrokeWidth = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Action Recognition<br/>
        /// Classify the actions in a video clip. The model states how the clip is cut and how its frames are sampled, so a caller sends the clip and nothing else. Frame indices in the response count from the first frame of the clip, and windows_classified reports how many calls the clip was cut into. A fine-tuned model reports its own classes. A zero-shot model names the events it finds in its own words. Frames are chosen by the clip's nominal frame rate, so a variable-frame-rate source is sampled at different instants than the model trained on. Send the clip as a URL. Base64 grows it by a third and holds the whole request in memory, so it suits short clips only.
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ActionRecognitionInferenceResponse> InferActionRecognitionInferActionRecognitionPostAsync(

            global::Roboflow.ActionRecognitionInferenceRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Action Recognition<br/>
        /// Classify the actions in a video clip. The model states how the clip is cut and how its frames are sampled, so a caller sends the clip and nothing else. Frame indices in the response count from the first frame of the clip, and windows_classified reports how many calls the clip was cut into. A fine-tuned model reports its own classes. A zero-shot model names the events it finds in its own words. Frames are chosen by the clip's nominal frame rate, so a variable-frame-rate source is sampled at different instants than the model trained on. Send the clip as a URL. Base64 grows it by a third and holds the whole request in memory, so it suits short clips only.
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.ActionRecognitionInferenceResponse>> InferActionRecognitionInferActionRecognitionPostAsResponseAsync(

            global::Roboflow.ActionRecognitionInferenceRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Action Recognition<br/>
        /// Classify the actions in a video clip. The model states how the clip is cut and how its frames are sampled, so a caller sends the clip and nothing else. Frame indices in the response count from the first frame of the clip, and windows_classified reports how many calls the clip was cut into. A fine-tuned model reports its own classes. A zero-shot model names the events it finds in its own words. Frames are chosen by the clip's nominal frame rate, so a variable-frame-rate source is sampled at different instants than the model trained on. Send the clip as a URL. Base64 grows it by a third and holds the whole request in memory, so it suits short clips only.
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
        /// <param name="modelId">
        /// The model to classify with
        /// </param>
        /// <param name="video">
        /// Video data for an inference request.<br/>
        /// Prefer a URL. Base64 grows the clip by a third, and the whole request is<br/>
        /// held in memory before the clip reaches disk, so gateways reject a large<br/>
        /// one. Base64 suits a short clip and a quick test.<br/>
        /// Attributes:<br/>
        ///     type (str): The type of video data provided, one of 'url' or 'base64'.<br/>
        ///     value (Optional[Any]): Video data corresponding to the video type.
        /// </param>
        /// <param name="classFilter">
        /// The subset of a fine-tuned model's classes to report. A zero-shot model answers in its own words and ignores this.
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ActionRecognitionInferenceResponse> InferActionRecognitionInferActionRecognitionPostAsync(
            string id,
            string modelId,
            global::Roboflow.InferenceRequestVideo video,
            bool? countinference = default,
            string? serviceSecret = default,
            string? apiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            string? streamPipelineContextId = default,
            bool? disableModelMonitoring = default,
            global::System.Collections.Generic.IList<string>? classFilter = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
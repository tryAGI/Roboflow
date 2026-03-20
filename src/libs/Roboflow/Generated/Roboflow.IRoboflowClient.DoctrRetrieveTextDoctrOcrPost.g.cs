#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// DocTR OCR response<br/>
        /// Run the DocTR OCR model to retrieve text in an image.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>> DoctrRetrieveTextDoctrOcrPostAsync(

            global::Roboflow.DoctrOCRInferenceRequest request,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// DocTR OCR response<br/>
        /// Run the DocTR OCR model to retrieve text in an image.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="id"></param>
        /// <param name="requestApiKey">
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
        /// <param name="image"></param>
        /// <param name="doctrVersionId">
        /// Default Value: default
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="generateBoundingBoxes">
        /// Default Value: false
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>> DoctrRetrieveTextDoctrOcrPostAsync(
            string id,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage> image,
            string? apiKey = default,
            bool? countinference = default,
            string? serviceSecret = default,
            string? requestApiKey = default,
            bool? usageBillable = default,
            double? start = default,
            string? source = default,
            string? sourceInfo = default,
            bool? disableModelMonitoring = default,
            string? doctrVersionId = default,
            string? modelId = default,
            bool? generateBoundingBoxes = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
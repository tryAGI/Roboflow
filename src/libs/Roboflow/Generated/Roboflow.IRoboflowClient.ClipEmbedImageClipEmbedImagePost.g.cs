#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// CLIP Image Embeddings<br/>
        /// Run the Open AI CLIP model to embed image data.
        /// </summary>
        /// <param name="countinference"></param>
        /// <param name="serviceSecret"></param>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ClipEmbeddingResponse> ClipEmbedImageClipEmbedImagePostAsync(

            global::Roboflow.ClipImageEmbeddingRequest request,
            bool? countinference = default,
            string? serviceSecret = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// CLIP Image Embeddings<br/>
        /// Run the Open AI CLIP model to embed image data.
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
        /// <param name="clipVersionId">
        /// The version ID of CLIP to be used for this request. Must be one of RN101, RN50, RN50x16, RN50x4, RN50x64, ViT-B-16, ViT-B-32, ViT-L-14-336px, and ViT-L-14.<br/>
        /// Default Value: ViT-B-16
        /// </param>
        /// <param name="modelId"></param>
        /// <param name="image"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ClipEmbeddingResponse> ClipEmbedImageClipEmbedImagePostAsync(
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
            string? clipVersionId = default,
            string? modelId = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
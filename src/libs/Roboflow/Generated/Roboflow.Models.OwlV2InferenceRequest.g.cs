
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Request for OwlV2 inference.<br/>
    /// Attributes:<br/>
    ///     api_key (Optional[str]): Roboflow API Key.<br/>
    ///     owlv2_version_id (Optional[str]): The version ID of OwlV2 to be used for this request.<br/>
    ///     image (Union[List[InferenceRequestImage], InferenceRequestImage]): Image(s) for inference.<br/>
    ///     training_data (List[TrainingImage]): Training data to ground the model on<br/>
    ///     confidence (float): Confidence threshold to filter predictions by
    /// </summary>
    public sealed partial class OwlV2InferenceRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_billable")]
        public bool? UsageBillable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public string? SourceInfo { get; set; }

        /// <summary>
        /// Internal stream-pipeline frame pairing id. Not part of the public API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_pipeline_context_id")]
        public string? StreamPipelineContextId { get; set; }

        /// <summary>
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_model_monitoring")]
        public bool? DisableModelMonitoring { get; set; }

        /// <summary>
        /// The version ID of owlv2 to be used for this request.<br/>
        /// Default Value: owlv2-large-patch14-ensemble
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("owlv2_version_id")]
        public string? Owlv2VersionId { get; set; }

        /// <summary>
        /// Model id to be used in the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        public string? ModelId { get; set; }

        /// <summary>
        /// Images to run the model on
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage> Image { get; set; }

        /// <summary>
        /// Training images for the owlvit model to learn form
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("training_data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Roboflow.TrainingImage> TrainingData { get; set; }

        /// <summary>
        /// Default confidence threshold for owlvit predictions. Needs to be much higher than you're used to, probably 0.99 - 0.9999<br/>
        /// Default Value: 0.99F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// If true, the predictions will be drawn on the original image and returned as a base64 string<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualize_predictions")]
        public bool? VisualizePredictions { get; set; }

        /// <summary>
        /// If true, labels will be rendered on prediction visualizations<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization_labels")]
        public bool? VisualizationLabels { get; set; }

        /// <summary>
        /// The stroke width used when visualizing predictions<br/>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization_stroke_width")]
        public int? VisualizationStrokeWidth { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OwlV2InferenceRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="image">
        /// Images to run the model on
        /// </param>
        /// <param name="trainingData">
        /// Training images for the owlvit model to learn form
        /// </param>
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OwlV2InferenceRequest(
            string id,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage> image,
            global::System.Collections.Generic.IList<global::Roboflow.TrainingImage> trainingData,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            string? streamPipelineContextId,
            bool? disableModelMonitoring,
            string? owlv2VersionId,
            string? modelId,
            double? confidence,
            bool? visualizePredictions,
            bool? visualizationLabels,
            int? visualizationStrokeWidth)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.StreamPipelineContextId = streamPipelineContextId;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.Owlv2VersionId = owlv2VersionId;
            this.ModelId = modelId;
            this.Image = image;
            this.TrainingData = trainingData ?? throw new global::System.ArgumentNullException(nameof(trainingData));
            this.Confidence = confidence;
            this.VisualizePredictions = visualizePredictions;
            this.VisualizationLabels = visualizationLabels;
            this.VisualizationStrokeWidth = visualizationStrokeWidth;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OwlV2InferenceRequest" /> class.
        /// </summary>
        public OwlV2InferenceRequest()
        {
        }

    }
}
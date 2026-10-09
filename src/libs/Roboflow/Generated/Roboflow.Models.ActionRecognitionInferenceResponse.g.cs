
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Classified ranges covering one clip.<br/>
    /// Frame indices count from the first frame of the submitted clip, so a<br/>
    /// caller converts them to seconds with ``source_fps``.
    /// </summary>
    public sealed partial class ActionRecognitionInferenceResponse
    {
        /// <summary>
        /// Unique identifier of inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_id")]
        public string? InferenceId { get; set; }

        /// <summary>
        /// The frame id of the image used in inference if the input was a video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_id")]
        public int? FrameId { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// Model identity and available package details for this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_model")]
        public global::Roboflow.ResolvedModel? ResolvedModel { get; set; }

        /// <summary>
        /// Classified frame ranges, which can overlap
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timeline")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction> Timeline { get; set; }

        /// <summary>
        /// Frames per second of the clip
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_fps")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double SourceFps { get; set; }

        /// <summary>
        /// Frames the clip holds
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_count")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int FrameCount { get; set; }

        /// <summary>
        /// Model calls the clip was cut into
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("windows_classified")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int WindowsClassified { get; set; }

        /// <summary>
        /// Default Value: instances
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("span_semantics")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.ActionRecognitionInferenceResponseSpanSemanticsJsonConverter))]
        public global::Roboflow.ActionRecognitionInferenceResponseSpanSemantics? SpanSemantics { get; set; }

        /// <summary>
        /// Uniform confidence threshold; null for per-class thresholds or unscored models
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_threshold")]
        public double? ConfidenceThreshold { get; set; }

        /// <summary>
        /// Effective class-specific thresholds when model-eval recommendations apply
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_class_confidence_thresholds")]
        public global::System.Collections.Generic.Dictionary<string, double>? PerClassConfidenceThresholds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("candidates")]
        public global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction>? Candidates { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRecognitionInferenceResponse" /> class.
        /// </summary>
        /// <param name="timeline">
        /// Classified frame ranges, which can overlap
        /// </param>
        /// <param name="sourceFps">
        /// Frames per second of the clip
        /// </param>
        /// <param name="frameCount">
        /// Frames the clip holds
        /// </param>
        /// <param name="windowsClassified">
        /// Model calls the clip was cut into
        /// </param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </param>
        /// <param name="resolvedModel">
        /// Model identity and available package details for this result.
        /// </param>
        /// <param name="spanSemantics">
        /// Default Value: instances
        /// </param>
        /// <param name="confidenceThreshold">
        /// Uniform confidence threshold; null for per-class thresholds or unscored models
        /// </param>
        /// <param name="perClassConfidenceThresholds">
        /// Effective class-specific thresholds when model-eval recommendations apply
        /// </param>
        /// <param name="candidates"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionRecognitionInferenceResponse(
            global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction> timeline,
            double sourceFps,
            int frameCount,
            int windowsClassified,
            string? inferenceId,
            int? frameId,
            double? time,
            global::Roboflow.ResolvedModel? resolvedModel,
            global::Roboflow.ActionRecognitionInferenceResponseSpanSemantics? spanSemantics,
            double? confidenceThreshold,
            global::System.Collections.Generic.Dictionary<string, double>? perClassConfidenceThresholds,
            global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction>? candidates)
        {
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.ResolvedModel = resolvedModel;
            this.Timeline = timeline ?? throw new global::System.ArgumentNullException(nameof(timeline));
            this.SourceFps = sourceFps;
            this.FrameCount = frameCount;
            this.WindowsClassified = windowsClassified;
            this.SpanSemantics = spanSemantics;
            this.ConfidenceThreshold = confidenceThreshold;
            this.PerClassConfidenceThresholds = perClassConfidenceThresholds;
            this.Candidates = candidates;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRecognitionInferenceResponse" /> class.
        /// </summary>
        public ActionRecognitionInferenceResponse()
        {
        }

    }
}
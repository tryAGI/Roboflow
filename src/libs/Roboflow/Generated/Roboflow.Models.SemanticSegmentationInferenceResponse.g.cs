
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Semantic Segmentation inference response.<br/>
    /// Attributes:<br/>
    ///     predictions (inference.core.entities.responses.inference.SemanticSegmentationPrediction): Semantic segmentation predictions.
    /// </summary>
    public sealed partial class SemanticSegmentationInferenceResponse
    {
        /// <summary>
        /// Base64 encoded string containing prediction visualization image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization")]
        public string? Visualization { get; set; }

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
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage> Image { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.SemanticSegmentationPrediction Predictions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationInferenceResponse" /> class.
        /// </summary>
        /// <param name="visualization">
        /// Base64 encoded string containing prediction visualization image data
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
        /// <param name="image"></param>
        /// <param name="predictions"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SemanticSegmentationInferenceResponse(
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage> image,
            global::Roboflow.SemanticSegmentationPrediction predictions,
            string? visualization,
            string? inferenceId,
            int? frameId,
            double? time)
        {
            this.Image = image;
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
            this.Visualization = visualization;
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationInferenceResponse" /> class.
        /// </summary>
        public SemanticSegmentationInferenceResponse()
        {
        }
    }
}
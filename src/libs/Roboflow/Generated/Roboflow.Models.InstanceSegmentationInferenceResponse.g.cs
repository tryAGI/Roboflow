
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Instance Segmentation inference response.<br/>
    /// Attributes:<br/>
    ///     predictions (List[Union[<br/>
    ///         inference.core.entities.responses.inference.InstanceSegmentationPrediction,<br/>
    ///         inference.core.entities.responses.inference.InstanceSegmentationRLEPrediction<br/>
    ///     ]]): List of instance segmentation predictions.
    /// </summary>
    public sealed partial class InstanceSegmentationInferenceResponse
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
        /// Model identity and available package details for this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_model")]
        public global::Roboflow.ResolvedModel? ResolvedModel { get; set; }

        /// <summary>
        /// Dimensions of the coordinate frame shared by bounding boxes, polygon points and RLE masks. With opt-in this is the selected mask grid; otherwise it is the original image. Multi-image responses may provide a list.
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
        public required global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>> Predictions { get; set; }

        /// <summary>
        /// Original image dimensions retained for opted-in responses, including when the selected grid has the same dimensions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("original_image")]
        public global::Roboflow.InferenceResponseImage? OriginalImage { get; set; }

        /// <summary>
        /// Present for opted-in responses in either format. All prediction geometry uses this grid. Multiply x coordinates and widths by scale_x, and y coordinates and heights by scale_y, to map to original_image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_metadata")]
        public global::Roboflow.MaskCoordinateMetadata? MaskMetadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceSegmentationInferenceResponse" /> class.
        /// </summary>
        /// <param name="image">
        /// Dimensions of the coordinate frame shared by bounding boxes, polygon points and RLE masks. With opt-in this is the selected mask grid; otherwise it is the original image. Multi-image responses may provide a list.
        /// </param>
        /// <param name="predictions"></param>
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
        /// <param name="resolvedModel">
        /// Model identity and available package details for this result.
        /// </param>
        /// <param name="originalImage">
        /// Original image dimensions retained for opted-in responses, including when the selected grid has the same dimensions.
        /// </param>
        /// <param name="maskMetadata">
        /// Present for opted-in responses in either format. All prediction geometry uses this grid. Multiply x coordinates and widths by scale_x, and y coordinates and heights by scale_y, to map to original_image.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstanceSegmentationInferenceResponse(
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage> image,
            global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>> predictions,
            string? visualization,
            string? inferenceId,
            int? frameId,
            double? time,
            global::Roboflow.ResolvedModel? resolvedModel,
            global::Roboflow.InferenceResponseImage? originalImage,
            global::Roboflow.MaskCoordinateMetadata? maskMetadata)
        {
            this.Visualization = visualization;
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.ResolvedModel = resolvedModel;
            this.Image = image;
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
            this.OriginalImage = originalImage;
            this.MaskMetadata = maskMetadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceSegmentationInferenceResponse" /> class.
        /// </summary>
        public InstanceSegmentationInferenceResponse()
        {
        }

    }
}

#nullable enable

namespace Roboflow
{
    /// <summary>
    /// OCR Inference response.<br/>
    /// Attributes:<br/>
    ///     result (str): The combined OCR recognition result.<br/>
    ///     predictions (List[ObjectDetectionPrediction]): List of objects detected by OCR<br/>
    ///     time (float): The time in seconds it took to produce the inference including preprocessing
    /// </summary>
    public sealed partial class OCRInferenceResponse
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
        /// The time in seconds it took to produce the inference including preprocessing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Time { get; set; }

        /// <summary>
        /// Model identity and available package details for this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_model")]
        public global::Roboflow.ResolvedModel? ResolvedModel { get; set; }

        /// <summary>
        /// The combined OCR recognition result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("result")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Result { get; set; }

        /// <summary>
        /// Metadata about input image dimensions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public global::Roboflow.InferenceResponseImage? Image { get; set; }

        /// <summary>
        /// List of objects detected by OCR
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        public global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionPrediction>? Predictions { get; set; }

        /// <summary>
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRInferenceResponse" /> class.
        /// </summary>
        /// <param name="time">
        /// The time in seconds it took to produce the inference including preprocessing.
        /// </param>
        /// <param name="result">
        /// The combined OCR recognition result.
        /// </param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="resolvedModel">
        /// Model identity and available package details for this result.
        /// </param>
        /// <param name="image">
        /// Metadata about input image dimensions
        /// </param>
        /// <param name="predictions">
        /// List of objects detected by OCR
        /// </param>
        /// <param name="parentId">
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OCRInferenceResponse(
            double time,
            string result,
            string? inferenceId,
            int? frameId,
            global::Roboflow.ResolvedModel? resolvedModel,
            global::Roboflow.InferenceResponseImage? image,
            global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionPrediction>? predictions,
            string? parentId)
        {
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.ResolvedModel = resolvedModel;
            this.Result = result ?? throw new global::System.ArgumentNullException(nameof(result));
            this.Image = image;
            this.Predictions = predictions;
            this.ParentId = parentId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OCRInferenceResponse" /> class.
        /// </summary>
        public OCRInferenceResponse()
        {
        }

    }
}
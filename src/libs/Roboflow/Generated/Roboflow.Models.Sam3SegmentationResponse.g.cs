
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class Sam3SegmentationResponse
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
        /// The time in seconds it took to produce the segmentation including preprocessing
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
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Roboflow.Sam3PromptResult> PromptResults { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3SegmentationResponse" /> class.
        /// </summary>
        /// <param name="time">
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </param>
        /// <param name="promptResults"></param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="resolvedModel">
        /// Model identity and available package details for this result.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam3SegmentationResponse(
            double time,
            global::System.Collections.Generic.IList<global::Roboflow.Sam3PromptResult> promptResults,
            string? inferenceId,
            int? frameId,
            global::Roboflow.ResolvedModel? resolvedModel)
        {
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.ResolvedModel = resolvedModel;
            this.PromptResults = promptResults ?? throw new global::System.ArgumentNullException(nameof(promptResults));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3SegmentationResponse" /> class.
        /// </summary>
        public Sam3SegmentationResponse()
        {
        }

    }
}
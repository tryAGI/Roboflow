
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// SAM embedding response.<br/>
    /// Attributes:<br/>
    ///     embeddings (Union[List[List[List[List[float]]]], Any]): The SAM embedding.<br/>
    ///     time (float): The time in seconds it took to produce the embeddings including preprocessing.
    /// </summary>
    public sealed partial class SamEmbeddingResponse
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
        /// The time in seconds it took to produce the embeddings including preprocessing
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
        /// If request format is json, embeddings is a series of nested lists representing the SAM embedding. If request format is binary, embeddings is a binary numpy array. The dimensions of the embedding are 1 x 256 x 64 x 64.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embeddings")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object> Embeddings { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamEmbeddingResponse" /> class.
        /// </summary>
        /// <param name="time">
        /// The time in seconds it took to produce the embeddings including preprocessing
        /// </param>
        /// <param name="embeddings">
        /// If request format is json, embeddings is a series of nested lists representing the SAM embedding. If request format is binary, embeddings is a binary numpy array. The dimensions of the embedding are 1 x 256 x 64 x 64.
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SamEmbeddingResponse(
            double time,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object> embeddings,
            string? inferenceId,
            int? frameId,
            global::Roboflow.ResolvedModel? resolvedModel)
        {
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.ResolvedModel = resolvedModel;
            this.Embeddings = embeddings;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamEmbeddingResponse" /> class.
        /// </summary>
        public SamEmbeddingResponse()
        {
        }

    }
}
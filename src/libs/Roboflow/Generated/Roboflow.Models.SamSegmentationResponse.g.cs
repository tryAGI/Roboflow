
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// SAM segmentation response.<br/>
    /// Attributes:<br/>
    ///     masks (Union[List[List[List[int]]], Any]): The set of output masks.<br/>
    ///     low_res_masks (Union[List[List[List[int]]], Any]): The set of output low-resolution masks.<br/>
    ///     time (float): The time in seconds it took to produce the segmentation including preprocessing.
    /// </summary>
    public sealed partial class SamSegmentationResponse
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
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are the same as the dimensions of the input image.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("masks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> Masks { get; set; }

        /// <summary>
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are 256 x 256
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("low_res_masks")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> LowResMasks { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SamSegmentationResponse" /> class.
        /// </summary>
        /// <param name="time">
        /// The time in seconds it took to produce the segmentation including preprocessing
        /// </param>
        /// <param name="masks">
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are the same as the dimensions of the input image.
        /// </param>
        /// <param name="lowResMasks">
        /// The set of output masks. If request format is json, masks is a list of polygons, where each polygon is a list of points, where each point is a tuple containing the x,y pixel coordinates of the point. If request format is binary, masks is a list of binary numpy arrays. The dimensions of each mask are 256 x 256
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
        public SamSegmentationResponse(
            double time,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> masks,
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object> lowResMasks,
            string? inferenceId,
            int? frameId,
            global::Roboflow.ResolvedModel? resolvedModel)
        {
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.ResolvedModel = resolvedModel;
            this.Masks = masks;
            this.LowResMasks = lowResMasks;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SamSegmentationResponse" /> class.
        /// </summary>
        public SamSegmentationResponse()
        {
        }

    }
}
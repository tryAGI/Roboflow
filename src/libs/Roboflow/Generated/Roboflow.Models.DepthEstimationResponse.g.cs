
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Response for depth estimation inference.<br/>
    /// Attributes:<br/>
    ///     normalized_depth (Union[str, List[List[float]]]): The per-image normalized ordinal<br/>
    ///         depth map as a 2D array of floats between 0 and 1. Higher values<br/>
    ///         indicate nearer predictions.<br/>
    ///         serialized according to the request's `depth_map_format`: a 2D array of<br/>
    ///         floats between 0 and 1 (`json`, the default) or a base64 grayscale PNG<br/>
    ///         string (16-bit for `png16`, 8-bit for `png8`).<br/>
    ///     depth_map_format (Literal["json", "png16", "png8"]): The serialization<br/>
    ///         format used for `normalized_depth`.<br/>
    ///     image (Optional[str]): Base64 encoded visualization of the depth map if visualize_predictions is True.<br/>
    ///     time (float): The processing time in seconds.<br/>
    ///     visualization (Optional[str]): Base64 encoded visualization of the depth map if visualize_predictions is True.
    /// </summary>
    public sealed partial class DepthEstimationResponse
    {
        /// <summary>
        /// Per-image normalized ordinal depth as a 2D array of floats between 0 and 1, where 1 is nearest and 0 is farthest. Values are not physical distances or directly comparable across images or model families without calibration. The normalized depth map: a 2D array of floats between 0 and 1 (`json` format, default) or a base64 grayscale PNG string (`png16`/`png8`), per the request's `depth_map_format`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("normalized_depth")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>> NormalizedDepth { get; set; }

        /// <summary>
        /// The serialization format used for `normalized_depth`<br/>
        /// Default Value: json
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("depth_map_format")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.DepthEstimationResponseDepthMapFormatJsonConverter))]
        public global::Roboflow.DepthEstimationResponseDepthMapFormat? DepthMapFormat { get; set; }

        /// <summary>
        /// Base64 encoded visualization of the depth map if visualize_predictions is True
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        public string? Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DepthEstimationResponse" /> class.
        /// </summary>
        /// <param name="normalizedDepth">
        /// Per-image normalized ordinal depth as a 2D array of floats between 0 and 1, where 1 is nearest and 0 is farthest. Values are not physical distances or directly comparable across images or model families without calibration. The normalized depth map: a 2D array of floats between 0 and 1 (`json` format, default) or a base64 grayscale PNG string (`png16`/`png8`), per the request's `depth_map_format`
        /// </param>
        /// <param name="depthMapFormat">
        /// The serialization format used for `normalized_depth`<br/>
        /// Default Value: json
        /// </param>
        /// <param name="image">
        /// Base64 encoded visualization of the depth map if visualize_predictions is True
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DepthEstimationResponse(
            global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>> normalizedDepth,
            global::Roboflow.DepthEstimationResponseDepthMapFormat? depthMapFormat,
            string? image)
        {
            this.NormalizedDepth = normalizedDepth;
            this.DepthMapFormat = depthMapFormat;
            this.Image = image;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DepthEstimationResponse" /> class.
        /// </summary>
        public DepthEstimationResponse()
        {
        }

    }
}
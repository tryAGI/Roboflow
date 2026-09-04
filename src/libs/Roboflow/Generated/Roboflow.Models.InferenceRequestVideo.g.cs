
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Video data for an inference request.<br/>
    /// Prefer a URL. Base64 grows the clip by a third, and the whole request is<br/>
    /// held in memory before the clip reaches disk, so gateways reject a large<br/>
    /// one. Base64 suits a short clip and a quick test.<br/>
    /// Attributes:<br/>
    ///     type (str): The type of video data provided, one of 'url' or 'base64'.<br/>
    ///     value (Optional[Any]): Video data corresponding to the video type.
    /// </summary>
    public sealed partial class InferenceRequestVideo
    {
        /// <summary>
        /// The type of video data provided, one of 'url' or 'base64'. Prefer 'url': base64 grows the clip by a third and holds the whole request in memory, which gateways reject above a few megabytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// Video data corresponding to the video type
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequestVideo" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of video data provided, one of 'url' or 'base64'. Prefer 'url': base64 grows the clip by a third and holds the whole request in memory, which gateways reject above a few megabytes.
        /// </param>
        /// <param name="value">
        /// Video data corresponding to the video type
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceRequestVideo(
            string type,
            object? value)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceRequestVideo" /> class.
        /// </summary>
        public InferenceRequestVideo()
        {
        }

    }
}
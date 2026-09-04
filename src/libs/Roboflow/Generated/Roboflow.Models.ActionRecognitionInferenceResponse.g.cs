
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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionRecognitionInferenceResponse(
            global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction> timeline,
            double sourceFps,
            int frameCount,
            int windowsClassified)
        {
            this.Timeline = timeline ?? throw new global::System.ArgumentNullException(nameof(timeline));
            this.SourceFps = sourceFps;
            this.FrameCount = frameCount;
            this.WindowsClassified = windowsClassified;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRecognitionInferenceResponse" /> class.
        /// </summary>
        public ActionRecognitionInferenceResponse()
        {
        }

    }
}
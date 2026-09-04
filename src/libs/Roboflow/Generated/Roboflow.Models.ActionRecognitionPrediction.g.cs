
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// One classified frame range of a video.<br/>
    /// The HTTP response and the workflow kind carry the same shape, so it is<br/>
    /// declared once here and imported by both. A field added on one transport<br/>
    /// would otherwise be silently missing from the other.
    /// </summary>
    public sealed partial class ActionRecognitionPrediction
    {
        /// <summary>
        /// First frame of the range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start_frame_idx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StartFrameIdx { get; set; }

        /// <summary>
        /// Last frame of the range
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("end_frame_idx")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int EndFrameIdx { get; set; }

        /// <summary>
        /// The class name
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Class { get; set; }

        /// <summary>
        /// The class position in the model's own class list. A model without a class list reports -1.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClassId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRecognitionPrediction" /> class.
        /// </summary>
        /// <param name="startFrameIdx">
        /// First frame of the range
        /// </param>
        /// <param name="endFrameIdx">
        /// Last frame of the range
        /// </param>
        /// <param name="class">
        /// The class name
        /// </param>
        /// <param name="classId">
        /// The class position in the model's own class list. A model without a class list reports -1.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionRecognitionPrediction(
            int startFrameIdx,
            int endFrameIdx,
            string @class,
            int classId)
        {
            this.StartFrameIdx = startFrameIdx;
            this.EndFrameIdx = endFrameIdx;
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
            this.ClassId = classId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRecognitionPrediction" /> class.
        /// </summary>
        public ActionRecognitionPrediction()
        {
        }

    }
}

#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Unified prompt that can contain text and/or geometry.<br/>
    /// Absolute pixel coordinates are used for boxes. Labels accept 0/1 or booleans.
    /// </summary>
    public sealed partial class Sam3Prompt
    {
        /// <summary>
        /// Optional hint: 'text' or 'visual'. 'visual' requires at least one box.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Concept to segment as a short noun phrase (e.g. 'person'). All matching instances are returned. Can be combined with exemplar boxes in the same prompt.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        public string? Text { get; set; }

        /// <summary>
        /// Score threshold for this prompt's outputs. Overrides request-level threshold if set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_prob_thresh")]
        public double? OutputProbThresh { get; set; }

        /// <summary>
        /// Exemplar boxes in absolute pixels, as XYWH entries ({x, y, width, height}, top-left anchored) or XYXY entries ({x0, y0, x1, y1}). Each box marks an example object; the model segments every instance matching the exemplars (and text, if provided), not just the boxed objects. Requires box_labels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boxes")]
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>? Boxes { get; set; }

        /// <summary>
        /// Per-box exemplar labels, one per entry in boxes: 1/true marks a positive exemplar (segment objects like this), 0/false marks a negative exemplar (exclude objects like this). Required when boxes is set.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("box_labels")]
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<int?, bool?>>? BoxLabels { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3Prompt" /> class.
        /// </summary>
        /// <param name="type">
        /// Optional hint: 'text' or 'visual'. 'visual' requires at least one box.
        /// </param>
        /// <param name="text">
        /// Concept to segment as a short noun phrase (e.g. 'person'). All matching instances are returned. Can be combined with exemplar boxes in the same prompt.
        /// </param>
        /// <param name="outputProbThresh">
        /// Score threshold for this prompt's outputs. Overrides request-level threshold if set.
        /// </param>
        /// <param name="boxes">
        /// Exemplar boxes in absolute pixels, as XYWH entries ({x, y, width, height}, top-left anchored) or XYXY entries ({x0, y0, x1, y1}). Each box marks an example object; the model segments every instance matching the exemplars (and text, if provided), not just the boxed objects. Requires box_labels.
        /// </param>
        /// <param name="boxLabels">
        /// Per-box exemplar labels, one per entry in boxes: 1/true marks a positive exemplar (segment objects like this), 0/false marks a negative exemplar (exclude objects like this). Required when boxes is set.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Sam3Prompt(
            string? type,
            string? text,
            double? outputProbThresh,
            global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>? boxes,
            global::System.Collections.Generic.IList<global::Roboflow.AnyOf<int?, bool?>>? boxLabels)
        {
            this.Type = type;
            this.Text = text;
            this.OutputProbThresh = outputProbThresh;
            this.Boxes = boxes;
            this.BoxLabels = boxLabels;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Sam3Prompt" /> class.
        /// </summary>
        public Sam3Prompt()
        {
        }

    }
}
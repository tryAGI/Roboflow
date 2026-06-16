
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Exemplar boxes in absolute pixels, as XYWH entries ({x, y, width, height}, top-left anchored) or XYXY entries ({x0, y0, x1, y1}). Each box marks an example object; the model segments every instance matching the exemplars (and text, if provided), not just the boxed objects. Requires box_labels.
    /// </summary>
    public sealed partial class Sam3PromptBoxes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
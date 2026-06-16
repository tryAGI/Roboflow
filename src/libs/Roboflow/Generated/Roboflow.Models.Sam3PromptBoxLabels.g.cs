
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Per-box exemplar labels, one per entry in boxes: 1/true marks a positive exemplar (segment objects like this), 0/false marks a negative exemplar (exclude objects like this). Required when boxes is set.
    /// </summary>
    public sealed partial class Sam3PromptBoxLabels
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
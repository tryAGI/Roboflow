
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Sorted list of pixel values present in segmentation_mask, including background (0) when present. Optimization hint that lets consumers skip scanning the full-resolution mask; consumers must fall back to scanning when this field is absent.
    /// </summary>
    public sealed partial class SemanticSegmentationPredictionPresentClassIds
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
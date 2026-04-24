
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// RLE-encoded mask in COCO format: {'size': [H, W], 'counts': '...'}
    /// </summary>
    public sealed partial class InstanceSegmentationRLEPredictionRle
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();
    }
}
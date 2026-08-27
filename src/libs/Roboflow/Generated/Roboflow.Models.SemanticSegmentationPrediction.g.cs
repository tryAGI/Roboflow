
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SemanticSegmentationPrediction
    {
        /// <summary>
        /// base64-encoded PNG of predicted class label at each pixel. When the request sets response_mask_format='numpy' (in-process fast path), this carries the raw uint8 numpy label map instead; JSON serialization always yields the base64 PNG string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("segmentation_mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SegmentationMask { get; set; }

        /// <summary>
        /// Map of pixel intensity value to class label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_map")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, string> ClassMap { get; set; }

        /// <summary>
        /// base64-encoded PNG of predicted class confidence at each pixel. When the request sets response_mask_format='numpy' (in-process fast path), this carries the raw uint8 numpy confidence map instead; JSON serialization always yields the base64 PNG string.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence_mask")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ConfidenceMask { get; set; }

        /// <summary>
        /// Sorted list of pixel values present in segmentation_mask, including background (0) when present. Optimization hint that lets consumers skip scanning the full-resolution mask; consumers must fall back to scanning when this field is absent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("present_class_ids")]
        public global::System.Collections.Generic.IList<int>? PresentClassIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationPrediction" /> class.
        /// </summary>
        /// <param name="segmentationMask">
        /// base64-encoded PNG of predicted class label at each pixel. When the request sets response_mask_format='numpy' (in-process fast path), this carries the raw uint8 numpy label map instead; JSON serialization always yields the base64 PNG string.
        /// </param>
        /// <param name="classMap">
        /// Map of pixel intensity value to class label
        /// </param>
        /// <param name="confidenceMask">
        /// base64-encoded PNG of predicted class confidence at each pixel. When the request sets response_mask_format='numpy' (in-process fast path), this carries the raw uint8 numpy confidence map instead; JSON serialization always yields the base64 PNG string.
        /// </param>
        /// <param name="presentClassIds">
        /// Sorted list of pixel values present in segmentation_mask, including background (0) when present. Optimization hint that lets consumers skip scanning the full-resolution mask; consumers must fall back to scanning when this field is absent.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SemanticSegmentationPrediction(
            string segmentationMask,
            global::System.Collections.Generic.Dictionary<string, string> classMap,
            string confidenceMask,
            global::System.Collections.Generic.IList<int>? presentClassIds)
        {
            this.SegmentationMask = segmentationMask ?? throw new global::System.ArgumentNullException(nameof(segmentationMask));
            this.ClassMap = classMap ?? throw new global::System.ArgumentNullException(nameof(classMap));
            this.ConfidenceMask = confidenceMask ?? throw new global::System.ArgumentNullException(nameof(confidenceMask));
            this.PresentClassIds = presentClassIds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SemanticSegmentationPrediction" /> class.
        /// </summary>
        public SemanticSegmentationPrediction()
        {
        }

    }
}
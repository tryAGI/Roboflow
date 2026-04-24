
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InstanceSegmentationRLEPrediction
    {
        /// <summary>
        /// The center x-axis pixel coordinate of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double X { get; set; }

        /// <summary>
        /// The center y-axis pixel coordinate of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Y { get; set; }

        /// <summary>
        /// The width of the prediction bounding box in number of pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Width { get; set; }

        /// <summary>
        /// The height of the prediction bounding box in number of pixels
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Height { get; set; }

        /// <summary>
        /// The detection confidence as a fraction between 0 and 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double Confidence { get; set; }

        /// <summary>
        /// The predicted class label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Class { get; set; }

        /// <summary>
        /// The class id of the prediction
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int ClassId { get; set; }

        /// <summary>
        /// Unique identifier of detection
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detection_id")]
        public string? DetectionId { get; set; }

        /// <summary>
        /// Identifier of parent image region
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// RLE-encoded mask in COCO format: {'size': [H, W], 'counts': '...'}
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rle")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Rle { get; set; }

        /// <summary>
        /// Type of mask format<br/>
        /// Default Value: rle
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mask_format")]
        public string? MaskFormat { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceSegmentationRLEPrediction" /> class.
        /// </summary>
        /// <param name="x">
        /// The center x-axis pixel coordinate of the prediction
        /// </param>
        /// <param name="y">
        /// The center y-axis pixel coordinate of the prediction
        /// </param>
        /// <param name="width">
        /// The width of the prediction bounding box in number of pixels
        /// </param>
        /// <param name="height">
        /// The height of the prediction bounding box in number of pixels
        /// </param>
        /// <param name="confidence">
        /// The detection confidence as a fraction between 0 and 1
        /// </param>
        /// <param name="class">
        /// The predicted class label
        /// </param>
        /// <param name="classId">
        /// The class id of the prediction
        /// </param>
        /// <param name="rle">
        /// RLE-encoded mask in COCO format: {'size': [H, W], 'counts': '...'}
        /// </param>
        /// <param name="detectionId">
        /// Unique identifier of detection
        /// </param>
        /// <param name="parentId">
        /// Identifier of parent image region
        /// </param>
        /// <param name="maskFormat">
        /// Type of mask format<br/>
        /// Default Value: rle
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InstanceSegmentationRLEPrediction(
            double x,
            double y,
            double width,
            double height,
            double confidence,
            string @class,
            int classId,
            object rle,
            string? detectionId,
            string? parentId,
            string? maskFormat)
        {
            this.X = x;
            this.Y = y;
            this.Width = width;
            this.Height = height;
            this.Confidence = confidence;
            this.Class = @class ?? throw new global::System.ArgumentNullException(nameof(@class));
            this.ClassId = classId;
            this.DetectionId = detectionId;
            this.ParentId = parentId;
            this.Rle = rle ?? throw new global::System.ArgumentNullException(nameof(rle));
            this.MaskFormat = maskFormat;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InstanceSegmentationRLEPrediction" /> class.
        /// </summary>
        public InstanceSegmentationRLEPrediction()
        {
        }
    }
}
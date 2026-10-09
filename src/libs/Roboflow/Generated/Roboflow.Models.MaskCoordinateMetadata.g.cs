
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Describe the prediction grid and its mapping to the original image.<br/>
    /// Attributes:<br/>
    ///     coordinate_system (str): Coordinate frame shared by boxes, polygons and encoded RLE masks.<br/>
    ///     width (int): Width of the encoded mask grid.<br/>
    ///     height (int): Height of the encoded mask grid.<br/>
    ///     scale_x (float): Multiply mask x coordinates by this to obtain image x.<br/>
    ///     scale_y (float): Multiply mask y coordinates by this to obtain image y.
    /// </summary>
    public sealed partial class MaskCoordinateMetadata
    {
        /// <summary>
        /// All prediction geometry uses this grid, matching response image dimensions.<br/>
        /// Default Value: mask_grid
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("coordinate_system")]
        public string? CoordinateSystem { get; set; }

        /// <summary>
        /// Mask-grid width in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// Mask-grid height in pixels.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Original image width divided by output-grid width.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScaleX { get; set; }

        /// <summary>
        /// Original image height divided by output-grid height.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scale_y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double ScaleY { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskCoordinateMetadata" /> class.
        /// </summary>
        /// <param name="width">
        /// Mask-grid width in pixels.
        /// </param>
        /// <param name="height">
        /// Mask-grid height in pixels.
        /// </param>
        /// <param name="scaleX">
        /// Original image width divided by output-grid width.
        /// </param>
        /// <param name="scaleY">
        /// Original image height divided by output-grid height.
        /// </param>
        /// <param name="coordinateSystem">
        /// All prediction geometry uses this grid, matching response image dimensions.<br/>
        /// Default Value: mask_grid
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MaskCoordinateMetadata(
            int width,
            int height,
            double scaleX,
            double scaleY,
            string? coordinateSystem)
        {
            this.CoordinateSystem = coordinateSystem;
            this.Width = width;
            this.Height = height;
            this.ScaleX = scaleX;
            this.ScaleY = scaleY;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MaskCoordinateMetadata" /> class.
        /// </summary>
        public MaskCoordinateMetadata()
        {
        }

    }
}
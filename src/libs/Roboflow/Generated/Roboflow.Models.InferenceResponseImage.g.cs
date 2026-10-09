
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Inference response image information.<br/>
    /// Attributes:<br/>
    ///     width (int): The width of the represented image coordinate frame.<br/>
    ///     height (int): The height of the represented image coordinate frame.
    /// </summary>
    public sealed partial class InferenceResponseImage
    {
        /// <summary>
        /// The width of the represented image coordinate frame
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Width { get; set; }

        /// <summary>
        /// The height of the represented image coordinate frame
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Height { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResponseImage" /> class.
        /// </summary>
        /// <param name="width">
        /// The width of the represented image coordinate frame
        /// </param>
        /// <param name="height">
        /// The height of the represented image coordinate frame
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InferenceResponseImage(
            int width,
            int height)
        {
            this.Width = width;
            this.Height = height;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InferenceResponseImage" /> class.
        /// </summary>
        public InferenceResponseImage()
        {
        }

    }
}
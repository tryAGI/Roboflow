
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Raw anomaly heatmap at the network input resolution.<br/>
    /// `data` is base64 of the row-major little-endian float32 values. The map covers<br/>
    /// the whole image as the network saw it (resized to a square), so resizing it to<br/>
    /// the image's width and height is a plain stretch. Values share the units of<br/>
    /// `anomaly_score` and are unbounded above.
    /// </summary>
    public sealed partial class AnomalyMapPayload
    {
        /// <summary>
        /// [height, width] of the map
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shape")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<int> Shape { get; set; }

        /// <summary>
        /// Element type of the decoded `data`
        /// </summary>
        /// <default>"float32"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("dtype")]
        public string Dtype { get; set; } = "float32";

        /// <summary>
        /// Base64 of the row-major little-endian float32 map values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyMapPayload" /> class.
        /// </summary>
        /// <param name="shape">
        /// [height, width] of the map
        /// </param>
        /// <param name="data">
        /// Base64 of the row-major little-endian float32 map values
        /// </param>
        /// <param name="dtype">
        /// Element type of the decoded `data`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnomalyMapPayload(
            global::System.Collections.Generic.IList<int> shape,
            string data,
            string dtype = "float32")
        {
            this.Shape = shape ?? throw new global::System.ArgumentNullException(nameof(shape));
            this.Dtype = dtype;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyMapPayload" /> class.
        /// </summary>
        public AnomalyMapPayload()
        {
        }

    }
}
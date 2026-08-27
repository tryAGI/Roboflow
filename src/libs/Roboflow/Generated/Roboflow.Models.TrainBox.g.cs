
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrainBox
    {
        /// <summary>
        /// Center x coordinate in pixels of train box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("x")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int X { get; set; }

        /// <summary>
        /// Center y coordinate in pixels of train box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("y")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Y { get; set; }

        /// <summary>
        /// Width in pixels of train box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("w")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int W { get; set; }

        /// <summary>
        /// Height in pixels of train box
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("h")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int H { get; set; }

        /// <summary>
        /// Class name of object this box encloses
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cls")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Cls { get; set; }

        /// <summary>
        /// Whether this object is a positive or negative example for this class<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("negative")]
        public bool? Negative { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainBox" /> class.
        /// </summary>
        /// <param name="x">
        /// Center x coordinate in pixels of train box
        /// </param>
        /// <param name="y">
        /// Center y coordinate in pixels of train box
        /// </param>
        /// <param name="w">
        /// Width in pixels of train box
        /// </param>
        /// <param name="h">
        /// Height in pixels of train box
        /// </param>
        /// <param name="cls">
        /// Class name of object this box encloses
        /// </param>
        /// <param name="negative">
        /// Whether this object is a positive or negative example for this class<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainBox(
            int x,
            int y,
            int w,
            int h,
            string cls,
            bool? negative)
        {
            this.X = x;
            this.Y = y;
            this.W = w;
            this.H = h;
            this.Cls = cls ?? throw new global::System.ArgumentNullException(nameof(cls));
            this.Negative = negative;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainBox" /> class.
        /// </summary>
        public TrainBox()
        {
        }

    }
}
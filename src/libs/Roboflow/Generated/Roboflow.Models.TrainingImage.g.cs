
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class TrainingImage
    {
        /// <summary>
        /// List of boxes and corresponding classes of examples for the model to learn from
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("boxes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Roboflow.TrainBox> Boxes { get; set; }

        /// <summary>
        /// Image data that `boxes` describes
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.InferenceRequestImage Image { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingImage" /> class.
        /// </summary>
        /// <param name="boxes">
        /// List of boxes and corresponding classes of examples for the model to learn from
        /// </param>
        /// <param name="image">
        /// Image data that `boxes` describes
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TrainingImage(
            global::System.Collections.Generic.IList<global::Roboflow.TrainBox> boxes,
            global::Roboflow.InferenceRequestImage image)
        {
            this.Boxes = boxes ?? throw new global::System.ArgumentNullException(nameof(boxes));
            this.Image = image ?? throw new global::System.ArgumentNullException(nameof(image));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TrainingImage" /> class.
        /// </summary>
        public TrainingImage()
        {
        }

    }
}
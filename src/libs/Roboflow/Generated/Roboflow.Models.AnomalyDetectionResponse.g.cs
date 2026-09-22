
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AnomalyDetectionResponse
    {
        /// <summary>
        /// Base64 encoded string containing prediction visualization image data
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("visualization")]
        public string? Visualization { get; set; }

        /// <summary>
        /// Unique identifier of inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("inference_id")]
        public string? InferenceId { get; set; }

        /// <summary>
        /// The frame id of the image used in inference if the input was a video
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("frame_id")]
        public int? FrameId { get; set; }

        /// <summary>
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("time")]
        public double? Time { get; set; }

        /// <summary>
        /// Model identity and available package details for this result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resolved_model")]
        public global::Roboflow.ResolvedModel? ResolvedModel { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("image")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage> Image { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predictions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Roboflow.ClassificationPrediction> Predictions { get; set; }

        /// <summary>
        /// The top predicted class label
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("top")]
        public string? Top { get; set; }

        /// <summary>
        /// The confidence of the top predicted class label<br/>
        /// Default Value: 0F
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("confidence")]
        public double? Confidence { get; set; }

        /// <summary>
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("parent_id")]
        public string? ParentId { get; set; }

        /// <summary>
        /// Raw anomaly score; larger means more anomalous
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anomaly_score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnomalyScore { get; set; }

        /// <summary>
        /// Decision threshold fitted on validation images
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anomaly_threshold")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required double AnomalyThreshold { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_anomalous")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool IsAnomalous { get; set; }

        /// <summary>
        /// Raw local anomaly evidence in original image coordinates
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("anomaly_map")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? AnomalyMap { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionResponse" /> class.
        /// </summary>
        /// <param name="image"></param>
        /// <param name="predictions"></param>
        /// <param name="anomalyScore">
        /// Raw anomaly score; larger means more anomalous
        /// </param>
        /// <param name="anomalyThreshold">
        /// Decision threshold fitted on validation images
        /// </param>
        /// <param name="isAnomalous"></param>
        /// <param name="visualization">
        /// Base64 encoded string containing prediction visualization image data
        /// </param>
        /// <param name="inferenceId">
        /// Unique identifier of inference
        /// </param>
        /// <param name="frameId">
        /// The frame id of the image used in inference if the input was a video
        /// </param>
        /// <param name="time">
        /// The time in seconds it took to produce the predictions including image preprocessing
        /// </param>
        /// <param name="resolvedModel">
        /// Model identity and available package details for this result.
        /// </param>
        /// <param name="top">
        /// The top predicted class label
        /// </param>
        /// <param name="confidence">
        /// The confidence of the top predicted class label<br/>
        /// Default Value: 0F
        /// </param>
        /// <param name="parentId">
        /// Identifier of parent image region. Useful when stack of detection-models is in use to refer the RoI being the input to inference
        /// </param>
        /// <param name="anomalyMap">
        /// Raw local anomaly evidence in original image coordinates
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AnomalyDetectionResponse(
            global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage> image,
            global::System.Collections.Generic.IList<global::Roboflow.ClassificationPrediction> predictions,
            double anomalyScore,
            double anomalyThreshold,
            bool isAnomalous,
            string? visualization,
            string? inferenceId,
            int? frameId,
            double? time,
            global::Roboflow.ResolvedModel? resolvedModel,
            string? top,
            double? confidence,
            string? parentId,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? anomalyMap)
        {
            this.Visualization = visualization;
            this.InferenceId = inferenceId;
            this.FrameId = frameId;
            this.Time = time;
            this.ResolvedModel = resolvedModel;
            this.Image = image;
            this.Predictions = predictions ?? throw new global::System.ArgumentNullException(nameof(predictions));
            this.Top = top;
            this.Confidence = confidence;
            this.ParentId = parentId;
            this.AnomalyScore = anomalyScore;
            this.AnomalyThreshold = anomalyThreshold;
            this.IsAnomalous = isAnomalous;
            this.AnomalyMap = anomalyMap;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AnomalyDetectionResponse" /> class.
        /// </summary>
        public AnomalyDetectionResponse()
        {
        }

    }
}
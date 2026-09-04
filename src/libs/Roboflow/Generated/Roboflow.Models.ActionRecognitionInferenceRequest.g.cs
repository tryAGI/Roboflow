
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Request for action recognition over a video clip.<br/>
    /// Attributes:<br/>
    ///     model_id (str): The model to classify with.<br/>
    ///     video (InferenceRequestVideo): The clip to classify.<br/>
    ///     class_filter (Optional[List[str]]): The subset of a fine-tuned<br/>
    ///         model's classes to report. A zero-shot model answers in its own<br/>
    ///         words and ignores this.
    /// </summary>
    public sealed partial class ActionRecognitionInferenceRequest
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage_billable")]
        public bool? UsageBillable { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("start")]
        public double? Start { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source")]
        public string? Source { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_info")]
        public string? SourceInfo { get; set; }

        /// <summary>
        /// Internal stream-pipeline frame pairing id. Not part of the public API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_pipeline_context_id")]
        public string? StreamPipelineContextId { get; set; }

        /// <summary>
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("disable_model_monitoring")]
        public bool? DisableModelMonitoring { get; set; }

        /// <summary>
        /// The model to classify with
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// Video data for an inference request.<br/>
        /// Prefer a URL. Base64 grows the clip by a third, and the whole request is<br/>
        /// held in memory before the clip reaches disk, so gateways reject a large<br/>
        /// one. Base64 suits a short clip and a quick test.<br/>
        /// Attributes:<br/>
        ///     type (str): The type of video data provided, one of 'url' or 'base64'.<br/>
        ///     value (Optional[Any]): Video data corresponding to the video type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("video")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.InferenceRequestVideo Video { get; set; }

        /// <summary>
        /// The subset of a fine-tuned model's classes to report. A zero-shot model answers in its own words and ignores this.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("class_filter")]
        public global::System.Collections.Generic.IList<string>? ClassFilter { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRecognitionInferenceRequest" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="modelId">
        /// The model to classify with
        /// </param>
        /// <param name="video">
        /// Video data for an inference request.<br/>
        /// Prefer a URL. Base64 grows the clip by a third, and the whole request is<br/>
        /// held in memory before the clip reaches disk, so gateways reject a large<br/>
        /// one. Base64 suits a short clip and a quick test.<br/>
        /// Attributes:<br/>
        ///     type (str): The type of video data provided, one of 'url' or 'base64'.<br/>
        ///     value (Optional[Any]): Video data corresponding to the video type.
        /// </param>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="usageBillable">
        /// Default Value: true
        /// </param>
        /// <param name="start"></param>
        /// <param name="source"></param>
        /// <param name="sourceInfo"></param>
        /// <param name="streamPipelineContextId">
        /// Internal stream-pipeline frame pairing id. Not part of the public API.
        /// </param>
        /// <param name="disableModelMonitoring">
        /// If true, disables model monitoring for this request<br/>
        /// Default Value: false
        /// </param>
        /// <param name="classFilter">
        /// The subset of a fine-tuned model's classes to report. A zero-shot model answers in its own words and ignores this.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ActionRecognitionInferenceRequest(
            string id,
            string modelId,
            global::Roboflow.InferenceRequestVideo video,
            string? apiKey,
            bool? usageBillable,
            double? start,
            string? source,
            string? sourceInfo,
            string? streamPipelineContextId,
            bool? disableModelMonitoring,
            global::System.Collections.Generic.IList<string>? classFilter)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ApiKey = apiKey;
            this.UsageBillable = usageBillable;
            this.Start = start;
            this.Source = source;
            this.SourceInfo = sourceInfo;
            this.StreamPipelineContextId = streamPipelineContextId;
            this.DisableModelMonitoring = disableModelMonitoring;
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.Video = video ?? throw new global::System.ArgumentNullException(nameof(video));
            this.ClassFilter = classFilter;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ActionRecognitionInferenceRequest" /> class.
        /// </summary>
        public ActionRecognitionInferenceRequest()
        {
        }

    }
}
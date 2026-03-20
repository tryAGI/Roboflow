
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WebRTCWorkerRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key")]
        public string? ApiKey { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("workflow_configuration")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.WorkflowConfiguration WorkflowConfiguration { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_preview")]
        public bool? IsPreview { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webrtc_offer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Roboflow.WebRTCOffer WebrtcOffer { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webrtc_config")]
        public global::Roboflow.WebRTCConfig? WebrtcConfig { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webrtc_turn_config")]
        public global::Roboflow.WebRTCTURNConfig? WebrtcTurnConfig { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webrtc_realtime_processing")]
        public bool? WebrtcRealtimeProcessing { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_output")]
        public global::System.Collections.Generic.IList<string>? StreamOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_output")]
        public global::System.Collections.Generic.IList<string>? DataOutput { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("declared_fps")]
        public double? DeclaredFps { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("rtsp_url")]
        public string? RtspUrl { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mjpeg_url")]
        public string? MjpegUrl { get; set; }

        /// <summary>
        /// Default Value: 3600
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_timeout")]
        public int? ProcessingTimeout { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("processing_session_started")]
        public global::System.DateTime? ProcessingSessionStarted { get; set; }

        /// <summary>
        /// Default Value: webrtc-gpu-small
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_plan")]
        public string? RequestedPlan { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_gpu")]
        public string? RequestedGpu { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("requested_region")]
        public string? RequestedRegion { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCWorkerRequest" /> class.
        /// </summary>
        /// <param name="apiKey"></param>
        /// <param name="workflowConfiguration"></param>
        /// <param name="isPreview">
        /// Default Value: false
        /// </param>
        /// <param name="webrtcOffer"></param>
        /// <param name="webrtcConfig"></param>
        /// <param name="webrtcTurnConfig"></param>
        /// <param name="webrtcRealtimeProcessing">
        /// Default Value: true
        /// </param>
        /// <param name="streamOutput"></param>
        /// <param name="dataOutput"></param>
        /// <param name="declaredFps"></param>
        /// <param name="rtspUrl"></param>
        /// <param name="mjpegUrl"></param>
        /// <param name="processingTimeout">
        /// Default Value: 3600
        /// </param>
        /// <param name="processingSessionStarted"></param>
        /// <param name="requestedPlan">
        /// Default Value: webrtc-gpu-small
        /// </param>
        /// <param name="requestedGpu"></param>
        /// <param name="requestedRegion"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebRTCWorkerRequest(
            global::Roboflow.WorkflowConfiguration workflowConfiguration,
            global::Roboflow.WebRTCOffer webrtcOffer,
            string? apiKey,
            bool? isPreview,
            global::Roboflow.WebRTCConfig? webrtcConfig,
            global::Roboflow.WebRTCTURNConfig? webrtcTurnConfig,
            bool? webrtcRealtimeProcessing,
            global::System.Collections.Generic.IList<string>? streamOutput,
            global::System.Collections.Generic.IList<string>? dataOutput,
            double? declaredFps,
            string? rtspUrl,
            string? mjpegUrl,
            int? processingTimeout,
            global::System.DateTime? processingSessionStarted,
            string? requestedPlan,
            string? requestedGpu,
            string? requestedRegion)
        {
            this.WorkflowConfiguration = workflowConfiguration ?? throw new global::System.ArgumentNullException(nameof(workflowConfiguration));
            this.WebrtcOffer = webrtcOffer ?? throw new global::System.ArgumentNullException(nameof(webrtcOffer));
            this.ApiKey = apiKey;
            this.IsPreview = isPreview;
            this.WebrtcConfig = webrtcConfig;
            this.WebrtcTurnConfig = webrtcTurnConfig;
            this.WebrtcRealtimeProcessing = webrtcRealtimeProcessing;
            this.StreamOutput = streamOutput;
            this.DataOutput = dataOutput;
            this.DeclaredFps = declaredFps;
            this.RtspUrl = rtspUrl;
            this.MjpegUrl = mjpegUrl;
            this.ProcessingTimeout = processingTimeout;
            this.ProcessingSessionStarted = processingSessionStarted;
            this.RequestedPlan = requestedPlan;
            this.RequestedGpu = requestedGpu;
            this.RequestedRegion = requestedRegion;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebRTCWorkerRequest" /> class.
        /// </summary>
        public WebRTCWorkerRequest()
        {
        }
    }
}
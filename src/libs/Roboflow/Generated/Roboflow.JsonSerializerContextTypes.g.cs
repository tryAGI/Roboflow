
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class JsonSerializerContextTypes
    {
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? StringStringDictionary { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, object>? StringObjectDictionary { get; set; }

        /// <summary>
        /// Runtime object lists used by dynamic JSON payloads such as tool arguments.
        /// </summary>
        public global::System.Collections.Generic.List<object>? ObjectList { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Text.Json.JsonElement? JsonElement { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionInferenceRequest? Type0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public string? Type1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public object? Type2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public bool? Type3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public double? Type4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InferenceRequestVideo? Type5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<double?, global::Roboflow.ActionRecognitionInferenceRequestConfidence?>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionInferenceRequestConfidence? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<string>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionInferenceResponse? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ResolvedModel? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction>? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionPrediction? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionInferenceResponseSpanSemantics? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnomalyDetectionResponse? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InferenceResponseImage? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ClassificationPrediction>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClassificationPrediction? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnomalyMapPayload? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Box? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.BoxXYXY? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClassificationInferenceResponse? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipCompareRequest? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.InferenceRequestImage, string>? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InferenceRequestImage? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipCompareResponse? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipEmbeddingResponse? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipImageEmbeddingRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipTextEmbeddingRequest? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.CommandContext? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationRequest? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationRequestDepthMapFormat? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationResponse? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationResponseDepthMapFormat? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DoctrOCRInferenceRequest? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.EasyOCRInferenceRequest? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.GroundingDINOInferenceRequest? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.HTTPValidationError? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ValidationError>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ValidationError? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InitializeWebRTCResponse? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationInferenceResponse? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>>? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationPrediction? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationRLEPrediction? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.MaskCoordinateMetadata? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.PointOutput>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PointOutput? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Keypoint? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.KeypointsDetectionInferenceResponse? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.KeypointsPrediction>? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.KeypointsPrediction? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Keypoint>? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LMMInferenceRequest? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LMMInferenceResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, object>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ModelDescriptionEntity? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ModelsDescriptions? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ModelDescriptionEntity>? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.MultiLabelClassificationInferenceResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Roboflow.MultiLabelClassificationPrediction>? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.MultiLabelClassificationPrediction? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.OCRInferenceResponse? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionPrediction>? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ObjectDetectionPrediction? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ObjectDetectionInferenceResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.OwlV2InferenceRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.TrainingImage>? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrainingImage? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PPOCRInferenceRequest? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderCompareRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderCompareResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderEmbeddingResponse? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderImageEmbeddingRequest? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderTextEmbeddingRequest? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PointInput? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.RTCIceServer? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2EmbeddingRequest? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2EmbeddingResponse? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2Prompt? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.PointInput>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2PromptSet? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam2Prompt>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationPrediction? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationRequest? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationResponse? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam2SegmentationPrediction>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3EmbeddingResponse? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3Prompt? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<int?, bool?>>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<int?, bool?>? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3PromptEcho? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3PromptResult? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3SegmentationPrediction>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationPrediction? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3Prompt>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationResponse? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3PromptResult>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam33dObjectsInferenceRequest? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamEmbeddingRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamEmbeddingResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamSegmentationRequest? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamSegmentationResponse? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SemanticSegmentationInferenceResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SemanticSegmentationPrediction? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ServerVersionInfo? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.StubResponse? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrOCRInferenceRequest? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrainBox? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.TrainBox>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<string, int?>>? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, int?>? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.RTCIceServer>? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCOffer? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCSessionHeartbeatRequest? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCTURNConfig? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCWorkerRequest? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WorkflowConfiguration? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.YOLOWorldInferenceRequest? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2?>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat? Type153 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>? Type154 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>? Type155 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>? Type156 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>? Type157 { get; set; }

        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<string>? ListType0 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ActionRecognitionPrediction>? ListType1 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>? ListType2 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.InferenceResponseImage>? ListType3 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ClassificationPrediction>? ListType4 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.List<string>, object>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ValidationError>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.PointOutput>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.KeypointsPrediction>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Keypoint>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ModelDescriptionEntity>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ObjectDetectionPrediction>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.TrainingImage>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.PointInput>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Sam2Prompt>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>, object>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Sam2SegmentationPrediction>? ListType28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>? ListType29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.AnyOf<int?, bool?>>? ListType30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Sam3SegmentationPrediction>? ListType31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Sam3Prompt>? ListType32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Sam3PromptResult>? ListType33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>, object>? ListType34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>? ListType35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>, object>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.TrainBox>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.AnyOf<string, int?>>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.RTCIceServer>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>? ListType44 { get; set; }
    }
}
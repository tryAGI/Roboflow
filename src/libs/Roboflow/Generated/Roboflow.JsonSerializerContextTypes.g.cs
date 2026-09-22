
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
        public global::System.Collections.Generic.IList<string>? Type6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionInferenceResponse? Type7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ResolvedModel? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction>? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionPrediction? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnomalyDetectionResponse? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InferenceResponseImage? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ClassificationPrediction>? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClassificationPrediction? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Box? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.BoxXYXY? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClassificationInferenceResponse? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipCompareRequest? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.InferenceRequestImage, string>? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InferenceRequestImage? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipCompareResponse? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipEmbeddingResponse? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipImageEmbeddingRequest? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipTextEmbeddingRequest? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.CommandContext? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationRequest? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationRequestDepthMapFormat? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationResponse? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationResponseDepthMapFormat? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DoctrOCRInferenceRequest? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.EasyOCRInferenceRequest? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.GroundingDINOInferenceRequest? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.HTTPValidationError? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ValidationError>? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ValidationError? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InitializeWebRTCResponse? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationInferenceResponse? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>>? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationPrediction? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationRLEPrediction? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.PointOutput>? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PointOutput? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Keypoint? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.KeypointsDetectionInferenceResponse? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.KeypointsPrediction>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.KeypointsPrediction? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Keypoint>? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LMMInferenceRequest? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LMMInferenceResponse? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, object>? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ModelDescriptionEntity? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ModelsDescriptions? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ModelDescriptionEntity>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.MultiLabelClassificationInferenceResponse? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Roboflow.MultiLabelClassificationPrediction>? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.MultiLabelClassificationPrediction? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.OCRInferenceResponse? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionPrediction>? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ObjectDetectionPrediction? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ObjectDetectionInferenceResponse? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.OwlV2InferenceRequest? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.TrainingImage>? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrainingImage? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PPOCRInferenceRequest? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderCompareRequest? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderCompareResponse? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderEmbeddingResponse? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderImageEmbeddingRequest? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderTextEmbeddingRequest? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PointInput? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.RTCIceServer? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2EmbeddingRequest? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2EmbeddingResponse? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2Prompt? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.PointInput>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2PromptSet? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam2Prompt>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationPrediction? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationRequest? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationResponse? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam2SegmentationPrediction>? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3EmbeddingResponse? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3Prompt? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<int?, bool?>>? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<int?, bool?>? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3PromptEcho? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3PromptResult? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3SegmentationPrediction>? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationPrediction? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationRequest? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3Prompt>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationResponse? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3PromptResult>? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam33dObjectsInferenceRequest? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamEmbeddingRequest? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamEmbeddingResponse? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamSegmentationRequest? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamSegmentationResponse? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SemanticSegmentationInferenceResponse? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SemanticSegmentationPrediction? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ServerVersionInfo? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.StubResponse? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrOCRInferenceRequest? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrainBox? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.TrainBox>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<string, int?>>? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, int?>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCConfig? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.RTCIceServer>? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCOffer? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCSessionHeartbeatRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCTURNConfig? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCWorkerRequest? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WorkflowConfiguration? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.YOLOWorldInferenceRequest? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2?>? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>? Type151 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>? Type152 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>? Type153 { get; set; }

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
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.List<string>, object>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>? ListType9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>? ListType10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<string>, string>? ListType11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>? ListType12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ValidationError>? ListType13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>>? ListType14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.PointOutput>? ListType15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.KeypointsPrediction>? ListType16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Keypoint>? ListType17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ModelDescriptionEntity>? ListType18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.ObjectDetectionPrediction>? ListType19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.TrainingImage>? ListType20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.List<string>>? ListType21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.PointInput>? ListType22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.Sam2Prompt>? ListType23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>, object>? ListType24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>? ListType25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>? ListType26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<int>? ListType27 { get; set; }
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
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>, object, object>? ListType37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>, object, object>? ListType38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.TrainBox>? ListType39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.AnyOf<string, int?>>? ListType40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.RTCIceServer>? ListType41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>? ListType42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>? ListType43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>>? ListType44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>? ListType45 { get; set; }
    }
}
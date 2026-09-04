
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
        public global::System.Collections.Generic.IList<global::Roboflow.ActionRecognitionPrediction>? Type8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ActionRecognitionPrediction? Type9 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public int? Type10 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Box? Type11 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.BoxXYXY? Type12 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClassificationInferenceResponse? Type13 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>? Type14 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>? Type15 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InferenceResponseImage? Type16 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ClassificationPrediction>? Type17 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClassificationPrediction? Type18 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipCompareRequest? Type19 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.InferenceRequestImage, string>? Type20 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InferenceRequestImage? Type21 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>? Type22 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>? Type23 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipCompareResponse? Type24 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>? Type25 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<double>? Type26 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, double>? Type27 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipEmbeddingResponse? Type28 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>? Type29 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipImageEmbeddingRequest? Type30 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>? Type31 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ClipTextEmbeddingRequest? Type32 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<string>, string>? Type33 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.CommandContext? Type34 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationRequest? Type35 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationRequestDepthMapFormat? Type36 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationResponse? Type37 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type38 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DepthEstimationResponseDepthMapFormat? Type39 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.DoctrOCRInferenceRequest? Type40 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.EasyOCRInferenceRequest? Type41 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.GroundingDINOInferenceRequest? Type42 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.HTTPValidationError? Type43 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ValidationError>? Type44 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ValidationError? Type45 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InitializeWebRTCResponse? Type46 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationInferenceResponse? Type47 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>>? Type48 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>? Type49 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationPrediction? Type50 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.InstanceSegmentationRLEPrediction? Type51 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.PointOutput>? Type52 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PointOutput? Type53 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Keypoint? Type54 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.KeypointsDetectionInferenceResponse? Type55 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.KeypointsPrediction>? Type56 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.KeypointsPrediction? Type57 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Keypoint>? Type58 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LMMInferenceRequest? Type59 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LMMInferenceResponse? Type60 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, object>? Type61 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ModelDescriptionEntity? Type62 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public long? Type63 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ModelsDescriptions? Type64 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ModelDescriptionEntity>? Type65 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.MultiLabelClassificationInferenceResponse? Type66 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, global::Roboflow.MultiLabelClassificationPrediction>? Type67 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.MultiLabelClassificationPrediction? Type68 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.OCRInferenceResponse? Type69 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionPrediction>? Type70 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ObjectDetectionPrediction? Type71 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ObjectDetectionInferenceResponse? Type72 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.OwlV2InferenceRequest? Type73 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.TrainingImage>? Type74 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrainingImage? Type75 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PPOCRInferenceRequest? Type76 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderCompareRequest? Type77 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderCompareResponse? Type78 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderEmbeddingResponse? Type79 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderImageEmbeddingRequest? Type80 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PerceptionEncoderTextEmbeddingRequest? Type81 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.PointInput? Type82 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.RTCIceServer? Type83 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<string>>? Type84 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2EmbeddingRequest? Type85 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2EmbeddingResponse? Type86 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2Prompt? Type87 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.PointInput>? Type88 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2PromptSet? Type89 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam2Prompt>? Type90 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationPrediction? Type91 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>? Type92 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>? Type93 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>? Type94 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<int>? Type95 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationRequest? Type96 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam2SegmentationResponse? Type97 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam2SegmentationPrediction>? Type98 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3EmbeddingResponse? Type99 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3Prompt? Type100 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>? Type101 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>? Type102 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<int?, bool?>>? Type103 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<int?, bool?>? Type104 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3PromptEcho? Type105 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3PromptResult? Type106 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3SegmentationPrediction>? Type107 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationPrediction? Type108 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationRequest? Type109 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3Prompt>? Type110 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam3SegmentationResponse? Type111 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.Sam3PromptResult>? Type112 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.Sam33dObjectsInferenceRequest? Type113 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamEmbeddingRequest? Type114 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamEmbeddingResponse? Type115 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>? Type116 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>? Type117 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>? Type118 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamSegmentationRequest? Type119 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>? Type120 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>? Type121 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SamSegmentationResponse? Type122 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SemanticSegmentationInferenceResponse? Type123 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.SemanticSegmentationPrediction? Type124 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.Dictionary<string, string>? Type125 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.ServerVersionInfo? Type126 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.StubResponse? Type127 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrOCRInferenceRequest? Type128 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.TrainBox? Type129 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.TrainBox>? Type130 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.AnyOf<string, int?>>? Type131 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<string, int?>? Type132 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCConfig? Type133 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.RTCIceServer>? Type134 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCOffer? Type135 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCSessionHeartbeatRequest? Type136 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCTURNConfig? Type137 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WebRTCWorkerRequest? Type138 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.WorkflowConfiguration? Type139 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.DateTime? Type140 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.YOLOWorldInferenceRequest? Type141 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2?>? Type142 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2? Type143 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2? Type144 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>? Type145 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2? Type146 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2? Type147 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>? Type148 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>? Type149 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>? Type150 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>? Type151 { get; set; }

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
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.List<string>, object>? ListType5 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>? ListType6 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::Roboflow.AnyOf<global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>? ListType7 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<double>? ListType8 { get; set; }
        /// <summary>
        ///
        /// </summary>
        public global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>? ListType9 { get; set; }
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
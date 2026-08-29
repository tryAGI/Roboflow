
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Roboflow.JsonConverters.DepthEstimationRequestDepthMapFormatJsonConverter),

            typeof(global::Roboflow.JsonConverters.DepthEstimationRequestDepthMapFormatNullableJsonConverter),

            typeof(global::Roboflow.JsonConverters.DepthEstimationResponseDepthMapFormatJsonConverter),

            typeof(global::Roboflow.JsonConverters.DepthEstimationResponseDepthMapFormatNullableJsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2JsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2NullableJsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2JsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2NullableJsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2JsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2NullableJsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2JsonConverter),

            typeof(global::Roboflow.JsonConverters.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2NullableJsonConverter),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.Box, global::Roboflow.BoxXYXY>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<int?, bool?>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, int?>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, global::System.Collections.Generic.IList<string>>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2?>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>),

            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>),

            typeof(global::Roboflow.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Box))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.BoxXYXY))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClassificationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>), TypeInfoPropertyName = "AnyOfIListInferenceResponseImageInferenceResponseImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InferenceResponseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClassificationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipCompareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.InferenceRequestImage, string>), TypeInfoPropertyName = "AnyOfInferenceRequestImageString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InferenceRequestImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>), TypeInfoPropertyName = "AnyOfIListInferenceRequestImageInferenceRequestImageStringIListStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipCompareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>), TypeInfoPropertyName = "AnyOfIListDoubleDictionaryStringDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipImageEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>), TypeInfoPropertyName = "AnyOfIListInferenceRequestImageInferenceRequestImage2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipTextEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<string>, string>), TypeInfoPropertyName = "AnyOfIListStringString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.CommandContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DepthEstimationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DepthEstimationRequestDepthMapFormat), TypeInfoPropertyName = "DepthEstimationRequestDepthMapFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DepthEstimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>), TypeInfoPropertyName = "AnyOfStringIListIListDouble2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DepthEstimationResponseDepthMapFormat), TypeInfoPropertyName = "DepthEstimationResponseDepthMapFormat2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DoctrOCRInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.EasyOCRInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.GroundingDINOInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InitializeWebRTCResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InstanceSegmentationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>), TypeInfoPropertyName = "AnyOfInstanceSegmentationPredictionInstanceSegmentationRLEPrediction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InstanceSegmentationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InstanceSegmentationRLEPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.PointOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PointOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Keypoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.KeypointsDetectionInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.KeypointsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.KeypointsPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Keypoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LMMInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LMMInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, object>), TypeInfoPropertyName = "AnyOfStringObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ModelDescriptionEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ModelsDescriptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ModelDescriptionEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.MultiLabelClassificationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Roboflow.MultiLabelClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.MultiLabelClassificationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.OCRInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ObjectDetectionPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ObjectDetectionInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.OwlV2InferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.TrainingImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.TrainingImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PPOCRInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderCompareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderCompareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderImageEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderTextEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PointInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.RTCIceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, global::System.Collections.Generic.IList<string>>), TypeInfoPropertyName = "AnyOfStringIListString2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2EmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.PointInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2PromptSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Sam2Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2SegmentationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>), TypeInfoPropertyName = "AnyOfIListIListIListInt32Object2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2SegmentationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2SegmentationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Sam2SegmentationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>), TypeInfoPropertyName = "AnyOfBoxBoxXYXY2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.AnyOf<int?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<int?, bool?>), TypeInfoPropertyName = "AnyOfInt32Boolean2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3PromptEcho))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3PromptResult))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Sam3SegmentationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3SegmentationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3SegmentationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Sam3Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3SegmentationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Sam3PromptResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam33dObjectsInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SamEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SamEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>), TypeInfoPropertyName = "AnyOfIListIListIListIListDoubleObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SamSegmentationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>), TypeInfoPropertyName = "AnyOfIListIListIListIListDoubleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>), TypeInfoPropertyName = "AnyOfIListIListIListDoubleObjectObject2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SamSegmentationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SemanticSegmentationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SemanticSegmentationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ServerVersionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.StubResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.TrOCRInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.TrainBox))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.TrainBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, int?>), TypeInfoPropertyName = "AnyOfStringInt322")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.RTCIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCSessionHeartbeatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCTURNConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCWorkerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.YOLOWorldInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2?>), TypeInfoPropertyName = "AnyOfDoubleLegacyInferFromRequestDatasetIdVersionIdPostConfidence22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostConfidence2), TypeInfoPropertyName = "LegacyInferFromRequestDatasetIdVersionIdPostConfidence22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2), TypeInfoPropertyName = "LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<double?, global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2?>), TypeInfoPropertyName = "AnyOfDoubleLegacyInferFromRequestDatasetIdVersionIdGetConfidence22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetConfidence2), TypeInfoPropertyName = "LegacyInferFromRequestDatasetIdVersionIdGetConfidence22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2), TypeInfoPropertyName = "LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat22")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>), TypeInfoPropertyName = "AnyOfLMMInferenceResponseIListLMMInferenceResponseStubResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>), TypeInfoPropertyName = "AnyOfOCRInferenceResponseIListOCRInferenceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>), TypeInfoPropertyName = "StubResponse_object_3c21c3c89a5e4853")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>?), TypeInfoPropertyName = "StubResponse_object_c867376ea263bfbe")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.InferenceResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationPrediction, global::Roboflow.InstanceSegmentationRLEPrediction>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.PointOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.KeypointsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Keypoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ModelDescriptionEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ObjectDetectionPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.TrainingImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.PointInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Sam2Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Sam2SegmentationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.AnyOf<int?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Sam3SegmentationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Sam3Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Sam3PromptResult>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>>, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>>, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.TrainBox>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.RTCIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
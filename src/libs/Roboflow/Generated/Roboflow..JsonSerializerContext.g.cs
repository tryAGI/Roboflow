
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
            typeof(global::Roboflow.JsonConverters.SelectorTypeJsonConverter),
            typeof(global::Roboflow.JsonConverters.SelectorTypeNullableJsonConverter),
            typeof(global::Roboflow.JsonConverters.ValueTypeJsonConverter),
            typeof(global::Roboflow.JsonConverters.ValueTypeNullableJsonConverter),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.PointOutput>, global::System.Collections.Generic.IList<global::Roboflow.Point3D>>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.Box, global::Roboflow.BoxXYXY>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<int?, bool?>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<string, int?>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.ObjectDetectionInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionInferenceResponse>, global::Roboflow.StubResponse>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.StubResponse>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.StubResponse>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.StubResponse>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>),
            typeof(global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>),
            typeof(global::Roboflow.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AddModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.BlockDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.OutputDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.OutputDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Box))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.BoxXYXY))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClassificationInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InferenceRequestImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClassificationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InferenceResponseImage))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClassificationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClearModelRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipCompareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.InferenceRequestImage, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipCompareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipImageEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ClipTextEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.CommandContext))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DepthEstimationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DepthEstimationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DescribeBlocksRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.DynamicBlockDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DynamicBlockDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DescribeInterfaceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<object, global::System.Collections.Generic.IList<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DoctrOCRInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ManifestDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PythonCode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DynamicInputDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.SelectorType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SelectorType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ValueType))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.DynamicOutputDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.EasyOCRInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ExecutionEngineVersions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ExternalBlockPropertyPrimitiveDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ExternalOperationDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ExternalOperatorDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ExternalWorkflowsBlockSelectorDefinition))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.FaceDetectionPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::Roboflow.PointOutput>, global::System.Collections.Generic.IList<global::Roboflow.Point3D>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.PointOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PointOutput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Point3D>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Point3D))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.GazeDetectionInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.GazeDetectionInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.GazeDetectionPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.GazeDetectionPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.GroundingDINOInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.HTTPValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ValidationError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InitializeWebRTCResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InstanceSegmentationInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InstanceSegmentationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.InstanceSegmentationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.InstanceSegmentationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Keypoint))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.KeypointsDetectionInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.KeypointsDetectionInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.KeypointsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.KeypointsPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Keypoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Kind))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LMMInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.LMMInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Roboflow.DynamicInputDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Roboflow.DynamicOutputDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ModelDescriptionEntity))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ModelsDescriptions))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ModelDescriptionEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.MultiLabelClassificationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Roboflow.MultiLabelClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.MultiLabelClassificationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.OCRInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ObjectDetectionPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ObjectDetectionInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ObjectDetectionInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Kind>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderCompareRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderCompareResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderEmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderImageEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PerceptionEncoderTextEmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PointInput))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PredefinedWorkflowDescribeInterfaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.PredefinedWorkflowInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.RTCIceServer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2EmbeddingRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.PointInput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2PromptSet))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Sam2Prompt>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2SegmentationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<int>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2SegmentationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam2SegmentationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.Sam2SegmentationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3EmbeddingResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.Sam3Prompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.Box, global::Roboflow.BoxXYXY>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.AnyOf<int?, bool?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<int?, bool?>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SamSegmentationRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SamSegmentationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SemanticSegmentationInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SemanticSegmentationInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.SemanticSegmentationPrediction))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.ServerVersionInfo))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.StubResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.TrOCRInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.UniversalQueryLanguageDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ExternalOperationDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ExternalOperatorDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<string, int?>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.RTCIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCOffer))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCSessionHeartbeatRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCTURNConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WebRTCWorkerRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowConfiguration))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowInferenceResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowSpecificationDescribeInterfaceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowSpecificationInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowValidationStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowsBlocksDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.BlockDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Roboflow.ExternalWorkflowsBlockSelectorDefinition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ExternalWorkflowsBlockSelectorDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ExternalBlockPropertyPrimitiveDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.WorkflowsBlocksSchemaDescription))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.YOLOWorldInferenceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.ObjectDetectionInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionInferenceResponse>, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Roboflow.GazeDetectionInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.OutputDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.InferenceResponseImage>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ClassificationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.List<string>, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<double>, global::System.Collections.Generic.Dictionary<string, double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<double>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<string>, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.DynamicBlockDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<object, global::System.Collections.Generic.List<object>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.SelectorType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ValueType>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::System.Collections.Generic.List<global::Roboflow.PointOutput>, global::System.Collections.Generic.List<global::Roboflow.Point3D>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.PointOutput>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Point3D>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.GazeDetectionPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ValidationError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.InstanceSegmentationPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.KeypointsPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Keypoint>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ModelDescriptionEntity>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ObjectDetectionPrediction>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.Kind>))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ExternalOperationDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ExternalOperatorDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.AnyOf<string, int?>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.RTCIceServer>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.BlockDescription>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Roboflow.ExternalWorkflowsBlockSelectorDefinition>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ExternalWorkflowsBlockSelectorDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ExternalBlockPropertyPrimitiveDefinition>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.ObjectDetectionInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.ObjectDetectionInferenceResponse>, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.ObjectDetectionInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.LMMInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Roboflow.AnyOf<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.OCRInferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Roboflow.GazeDetectionInferenceResponse>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}
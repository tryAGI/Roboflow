
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Identity of the model and available package details used for inference.<br/>
    /// Attributes:<br/>
    ///     model_id (str): ID of the loaded model, using the canonical ID when available.<br/>
    ///     model_package_id (Optional[str]): ID of the loaded model package.<br/>
    ///     backend (Optional[str]): Backend of the loaded package.<br/>
    ///     quantization (Optional[str]): Quantization of the loaded package.
    /// </summary>
    public sealed partial class ResolvedModel
    {
        /// <summary>
        /// ID of the loaded model, using the canonical ID when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ModelId { get; set; }

        /// <summary>
        /// ID of the package that loaded successfully and produced this result, including after a loading fallback.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_package_id")]
        public string? ModelPackageId { get; set; }

        /// <summary>
        /// Backend of the loaded package, such as onnx, trt, or torch.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// Package quantization, such as fp32 or fp16, or unknown when unavailable. This does not specify the input tensor dtype or the precision of every runtime operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("quantization")]
        public string? Quantization { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedModel" /> class.
        /// </summary>
        /// <param name="modelId">
        /// ID of the loaded model, using the canonical ID when available.
        /// </param>
        /// <param name="modelPackageId">
        /// ID of the package that loaded successfully and produced this result, including after a loading fallback.
        /// </param>
        /// <param name="backend">
        /// Backend of the loaded package, such as onnx, trt, or torch.
        /// </param>
        /// <param name="quantization">
        /// Package quantization, such as fp32 or fp16, or unknown when unavailable. This does not specify the input tensor dtype or the precision of every runtime operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResolvedModel(
            string modelId,
            string? modelPackageId,
            string? backend,
            string? quantization)
        {
            this.ModelId = modelId ?? throw new global::System.ArgumentNullException(nameof(modelId));
            this.ModelPackageId = modelPackageId;
            this.Backend = backend;
            this.Quantization = quantization;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResolvedModel" /> class.
        /// </summary>
        public ResolvedModel()
        {
        }

    }
}
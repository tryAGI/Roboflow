
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ModelsDescriptions
    {
        /// <summary>
        /// List of models that are loaded by model manager.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("models")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Roboflow.ModelDescriptionEntity> Models { get; set; }

        /// <summary>
        /// Total estimated VRAM consumed by all loaded models in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("total_vram_bytes")]
        public long? TotalVramBytes { get; set; }

        /// <summary>
        /// Current GPU memory in use in bytes (device-level, includes all runtimes).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory_used")]
        public long? GpuMemoryUsed { get; set; }

        /// <summary>
        /// Total GPU memory available in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gpu_memory_total")]
        public long? GpuMemoryTotal { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDescriptions" /> class.
        /// </summary>
        /// <param name="models">
        /// List of models that are loaded by model manager.
        /// </param>
        /// <param name="totalVramBytes">
        /// Total estimated VRAM consumed by all loaded models in bytes.
        /// </param>
        /// <param name="gpuMemoryUsed">
        /// Current GPU memory in use in bytes (device-level, includes all runtimes).
        /// </param>
        /// <param name="gpuMemoryTotal">
        /// Total GPU memory available in bytes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ModelsDescriptions(
            global::System.Collections.Generic.IList<global::Roboflow.ModelDescriptionEntity> models,
            long? totalVramBytes,
            long? gpuMemoryUsed,
            long? gpuMemoryTotal)
        {
            this.Models = models ?? throw new global::System.ArgumentNullException(nameof(models));
            this.TotalVramBytes = totalVramBytes;
            this.GpuMemoryUsed = gpuMemoryUsed;
            this.GpuMemoryTotal = gpuMemoryTotal;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ModelsDescriptions" /> class.
        /// </summary>
        public ModelsDescriptions()
        {
        }
    }
}
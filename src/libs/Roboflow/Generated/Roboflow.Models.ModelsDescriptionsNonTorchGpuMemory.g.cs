
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Device memory not reserved by PyTorch in bytes. This includes native runtimes, CUDA context overhead, and allocations from other processes.
    /// </summary>
    public sealed partial class ModelsDescriptionsNonTorchGpuMemory
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
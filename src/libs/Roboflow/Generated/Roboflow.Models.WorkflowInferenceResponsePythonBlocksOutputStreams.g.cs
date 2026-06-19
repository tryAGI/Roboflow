
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// When `debug=True` was set on the request, stdout/stderr captured for each local custom Python block execution, keyed by step name. Each step maps to the list of invocations (in execution order) with `stdout` and `stderr` strings (or null if empty). Only populated for local executions.
    /// </summary>
    public sealed partial class WorkflowInferenceResponsePythonBlocksOutputStreams
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
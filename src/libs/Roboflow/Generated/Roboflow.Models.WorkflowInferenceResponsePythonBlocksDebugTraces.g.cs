
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// When `debug=True` was set on the request, structured debug entries appended via the `debug_traces` variable in custom Python blocks, in chronological execution order. Each entry has `step` (step name) and `value` (JSON-serialisable payload, or string repr for non-serialisable values). When `debug_traces.append(..., add_timestamp=True)` was used, the entry also includes `timestamp` (ISO-8601) and `timestamp_timezone` (IANA name, default `UTC`). Only populated for local executions.
    /// </summary>
    public sealed partial class WorkflowInferenceResponsePythonBlocksDebugTraces
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
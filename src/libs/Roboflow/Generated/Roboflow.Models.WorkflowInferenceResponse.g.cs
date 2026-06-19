
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class WorkflowInferenceResponse
    {
        /// <summary>
        /// Dictionary with keys defined in workflow output and serialised values
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("outputs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<object> Outputs { get; set; }

        /// <summary>
        /// Profiler events
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("profiler_trace")]
        public global::System.Collections.Generic.IList<object>? ProfilerTrace { get; set; }

        /// <summary>
        /// When `debug=True` was set on the request, stdout/stderr captured for each local custom Python block execution, keyed by step name. Each step maps to the list of invocations (in execution order) with `stdout` and `stderr` strings (or null if empty). Only populated for local executions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python_blocks_output_streams")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? PythonBlocksOutputStreams { get; set; }

        /// <summary>
        /// When `debug=True` was set on the request, structured debug entries appended via the `debug_traces` variable in custom Python blocks, in chronological execution order. Each entry has `step` (step name) and `value` (JSON-serialisable payload, or string repr for non-serialisable values). When `debug_traces.append(..., add_timestamp=True)` was used, the entry also includes `timestamp` (ISO-8601) and `timestamp_timezone` (IANA name, default `UTC`). Only populated for local executions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("python_blocks_debug_traces")]
        public global::System.Collections.Generic.IList<object>? PythonBlocksDebugTraces { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInferenceResponse" /> class.
        /// </summary>
        /// <param name="outputs">
        /// Dictionary with keys defined in workflow output and serialised values
        /// </param>
        /// <param name="profilerTrace">
        /// Profiler events
        /// </param>
        /// <param name="pythonBlocksOutputStreams">
        /// When `debug=True` was set on the request, stdout/stderr captured for each local custom Python block execution, keyed by step name. Each step maps to the list of invocations (in execution order) with `stdout` and `stderr` strings (or null if empty). Only populated for local executions.
        /// </param>
        /// <param name="pythonBlocksDebugTraces">
        /// When `debug=True` was set on the request, structured debug entries appended via the `debug_traces` variable in custom Python blocks, in chronological execution order. Each entry has `step` (step name) and `value` (JSON-serialisable payload, or string repr for non-serialisable values). When `debug_traces.append(..., add_timestamp=True)` was used, the entry also includes `timestamp` (ISO-8601) and `timestamp_timezone` (IANA name, default `UTC`). Only populated for local executions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WorkflowInferenceResponse(
            global::System.Collections.Generic.IList<object> outputs,
            global::System.Collections.Generic.IList<object>? profilerTrace,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<object>>? pythonBlocksOutputStreams,
            global::System.Collections.Generic.IList<object>? pythonBlocksDebugTraces)
        {
            this.Outputs = outputs ?? throw new global::System.ArgumentNullException(nameof(outputs));
            this.ProfilerTrace = profilerTrace;
            this.PythonBlocksOutputStreams = pythonBlocksOutputStreams;
            this.PythonBlocksDebugTraces = pythonBlocksDebugTraces;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WorkflowInferenceResponse" /> class.
        /// </summary>
        public WorkflowInferenceResponse()
        {
        }

    }
}
#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Endpoint to run workflow specification provided in payload<br/>
        /// Parses and executes workflow specification, injecting runtime parameters from request body.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowInferenceResponse> InferFromWorkflowWorkflowsRunPostAsync(

            global::Roboflow.WorkflowSpecificationInferenceRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to run workflow specification provided in payload<br/>
        /// Parses and executes workflow specification, injecting runtime parameters from request body.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.WorkflowInferenceResponse>> InferFromWorkflowWorkflowsRunPostAsResponseAsync(

            global::Roboflow.WorkflowSpecificationInferenceRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to run workflow specification provided in payload<br/>
        /// Parses and executes workflow specification, injecting runtime parameters from request body.
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="inputs">
        /// Dictionary that contains each parameter defined as an input for chosen workflow
        /// </param>
        /// <param name="excludedFields">
        /// List of field that shall be excluded from the response (among those defined in workflow specification)
        /// </param>
        /// <param name="enableProfiling">
        /// Flag to request Workflow run profiling. Enables Workflow profiler only when server settings allow profiling traces to be exported to clients. Only applies for Workflows definitions saved on Roboflow platform.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="debug">
        /// When True, captures stdout/stderr emitted by custom Python blocks executed locally and returns them in the response under `python_blocks_output_streams`. Also activates the workflow-scoped `debug_traces` variable in custom Python blocks; values appended during execution are returned under `python_blocks_debug_traces`. On Modal / OCI sandbox executions `debug_traces` is a no-op (entries appended remotely are not collected), but calls are safe and will not raise.<br/>
        /// Default Value: false
        /// </param>
        /// <param name="workflowId">
        /// Optional identifier of workflow
        /// </param>
        /// <param name="specification"></param>
        /// <param name="isPreview">
        /// Reserved, used internally by Roboflow to distinguish between preview and non-preview runs<br/>
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowInferenceResponse> InferFromWorkflowWorkflowsRunPostAsync(
            object inputs,
            object specification,
            string? apiKey = default,
            global::System.Collections.Generic.IList<string>? excludedFields = default,
            bool? enableProfiling = default,
            bool? debug = default,
            string? workflowId = default,
            bool? isPreview = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
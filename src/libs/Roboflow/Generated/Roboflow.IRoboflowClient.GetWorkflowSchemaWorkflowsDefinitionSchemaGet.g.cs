#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Endpoint to fetch the workflows block schema<br/>
        /// Endpoint to fetch the schema of all available blocks. This information can be used to validate workflow definitions and suggest syntax in the JSON editor.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowsBlocksSchemaDescription> GetWorkflowSchemaWorkflowsDefinitionSchemaGetAsync(
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to fetch the workflows block schema<br/>
        /// Endpoint to fetch the schema of all available blocks. This information can be used to validate workflow definitions and suggest syntax in the JSON editor.
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.WorkflowsBlocksSchemaDescription>> GetWorkflowSchemaWorkflowsDefinitionSchemaGetAsResponseAsync(
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
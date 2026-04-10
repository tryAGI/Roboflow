#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to get definition of workflows blocks that are accessible<br/>
        /// Endpoint provides detailed information about workflows building blocks that are accessible in the inference server. This information could be used to programmatically build / display workflows. Additionally - in request body one can specify list of dynamic blocks definitions which will be transformed into blocks and used to generate schemas and definitions of connections
        /// </summary>
        /// <param name="airGapped">
        /// Default Value: false
        /// </param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowsBlocksDescription> DescribeWorkflowsBlocksWorkflowsBlocksDescribePostAsync(

            global::Roboflow.DescribeBlocksRequest request,
            bool? airGapped = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to get definition of workflows blocks that are accessible<br/>
        /// Endpoint provides detailed information about workflows building blocks that are accessible in the inference server. This information could be used to programmatically build / display workflows. Additionally - in request body one can specify list of dynamic blocks definitions which will be transformed into blocks and used to generate schemas and definitions of connections
        /// </summary>
        /// <param name="airGapped">
        /// Default Value: false
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowsBlocksDescription> DescribeWorkflowsBlocksWorkflowsBlocksDescribePostAsync(
            bool? airGapped = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
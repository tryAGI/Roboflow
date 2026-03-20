#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to get definition of dynamic output for workflow step<br/>
        /// Endpoint to be used when step outputs can be discovered only after filling manifest with data.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Roboflow.OutputDefinition>> GetDynamicBlockOutputsWorkflowsBlocksDynamicOutputsPostAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to get definition of dynamic output for workflow step<br/>
        /// Endpoint to be used when step outputs can be discovered only after filling manifest with data.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Roboflow.OutputDefinition>> GetDynamicBlockOutputsWorkflowsBlocksDynamicOutputsPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
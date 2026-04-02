#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to validate<br/>
        /// Endpoint provides a way to check validity of JSON workflow definition.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowValidationStatus> ValidateWorkflowWorkflowsValidatePostAsync(

            object request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// [EXPERIMENTAL] Endpoint to validate<br/>
        /// Endpoint provides a way to check validity of JSON workflow definition.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.Experimental(diagnosticId: "ROBOFLOW_EXPERIMENTAL_001")]
#endif
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowValidationStatus> ValidateWorkflowWorkflowsValidatePostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
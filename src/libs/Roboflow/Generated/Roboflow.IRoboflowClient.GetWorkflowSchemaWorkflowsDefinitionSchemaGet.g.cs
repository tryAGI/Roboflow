#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Endpoint to fetch the workflows block schema<br/>
        /// Endpoint to fetch the schema of all available blocks. This information can be used to validate workflow definitions and suggest syntax in the JSON editor.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.WorkflowsBlocksSchemaDescription> GetWorkflowSchemaWorkflowsDefinitionSchemaGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
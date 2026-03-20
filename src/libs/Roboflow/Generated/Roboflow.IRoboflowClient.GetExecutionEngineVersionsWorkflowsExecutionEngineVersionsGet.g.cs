#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {

        /// <summary>
        /// Returns available Execution Engine versions sorted from oldest to newest<br/>
        /// Returns available Execution Engine versions sorted from oldest to newest
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ExecutionEngineVersions> GetExecutionEngineVersionsWorkflowsExecutionEngineVersionsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
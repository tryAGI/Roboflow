#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Healthz<br/>
        /// Health endpoint for Kubernetes liveness probe.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthzHealthzGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
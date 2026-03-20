#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {

        /// <summary>
        /// Readiness<br/>
        /// Readiness endpoint for Kubernetes readiness probe.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> ReadinessReadinessGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
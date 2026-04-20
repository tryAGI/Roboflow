#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Healthz<br/>
        /// Health endpoint for Kubernetes liveness probe.<br/>
        /// Verifies CUDA context health when running on GPU. Returns 503 if<br/>
        /// CUDA is corrupted (unrecoverable - requires process restart).
        /// </summary>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> HealthzHealthzGetAsync(
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
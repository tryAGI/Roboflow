#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Metrics<br/>
        /// Endpoint that serves Prometheus metrics.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> MetricsMetricsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
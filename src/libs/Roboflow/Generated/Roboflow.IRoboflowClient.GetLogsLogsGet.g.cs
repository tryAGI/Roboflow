#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Get Recent Logs<br/>
        /// Get recent application logs for debugging
        /// </summary>
        /// <param name="limit">
        /// Maximum number of log entries to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="level">
        /// Filter by log level (DEBUG, INFO, WARNING, ERROR, CRITICAL)
        /// </param>
        /// <param name="since">
        /// Return logs since this ISO timestamp
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> GetLogsLogsGetAsync(
            int? limit = default,
            string? level = default,
            string? since = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Get Recent Logs<br/>
        /// Get recent application logs for debugging
        /// </summary>
        /// <param name="limit">
        /// Maximum number of log entries to return<br/>
        /// Default Value: 100
        /// </param>
        /// <param name="level">
        /// Filter by log level (DEBUG, INFO, WARNING, ERROR, CRITICAL)
        /// </param>
        /// <param name="since">
        /// Return logs since this ISO timestamp
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<string>> GetLogsLogsGetAsResponseAsync(
            int? limit = default,
            string? level = default,
            string? since = default,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
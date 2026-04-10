#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// WebRTC session heartbeat<br/>
        /// Receive heartbeat for an active WebRTC session.<br/>
        /// This endpoint is called periodically to indicate<br/>
        /// that their session is still active. The session will be removed from<br/>
        /// the quota count if no heartbeat is received within the TTL period.<br/>
        /// Requires api_key for authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WebrtcSessionHeartbeatWebrtcSessionHeartbeatPostAsync(

            global::Roboflow.WebRTCSessionHeartbeatRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// WebRTC session heartbeat<br/>
        /// Receive heartbeat for an active WebRTC session.<br/>
        /// This endpoint is called periodically to indicate<br/>
        /// that their session is still active. The session will be removed from<br/>
        /// the quota count if no heartbeat is received within the TTL period.<br/>
        /// Requires api_key for authentication.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="apiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> WebrtcSessionHeartbeatWebrtcSessionHeartbeatPostAsync(
            string sessionId,
            string apiKey,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
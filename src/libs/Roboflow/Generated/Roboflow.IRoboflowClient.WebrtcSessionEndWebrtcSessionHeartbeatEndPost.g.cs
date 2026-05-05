#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// End WebRTC session<br/>
        /// End a WebRTC session and immediately free the quota slot.<br/>
        /// Requires api_key for authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> WebrtcSessionEndWebrtcSessionHeartbeatEndPostAsync(

            global::Roboflow.WebRTCSessionHeartbeatRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// End WebRTC session<br/>
        /// End a WebRTC session and immediately free the quota slot.<br/>
        /// Requires api_key for authentication.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<string>> WebrtcSessionEndWebrtcSessionHeartbeatEndPostAsResponseAsync(

            global::Roboflow.WebRTCSessionHeartbeatRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// End WebRTC session<br/>
        /// End a WebRTC session and immediately free the quota slot.<br/>
        /// Requires api_key for authentication.
        /// </summary>
        /// <param name="sessionId"></param>
        /// <param name="apiKey"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<string> WebrtcSessionEndWebrtcSessionHeartbeatEndPostAsync(
            string sessionId,
            string apiKey,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
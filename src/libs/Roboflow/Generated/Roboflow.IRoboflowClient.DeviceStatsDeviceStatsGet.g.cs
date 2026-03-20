#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Device Stats
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DeviceStatsDeviceStatsGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
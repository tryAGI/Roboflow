#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Dashboard Guard
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> DashboardGuardDashboardHtmlGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
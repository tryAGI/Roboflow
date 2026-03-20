#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Get model keys<br/>
        /// Get the ID of each loaded model
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ModelsDescriptions> RegistryModelRegistryGetAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
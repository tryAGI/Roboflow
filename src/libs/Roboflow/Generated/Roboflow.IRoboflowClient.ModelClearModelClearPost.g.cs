#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Remove all models<br/>
        /// Remove all loaded models
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ModelsDescriptions> ModelClearModelClearPostAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
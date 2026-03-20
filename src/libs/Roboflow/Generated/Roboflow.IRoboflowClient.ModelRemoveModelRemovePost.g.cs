#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {

        /// <summary>
        /// Remove a model<br/>
        /// Remove the model with the given model ID
        /// </summary>

        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ModelsDescriptions> ModelRemoveModelRemovePostAsync(

            global::Roboflow.ClearModelRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Remove a model<br/>
        /// Remove the model with the given model ID
        /// </summary>
        /// <param name="modelId">
        /// A unique model identifier<br/>
        /// Example: raccoon-detector-1
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.ModelsDescriptions> ModelRemoveModelRemovePostAsync(
            string modelId,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
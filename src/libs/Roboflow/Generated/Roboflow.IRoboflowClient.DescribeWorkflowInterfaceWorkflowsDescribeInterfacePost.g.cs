#nullable enable

namespace Roboflow
{
    public partial interface IRoboflowClient
    {
        /// <summary>
        /// Endpoint to describe interface of workflow given in request<br/>
        /// Parses workflow definition and retrieves describes inputs and outputs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.DescribeInterfaceResponse> DescribeWorkflowInterfaceWorkflowsDescribeInterfacePostAsync(

            global::Roboflow.WorkflowSpecificationDescribeInterfaceRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to describe interface of workflow given in request<br/>
        /// Parses workflow definition and retrieves describes inputs and outputs
        /// </summary>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.AutoSDKHttpResponse<global::Roboflow.DescribeInterfaceResponse>> DescribeWorkflowInterfaceWorkflowsDescribeInterfacePostAsResponseAsync(

            global::Roboflow.WorkflowSpecificationDescribeInterfaceRequest request,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to describe interface of workflow given in request<br/>
        /// Parses workflow definition and retrieves describes inputs and outputs
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="specification"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.DescribeInterfaceResponse> DescribeWorkflowInterfaceWorkflowsDescribeInterfacePostAsync(
            string apiKey,
            object specification,
            global::Roboflow.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
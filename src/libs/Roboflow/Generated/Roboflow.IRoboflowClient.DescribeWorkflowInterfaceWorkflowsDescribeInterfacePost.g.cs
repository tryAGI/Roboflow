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
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Roboflow.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.DescribeInterfaceResponse> DescribeWorkflowInterfaceWorkflowsDescribeInterfacePostAsync(

            global::Roboflow.WorkflowSpecificationDescribeInterfaceRequest request,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Endpoint to describe interface of workflow given in request<br/>
        /// Parses workflow definition and retrieves describes inputs and outputs
        /// </summary>
        /// <param name="apiKey">
        /// Roboflow API Key that will be passed to the model during initialization for artifact retrieval
        /// </param>
        /// <param name="specification"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::Roboflow.DescribeInterfaceResponse> DescribeWorkflowInterfaceWorkflowsDescribeInterfacePostAsync(
            string apiKey,
            object specification,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}
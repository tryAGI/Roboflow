namespace Roboflow.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static RoboflowClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("ROBOFLOW_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("ROBOFLOW_API_KEY environment variable is not found.");

        var client = new RoboflowClient(apiKey);
        
        return client;
    }
}

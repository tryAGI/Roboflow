
#nullable enable

namespace Roboflow
{
    public sealed partial class RoboflowClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInQuery(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Roboflow.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Query",
                Name = "api_key",
                Value = apiKey,
            });
        }
    }
}
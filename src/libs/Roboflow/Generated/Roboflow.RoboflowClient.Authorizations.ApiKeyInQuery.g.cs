
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

            for (var i = Authorizations.Count - 1; i >= 0; i--)
            {
                var __authorization = Authorizations[i];
                if (__authorization.Type == "ApiKey" &&
                    __authorization.Location == "Query" &&
                    __authorization.Name == "api_key")
                {
                    Authorizations.RemoveAt(i);
                }
            }

            Authorizations.Add(new global::Roboflow.EndPointAuthorization
            {
                Type = "ApiKey",
                SchemeId = "ApikeyApiKey",
                Location = "Query",
                Name = "api_key",
                Value = apiKey,
            });
        }
    }
}
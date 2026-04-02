
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Roboflow inference server<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class RoboflowClient : global::Roboflow.IRoboflowClient, global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string DefaultBaseUrl = "https://inference.roboflow.com";

        private bool _disposeHttpClient = true;

        /// <inheritdoc/>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <inheritdoc/>
        public System.Uri? BaseUri => HttpClient.BaseAddress;

        /// <inheritdoc/>
        public global::System.Collections.Generic.List<global::Roboflow.EndPointAuthorization> Authorizations { get; }

        /// <inheritdoc/>
        public bool ReadResponseAsString { get; set; }
#if DEBUG
            = true;
#endif
        /// <summary>
        /// 
        /// </summary>
        #pragma warning disable CS0618 // Type or member is obsolete
        public global::System.Text.Json.JsonSerializerOptions JsonSerializerOptions { get; set; } = new global::System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true,
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                Converters =
                {
                    new global::Roboflow.JsonConverters.SelectorTypeJsonConverter(),
                    new global::Roboflow.JsonConverters.SelectorTypeNullableJsonConverter(),
                    new global::Roboflow.JsonConverters.ValueTypeJsonConverter(),
                    new global::Roboflow.JsonConverters.ValueTypeNullableJsonConverter(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<object, global::System.Collections.Generic.IList<object>>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.PointOutput>, global::System.Collections.Generic.IList<global::Roboflow.Point3D>>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<string, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage, string, global::System.Collections.Generic.IList<string>, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InferenceRequestImage, string>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<double>, global::System.Collections.Generic.Dictionary<string, double>>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<string>, string>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.Box, global::Roboflow.BoxXYXY>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<int?, bool?>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>>, object, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<double>>>, object, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<int>>>, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceResponseImage>, global::Roboflow.InferenceResponseImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<string, int?>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<global::Roboflow.InferenceRequestImage>, global::Roboflow.InferenceRequestImage>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.ObjectDetectionInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.ObjectDetectionInferenceResponse>, global::Roboflow.StubResponse>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.StubResponse>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.StubResponse>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.StubResponse>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.LMMInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.LMMInferenceResponse>, global::Roboflow.StubResponse>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.OCRInferenceResponse, global::System.Collections.Generic.IList<global::Roboflow.OCRInferenceResponse>>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>(),
                    new global::Roboflow.JsonConverters.AnyOfJsonConverter<global::Roboflow.InstanceSegmentationInferenceResponse, global::Roboflow.KeypointsDetectionInferenceResponse, global::Roboflow.ObjectDetectionInferenceResponse, global::Roboflow.ClassificationInferenceResponse, global::Roboflow.MultiLabelClassificationInferenceResponse, global::Roboflow.SemanticSegmentationInferenceResponse, global::Roboflow.StubResponse, object>(),
                    new global::Roboflow.JsonConverters.UnixTimestampJsonConverter(),
                }
            };
        #pragma warning restore CS0618 // Type or member is obsolete


        /// <summary>
        /// Creates a new instance of the RoboflowClient.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, the default baseUri from OpenAPI spec will be used.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>
        public RoboflowClient(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::Roboflow.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true)
        {
            HttpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            HttpClient.BaseAddress ??= baseUri ?? new global::System.Uri(DefaultBaseUrl);
            Authorizations = authorizations ?? new global::System.Collections.Generic.List<global::Roboflow.EndPointAuthorization>();
            _disposeHttpClient = disposeHttpClient;

            Initialized(HttpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            if (_disposeHttpClient)
            {
                HttpClient.Dispose();
            }
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}
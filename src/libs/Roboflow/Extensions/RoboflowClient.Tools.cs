using System.ComponentModel;
using System.Globalization;
using Microsoft.Extensions.AI;

namespace Roboflow;

/// <summary>
/// Extensions for using RoboflowClient as MEAI AIFunction tools with any IChatClient.
/// </summary>
public static class RoboflowToolExtensions
{
    /// <summary>
    /// Creates an <see cref="AIFunction"/> that runs object detection on an image
    /// using a specified Roboflow model.
    /// </summary>
    /// <param name="client">The Roboflow client to use for inference.</param>
    /// <param name="confidence">The confidence threshold (0-1) for filtering predictions (default: 0.4).</param>
    /// <param name="maxDetections">Maximum number of detections to return (default: 300).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsObjectDetectionTool(
        this RoboflowClient client,
        double confidence = 0.4,
        int maxDetections = 300)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The model ID to use for object detection (e.g. 'yolov8n-640')")] string modelId,
                [Description("The image URL to run object detection on")] string imageUrl,
                CancellationToken cancellationToken) =>
            {
                var image = new InferenceRequestImage(type: "url", value: imageUrl);

                var response = await client.InferObjectDetectionInferObjectDetectionPostAsync(
                    id: modelId,
                    image: image,
                    confidence: confidence,
                    maxDetections: maxDetections,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatObjectDetectionResponse(response);
            },
            name: "DetectObjects",
            description: "Detect objects in an image using a Roboflow computer vision model. Returns bounding boxes with class labels and confidence scores.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that classifies an image
    /// using a specified Roboflow classification model.
    /// </summary>
    /// <param name="client">The Roboflow client to use for inference.</param>
    /// <param name="confidence">The confidence threshold (0-1) for filtering predictions (default: 0.4).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsClassificationTool(
        this RoboflowClient client,
        double confidence = 0.4)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The model ID to use for image classification")] string modelId,
                [Description("The image URL to classify")] string imageUrl,
                CancellationToken cancellationToken) =>
            {
                var image = new InferenceRequestImage(type: "url", value: imageUrl);

                var response = await client.InferClassificationInferClassificationPostAsync(
                    id: modelId,
                    image: image,
                    confidence: confidence,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatClassificationResponse(response);
            },
            name: "ClassifyImage",
            description: "Classify an image using a Roboflow classification model. Returns predicted class labels with confidence scores.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that extracts text from an image
    /// using the DocTR OCR model.
    /// </summary>
    /// <param name="client">The Roboflow client to use for inference.</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsOcrTool(this RoboflowClient client)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The image URL to extract text from")] string imageUrl,
                CancellationToken cancellationToken) =>
            {
                var image = new InferenceRequestImage(type: "url", value: imageUrl);

                var response = await client.DoctrRetrieveTextDoctrOcrPostAsync(
                    id: "doctr",
                    image: image,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatOcrResponse(response);
            },
            name: "ExtractTextFromImage",
            description: "Extract text from an image using OCR (Optical Character Recognition). Returns the recognized text content.");
    }

    /// <summary>
    /// Creates an <see cref="AIFunction"/> that runs instance segmentation on an image
    /// using a specified Roboflow model.
    /// </summary>
    /// <param name="client">The Roboflow client to use for inference.</param>
    /// <param name="confidence">The confidence threshold (0-1) for filtering predictions (default: 0.4).</param>
    /// <param name="maxDetections">Maximum number of detections to return (default: 300).</param>
    /// <returns>An AIFunction that can be passed to ChatOptions.Tools.</returns>
    public static AIFunction AsInstanceSegmentationTool(
        this RoboflowClient client,
        double confidence = 0.4,
        int maxDetections = 300)
    {
        ArgumentNullException.ThrowIfNull(client);

        return AIFunctionFactory.Create(
            async (
                [Description("The model ID to use for instance segmentation")] string modelId,
                [Description("The image URL to run instance segmentation on")] string imageUrl,
                CancellationToken cancellationToken) =>
            {
                var image = new InferenceRequestImage(type: "url", value: imageUrl);

                var response = await client.InferInstanceSegmentationInferInstanceSegmentationPostAsync(
                    id: modelId,
                    image: image,
                    confidence: confidence,
                    maxDetections: maxDetections,
                    cancellationToken: cancellationToken).ConfigureAwait(false);

                return FormatInstanceSegmentationResponse(response);
            },
            name: "SegmentObjects",
            description: "Run instance segmentation on an image using a Roboflow model. Returns detected objects with pixel-level polygon masks, bounding boxes, and confidence scores.");
    }

    private static string FormatObjectDetectionResponse(
        AnyOf<ObjectDetectionInferenceResponse, IList<ObjectDetectionInferenceResponse>, StubResponse> response)
    {
        if (response.IsValue1)
        {
            return FormatSingleObjectDetectionResponse(response.Value1);
        }

        if (response.IsValue2)
        {
            var parts = new List<string>();
            for (var i = 0; i < response.Value2.Count; i++)
            {
                parts.Add($"--- Image {i + 1} ---");
                parts.Add(FormatSingleObjectDetectionResponse(response.Value2[i]));
            }

            return string.Join("\n", parts);
        }

        return "No detection results returned.";
    }

    private static string FormatSingleObjectDetectionResponse(ObjectDetectionInferenceResponse response)
    {
        var parts = new List<string>();

        if (response.Time.HasValue)
        {
            parts.Add(string.Create(CultureInfo.InvariantCulture, $"Inference time: {response.Time.Value:F3}s"));
        }

        parts.Add(string.Create(CultureInfo.InvariantCulture, $"Detections: {response.Predictions.Count}"));

        foreach (var pred in response.Predictions)
        {
            parts.Add(string.Create(CultureInfo.InvariantCulture,
                $"- {pred.Class} (confidence: {pred.Confidence:P1}) at [{pred.X:F0}, {pred.Y:F0}] size {pred.Width:F0}x{pred.Height:F0}"));
        }

        return string.Join("\n", parts);
    }

    private static string FormatClassificationResponse(
        AnyOf<ClassificationInferenceResponse, MultiLabelClassificationInferenceResponse, StubResponse> response)
    {
        if (response.IsValue1)
        {
            return FormatSingleClassificationResponse(response.Value1);
        }

        return "No classification results returned.";
    }

    private static string FormatSingleClassificationResponse(ClassificationInferenceResponse response)
    {
        var parts = new List<string>();

        if (response.Time.HasValue)
        {
            parts.Add(string.Create(CultureInfo.InvariantCulture, $"Inference time: {response.Time.Value:F3}s"));
        }

        if (!string.IsNullOrWhiteSpace(response.Top))
        {
            parts.Add(string.Create(CultureInfo.InvariantCulture,
                $"Top prediction: {response.Top} (confidence: {response.Confidence:P1})"));
        }

        parts.Add("All predictions:");
        foreach (var pred in response.Predictions)
        {
            parts.Add(string.Create(CultureInfo.InvariantCulture,
                $"- {pred.Class} (confidence: {pred.Confidence:P1})"));
        }

        return string.Join("\n", parts);
    }

    private static string FormatOcrResponse(
        AnyOf<OCRInferenceResponse, IList<OCRInferenceResponse>> response)
    {
        if (response.IsValue1)
        {
            return FormatSingleOcrResponse(response.Value1);
        }

        if (response.IsValue2)
        {
            var parts = new List<string>();
            for (var i = 0; i < response.Value2.Count; i++)
            {
                parts.Add($"--- Image {i + 1} ---");
                parts.Add(FormatSingleOcrResponse(response.Value2[i]));
            }

            return string.Join("\n", parts);
        }

        return "No OCR results returned.";
    }

    private static string FormatSingleOcrResponse(OCRInferenceResponse response)
    {
        var parts = new List<string>();

        parts.Add(string.Create(CultureInfo.InvariantCulture, $"Inference time: {response.Time:F3}s"));
        parts.Add($"Extracted text: {response.Result}");

        return string.Join("\n", parts);
    }

    private static string FormatInstanceSegmentationResponse(
        AnyOf<InstanceSegmentationInferenceResponse, StubResponse> response)
    {
        if (response.IsValue1)
        {
            return FormatSingleInstanceSegmentationResponse(response.Value1);
        }

        return "No segmentation results returned.";
    }

    private static string FormatSingleInstanceSegmentationResponse(InstanceSegmentationInferenceResponse response)
    {
        var parts = new List<string>();

        if (response.Time.HasValue)
        {
            parts.Add(string.Create(CultureInfo.InvariantCulture, $"Inference time: {response.Time.Value:F3}s"));
        }

        parts.Add(string.Create(CultureInfo.InvariantCulture, $"Segments: {response.Predictions.Count}"));

        foreach (var pred in response.Predictions)
        {
            parts.Add(string.Create(CultureInfo.InvariantCulture,
                $"- {pred.Class} (confidence: {pred.Confidence:P1}) at [{pred.X:F0}, {pred.Y:F0}] size {pred.Width:F0}x{pred.Height:F0}, {pred.Points.Count} polygon points"));
        }

        return string.Join("\n", parts);
    }
}

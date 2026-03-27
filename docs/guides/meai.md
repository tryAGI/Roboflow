# Microsoft.Extensions.AI Integration

!!! tip "Cross-SDK comparison"
    See the [centralized MEAI documentation](https://tryagi.github.io/docs/meai/) for feature matrices and comparisons across all tryAGI SDKs.

The Roboflow SDK provides `AIFunction` tool wrappers from [Microsoft.Extensions.AI](https://learn.microsoft.com/en-us/dotnet/ai/microsoft-extensions-ai), allowing you to use Roboflow computer vision inference as tools with any `IChatClient`.

## Installation

```bash
dotnet add package Roboflow
```

## Object Detection Tool

Use `AsObjectDetectionTool()` to detect objects in images using a Roboflow model:

```csharp
using Roboflow;
using Microsoft.Extensions.AI;

var roboflowClient = new RoboflowClient(apiKey: Environment.GetEnvironmentVariable("ROBOFLOW_API_KEY")!);

var detectionTool = roboflowClient.AsObjectDetectionTool(confidence: 0.5);

// Use with any IChatClient
IChatClient chatClient = /* your chat client */;
var options = new ChatOptions
{
    Tools = [detectionTool],
};

var response = await chatClient.GetResponseAsync(
    "Detect all objects in this image: https://example.com/photo.jpg",
    options);
```

## Classification Tool

Use `AsClassificationTool()` to classify images:

```csharp
var classificationTool = roboflowClient.AsClassificationTool(confidence: 0.5);

var options = new ChatOptions
{
    Tools = [classificationTool],
};
```

## OCR Tool

Use `AsOcrTool()` to extract text from images using the DocTR OCR model:

```csharp
var ocrTool = roboflowClient.AsOcrTool();

var options = new ChatOptions
{
    Tools = [ocrTool],
};

var response = await chatClient.GetResponseAsync(
    "Extract all text from this document image: https://example.com/document.jpg",
    options);
```

## Instance Segmentation Tool

Use `AsInstanceSegmentationTool()` to run pixel-level instance segmentation:

```csharp
var segmentationTool = roboflowClient.AsInstanceSegmentationTool(confidence: 0.5);

var options = new ChatOptions
{
    Tools = [segmentationTool],
};
```

## Combining Tools

All four tools can be used together to give an LLM comprehensive computer vision capabilities:

```csharp
var options = new ChatOptions
{
    Tools =
    [
        roboflowClient.AsObjectDetectionTool(confidence: 0.5),
        roboflowClient.AsClassificationTool(confidence: 0.5),
        roboflowClient.AsOcrTool(),
        roboflowClient.AsInstanceSegmentationTool(confidence: 0.5),
    ],
};
```

!!! tip "Cross-SDK tool combination"
    Roboflow vision tools can be combined with search tools from [Tavily](https://tryagi.github.io/Tavily/guides/meai/) or [Exa](https://tryagi.github.io/Exa/guides/meai/) in a single `ChatOptions.Tools` list for multimodal research workflows.

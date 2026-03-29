# CLAUDE.md -- Roboflow SDK

## Overview

Auto-generated C# SDK for [Roboflow](https://roboflow.com/) -- computer vision inference platform with object detection, instance segmentation, image classification, OCR, CLIP embeddings, SAM (Segment Anything), and workflow execution.
OpenAPI spec from `https://inference.roboflow.com/openapi.json`.

## Build & Test

```bash
dotnet build Roboflow.slnx
dotnet test src/tests/IntegrationTests/
```

## Auth

API key in query parameter (`api_key`):

```csharp
var client = new RoboflowClient(apiKey); // ROBOFLOW_API_KEY env var
```

Auth is passed as a query parameter, not a header. The spec had no `securitySchemes` -- `--security-scheme ApiKey:Query:api_key` injects it at generation time.

## Key Files

- `src/libs/Roboflow/openapi.json` -- OpenAPI spec (3.1.0, downloaded from Roboflow inference server)
- `src/libs/Roboflow/generate.sh` -- Downloads spec, runs autosdk with `--security-scheme ApiKey:Query:api_key` and `--base-url https://inference.roboflow.com`
- `src/libs/Roboflow/Generated/` -- **Never edit** -- auto-generated code (~1339 files)
- `src/libs/Roboflow/Extensions/RoboflowClient.Tools.cs` -- Hand-written MEAI AIFunction tools

## API Pattern

Roboflow uses a flat client (no sub-clients). All endpoints are on the root `RoboflowClient`:

```csharp
// Object detection
client.InferObjectDetectionInferObjectDetectionPostAsync(
    id: "yolov8n-640",
    image: new InferenceRequestImage(type: "url", value: imageUrl),
    confidence: 0.4,
    maxDetections: 300);

// Image classification
client.InferClassificationInferClassificationPostAsync(
    id: modelId,
    image: new InferenceRequestImage(type: "url", value: imageUrl),
    confidence: 0.4);

// OCR (DocTR)
client.DoctrRetrieveTextDoctrOcrPostAsync(
    id: "doctr",
    image: new InferenceRequestImage(type: "url", value: imageUrl));

// Instance segmentation
client.InferInstanceSegmentationInferInstanceSegmentationPostAsync(
    id: modelId,
    image: image,
    confidence: 0.4,
    maxDetections: 300);
```

Images are passed as `InferenceRequestImage` with `type: "url"` and `value: "<image-url>"`.

## MEAI Integration

`AIFunction` tools for use with any `IChatClient` (in `RoboflowClient.Tools.cs`):

- `client.AsObjectDetectionTool(confidence, maxDetections)` -- Detect objects in an image with bounding boxes
- `client.AsClassificationTool(confidence)` -- Classify an image with confidence scores
- `client.AsOcrTool()` -- Extract text from an image using DocTR OCR
- `client.AsInstanceSegmentationTool(confidence, maxDetections)` -- Segment objects with polygon masks

## Spec Notes

- OpenAPI 3.1.0 spec from Roboflow inference server
- Spec has no `securitySchemes` or `servers` section -- both injected via CLI flags
- ~70+ API operations covering object detection, segmentation, classification, OCR, CLIP, SAM, workflows
- Uses `--exclude-deprecated-operations` flag
- Response types use `AnyOf<T1, T2, ...>` unions (e.g., single response vs. batch response vs. stub)

# Authentication

The Roboflow SDK uses API key authentication via a query parameter. You can obtain an API key from your [Roboflow settings](https://app.roboflow.com/settings/api).

## Basic Usage

```csharp
using Roboflow;

var client = new RoboflowClient(apiKey: Environment.GetEnvironmentVariable("ROBOFLOW_API_KEY")!);
```

The API key is automatically appended as a query parameter to each request.

## Environment Variable

| Variable | Description |
|----------|-------------|
| `ROBOFLOW_API_KEY` | Your Roboflow API key |

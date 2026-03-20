#!/usr/bin/env bash
set -euo pipefail
readonly openapi_url="https://inference.roboflow.com/openapi.json"
dotnet tool update --global autosdk.cli --prerelease || dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location "$openapi_url" -o openapi.json

# Roboflow spec has no servers section and no security schemes.
# Add servers + apiKey auth in query parameter (api_key).
jq '
  .servers = [{"url": "https://inference.roboflow.com", "description": "Roboflow Inference Server"}] |
  .components.securitySchemes.ApiKeyAuth = {
    "type": "apiKey",
    "in": "query",
    "name": "api_key"
  } |
  .security = [{"ApiKeyAuth": []}]
' openapi.json > openapi_fixed.json && mv openapi_fixed.json openapi.json

autosdk generate openapi.json \
  --namespace Roboflow \
  --clientClassName RoboflowClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations

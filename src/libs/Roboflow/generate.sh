#!/usr/bin/env bash
set -euo pipefail

# OpenAPI spec: https://inference.roboflow.com/openapi.json

dotnet tool install --global autosdk.cli --prerelease
rm -rf Generated
curl --fail --silent --show-error --location https://inference.roboflow.com/openapi.json -o openapi.json

# Auth: --security-scheme injects apiKey in query parameter (spec has no securitySchemes).
# --base-url injects server URL (spec has no servers section).
autosdk generate openapi.json \
  --namespace Roboflow \
  --clientClassName RoboflowClient \
  --targetFramework net10.0 \
  --output Generated \
  --exclude-deprecated-operations \
  --security-scheme ApiKey:Query:api_key \
  --base-url https://inference.roboflow.com

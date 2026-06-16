#!/usr/bin/env bash
set -euo pipefail

install_autosdk_cli() {
  dotnet tool update --global autosdk.cli --prerelease >/dev/null 2>&1 || \
    dotnet tool install --global autosdk.cli --prerelease
}

fetch_spec() {
  curl "$@" \
    --fail --silent --show-error --location \
    --retry 5 --retry-delay 10 --retry-all-errors \
    --connect-timeout 30 --max-time 300
}

# OpenAPI spec: https://inference.roboflow.com/openapi.json
install_autosdk_cli
rm -rf Generated
fetch_spec --fail --silent --show-error --location https://inference.roboflow.com/openapi.json -o openapi.json

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

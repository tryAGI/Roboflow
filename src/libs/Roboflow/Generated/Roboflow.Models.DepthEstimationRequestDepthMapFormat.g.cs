
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Serialization format for `normalized_depth` in the response: `json` (default, wire-compatible with older clients) returns the nested float list; `png16` returns a base64 16-bit grayscale PNG (quantization step 1/65535, typically &gt;10x smaller payload - `inference_sdk` decodes it back to a numpy array when requested via `depth_map_format='png16'`); `png8` returns a base64 8-bit grayscale PNG (256 depth levels, roughly another order of magnitude smaller - fine for visualization/thresholding, lossy for geometric use).<br/>
    /// Default Value: json
    /// </summary>
    public enum DepthEstimationRequestDepthMapFormat
    {
        /// <summary>
        /// `json` (default, wire-compatible with older clients) returns the nested float list; `png16` returns a base64 16-bit grayscale PNG (quantization step 1/65535, typically &gt;10x smaller payload - `inference_sdk` decodes it back to a numpy array when requested via `depth_map_format='png16'`); `png8` returns a base64 8-bit grayscale PNG (256 depth levels, roughly another order of magnitude smaller - fine for visualization/thresholding, lossy for geometric use).
        /// </summary>
        Json,
        /// <summary>
        /// `json` (default, wire-compatible with older clients) returns the nested float list; `png16` returns a base64 16-bit grayscale PNG (quantization step 1/65535, typically &gt;10x smaller payload - `inference_sdk` decodes it back to a numpy array when requested via `depth_map_format='png16'`); `png8` returns a base64 8-bit grayscale PNG (256 depth levels, roughly another order of magnitude smaller - fine for visualization/thresholding, lossy for geometric use).
        /// </summary>
        Png16,
        /// <summary>
        /// `json` (default, wire-compatible with older clients) returns the nested float list; `png16` returns a base64 16-bit grayscale PNG (quantization step 1/65535, typically &gt;10x smaller payload - `inference_sdk` decodes it back to a numpy array when requested via `depth_map_format='png16'`); `png8` returns a base64 8-bit grayscale PNG (256 depth levels, roughly another order of magnitude smaller - fine for visualization/thresholding, lossy for geometric use).
        /// </summary>
        Png8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DepthEstimationRequestDepthMapFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DepthEstimationRequestDepthMapFormat value)
        {
            return value switch
            {
                DepthEstimationRequestDepthMapFormat.Json => "json",
                DepthEstimationRequestDepthMapFormat.Png16 => "png16",
                DepthEstimationRequestDepthMapFormat.Png8 => "png8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DepthEstimationRequestDepthMapFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => DepthEstimationRequestDepthMapFormat.Json,
                "png16" => DepthEstimationRequestDepthMapFormat.Png16,
                "png8" => DepthEstimationRequestDepthMapFormat.Png8,
                _ => null,
            };
        }
    }
}
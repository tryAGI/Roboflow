
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// The serialization format used for `normalized_depth`<br/>
    /// Default Value: json
    /// </summary>
    public enum DepthEstimationResponseDepthMapFormat
    {
        /// <summary>
        ///
        /// </summary>
        Json,
        /// <summary>
        ///
        /// </summary>
        Png16,
        /// <summary>
        ///
        /// </summary>
        Png8,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DepthEstimationResponseDepthMapFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DepthEstimationResponseDepthMapFormat value)
        {
            return value switch
            {
                DepthEstimationResponseDepthMapFormat.Json => "json",
                DepthEstimationResponseDepthMapFormat.Png16 => "png16",
                DepthEstimationResponseDepthMapFormat.Png8 => "png8",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DepthEstimationResponseDepthMapFormat? ToEnum(string value)
        {
            return value switch
            {
                "json" => DepthEstimationResponseDepthMapFormat.Json,
                "png16" => DepthEstimationResponseDepthMapFormat.Png16,
                "png8" => DepthEstimationResponseDepthMapFormat.Png8,
                _ => null,
            };
        }
    }
}
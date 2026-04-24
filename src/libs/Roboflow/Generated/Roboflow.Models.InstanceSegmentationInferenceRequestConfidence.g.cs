
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum InstanceSegmentationInferenceRequestConfidence
    {
        /// <summary>
        /// 
        /// </summary>
        Best,
        /// <summary>
        /// 
        /// </summary>
        Default,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InstanceSegmentationInferenceRequestConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstanceSegmentationInferenceRequestConfidence value)
        {
            return value switch
            {
                InstanceSegmentationInferenceRequestConfidence.Best => "best",
                InstanceSegmentationInferenceRequestConfidence.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstanceSegmentationInferenceRequestConfidence? ToEnum(string value)
        {
            return value switch
            {
                "best" => InstanceSegmentationInferenceRequestConfidence.Best,
                "default" => InstanceSegmentationInferenceRequestConfidence.Default,
                _ => null,
            };
        }
    }
}
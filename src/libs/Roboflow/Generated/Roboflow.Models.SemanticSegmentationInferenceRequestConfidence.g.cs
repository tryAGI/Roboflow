
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum SemanticSegmentationInferenceRequestConfidence
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
    public static class SemanticSegmentationInferenceRequestConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SemanticSegmentationInferenceRequestConfidence value)
        {
            return value switch
            {
                SemanticSegmentationInferenceRequestConfidence.Best => "best",
                SemanticSegmentationInferenceRequestConfidence.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SemanticSegmentationInferenceRequestConfidence? ToEnum(string value)
        {
            return value switch
            {
                "best" => SemanticSegmentationInferenceRequestConfidence.Best,
                "default" => SemanticSegmentationInferenceRequestConfidence.Default,
                _ => null,
            };
        }
    }
}
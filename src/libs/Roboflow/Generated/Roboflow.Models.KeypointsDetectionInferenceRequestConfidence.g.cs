
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum KeypointsDetectionInferenceRequestConfidence
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
    public static class KeypointsDetectionInferenceRequestConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this KeypointsDetectionInferenceRequestConfidence value)
        {
            return value switch
            {
                KeypointsDetectionInferenceRequestConfidence.Best => "best",
                KeypointsDetectionInferenceRequestConfidence.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static KeypointsDetectionInferenceRequestConfidence? ToEnum(string value)
        {
            return value switch
            {
                "best" => KeypointsDetectionInferenceRequestConfidence.Best,
                "default" => KeypointsDetectionInferenceRequestConfidence.Default,
                _ => null,
            };
        }
    }
}
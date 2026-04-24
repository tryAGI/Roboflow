
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum ObjectDetectionInferenceRequestConfidence
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
    public static class ObjectDetectionInferenceRequestConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ObjectDetectionInferenceRequestConfidence value)
        {
            return value switch
            {
                ObjectDetectionInferenceRequestConfidence.Best => "best",
                ObjectDetectionInferenceRequestConfidence.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ObjectDetectionInferenceRequestConfidence? ToEnum(string value)
        {
            return value switch
            {
                "best" => ObjectDetectionInferenceRequestConfidence.Best,
                "default" => ObjectDetectionInferenceRequestConfidence.Default,
                _ => null,
            };
        }
    }
}
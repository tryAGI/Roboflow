
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public enum ActionRecognitionInferenceRequestConfidence
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
    public static class ActionRecognitionInferenceRequestConfidenceExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionRecognitionInferenceRequestConfidence value)
        {
            return value switch
            {
                ActionRecognitionInferenceRequestConfidence.Best => "best",
                ActionRecognitionInferenceRequestConfidence.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionRecognitionInferenceRequestConfidence? ToEnum(string value)
        {
            return value switch
            {
                "best" => ActionRecognitionInferenceRequestConfidence.Best,
                "default" => ActionRecognitionInferenceRequestConfidence.Default,
                _ => null,
            };
        }
    }
}
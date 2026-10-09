
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Default Value: instances
    /// </summary>
    public enum ActionRecognitionInferenceResponseSpanSemantics
    {
        /// <summary>
        ///
        /// </summary>
        ClassUnion,
        /// <summary>
        ///
        /// </summary>
        Instances,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ActionRecognitionInferenceResponseSpanSemanticsExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ActionRecognitionInferenceResponseSpanSemantics value)
        {
            return value switch
            {
                ActionRecognitionInferenceResponseSpanSemantics.ClassUnion => "class_union",
                ActionRecognitionInferenceResponseSpanSemantics.Instances => "instances",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ActionRecognitionInferenceResponseSpanSemantics? ToEnum(string value)
        {
            return value switch
            {
                "class_union" => ActionRecognitionInferenceResponseSpanSemantics.ClassUnion,
                "instances" => ActionRecognitionInferenceResponseSpanSemantics.Instances,
                _ => null,
            };
        }
    }
}
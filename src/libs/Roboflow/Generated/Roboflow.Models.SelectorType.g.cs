
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum SelectorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputImage,
        /// <summary>
        /// 
        /// </summary>
        StepOutputImage,
        /// <summary>
        /// 
        /// </summary>
        InputParameter,
        /// <summary>
        /// 
        /// </summary>
        StepOutput,
        /// <summary>
        /// 
        /// </summary>
        Generic,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SelectorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SelectorType value)
        {
            return value switch
            {
                SelectorType.InputImage => "input_image",
                SelectorType.StepOutputImage => "step_output_image",
                SelectorType.InputParameter => "input_parameter",
                SelectorType.StepOutput => "step_output",
                SelectorType.Generic => "generic",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SelectorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => SelectorType.InputImage,
                "step_output_image" => SelectorType.StepOutputImage,
                "input_parameter" => SelectorType.InputParameter,
                "step_output" => SelectorType.StepOutput,
                "generic" => SelectorType.Generic,
                _ => null,
            };
        }
    }
}
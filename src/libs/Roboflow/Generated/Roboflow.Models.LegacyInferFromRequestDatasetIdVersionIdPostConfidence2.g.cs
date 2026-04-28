
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyInferFromRequestDatasetIdVersionIdPostConfidence2
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
    public static class LegacyInferFromRequestDatasetIdVersionIdPostConfidence2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyInferFromRequestDatasetIdVersionIdPostConfidence2 value)
        {
            return value switch
            {
                LegacyInferFromRequestDatasetIdVersionIdPostConfidence2.Best => "best",
                LegacyInferFromRequestDatasetIdVersionIdPostConfidence2.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyInferFromRequestDatasetIdVersionIdPostConfidence2? ToEnum(string value)
        {
            return value switch
            {
                "best" => LegacyInferFromRequestDatasetIdVersionIdPostConfidence2.Best,
                "default" => LegacyInferFromRequestDatasetIdVersionIdPostConfidence2.Default,
                _ => null,
            };
        }
    }
}
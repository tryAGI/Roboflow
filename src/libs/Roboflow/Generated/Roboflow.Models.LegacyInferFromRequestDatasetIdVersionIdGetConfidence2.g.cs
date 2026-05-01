
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyInferFromRequestDatasetIdVersionIdGetConfidence2
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
    public static class LegacyInferFromRequestDatasetIdVersionIdGetConfidence2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyInferFromRequestDatasetIdVersionIdGetConfidence2 value)
        {
            return value switch
            {
                LegacyInferFromRequestDatasetIdVersionIdGetConfidence2.Best => "best",
                LegacyInferFromRequestDatasetIdVersionIdGetConfidence2.Default => "default",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyInferFromRequestDatasetIdVersionIdGetConfidence2? ToEnum(string value)
        {
            return value switch
            {
                "best" => LegacyInferFromRequestDatasetIdVersionIdGetConfidence2.Best,
                "default" => LegacyInferFromRequestDatasetIdVersionIdGetConfidence2.Default,
                _ => null,
            };
        }
    }
}

#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2
    {
        /// <summary>
        /// 
        /// </summary>
        Polygon,
        /// <summary>
        /// 
        /// </summary>
        Rle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2 value)
        {
            return value switch
            {
                LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2.Polygon => "polygon",
                LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2.Rle => "rle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2? ToEnum(string value)
        {
            return value switch
            {
                "polygon" => LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2.Polygon,
                "rle" => LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat2.Rle,
                _ => null,
            };
        }
    }
}
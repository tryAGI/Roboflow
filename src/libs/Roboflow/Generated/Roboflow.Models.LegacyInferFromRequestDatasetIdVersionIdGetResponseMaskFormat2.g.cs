
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2
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
    public static class LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2 value)
        {
            return value switch
            {
                LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2.Polygon => "polygon",
                LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2.Rle => "rle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2? ToEnum(string value)
        {
            return value switch
            {
                "polygon" => LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2.Polygon,
                "rle" => LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2.Rle,
                _ => null,
            };
        }
    }
}
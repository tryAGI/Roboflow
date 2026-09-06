
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public enum LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat
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
    public static class LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat value)
        {
            return value switch
            {
                LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat.Polygon => "polygon",
                LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat.Rle => "rle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat? ToEnum(string value)
        {
            return value switch
            {
                "polygon" => LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat.Polygon,
                "rle" => LegacyInferFromRequestDatasetIdVersionIdPostResponseMaskFormat.Rle,
                _ => null,
            };
        }
    }
}
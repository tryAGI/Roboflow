
#nullable enable

namespace Roboflow
{
    /// <summary>
    ///
    /// </summary>
    public enum LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat
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
    public static class LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat value)
        {
            return value switch
            {
                LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat.Polygon => "polygon",
                LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat.Rle => "rle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat? ToEnum(string value)
        {
            return value switch
            {
                "polygon" => LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat.Polygon,
                "rle" => LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat.Rle,
                _ => null,
            };
        }
    }
}
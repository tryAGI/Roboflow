
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Requested output mask format - `polygon` is the default Roboflow format, which however is not capable representing certain shapes - RLE is compact and more standard representation, yet require special decoding on the caller side - currently supported in `opt-in` mode when server is running with `USE_INFERENCE_MODELS=True` - otherwise it's ignored.<br/>
    /// Default Value: polygon
    /// </summary>
    public enum InstanceSegmentationInferenceRequestResponseMaskFormat
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
    public static class InstanceSegmentationInferenceRequestResponseMaskFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InstanceSegmentationInferenceRequestResponseMaskFormat value)
        {
            return value switch
            {
                InstanceSegmentationInferenceRequestResponseMaskFormat.Polygon => "polygon",
                InstanceSegmentationInferenceRequestResponseMaskFormat.Rle => "rle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InstanceSegmentationInferenceRequestResponseMaskFormat? ToEnum(string value)
        {
            return value switch
            {
                "polygon" => InstanceSegmentationInferenceRequestResponseMaskFormat.Polygon,
                "rle" => InstanceSegmentationInferenceRequestResponseMaskFormat.Rle,
                _ => null,
            };
        }
    }
}
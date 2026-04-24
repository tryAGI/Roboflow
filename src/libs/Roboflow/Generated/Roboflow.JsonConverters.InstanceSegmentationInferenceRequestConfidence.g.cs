#nullable enable

namespace Roboflow.JsonConverters
{
    /// <inheritdoc />
    public sealed class InstanceSegmentationInferenceRequestConfidenceJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Roboflow.InstanceSegmentationInferenceRequestConfidence>
    {
        /// <inheritdoc />
        public override global::Roboflow.InstanceSegmentationInferenceRequestConfidence Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Roboflow.InstanceSegmentationInferenceRequestConfidenceExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Roboflow.InstanceSegmentationInferenceRequestConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Roboflow.InstanceSegmentationInferenceRequestConfidence);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Roboflow.InstanceSegmentationInferenceRequestConfidence value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Roboflow.InstanceSegmentationInferenceRequestConfidenceExtensions.ToValueString(value));
        }
    }
}

#nullable enable

namespace Roboflow.JsonConverters
{
    /// <inheritdoc />
    public sealed class SemanticSegmentationInferenceRequestConfidenceNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Roboflow.SemanticSegmentationInferenceRequestConfidence?>
    {
        /// <inheritdoc />
        public override global::Roboflow.SemanticSegmentationInferenceRequestConfidence? Read(
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
                        return global::Roboflow.SemanticSegmentationInferenceRequestConfidenceExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Roboflow.SemanticSegmentationInferenceRequestConfidence)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Roboflow.SemanticSegmentationInferenceRequestConfidence?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Roboflow.SemanticSegmentationInferenceRequestConfidence? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Roboflow.SemanticSegmentationInferenceRequestConfidenceExtensions.ToValueString(value.Value));
            }
        }
    }
}

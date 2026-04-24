#nullable enable

namespace Roboflow.JsonConverters
{
    /// <inheritdoc />
    public sealed class LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2JsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2>
    {
        /// <inheritdoc />
        public override global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2 Read(
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
                        return global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2Extensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2 value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Roboflow.LegacyInferFromRequestDatasetIdVersionIdGetResponseMaskFormat2Extensions.ToValueString(value));
        }
    }
}

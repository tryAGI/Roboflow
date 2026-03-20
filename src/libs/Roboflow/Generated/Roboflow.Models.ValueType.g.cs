
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// 
    /// </summary>
    public enum ValueType
    {
        /// <summary>
        /// 
        /// </summary>
        Any,
        /// <summary>
        /// 
        /// </summary>
        Integer,
        /// <summary>
        /// 
        /// </summary>
        Float,
        /// <summary>
        /// 
        /// </summary>
        Boolean,
        /// <summary>
        /// 
        /// </summary>
        Dict,
        /// <summary>
        /// 
        /// </summary>
        List,
        /// <summary>
        /// 
        /// </summary>
        String,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ValueTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ValueType value)
        {
            return value switch
            {
                ValueType.Any => "any",
                ValueType.Integer => "integer",
                ValueType.Float => "float",
                ValueType.Boolean => "boolean",
                ValueType.Dict => "dict",
                ValueType.List => "list",
                ValueType.String => "string",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ValueType? ToEnum(string value)
        {
            return value switch
            {
                "any" => ValueType.Any,
                "integer" => ValueType.Integer,
                "float" => ValueType.Float,
                "boolean" => ValueType.Boolean,
                "dict" => ValueType.Dict,
                "list" => ValueType.List,
                "string" => ValueType.String,
                _ => null,
            };
        }
    }
}
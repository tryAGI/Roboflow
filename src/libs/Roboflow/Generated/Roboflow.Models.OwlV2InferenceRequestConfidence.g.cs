
#nullable enable

namespace Roboflow
{
    /// <summary>
    /// Default confidence threshold for owlvit predictions. Needs to be much higher than you're used to, probably 0.99 - 0.9999<br/>
    /// Default Value: 0.99F
    /// </summary>
    public sealed partial class OwlV2InferenceRequestConfidence
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
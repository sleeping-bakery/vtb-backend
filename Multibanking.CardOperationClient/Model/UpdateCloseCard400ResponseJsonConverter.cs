using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Multibanking.CardOperationClient.Model;

/// <summary>
///     Custom JSON converter for UpdateCloseCard400Response
/// </summary>
public class UpdateCloseCard400ResponseJsonConverter : JsonConverter
{
    /// <summary>
    ///     To write the JSON string
    /// </summary>
    /// <param name="writer">JSON writer</param>
    /// <param name="value">Object to be converted into a JSON string</param>
    /// <param name="serializer">JSON Serializer</param>
    public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
    {
        writer.WriteRawValue((string)typeof(UpdateCloseCard400Response).GetMethod("ToJson").Invoke(value, null));
    }

    /// <summary>
    ///     To convert a JSON string into an object
    /// </summary>
    /// <param name="reader">JSON reader</param>
    /// <param name="objectType">Object type</param>
    /// <param name="existingValue">Existing value</param>
    /// <param name="serializer">JSON Serializer</param>
    /// <returns>The object converted from the JSON string</returns>
    public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
    {
        if (reader.TokenType != JsonToken.Null) return UpdateCloseCard400Response.FromJson(JObject.Load(reader).ToString(Formatting.None));
        return null;
    }

    /// <summary>
    ///     Check if the object can be converted
    /// </summary>
    /// <param name="objectType">Object type</param>
    /// <returns>True if the object can be converted</returns>
    public override bool CanConvert(Type objectType)
    {
        return false;
    }
}
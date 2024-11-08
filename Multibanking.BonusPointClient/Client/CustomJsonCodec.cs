using System;
using System.Globalization;
using System.IO;
using System.Text.RegularExpressions;
using Multibanking.BonusPointClient.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using RestSharp.Serializers;

namespace Multibanking.BonusPointClient.Client;

/// <summary>
///     Allows RestSharp to Serialize/Deserialize JSON using our custom logic, but only when ContentType is JSON.
/// </summary>
internal class CustomJsonCodec : IRestSerializer, ISerializer, IDeserializer
{
    private static readonly string _contentType = "application/json";
    private readonly IReadableConfiguration _configuration;

    private readonly JsonSerializerSettings _serializerSettings = new()
    {
        // OpenAPI generated types generally hide default constructors.
        ConstructorHandling = ConstructorHandling.AllowNonPublicDefaultConstructor,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy
            {
                OverrideSpecifiedNames = false
            }
        }
    };

    public CustomJsonCodec(IReadableConfiguration configuration)
    {
        _configuration = configuration;
    }

    public CustomJsonCodec(JsonSerializerSettings serializerSettings, IReadableConfiguration configuration)
    {
        _serializerSettings = serializerSettings;
        _configuration = configuration;
    }

    public T Deserialize<T>(RestResponse response)
    {
        var result = (T)Deserialize(response, typeof(T));
        return result;
    }

    public string Serialize(Parameter bodyParameter)
    {
        return Serialize(bodyParameter.Value);
    }

    public ISerializer Serializer => this;
    public IDeserializer Deserializer => this;

    public string[] AcceptedContentTypes => RestSharp.Serializers.ContentType.JsonAccept;

    public SupportsContentType SupportsContentType => contentType =>
        contentType.EndsWith("json", StringComparison.InvariantCultureIgnoreCase) ||
        contentType.EndsWith("javascript", StringComparison.InvariantCultureIgnoreCase);

    public DataFormat DataFormat => DataFormat.Json;

    /// <summary>
    ///     Serialize the object into a JSON string.
    /// </summary>
    /// <param name="obj">Object to be serialized.</param>
    /// <returns>A JSON string.</returns>
    public string Serialize(object obj)
    {
        if (obj != null && obj is AbstractOpenAPISchema)
            // the object to be serialized is an oneOf/anyOf schema
            return ((AbstractOpenAPISchema)obj).ToJson();
        return JsonConvert.SerializeObject(obj, _serializerSettings);
    }

    public string ContentType
    {
        get => _contentType;
        set => throw new InvalidOperationException("Not allowed to set content type.");
    }

    /// <summary>
    ///     Deserialize the JSON string into a proper object.
    /// </summary>
    /// <param name="response">The HTTP response.</param>
    /// <param name="type">Object type.</param>
    /// <returns>Object representation of the JSON string.</returns>
    internal object Deserialize(RestResponse response, Type type)
    {
        if (type == typeof(byte[])) // return byte array
            return response.RawBytes;

        if (type == typeof(Stream))
        {
            var bytes = response.RawBytes;
            if (response.Headers != null)
            {
                var filePath = string.IsNullOrEmpty(_configuration.TempFolderPath)
                    ? Path.GetTempPath()
                    : _configuration.TempFolderPath;
                var regex = new Regex(@"Content-Disposition=.*filename=['""]?([^'""\s]+)['""]?$");
                foreach (var header in response.Headers)
                {
                    var match = regex.Match(header.ToString());
                    if (match.Success)
                    {
                        var fileName = filePath + ClientUtils.SanitizeFilename(match.Groups[1].Value.Replace("\"", "").Replace("'", ""));
                        File.WriteAllBytes(fileName, bytes);
                        return new FileStream(fileName, FileMode.Open);
                    }
                }
            }

            var stream = new MemoryStream(bytes);
            return stream;
        }

        if (type.Name.StartsWith("System.Nullable`1[[System.DateTime")) // return a datetime object
            return DateTime.Parse(response.Content, null, DateTimeStyles.RoundtripKind);

        if (type == typeof(string) || type.Name.StartsWith("System.Nullable")) // return primitive type
            return Convert.ChangeType(response.Content, type);

        // at this point, it must be a model (json)
        try
        {
            return JsonConvert.DeserializeObject(response.Content, type, _serializerSettings);
        }
        catch (Exception e)
        {
            throw new ApiException(500, e.Message);
        }
    }
}
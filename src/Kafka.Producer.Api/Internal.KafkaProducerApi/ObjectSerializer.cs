using System.Text.Json;
using System.Text.Json.Serialization;
using Confluent.Kafka;

namespace GGroupp.Infra.Kafka;

internal sealed class ObjectSerializer<T> : ISerializer<T>
{
    private static readonly JsonSerializerOptions jsonSerializerOptions;

    static ObjectSerializer()
        =>
        jsonSerializerOptions = new()
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase
        };
    
    public byte[] Serialize(T data, SerializationContext context) 
        => 
        JsonSerializer.SerializeToUtf8Bytes(data, jsonSerializerOptions);
}   

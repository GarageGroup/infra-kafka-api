using Confluent.Kafka;

namespace GGroupp.Infra.Kafka;

public sealed record class ProducerKafkaOptions
{
    public ProducerKafkaOptions(
        string bootstrapServers, 
        string topic)
    {
        BootstrapServers = bootstrapServers ?? string.Empty;
        Topic = topic ?? string.Empty;
    }

    internal string BootstrapServers { get; }
 
    internal string Topic { get; }
}
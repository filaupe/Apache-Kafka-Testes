using Confluent.Kafka;

var config = new ConsumerConfig
{
    GroupId = Guid.NewGuid().ToString(),
    BootstrapServers = "localhost:9092",
    AutoOffsetReset = AutoOffsetReset.Earliest,
};

using var consumer = new ConsumerBuilder<Null, string>(config).Build();

var tps = new TopicPartitionOffset(new TopicPartition("chat-topic", 0), Offset.Beginning);
consumer.Assign(tps);

consumer.Subscribe("chat-topic");

CancellationTokenSource token = new();

try
{
    while (true)
    {
        var response = consumer.Consume(token.Token);
        if (response.Message != null)
        {
            Console.WriteLine($"Mensagem recebida: {response.Message.Value}");
        }
    }
}
catch (Exception)
{

	throw;
}
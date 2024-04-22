using Confluent.Kafka;

var config = new ProducerConfig { BootstrapServers = "localhost:9092", };
using var producer = new ProducerBuilder<Null, string>(config).Build();

try
{
    Console.WriteLine("Producer Iniciado, escreva as mensagens:");

    string? msg;
    while ((msg = Console.ReadLine()) != null)
    {
        var response = await producer.ProduceAsync("chat-topic",
            new Message<Null, string> { Value = msg });
    }
}
catch (ProduceException<Null, string> exc)
{
    Console.WriteLine(exc.Message);
}
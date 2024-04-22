using Confluent.Kafka;
using Kafka.WinForms.Client.Models;

namespace Kafka.WinForms.Client
{
    public partial class TableUpdater : Form
    {
        private readonly ConsumerConfig _consumerConfig;
        private readonly TopicPartitionOffset _topicPartitionOffset;

        public TableUpdater()
        {
            InitializeComponent();

            var topicPartition = new TopicPartition("chat-topic", 0);

            _consumerConfig = new ConsumerConfig
            {
                GroupId = Guid.NewGuid().ToString(),
                BootstrapServers = "localhost:9092",
                AutoOffsetReset = AutoOffsetReset.Earliest,
            };

            _topicPartitionOffset = new TopicPartitionOffset(topicPartition, Offset.Beginning);
        }

        private void TableUpdater_Load(object sender, EventArgs e)
        {
            backgroundWorkerConsumer.RunWorkerAsync();
        }

        private void backgroundWorkerConsumer_DoWork(object sender, System.ComponentModel.DoWorkEventArgs e)
        {
            using var consumer = new ConsumerBuilder<Null, string>(_consumerConfig).Build();

            consumer.Assign(_topicPartitionOffset);
            consumer.Subscribe(_topicPartitionOffset.Topic);

            CancellationTokenSource token = new();

            try
            {
                while (true)
                {
                    var response = consumer.Consume(token.Token);
                    if (response.Message != null)
                    {
                        backgroundWorkerConsumer.ReportProgress(100, response.Message.Value);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void backgroundWorkerConsumer_ProgressChanged(object sender, System.ComponentModel.ProgressChangedEventArgs e)
        {
            if (e.UserState is string message)
            {
                kafkaMessageViewModelBindingSource.Add(new KafkaMessageViewModel(message));
                kafkaMessageViewModelBindingSource.MoveLast();
            }
        }
    }
}

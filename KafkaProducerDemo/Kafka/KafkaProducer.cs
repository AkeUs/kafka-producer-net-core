using Confluent.Kafka;

namespace KafkaProducerDemo.Kafka {
    public class KafkaProducer {
        private readonly IProducer<string, string> _producer;

        public KafkaProducer(IProducer<string, string> producer) => _producer = producer;

    }
}
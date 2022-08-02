namespace RabbitMQPublisher
{
    public interface IMessageProducer
    {
        void SendMessage<T>(T message);
    }
}

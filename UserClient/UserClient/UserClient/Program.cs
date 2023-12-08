using MQTTnet;
using MQTTnet.Client;

namespace UserClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var mqttFactory = new MqttFactory();
            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithTcpServer("localhost", 1884)
                .Build();
            var mqttClient = mqttFactory.CreateMqttClient();

            mqttClient.ApplicationMessageReceivedAsync += e =>
            {
                Console.WriteLine(e.ApplicationMessage.ConvertPayloadToString());
                return Task.CompletedTask;
            };

            
            var responce = await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
            Console.WriteLine("The MQTT client is connected");

            var mqtttSubscribeOptions = mqttFactory.CreateSubscribeOptionsBuilder()
                .WithTopicFilter(
                    f =>
                    {
                        f.WithTopic("mqtt/sample/topik/1");
                    })
                .Build();

            await mqttClient.SubscribeAsync(mqtttSubscribeOptions, CancellationToken.None);

            Console.WriteLine("MQTT Client Subscibe to topic");

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
        }
    }
}
using MQTTnet;
using MQTTnet.Client;

namespace StandClient
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var mqttFactory = new MqttFactory();

            var mqttClient = mqttFactory.CreateMqttClient();

            var mqttClientOptions = new MqttClientOptionsBuilder()
                .WithTcpServer("localhost", 1884)
                .Build();

            await mqttClient.ConnectAsync(mqttClientOptions, CancellationToken.None);

            while (true)
            {
                string? message = Console.ReadLine();
                var applicationMessage = new MqttApplicationMessageBuilder()
                    .WithTopic("mqtt/sample/topik/1")
                    .WithPayload(message)
                    .Build();

                await mqttClient.PublishAsync(applicationMessage, CancellationToken.None);
            }

            

            
        }
    }
}
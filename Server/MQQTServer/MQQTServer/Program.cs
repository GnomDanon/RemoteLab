using MQTTnet;
using MQTTnet.Diagnostics;
using MQTTnet.Protocol;
using MQTTnet.Server;

namespace MQQTServer
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            var optionsBuilder = new MqttServerOptionsBuilder()
                .WithConnectionBacklog(100)
                .WithDefaultEndpoint()
                .WithDefaultEndpointPort(1884);
            var mqttServer = new MqttFactory().CreateMqttServer(optionsBuilder.Build());

            /**
            mqttServer.ValidatingConnectionAsync += e =>
            {
                if (e.ClientId != "ValidClientId")
                {
                    e.ReasonCode = MqttConnectReasonCode.ClientIdentifierNotValid;
                }

                if (e.UserName != "ValidUser")
                {
                    e.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
                }

                if (e.Password != "SecretPassword")
                {
                    e.ReasonCode = MqttConnectReasonCode.BadUserNameOrPassword;
                }

                return Task.CompletedTask;
            };
            **/
            
            await mqttServer.StartAsync();

            Console.WriteLine("Press Enter to exit");
            Console.ReadLine();
            await mqttServer.StopAsync();
        }
    }
}
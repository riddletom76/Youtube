using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace MQTTPublisher
{
    class Publisher
    {
        static async Task Main(string[] args)
        {
            var mqttFactory = new MqttFactory();
            IMqttClient client = mqttFactory.CreateMqttClient();
            var tlsOptions = new MqttClientOptionsBuilderTlsParameters
            {
                UseTls = true,
                Certificates = new List<X509Certificate>
                {
                    new X509Certificate("mosquitto.org.crt")
                },
                AllowUntrustedCertificates = true,
                IgnoreCertificateChainErrors = true,
                IgnoreCertificateRevocationErrors = true
            };
            var options = new MqttClientOptionsBuilder()
                            .WithClientId(Guid.NewGuid().ToString())
                            .WithTcpServer("test.mosquitto.org", 8883)
                            .WithTls(tlsOptions)
                            .WithCleanSession()
                            .Build();
            client.UseConnectedHandler(e =>
            {
                Console.WriteLine("Connected to the broker");
            });

            client.UseDisconnectedHandler(e =>
            {
                Console.WriteLine("Disconnected from the broker");
            });

            await client.ConnectAsync(options);

            Console.WriteLine("Please press a key to publish the message");

            Console.ReadLine();

            await PublishMessageAsync(client);

            await client.DisconnectAsync();
        }

        private static async Task PublishMessageAsync(IMqttClient client)
        {
            string messagePayload = "Hello!";
            var message = new MqttApplicationMessageBuilder()
                                .WithTopic("RishabhSharma")
                                .WithPayload(messagePayload)
                                .WithAtLeastOnceQoS()
                                .Build();
            if (client.IsConnected)
            {
                await client.PublishAsync(message);
                Console.WriteLine($"Published Message - {messagePayload}");
            }
        }
    }
}

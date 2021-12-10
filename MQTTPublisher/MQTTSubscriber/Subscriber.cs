using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MQTTSubscriber
{
    class Subscriber
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

            client.UseConnectedHandler(async e =>
            {
                Console.WriteLine("Connected to the broker");
                var topicFilter = new TopicFilterBuilder()
                                        .WithTopic("RishabhSharma")
                                        .Build();
                await client.SubscribeAsync(topicFilter);
            });

            client.UseDisconnectedHandler(e =>
            {
                Console.WriteLine("Disconnected from the broker");
            });

            client.UseApplicationMessageReceivedHandler(e =>
            {

                Console.WriteLine($"Received Message - {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");

            });

            await client.ConnectAsync(options);

            Console.ReadLine();

            await client.DisconnectAsync();
        }
    }
}

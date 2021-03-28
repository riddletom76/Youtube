using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace SampleGrpcClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string serviceEndpoint = "https://localhost:5001";
            var channel = GrpcChannel.ForAddress(serviceEndpoint);
            var client = new Greeter.GreeterClient(channel);
            HelloRequest helloRequest = new HelloRequest {
                Name = "Rishabh"
            };
            var response = await client.SayHelloAsync(helloRequest);

            Console.WriteLine($"Response obtained from the service {response.Message}");
        }
    }
}

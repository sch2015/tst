using Domain;
using Grpc.Core;
using System;

namespace client
{
    class Program
    {
        static void Main(string[] args)
        {
            Channel channel = new Channel("127.0.0.1:9007", ChannelCredentials.Insecure);

            var client = new gRPC.gRPCClient(channel);


            var reply = client.SayHelloAsync(new HelloRequest { Name = "LineZero" }).ResponseAsync.Result;
            Console.WriteLine("来自" + reply.Message);

            channel.ShutdownAsync().Wait();
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}

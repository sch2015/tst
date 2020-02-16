using Domain;
using Grpc.Core;
using System;

namespace grpctest
{
    class Program
    {
        const int Port = 9007;
        static void Main(string[] args)
        {
            Server server = new Server
            {
                Services = { gRPC.BindService(new gRPCImpl()) },
                Ports = { new ServerPort("localhost", Port, ServerCredentials.Insecure) }
            };
            server.Start();

            Console.WriteLine("gRPC server listening on port " + Port);
            Console.WriteLine("任意键退出...");
            Console.ReadKey();
            Console.WriteLine("Hello World!");
        }
    }
}

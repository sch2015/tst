using Domain;
using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace grpctest
{
    public class gRPCImpl : Domain.gRPC.gRPCBase
    {
        public override Task<HelloReply> SayHello(HelloRequest request, ServerCallContext context)
        {
            return Task.FromResult(new HelloReply() { Message = "dd" });
        }
    }

}

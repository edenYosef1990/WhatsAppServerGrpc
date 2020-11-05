using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WhatsAppServerGrpc.Protos;

namespace WhatsAppServerGrpc.WhatsappService
{
    public class WhatsappServerService : WhatsAppMsgService.WhatsAppMsgServiceBase
    {
        public override async Task SendInitMessage(InitialMessage request, IServerStreamWriter<ReadingMessage> responseStream, ServerCallContext context)
        {
            for(int i=0; i< 10;i++)
            {
                await Task.Delay(500);

                await responseStream.WriteAsync(new ReadingMessage() { Text = "this is a test" });
            }
        }
    }
}

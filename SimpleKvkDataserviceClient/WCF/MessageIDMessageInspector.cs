using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SimpleKvkDataserviceClient.WCF
{
    public class MessageIDMessageInspector : IClientMessageInspector
    {
        public void AfterReceiveReply(ref Message reply, object correlationState)
        {
            
        }

        public object BeforeSendRequest(ref Message request, IClientChannel channel)
        {
            UniqueId unID = new UniqueId();

            //Fix the urn:uuid: construct in messageid header
            if (request.Headers.MessageId.ToString().StartsWith("urn:"))
                request.Headers.MessageId = new UniqueId(request.Headers.MessageId.ToString().Substring(4));

            return null;
        }

    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKvkDataserviceClient.WCF.Configuration
{
    public class MessageIDBehaviorExtensionElement : System.ServiceModel.Configuration.BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(MessageIDEndpointBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new MessageIDEndpointBehavior();
        }
    }

}

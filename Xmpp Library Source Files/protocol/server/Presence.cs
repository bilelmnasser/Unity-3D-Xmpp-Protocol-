using System;

namespace Xmpp.protocol.server
{
    public class Presence : Xmpp.protocol.client.Presence
    {
        public Presence()
        {
            this.Namespace = Uri.SERVER;
        }
    }
}

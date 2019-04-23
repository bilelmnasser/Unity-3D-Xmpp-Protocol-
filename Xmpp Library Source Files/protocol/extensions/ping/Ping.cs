using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.ping
{
    /*
     * <iq from='capulet.com' to='juliet@capulet.com/balcony' id='ping123' type='get'>
     *   <ping xmlns='urn:xmpp:ping'/>
     * </iq>
     */
    public class Ping : Element
    {
        public Ping()
        {
            this.TagName    = "ping";
            this.Namespace  = Uri.PING;
        }
    }
}

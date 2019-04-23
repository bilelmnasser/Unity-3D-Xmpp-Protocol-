using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.bytestreams
{
    /*
        <message 
            from='proxy.host3' 
            to='target@host2/bar' 
            id='initiate'>
            <udpsuccess xmlns='http://jabber.org/protocol/bytestreams' dstaddr='Value of Hash'/>
        </message>
    */
    public class UdpSuccess : Element
    {
        public UdpSuccess(string dstaddr)
        {
            this.TagName    = "udpsuccess";
            this.Namespace  = Uri.BYTESTREAMS;

            DestinationAddress = dstaddr;
        }

        public string DestinationAddress
        {
            get { return GetAttribute("dstaddr"); }
            set { SetAttribute("dstaddr", value); }
        }

    }
}

using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.compression
{
    /*
     * Example 5. Receiving Entity Acknowledges Stream Compression
     * <compressed xmlns='http://jabber.org/protocol/compress'/> 
     */

    public class Compressed : Element
    {
        public Compressed()
        {            
            this.TagName    = "compressed";
            this.Namespace  = Uri.COMPRESS;
        }
    }
}

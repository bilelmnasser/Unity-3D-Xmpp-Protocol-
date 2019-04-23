using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.msgreceipts
{
    /// <summary>
    /// 
    /// </summary>
    public class Received : Element
    {
        /*         
         * <received xmlns='http://www.xmpp.org/extensions/xep-0184.html#ns'/>
         */
        public Received()
        {
            this.TagName    = "received";
            this.Namespace  = Uri.MSG_RECEIPT;
        }
    }
}

using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.msgreceipts
{
    /// <summary>
    /// 
    /// </summary>
    public class Request : Element
    {
        /*
         * <request xmlns='http://www.xmpp.org/extensions/xep-0184.html#ns'/>         
         */
        public Request()
        {
            this.TagName    = "request";
            this.Namespace  = Uri.MSG_RECEIPT;
        }
    }
}
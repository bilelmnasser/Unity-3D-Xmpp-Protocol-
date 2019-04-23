using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.html
{
    /// <summary>
    /// The Body Element of a XHTML message
    /// </summary>
    public class Body : Element
    {
        public Body()
        {
            this.TagName    = "body";
            this.Namespace  = Uri.XHTML;
        }

        /// <summary>
        /// 
        /// </summary>
        public string InnerHtml
        {
            get
            {
                // Thats a HACK
                string xml = this.ToString();
                
                int start   = xml.IndexOf(">");
                int end     = xml.LastIndexOf("</" + this.TagName + ">");

                return xml.Substring(start + 1, end - start -1);
            }
        }
    }
}
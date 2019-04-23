using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.html
{
    /*
     * <message>
     *      <body>hi!</body>
     *      <html xmlns='http://jabber.org/protocol/xhtml-im'>
     *          <body xmlns='http://www.w3.org/1999/xhtml'>
     *              <p style='font-weight:bold'>hi!</p>
     *          </body>
     *      </html>
     * </message>
     */

    public class Html : Element
    {
        public Html()
        {
            this.TagName    = "html";
            this.Namespace  = Uri.XHTML_IM;
        }
        
        /// <summary>
        /// The Body Element of the XHTML Message
        /// </summary>
        public Body Body
        {
            get
            {
                return SelectSingleElement(typeof(Body)) as Body;

            }
            set
            {
                if (HasTag(typeof(Body)))
                    RemoveTag(typeof(Body));
                
                if (value != null)
                    this.AddChild(value);
            }
        }
    }
}

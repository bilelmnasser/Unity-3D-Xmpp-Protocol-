using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.ibb
{
    /// <summary>
    /// IBB base class
    /// </summary>
    public abstract class Base : Element
    {
        public Base()
        {
            this.Namespace = Uri.IBB;
        }

        /// <summary>
        /// Sid
        /// </summary>
        public string Sid
        {
            get { return GetAttribute("sid"); }
            set { SetAttribute("sid", value); }
        }
    }
}

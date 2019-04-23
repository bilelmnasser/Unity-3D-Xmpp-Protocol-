using System;

using Xmpp.Xml;
using Xmpp.Xml.Dom;
using Xmpp.protocol.client;

namespace Xmpp.protocol.Base
{
    /// <summary>
    /// Base XMPP Element
    /// This must ne used to build all other new packets
    /// </summary>
    public abstract class DirectionalElement : Element
    {
        public DirectionalElement()
            : base()
        {
        }

        public DirectionalElement(string tag)
            : base(tag)
        {
        }

        public DirectionalElement(string tag, string ns)
            : base(tag)
        {
            this.Namespace = ns;
        }

        public DirectionalElement(string tag, string text, string ns)
            : base(tag, text)
        {
            this.Namespace = ns;
        }

        public Jid From
        {
            get
            {
                if (HasAttribute("from"))
                    return new Jid(this.GetAttribute("from"));
                else
                    return null;
            }
            set
            {
                if (value != null)
                    this.SetAttribute("from", value.ToString());
                else
                    RemoveAttribute("from");
            }
        }

        public Jid To
        {
            get
            {
                if (HasAttribute("to"))
                    return new Jid(this.GetAttribute("to"));
                else
                    return null;
            }
            set
            {
                if (value != null)
                    this.SetAttribute("to", value.ToString());
                else
                    RemoveAttribute("to");
            }
        }

        /// <summary>
        /// Switches the from and to attributes when existing
        /// </summary>
        public void SwitchDirection()
        {
            Jid from = From;
            Jid to = To;

            // Remove from and to now
            RemoveAttribute("from");
            RemoveAttribute("to");

            Jid helper = null;

            helper = from;
            from = to;
            to = helper;

            From = from;
            To = to;
        } 
    }
}
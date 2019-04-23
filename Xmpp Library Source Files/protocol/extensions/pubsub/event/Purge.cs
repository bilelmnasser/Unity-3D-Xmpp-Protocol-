using System;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub.@event
{
	public class Purge : Element
    {
        #region << Constructors >>
        public Purge()
        {            
            this.TagName    = "purge";
            this.Namespace  = Uri.PUBSUB_EVENT;
        }

        public Purge(string node) : this()
        {
            this.Node = node;
        }
        #endregion

        public string Node
        {
            get { return GetAttribute("node"); }
            set { SetAttribute("node", value); }
        }
	}
}
using System;
using System.Text;

using Xmpp.Xml.Dom;

namespace Xmpp.protocol.extensions.pubsub
{
    public class Subscribe : Element
    {
        /*
        Example 25. Entity subscribes to a node

        <iq type="set"
            from="sub1@foo.com/home"
            to="pubsub.jabber.org"
            id="sub1">
          <pubsub xmlns="http://jabber.org/protocol/pubsub">
            <subscribe
                node="generic/pgm-mp3-player"
                jid="sub1@foo.com"/>
          </pubsub>
        </iq>
        */
        #region << Constructors >>
        public Subscribe()
        {
            this.TagName    = "subscribe";
            this.Namespace  = Uri.PUBSUB;
        }

        public Subscribe(string node, Jid jid) : this()
        {
            this.Node   = node;
            this.Jid    = jid;
        }
        #endregion

        public string Node
        {
            get { return GetAttribute("node"); }
            set { SetAttribute("node", value); }
        }

        public Jid Jid
		{
			get 
			{ 
				if (HasAttribute("jid"))
					return new Jid(this.GetAttribute("jid"));
				else
					return null;
			}
			set 
			{
                if (value != null)
                    this.SetAttribute("jid", value.ToString());
                else
                    RemoveAttribute("jid");
			}
		}
    }
}

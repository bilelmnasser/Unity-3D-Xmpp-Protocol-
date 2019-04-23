using System;
using System.Text;

namespace Xmpp.protocol.extensions.pubsub
{
    /*
        
        Example 38. Entity unsubscribes from a node

        <iq type='set'
            from='francisco@denmark.lit/barracks'
            to='pubsub.shakespeare.lit'
            id='unsub1'>
          <pubsub xmlns='http://jabber.org/protocol/pubsub'>
             <unsubscribe
                 node='blogs/princely_musings'
                 jid='francisco@denmark.lit'/>
          </pubsub>
        </iq>
    
    */

    // looks exactly the same as subscribe, but has an additional Attribute subid

    public class Unsubscribe : Subscribe
    {
        #region << Constructors >>
        public Unsubscribe() : base()
        {
            this.TagName = "unsubscribe";
        }

        public Unsubscribe(string node, Jid jid) : this()
        {
            this.Node   = node;
            this.Jid    = jid;
        }

        public Unsubscribe(string node, Jid jid, string subid)
            : this(node, jid)
        {
            SubId = subid;
        }
        #endregion

        public string SubId
        {
            get { return GetAttribute("subid"); }
            set { SetAttribute("subid", value); }
        }        

    }
}

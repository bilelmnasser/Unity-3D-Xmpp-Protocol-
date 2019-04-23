using System;
using System.Text;

using Xmpp.protocol.client;

namespace Xmpp.protocol.extensions.pubsub
{
    public class PubSubIq : IQ
    {
        /*
            Example 1. Entity requests a new node with default configuration.

            <iq type="set"
                from="pgm@jabber.org"
                to="pubsub.jabber.org"
                id="create1">
                <pubsub xmlns="http://jabber.org/protocol/pubsub">
                    <create node="generic/pgm-mp3-player"/>
                    <configure/>
                </pubsub>
            </iq>
        */
        private PubSub m_PubSub = new PubSub();

        #region << Constructors >>
        public PubSubIq()
        {
            this.GenerateId();
            this.AddChild(m_PubSub);            
        }
        
        public PubSubIq(IqType type) : this()
        {
            this.Type = type;
        }

        public PubSubIq(IqType type, Jid to) : this(type)
        {
            this.To = to;
        }

        public PubSubIq(IqType type, Jid to, Jid from) : this(type, to)
        {
            this.From = from;
        }
        #endregion

        public PubSub PubSub
        {
            get
            {
                return m_PubSub;
            }
        }

        
    }		
}

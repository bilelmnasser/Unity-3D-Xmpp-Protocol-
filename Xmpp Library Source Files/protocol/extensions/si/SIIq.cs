using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.extensions.si
{
    /*
    <iq id="jcl_18" to="xxx" type="result" from="yyy">
        <si xmlns="http://jabber.org/protocol/si">
            <feature xmlns="http://jabber.org/protocol/feature-neg">
                <x xmlns="jabber:x:data" type="submit">
                    <field var="stream-method">
                        <value>http://jabber.org/protocol/bytestreams</value>
                    </field>
                </x>
            </feature>
        </si>
    </iq>
 
    */

    /// <summary>
    /// 
    /// </summary>
    public class SIIq : IQ
    {
        private SI m_SI = new SI();

        public SIIq()
        {            
            this.GenerateId();
            this.AddChild(m_SI);
        }

        public SIIq(IqType type)
            : this()
        {
            this.Type = type;
        }

        public SIIq(IqType type, Jid to)
            : this(type)
        {
            this.To = to;
        }

        public SIIq(IqType type, Jid to, Jid from)
            : this(type, to)
        {
            this.From = from;
        }

        public SI SI
        {
            get
            {
                return m_SI;
            }
        }
    }
}

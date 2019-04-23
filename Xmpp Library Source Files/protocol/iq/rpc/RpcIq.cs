using System;

using Xmpp.protocol.client;


namespace Xmpp.protocol.iq.rpc
{
    /// <summary>
    /// RpcIq.
    /// </summary>
    public class RpcIq : IQ
    {
        private Rpc m_Rpc = new Rpc();

        public RpcIq()
        {
            base.Query = m_Rpc;
            this.GenerateId();
        }

        public RpcIq(IqType type) : this()
        {
            this.Type = type;
        }

        public RpcIq(IqType type, Jid to) : this(type)
        {
            this.To = to;
        }

        public RpcIq(IqType type, Jid to, Jid from) : this(type, to)
        {
            this.From = from;
        }

        public new Rpc Query
        {
            get
            {
                return m_Rpc;
            }
        }

    }
}

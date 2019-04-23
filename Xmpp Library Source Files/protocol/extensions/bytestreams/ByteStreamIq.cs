using System;
using Xmpp.protocol.client;

namespace Xmpp.protocol.extensions.bytestreams
{
    /// <summary>
    /// a Bytestream IQ
    /// </summary>
    public class ByteStreamIq : IQ
    {
        private ByteStream m_ByteStream = new ByteStream();

        public ByteStreamIq()
        {
            base.Query = m_ByteStream;
            this.GenerateId(); 
        }

        public ByteStreamIq(IqType type) : this()
        {
            this.Type = type;
        }

        public ByteStreamIq(IqType type, Jid to)
            : this(type)
        {
            this.To = to;
        }

        public ByteStreamIq(IqType type, Jid to, Jid from)
            : this(type, to)
        {
            this.From = from;
        }

        public ByteStreamIq(IqType type, Jid to, Jid from, string Id)
            : this(type, to, from)
        {
            this.Id = Id;
        }

        public new ByteStream Query
        {
            get
            {
                return m_ByteStream;
            }
        }
    }
}

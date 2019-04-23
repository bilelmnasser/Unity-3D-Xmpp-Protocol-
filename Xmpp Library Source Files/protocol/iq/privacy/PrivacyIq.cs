using System;

using Xmpp.protocol.client;

namespace Xmpp.protocol.iq.privacy
{
    /// <summary>
    /// Summary description for PrivateIq.
    /// </summary>
    public class PrivacyIq : IQ
    {
        Privacy m_Privacy = new Privacy();

        public PrivacyIq()
        {
            base.Query = m_Privacy;
            this.GenerateId();
        }

        public PrivacyIq(IqType type)
            : this()
        {
            this.Type = type;
        }

        public PrivacyIq(IqType type, Jid to)
            : this(type)
        {
            this.To = to;
        }

        public PrivacyIq(IqType type, Jid to, Jid from)
            : this(type, to)
        {
            this.From = from;
        }

        public new Privacy Query
        {
            get { return m_Privacy; }
        }
    }
}
